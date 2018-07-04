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
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 设施检验表格控件
    /// </summary>
    public partial class InspectionGrid : WinEntityGrid<Inspection>
    {
        #region Constructor
        public InspectionGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
