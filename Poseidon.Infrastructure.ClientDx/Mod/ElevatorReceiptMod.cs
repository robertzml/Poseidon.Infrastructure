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
    using Poseidon.Base.System;
    using Poseidon.Base.Framework;
    using Poseidon.Common;
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
        /// 载入电梯对象
        /// </summary>
        /// <param name="id">电梯ID</param>
        private void LoadElevator(string id)
        {
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(id);
        }

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
            LoadElevator(id);

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

            LoadElevator(this.currentElevator.Id);
            DisplayInfo();
        }

        /// <summary>
        /// 编辑电梯管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditManager_Click(object sender, EventArgs e)
        {
            var manager = this.managersGrid.GetCurrentSelect();
            if (manager == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmElevatorManagerEdit), new object[] { manager });

            LoadElevator(this.currentElevator.Id);
            DisplayInfo();
        }
        
        /// <summary>
        /// 删除电梯管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            var manager = this.managersGrid.GetCurrentSelect();
            if (manager == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否删除选择管理员: " + manager.Name) == DialogResult.Yes)
            {
                try
                {
                    this.currentElevator.Managers.Remove(manager);
                    BusinessFactory<ElevatorBusiness>.Instance.SetManagers(this.currentElevator.Id, this.currentElevator.Managers);

                    LoadElevator(this.currentElevator.Id);
                    DisplayInfo();

                    MessageUtil.ShowInfo("删除成功");
                }
                catch (PoseidonException pe)
                {
                    Logger.Instance.Exception("删除管理员失败", pe);
                    MessageUtil.ShowError(string.Format("删除失败，错误消息:{0}", pe.Message));
                }
            }
        }
        #endregion //Event
    }
}
