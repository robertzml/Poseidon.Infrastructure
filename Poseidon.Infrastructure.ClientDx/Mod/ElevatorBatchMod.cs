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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 电梯批量管理模块
    /// </summary>
    public partial class ElevatorBatchMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public ElevatorBatchMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        public void Init()
        {

        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 批量设置维保信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMaintenanceInfo_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmMaintenanceInfoBatch));
        }
        #endregion //Event
    }
}
