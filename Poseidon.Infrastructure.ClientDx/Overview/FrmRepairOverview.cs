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
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 维修改造总览
    /// </summary>
    public partial class FrmRepairOverview : BaseMdiForm
    {
        #region Constructor
        public FrmRepairOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.SuspendLayout();

            this.repairOvMod.Init();
            this.repairReceiptMod.Init();
            this.repairRecordMod.Init();

            base.InitForm();

            this.ResumeLayout();
        }
        #endregion //Function
    }
}
