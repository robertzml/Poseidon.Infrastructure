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
    /// 设施检验模块
    /// </summary>
    public partial class InspectionReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        public InspectionReceiptMod()
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
        private void DisplayInfo()
        {
            this.insGrid.DataSource = BusinessFactory<InspectionBusiness>.Instance.FindByFacility(this.currentFacility.Id).ToList();
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

            this.insGrid.Init(ModelTypeCode.Elevator);
            DisplayInfo();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.insGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 添加检验信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentFacility == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmInspectionAdd), new object[] { this.currentFacility.Id });

            DisplayInfo();
        }

        /// <summary>
        /// 编辑检验信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentFacility == null)
                return;

            var inspection = this.insGrid.GetCurrentSelect();
            if (inspection == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmInspectionEdit), new object[] { inspection.Id });
            DisplayInfo();
        }
        
        /// <summary>
        /// 选择检验信息
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void insGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var inspection = this.insGrid.GetCurrentSelect();
            if (inspection == null)
            {
                this.expGrid.Clear();
            }
            else
            {
                var expense = BusinessFactory<ExpenseBusiness>.Instance.FindByDocumentId(inspection.Id);
                this.expGrid.DataSource = expense.ToList();
            }
        }
        #endregion //Event
    }
}
