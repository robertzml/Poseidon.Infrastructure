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
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 电梯管理模块
    /// </summary>
    public partial class ElevatorReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public ElevatorReceiptMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示电梯基本信息
        /// </summary>
        private void DisplayInfo()
        {
            this.elevatorInfoView.SetElevator(currentElevator);
            this.managersGrid.DataSource = this.currentElevator.Managers;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置电梯
        /// </summary>
        /// <param name="id">电梯ID</param>
        public void SetElevator(string id)
        {
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(id);

            DisplayInfo();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.elevatorInfoView.Clear();
            this.managersGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 添加电梯管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddManager_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmElevatorManagerAdd), new object[] { this.currentElevator.Id });

            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(currentElevator.Id);
            DisplayInfo();
        }
        #endregion //Event
    }
}
