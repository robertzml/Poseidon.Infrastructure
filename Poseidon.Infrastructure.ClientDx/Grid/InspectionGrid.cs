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
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 设施检验表格控件
    /// </summary>
    public partial class InspectionGrid : WinEntityGrid<Inspection>
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
        public InspectionGrid()
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
            var type = InspectionBusiness.GetInspectionType(modelType);
            ControlUtil.BindDictToComboBox(this.cmbType, type, "Type");
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InspectionGrid_Load(object sender, EventArgs e)
        {
            this.AppendMenu(this.contextMenuStrip1);

            this.colModelType.Visible = this.showModelTypeColumn;
            this.menuAddExpense.Visible = this.showAddExpenseMenu;
        }
       
        /// <summary>
        /// 添加支出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAddExpense_Click(object sender, EventArgs e)
        {
            var inspection = this.GetCurrentSelect();

            if (inspection != null)
            {
                string moduleName = typeof(InspectionInfoView).FullName;
                string assemblyName = typeof(InspectionInfoView).Assembly.GetName().Name;
                string collectionName = InfrastructureConstant.InspectionCollectionName;
                string documentId = inspection.Id;

                ChildFormManage.ShowDialogForm(typeof(FrmExpenseAdd), new object[] { moduleName, assemblyName, collectionName, documentId });
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
