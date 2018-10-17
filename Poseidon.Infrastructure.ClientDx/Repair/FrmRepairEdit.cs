using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Infrastructure.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 编辑维修改造
    /// </summary>
    public partial class FrmRepairEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联维修改造
        /// </summary>
        private Repair currentRepair;

        /// <summary>
        /// 维修改造记录
        /// </summary>
        private List<RepairRecord> repairRecords;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 编辑维修改造
        /// </summary>
        /// <param name="id">维修改造ID</param>
        public FrmRepairEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentRepair = BusinessFactory<RepairBusiness>.Instance.FindById(id);
            this.repairRecords = BusinessFactory<RepairRecordBusiness>.Instance.FindByRepair(id).ToList();
        }

        protected override void InitForm()
        {
            this.txtNumber.Text = this.currentRepair.Number;
            this.txtName.Text = this.currentRepair.Name;
            ControlUtil.BindDictToComboBox(this.cmbType, typeof(Repair), "Type");

            this.cmbType.EditValue = this.currentRepair.Type;
            this.txtConstructionCompany.Text = this.currentRepair.ConstructionCompany;
            this.dpStartDate.DateTime = this.currentRepair.StartDate;

            if (this.currentRepair.EndDate != null)
                this.dpEndDate.DateTime = this.currentRepair.EndDate.Value;

            this.spRepairFee.Value = this.currentRepair.RepairFee;
            this.txtRemark.Text = this.currentRepair.Remark;

            this.recordGrid.Init(this.currentRepair.ModelType);
            this.recordGrid.DataSource = this.repairRecords;
            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtNumber.Text.Trim()))
            {
                errorMessage = "请输入编号";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "请输入名称";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.cmbType.EditValue == null)
            {
                errorMessage = "请选择维修改造类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpStartDate.EditValue == null)
            {
                errorMessage = "请选择开始日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.recordGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.FacilityId))
                {
                    errorMessage = "请选择设施";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (string.IsNullOrEmpty(item.ItemName))
                {
                    errorMessage = "项目名称不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        private void SetEntity(Repair entity)
        {
            entity.Number = this.txtNumber.Text;
            entity.Name = this.txtName.Text;
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.ConstructionCompany = this.txtConstructionCompany.Text;
            entity.RepairFee = this.spRepairFee.Value;
            entity.StartDate = this.dpStartDate.DateTime;

            if (this.dpEndDate.EditValue == null)
                entity.EndDate = null;
            else
                entity.EndDate = this.dpEndDate.DateTime;

            entity.Remark = this.txtRemark.Text;
        }

        /// <summary>
        /// 设置记录
        /// </summary>
        /// <returns></returns>
        private List<RepairRecord> SetRecords()
        {
            List<RepairRecord> records = this.recordGrid.DataSource;

            foreach (var item in records)
            {
                item.ModelType = this.currentRepair.ModelType;
                item.Specification = item.Specification ?? "";
                item.TotalPrice = Math.Round(item.Count * item.UnitPrice, 2);
                item.Remark = item.Remark ?? "";
            }

            return records;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.recordGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Repair entity = BusinessFactory<RepairBusiness>.Instance.FindById(this.currentRepair.Id);
                SetEntity(entity);

                List<RepairRecord> records = SetRecords();

                var result = BusinessFactory<RepairBusiness>.Instance.Update(entity, this.currentUser);

                if (!result.success)
                {
                    MessageUtil.ShowClaim("编辑维修改造失败: " + result.errorMessage);
                    return;
                }

                BusinessFactory<RepairRecordBusiness>.Instance.Update(entity, records);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("编辑维修改造失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
