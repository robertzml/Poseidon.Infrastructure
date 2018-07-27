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
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 维修改造表格控件
    /// </summary>
    public partial class RepairGrid : WinEntityGrid<Repair>
    {
        #region Field
        /// <summary>
        /// 是否显示设施类型
        /// </summary>
        private bool showModelTypeColumn = false;
        #endregion //Field

        #region Constructor
        public RepairGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void Init(string modelType)
        {
            var type = RepairBusiness.GetRepairType(modelType);
            ControlUtil.BindDictToComboBox(this.cmbType, type, "Type");
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepairGrid_Load(object sender, EventArgs e)
        {
            this.colModelType.Visible = this.showModelTypeColumn;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示设施类型
        /// </summary>
        [Description("是否显示设施类型"), Category("界面")]
        public bool ShowModelTypeColumn
        {
            get
            {
                return showModelTypeColumn;
            }

            set
            {
                showModelTypeColumn = value;
            }
        }
        #endregion //Property
    }
}
