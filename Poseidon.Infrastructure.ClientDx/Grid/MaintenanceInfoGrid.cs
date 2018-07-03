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
    /// 维修记录表格控件
    /// </summary>
    public partial class MaintenanceInfoGrid : WinEntityGrid<MaintenanceInfo>
    {
        public MaintenanceInfoGrid()
        {
            InitializeComponent();
        }
    }
}
