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
    /// 添加维修改造
    /// </summary>
    public partial class FrmRepairAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 添加维修改造
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        public FrmRepairAdd(string facilityId)
        {
            InitializeComponent();

            InitData(facilityId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string facilityId)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(facilityId);
        }

        protected override void InitForm()
        {
            this.txtFacilityName.Text = this.currentFacility.Name;

            var type = RepairBusiness.GetRepairType(this.currentFacility.ModelType);
            ControlUtil.BindDictToComboBox(this.cmbType, type, "Type");

            this.recordGrid.DataSource = new List<RepairRecord>();

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

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
            entity.FacilityId = this.currentFacility.Id;
            entity.FacilityName = this.currentFacility.Name;
            entity.ModelType = this.currentFacility.ModelType;
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
                item.ModelType = this.currentFacility.ModelType;
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
                Repair entity = new Repair();
                SetEntity(entity);

                List<RepairRecord> records = SetRecords();

                BusinessFactory<RepairBusiness>.Instance.Create(entity, this.currentUser);
                BusinessFactory<RepairRecordBusiness>.Instance.CreateMany(entity, records);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增维修改造失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
