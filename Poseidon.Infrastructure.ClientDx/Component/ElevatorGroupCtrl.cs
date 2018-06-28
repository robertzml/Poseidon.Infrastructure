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
    using Poseidon.Winform.Base;

    /// <summary>
    /// 电梯分组管理组件
    /// </summary>
    public partial class ElevatorGroupCtrl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public ElevatorGroupCtrl()
        {
            InitializeComponent();
        }
        #endregion //Constructor

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
