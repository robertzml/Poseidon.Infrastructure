using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Infrastructure.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 电梯维保信息模块
    /// </summary>
    public partial class MaintenanceInfoReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public MaintenanceInfoReceiptMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示维保信息
        /// </summary>
        private void DisplayMaintenanceInfo()
        {
            this.maintenanceInfoGrid.DataSource = BusinessFactory<MaintenanceInfoBusiness>.Instance.FindByFacility(this.currentElevator.Id).ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置电梯
        /// </summary>
        /// <param name="elevator">电梯</param>
        public void SetElevator(Elevator elevator)
        {
            this.currentElevator = elevator;

            DisplayMaintenanceInfo();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.currentElevator = null;
            this.maintenanceInfoGrid.Clear();
            this.maintenanceCompanyInfo.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 维保信息选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void maintenanceInfoGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var info = this.maintenanceInfoGrid.GetCurrentSelect();
            if (info == null)
            {
                this.maintenanceCompanyInfo.Clear();
            }

            var company = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindById(info.MaintenanceCompanyId);
            this.maintenanceCompanyInfo.SetMaintenanceCompany(company);
        }

        /// <summary>
        /// 添加维保信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMaintenanceInfoAdd), new object[] { this.currentElevator.Id });
            DisplayMaintenanceInfo();
        }

        /// <summary>
        /// 编辑维保信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            var info = this.maintenanceInfoGrid.GetCurrentSelect();
            if (info == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMaintenanceInfoEdit), new object[] { info.Id });

            DisplayMaintenanceInfo();
        }

        /// <summary>
        /// 删除维保信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            var info = this.maintenanceInfoGrid.GetCurrentSelect();
            if (info == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否删除选择维保信息") == DialogResult.Yes)
            {
                try
                {
                    BusinessFactory<MaintenanceInfoBusiness>.Instance.Delete(info);
                    DisplayMaintenanceInfo();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    Logger.Instance.Exception("删除维保信息失败", pe);
                    MessageUtil.ShowError(string.Format("删除失败，错误消息:{0}", pe.Message));
                }
            }
        }
        #endregion //Event
    }
}
