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
    /// 维修改造记录表格控件
    /// </summary>
    public partial class RepairRecordGrid : WinEntityGrid<RepairRecord>
    {
        #region Field
        /// <summary>
        /// 使用计算总价列
        /// </summary>
        private bool useCalculatePrice = false;
        #endregion //Field

        #region Constructor
        public RepairRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        private void RepairRecordGrid_Load(object sender, EventArgs e)
        {
            this.colCalculatePrice.Visible = this.useCalculatePrice;
            this.colTotalPrice.Visible = !this.useCalculatePrice;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 使用计算总价列
        /// </summary>
        [Description("使用计算总价列"), Category("界面")]
        public bool UseCalculatePrice
        {
            get
            {
                return useCalculatePrice;
            }

            set
            {
                useCalculatePrice = value;
            }
        }
        #endregion //Property
    }
}
