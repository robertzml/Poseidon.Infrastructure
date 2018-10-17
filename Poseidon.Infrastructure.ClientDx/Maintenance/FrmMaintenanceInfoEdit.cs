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
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 编辑维保信息窗体
    /// </summary>
    public partial class FrmMaintenanceInfoEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;

        /// <summary>
        /// 关联维保信息
        /// </summary>
        private MaintenanceInfo currentInfo;
        #endregion //Field

        #region Constructor
        public FrmMaintenanceInfoEdit(string maintenanceInfoId)
        {
            InitializeComponent();

            InitData(maintenanceInfoId);
        }
        #endregion //Constructor

        #region Function
        protected void InitData(string maintenanceInfoId)
        {
            this.currentInfo = BusinessFactory<MaintenanceInfoBusiness>.Instance.FindById(maintenanceInfoId);
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(currentInfo.FacilityId);

            this.bsMaintenanceCompany.DataSource = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindAll().ToList();
        }

        protected override void InitForm()
        {
            this.txtFacilityName.Text = this.currentInfo.FacilityName;

            this.luMaintenanceCompany.EditValue = this.currentInfo.MaintenanceCompanyId;
            this.dpStartDate.DateTime = this.currentInfo.StartDate;
            this.dpEndDate.DateTime = this.currentInfo.EndDate;
            this.spMaintenanceFee.Value = this.currentInfo.MaintenanceFee;
            this.chkIsFree.Checked = this.currentInfo.IsFree;
            this.txtRemark.Text = this.currentInfo.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (luMaintenanceCompany.EditValue == null)
            {
                errorMessage = "请选择维保公司";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpStartDate.EditValue == null)
            {
                errorMessage = "请选择开始日期";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpEndDate.EditValue == null)
            {
                errorMessage = "请选择结束日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(MaintenanceInfo entity)
        {
            var company = this.luMaintenanceCompany.GetSelectedDataRow() as MaintenanceCompany;
            entity.MaintenanceCompanyId = company.Id;
            entity.MaintenanceCompanyName = company.Name;
            entity.StartDate = this.dpStartDate.DateTime;
            entity.EndDate = this.dpEndDate.DateTime;
            entity.MaintenanceFee = this.spMaintenanceFee.Value;
            entity.IsFree = this.chkIsFree.Checked;
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
                var info = BusinessFactory<MaintenanceInfoBusiness>.Instance.FindById(this.currentInfo.Id);
                SetEntity(info);

                var result = BusinessFactory<MaintenanceInfoBusiness>.Instance.Update(info, this.currentUser);

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
                Logger.Instance.Exception("编辑维保信息失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
