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
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;
    using Poseidon.Finance.Core.BL;

    /// <summary>
    /// 维修改造管理窗体 
    /// </summary>
    public partial class FrmRepairManage : BaseMdiForm
    {
        #region Field
        #endregion //Field

        #region Constructor
        public FrmRepairManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.repairGrid.Init();

            SetYearList();

            base.InitForm();
        }

        /// <summary>
        /// 设置年度列表
        /// </summary>
        private void SetYearList()
        {
            this.lbYears.Items.Clear();

            var nowYear = DateTime.Now.Year;
            for (int i = nowYear; i >= InfrastructureConstant.StartYear; i--)
            {
                this.lbYears.Items.Add(i + "年");
            }
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

        #region Event
        /// <summary>
        /// 新增维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmRepairAdd), new object[] { ModelTypeCode.Elevator });

            SetYearList();
        }

        /// <summary>
        /// 编辑维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmRepairEdit), new object[] { repair.Id });
            SetYearList();
        }

        /// <summary>
        /// 删除维修改造
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否删除该维修改造信息") == DialogResult.Yes)
            {
                bool could = BusinessFactory<RepairBusiness>.Instance.CheckDelete(repair.Id);
                if (!could)
                {
                    MessageUtil.ShowWarning("该维修改造包含费用记录，不能删除");
                    return;
                }

                BusinessFactory<RepairRecordBusiness>.Instance.DeleteByRepair(repair.Id);
                var result = BusinessFactory<RepairBusiness>.Instance.Delete(repair.Id);

                if (result.success)
                {
                    MessageUtil.ShowWarning("删除维修改造信息成功");
                }
                else
                {
                    MessageUtil.ShowWarning("删除维修改造信息失败: " + result.errorMessage);
                }

                SetYearList();
            }
        }

        /// <summary>
        /// 选择改造项目
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void repairGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var repair = this.repairGrid.GetCurrentSelect();
            if (repair == null)
            {
                this.repairRecordGrid.Clear();
                this.expenseGrid.Clear();
            }
            else
            {
                var records = BusinessFactory<RepairRecordBusiness>.Instance.FindByRepair(repair.Id);
                this.repairRecordGrid.DataSource = records.ToList();

                var expense = BusinessFactory<ExpenseBusiness>.Instance.FindByDocumentId(repair.Id);
                this.expenseGrid.DataSource = expense.ToList();
            }
        }

        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbYears.SelectedIndex == -1)
                return;

            string text = this.lbYears.SelectedItem.ToString();
            int year = Convert.ToInt32(text.Substring(0, 4));

            LoadRepairs(year);
        }
        #endregion //Event
    }
}
