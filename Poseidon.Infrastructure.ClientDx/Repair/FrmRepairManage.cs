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
        #endregion //Event
    }
}
