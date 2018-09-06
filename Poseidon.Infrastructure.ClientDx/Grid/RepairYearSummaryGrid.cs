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
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 维修改造年度汇总表格
    /// </summary>
    public partial class RepairYearSummaryGrid : WinEntityGrid<RepairYearSummaryModel>
    {
        #region Constructor
        public RepairYearSummaryGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
