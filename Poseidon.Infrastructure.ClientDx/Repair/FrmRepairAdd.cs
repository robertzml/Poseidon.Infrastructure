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
        /// 模型类型代码
        /// </summary>
        private string modelType;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 添加维修改造
        /// </summary>
        /// <param name="modelType">模型类型</param>
        public FrmRepairAdd(string modelType)
        {
            InitializeComponent();

            InitData(modelType);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string modelType)
        {
            this.modelType = modelType;
        }

        protected override void InitForm()
        {
            ControlUtil.BindDictToComboBox(this.cmbType, typeof(Repair), "Type");

            this.recordGrid.Init(this.modelType);
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
            entity.Name = this.txtName.Text;
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.ModelType = this.modelType;
            entity.ConstructionCompany = this.txtConstructionCompany.Text;
            entity.RepairFee = this.spRepairFee.Value;
            entity.StartDate = this.dpStartDate.DateTime;
            entity.IsProject = this.chkIsProject.Checked;
            if (entity.IsProject)
            {
                entity.ProjectId = this.luProject.EditValue.ToString();
            }
            else
            {
                entity.ProjectId = "";
            }

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
                item.ModelType = this.modelType;
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
