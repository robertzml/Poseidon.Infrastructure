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
    /// 电梯管理员模块
    /// </summary>
    public partial class ElevatorManagerReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联电梯
        /// </summary>
        private Elevator currentElevator;

        /// <summary>
        /// 能否编辑
        /// </summary>
        private bool editable = true;
        #endregion //Field

        #region Constructor
        public ElevatorManagerReceiptMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入电梯管理员
        /// </summary>
        private void LoadManagers()
        {
            this.managerGrid.DataSource = this.currentElevator.Managers;
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
            LoadManagers();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.currentElevator = null;
            this.managerGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElevatorManagerReceiptMod_Load(object sender, EventArgs e)
        {
            if (this.editable)
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        /// <summary>
        /// 添加电梯管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmElevatorManagerAdd), new object[] { this.currentElevator.Id });

            LoadManagers();
        }

        /// <summary>
        /// 编辑电梯管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            var manager = this.managerGrid.GetCurrentSelect();
            if (manager == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmElevatorManagerEdit), new object[] { manager });

            LoadManagers();
        }

        /// <summary>
        /// 删除电梯管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            var manager = this.managerGrid.GetCurrentSelect();
            if (manager == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否删除选择管理员: " + manager.Name) == DialogResult.Yes)
            {
                try
                {
                    this.currentElevator.Managers.Remove(manager);
                    BusinessFactory<ElevatorBusiness>.Instance.SetManagers(this.currentElevator.Id, this.currentElevator.Managers);

                    LoadManagers();

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

        #region Property
        /// <summary>
        /// 能否编辑
        /// </summary>
        [Description("能否编辑"), Category("功能")]
        public bool Editable
        {
            get
            {
                return this.editable;
            }
            set
            {
                this.editable = value;
            }
        }
        #endregion //Property
    }
}
