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
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 维修改造表格控件
    /// </summary>
    public partial class RepairGrid : WinEntityGrid<Repair>
    {
        #region Field
        /// <summary>
        /// 是否显示添加费用菜单
        /// </summary>
        private bool showAddExpenseMenu = false;

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
        public void Init()
        {
            ControlUtil.BindDictToComboBox(this.cmbType, typeof(Repair), "Type");
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
            this.AppendMenu(this.contextMenuStrip1);

            this.colModelType.Visible = this.showModelTypeColumn;
            this.menuAddExpense.Visible = this.showAddExpenseMenu;
            this.menuBindExpense.Visible = this.showAddExpenseMenu;
        }

        /// <summary>
        /// 添加费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAddExpense_Click(object sender, EventArgs e)
        {
            var repair = this.GetCurrentSelect();

            if (repair != null)
            {
                string moduleName = typeof(RepairInfoView).FullName;
                string assemblyName = typeof(RepairInfoView).Assembly.GetName().Name;
                string collectionName = InfrastructureConstant.RepairCollectionName;
                string documentId = repair.Id;

                var repairBusiness = BusinessFactory<RepairBusiness>.Instance;
                ChildFormManage.ShowDialogForm(typeof(FrmExpenseAdd), new object[] { moduleName, assemblyName, collectionName, documentId, repairBusiness });
            }
        }

        /// <summary>
        /// 绑定费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBindExpense_Click(object sender, EventArgs e)
        {
            var repair = this.GetCurrentSelect();

            if (repair != null)
            {
                string moduleName = typeof(RepairInfoView).FullName;
                string assemblyName = typeof(RepairInfoView).Assembly.GetName().Name;
                string collectionName = InfrastructureConstant.RepairCollectionName;
                string documentId = repair.Id;

                var repairBusiness = BusinessFactory<RepairBusiness>.Instance;
                ChildFormManage.ShowDialogForm(typeof(FrmExpenseBind), new object[] { moduleName, assemblyName, collectionName, documentId, repairBusiness });
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示添加费用菜单
        /// </summary>
        [Description("是否显示添加费用菜单"), Category("菜单")]
        public bool ShowAddExpenseMenu
        {
            get
            {
                return showAddExpenseMenu;
            }

            set
            {
                showAddExpenseMenu = value;
            }
        }

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
