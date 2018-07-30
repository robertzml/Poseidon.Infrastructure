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
    /// 维修改造管理模块
    /// </summary>
    public partial class RepairReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        public RepairReceiptMod()
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
        /// 显示数据
        /// </summary>
        private void DisplayInfo()
        {
            this.repairGrid.DataSource = BusinessFactory<RepairBusiness>.Instance.FindByFacility(this.currentFacility.Id).ToList();
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

            this.repairGrid.Init(ModelTypeCode.Elevator);
            DisplayInfo();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.currentFacility = null;
            this.repairGrid.Clear();
            this.recordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 新增维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentFacility == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmRepairAdd), new object[] { this.currentFacility.Id });

            DisplayInfo();
        }

        /// <summary>
        /// 编辑维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentFacility == null)
                return;

            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmRepairEdit), new object[] { repair.Id });
            DisplayInfo();
        }

        /// <summary>
        /// 删除维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentFacility == null)
                return;

            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否删除该维修改造信息") == DialogResult.Yes)
            {
                bool could = BusinessFactory<RepairBusiness>.Instance.CheckDelete(repair.Id);
                if (!could)
                {
                    MessageUtil.ShowWarning("该维修改造包含费用记录，不能删除");
                    return;
                }

                BusinessFactory<RepairRecordBusiness>.Instance.DeleteByRepair(repair.Id);
                var result = BusinessFactory<RepairBusiness>.Instance.Delete(repair.Id);
                if (result)
                {
                    MessageUtil.ShowWarning("删除维修改造信息成功");
                    DisplayInfo();
                }
                else
                {
                    MessageUtil.ShowWarning("删除维修改造信息失败");
                }
            }
        }

        /// <summary>
        /// 选择项
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
