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
    /// 编辑检验记录
    /// </summary>
    public partial class FrmInspectionEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;

        /// <summary>
        /// 当前关联检验
        /// </summary>
        private Inspection currentInspection;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 编辑检验记录
        /// </summary>
        /// <param name="id">检验ID</param>
        public FrmInspectionEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentInspection = BusinessFactory<InspectionBusiness>.Instance.FindById(id);

            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(currentInspection.FacilityId);
        }

        protected override void InitForm()
        {
            this.txtFacilityName.Text = this.currentFacility.Name;

            var type = InspectionBusiness.GetInspectionType(this.currentFacility.ModelType);
            ControlUtil.BindDictToComboBox(this.cmbType, type, "Type", currentInspection.Type);

            this.dpPlanDate.DateTime = this.currentInspection.PlanDate;

            if (this.currentInspection.InspectionDate != null)
                this.dpInspectionDate.DateTime = this.currentInspection.InspectionDate.Value;

            this.txtInspectionCompany.Text = this.currentInspection.InspectionCompany;
            this.spInspectionFee.Value = this.currentInspection.InspectionFee;
            this.chkIsDone.Checked = this.currentInspection.IsDone;
            this.txtInspectionResult.Text = this.currentInspection.InspectionResult;
            this.txtRemark.Text = this.currentInspection.Remark;

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
                errorMessage = "请选择检验类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpPlanDate.EditValue == null)
            {
                errorMessage = "请选择计划日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Inspection entity)
        {
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.PlanDate = this.dpPlanDate.DateTime;

            if (this.dpInspectionDate.EditValue != null)
            {
                entity.InspectionDate = this.dpInspectionDate.DateTime;
            }

            entity.InspectionFee = this.spInspectionFee.Value;
            entity.InspectionCompany = this.txtInspectionCompany.Text;
            entity.InspectionResult = this.txtInspectionResult.Text;
            entity.IsDone = this.chkIsDone.Checked;

            entity.Remark = this.txtRemark.Text;
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
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                var inspection = BusinessFactory<InspectionBusiness>.Instance.FindById(this.currentInspection.Id);
                SetEntity(inspection);

                var result = BusinessFactory<InspectionBusiness>.Instance.Update(inspection, this.currentUser);

                if (result.success)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowClaim("保存失败: " + result.errorMessage);
                }
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("编辑检验信息失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
