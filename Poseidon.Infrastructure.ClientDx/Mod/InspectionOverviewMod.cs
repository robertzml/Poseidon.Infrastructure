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

    /// <summary>
    /// 设施检验总览模块
    /// </summary>
    public partial class InspectionOverviewMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        public InspectionOverviewMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入设施对象
        /// </summary>
        /// <param name="id">设施ID</param>
        private void LoadFacility(string id)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(id);
        }

        /// <summary>
        /// 显示数据
        /// </summary>
        private void DisplayInspectionList()
        {
            this.inspectionGrid.DataSource = BusinessFactory<InspectionBusiness>.Instance.FindByFacility(this.currentFacility.Id).ToList();
        }

        /// <summary>
        /// 显示检验信息
        /// </summary>
        /// <param name="inspection">检验记录</param>
        private void DisplayInspectionInfo(Inspection inspection)
        {
            this.inspectionInfo.Init(inspection);
        }

        /// <summary>
        /// 显示费用记录
        /// </summary>
        /// <param name="inspection">检验记录</param>
        private void DisplayExpense(Inspection inspection)
        {
            var expense = BusinessFactory<ExpenseBusiness>.Instance.FindByDocumentId(inspection.Id);
            this.expenseGrid.DataSource = expense.ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置设施
        /// </summary>
        /// <param name="id">设施ID</param>
        public void SetFacility(string id)
        {
            LoadFacility(id);

            this.inspectionGrid.Init(ModelTypeCode.Elevator);
            DisplayInspectionList();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.inspectionGrid.Clear();
            this.inspectionInfo.Clear();
            this.expenseGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 检验记录选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void inspectionGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var inspection = this.inspectionGrid.GetCurrentSelect();
            if (inspection == null)
            {
                this.inspectionInfo.Clear();
                this.expenseGrid.Clear();
            }
            else
            {
                DisplayInspectionInfo(inspection);
                DisplayExpense(inspection);
            }
        }
        #endregion //Event
    }
}
