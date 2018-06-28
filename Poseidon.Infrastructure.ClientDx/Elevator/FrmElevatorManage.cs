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

    /// <summary>
    /// 电梯管理窗体
    /// </summary>
    public partial class FrmElevatorManage : BaseMdiForm
    {
        #region Constructor
        public FrmElevatorManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.elevatorGroupMod.Init();

            base.InitForm();
        }
        #endregion //Function
    }
}
