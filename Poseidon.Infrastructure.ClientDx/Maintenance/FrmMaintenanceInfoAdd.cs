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
    /// 添加维保信息窗体
    /// </summary>
    public partial class FrmMaintenanceInfoAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        public FrmMaintenanceInfoAdd(string facilityId)
        {
            InitializeComponent();
            InitData(facilityId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string facilityId)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(facilityId);

            this.bsMaintenanceCompany.DataSource = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindAll().ToList();
        }

        protected override void InitForm()
        {
            this.txtFacilityName.Text = this.currentFacility.Name;
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
            entity.FacilityId = this.currentFacility.Id;
            entity.FacilityName = this.currentFacility.Name;

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
                MaintenanceInfo entity = new MaintenanceInfo();
                SetEntity(entity);

                BusinessFactory<MaintenanceInfoBusiness>.Instance.Create(entity, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增维保信息失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
