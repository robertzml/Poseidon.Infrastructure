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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 设施相关维修改造模块
    /// </summary>
    public partial class FacilityRepairMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        public FacilityRepairMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入设施对象
        /// </summary>
        /// <param name="id">设施ID</param>
        private void LoadFacility(string id)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(id);
        }

        /// <summary>
        /// 载入设施维修改造项目
        /// </summary>
        private void LoadRepair()
        {
            this.repairGrid.Init();

            this.repairGrid.DataSource = BusinessFactory<RepairBusiness>.Instance.FindByFacility(this.currentFacility.Id).ToList();
        }

        /// <summary>
        /// 载入设施维修改造全部记录
        /// </summary>
        private void LoadRecords()
        {
            var data = BusinessFactory<RepairRecordBusiness>.Instance.FindByFacility(this.currentFacility.Id).ToList();
            this.fullRecordGrid.DataSource = data;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置设施
        /// </summary>
        /// <param name="id">设施ID</param>
        public void SetFacility(string id)
        {
            LoadFacility(id);

            LoadRepair();

            this.accordionControl1.SelectedElement = this.accRepairItem;
            this.navFrame.SelectedPageIndex = 0;
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.repairGrid.Clear();
            this.recordGrid.Clear();

            this.fullRecordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 菜单选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            var tag = e.Element.Tag.ToString();

            switch (tag)
            {
                case "Repair":
                    LoadRepair();
                    this.navFrame.SelectedPageIndex = 0;
                    break;
                case "Record":
                    LoadRecords();
                    this.navFrame.SelectedPageIndex = 1;
                    break;
            }
        }

        /// <summary>
        /// 维修改造项目选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void repairGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
            {
                this.recordGrid.Clear();
            }
            else
            {
                var records = BusinessFactory<RepairRecordBusiness>.Instance.FindByRepair(repair.Id);
                this.recordGrid.DataSource = records.ToList();
            }
        }
        #endregion //Event
    }
}
