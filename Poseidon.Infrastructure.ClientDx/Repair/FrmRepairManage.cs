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
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 维修改造管理窗体 
    /// </summary>
    public partial class FrmRepairManage : BaseMdiForm
    {
        #region Constructor
        public FrmRepairManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.repairGrid.Init();

            LoadRepairs();

            base.InitForm();
        }

        /// <summary>
        /// 载入维修改造信息
        /// </summary>
        private void LoadRepairs()
        {
            this.repairGrid.DataSource = BusinessFactory<RepairBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 新增维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmRepairAdd), new object[] { ModelTypeCode.Elevator });

            LoadRepairs();
        }
        
        /// <summary>
        /// 编辑维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmRepairEdit), new object[] { repair.Id });
            LoadRepairs();
        }
        
        /// <summary>
        /// 删除维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
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
                    LoadRepairs();
                }
                else
                {
                    MessageUtil.ShowWarning("删除维修改造信息失败");
                }
            }
        }
        #endregion //Event
    }
}
