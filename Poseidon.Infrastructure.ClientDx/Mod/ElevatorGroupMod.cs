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
    /// 电梯分组管理组件
    /// </summary>
    public partial class ElevatorGroupMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public ElevatorGroupMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入电梯数据
        /// </summary>
        private void LoadData()
        {
            this.elevatorGrid.DataSource = BusinessFactory<ElevatorBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            LoadData();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 添加电梯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmElevatorAdd));
        }
        #endregion //Event
    }
}
