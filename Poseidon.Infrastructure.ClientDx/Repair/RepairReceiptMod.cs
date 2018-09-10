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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 维修改造管理模块
    /// </summary>
    public partial class RepairReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        #endregion //Field

        #region Constructor
        public RepairReceiptMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 设置年度列表
        /// </summary>
        private void SetYearList()
        {
            this.lbYears.Items.Clear();

            this.lbYears.Items.Add("全部");
            this.lbYears.Items.Add("-----");
            var nowYear = DateTime.Now.Year;
            for (int i = nowYear; i >= InfrastructureConstant.StartYear; i--)
            {
                this.lbYears.Items.Add(i + "年");
            }
        }

        /// <summary>
        /// 载入所有维修改造信息
        /// </summary>
        private void LoadRepairs()
        {
            var data = BusinessFactory<RepairBusiness>.Instance.FindAll();
            this.repairGrid.DataSource = data.ToList();
        }

        /// <summary>
        /// 按年度载入维修改造信息
        /// </summary>
        /// <param name="year"></param>
        private void LoadRepairs(int year)
        {
            var data = BusinessFactory<RepairBusiness>.Instance.FindByYear(year);
            this.repairGrid.DataSource = data.ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.repairGrid.Init();

            SetYearList();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.lbYears.Items.Clear();
            this.repairGrid.Clear();

            this.repairInfoView.Clear();
            this.expenseGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbYears.SelectedIndex == -1)
                return;
            else if (this.lbYears.SelectedIndex == 0)
            {
                LoadRepairs();
                return;
            }
            else if (this.lbYears.SelectedIndex == 1)
            {
                this.repairGrid.Clear();
                return;
            }

            string text = this.lbYears.SelectedItem.ToString();
            int year = Convert.ToInt32(text.Substring(0, 4));

            LoadRepairs(year);
        }

        /// <summary>
        /// 选择项
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void repairGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
            {
                this.repairInfoView.Clear();
                this.expenseGrid.Clear();
            }
            else
            {
                this.repairInfoView.Init(repair);

                var expense = BusinessFactory<ExpenseBusiness>.Instance.FindByDocumentId(repair.Id);
                this.expenseGrid.DataSource = expense.ToList();
            }
        }
        #endregion //Event
    }
}
