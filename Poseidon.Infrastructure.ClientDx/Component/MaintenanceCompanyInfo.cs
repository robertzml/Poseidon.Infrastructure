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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 维保公司信息组件
    /// </summary>
    public partial class MaintenanceCompanyInfo : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 关联维保公司
        /// </summary>
        private MaintenanceCompany currentCompany;
        #endregion //Field

        #region Constructor
        public MaintenanceCompanyInfo()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示信息
        /// </summary>
        private void Display()
        {
            this.txtName.Text = this.currentCompany.Name;
            this.txtShortName.Text = this.currentCompany.ShortName;
            this.txtAddress.Text = this.currentCompany.Address;
            this.txtContact.Text = this.currentCompany.Contact;
            this.txtRemark.Text = this.currentCompany.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置维保公司
        /// </summary>
        /// <param name="company">维保公司</param>
        public void SetMaintenanceCompany(MaintenanceCompany company)
        {
            this.currentCompany = company;
            if (company != null)
                this.Display();
            else
                this.Clear();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtName.Text = "";
            this.txtShortName.Text = "";
            this.txtAddress.Text = "";
            this.txtContact.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
