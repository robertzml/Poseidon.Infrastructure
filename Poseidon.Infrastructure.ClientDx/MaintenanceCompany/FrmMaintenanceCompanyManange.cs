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

    /// <summary>
    /// 维保公司管理窗体
    /// </summary>
    public partial class FrmMaintenanceCompanyManange : BaseMdiForm
    {
        #region Constructor
        public FrmMaintenanceCompanyManange()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadData();

            base.InitForm();
        }

        /// <summary>
        /// 载入维保公司数据
        /// </summary>
        private void LoadData()
        {
            this.companyGrid.DataSource = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加维保公司
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmMaintenanceCompanyAdd));
            LoadData();
        }
       
        /// <summary>
        /// 编辑维保公司
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var company = this.companyGrid.GetCurrentSelect();
            if (company == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmMaintenanceCompanyEdit), new object[] { company.Id });
            LoadData();
        }
        #endregion //Event
    }
}
