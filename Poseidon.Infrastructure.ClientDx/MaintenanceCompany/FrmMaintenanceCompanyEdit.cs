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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 编辑维保公司窗体
    /// </summary>
    public partial class FrmMaintenanceCompanyEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联维保公司
        /// </summary>
        private MaintenanceCompany currentCompany;
        #endregion //Field

        #region Constructor
        public FrmMaintenanceCompanyEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id"></param>
        private void InitData(string id)
        {
            this.currentCompany = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentCompany.Name;
            this.txtShortName.Text = this.currentCompany.ShortName;
            this.txtAddress.Text = this.currentCompany.Address;
            this.txtContact.Text = this.currentCompany.Contact;
            this.txtRemark.Text = this.currentCompany.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(MaintenanceCompany entity)
        {
            entity.Name = this.txtName.Text;
            entity.ShortName = this.txtShortName.Text;
            entity.Address = this.txtAddress.Text;
            entity.Contact = this.txtContact.Text;
            entity.Remark = this.txtRemark.Text;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                MaintenanceCompany entity = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindById(this.currentCompany.Id);
                SetEntity(entity);

                BusinessFactory<MaintenanceCompanyBusiness>.Instance.Update(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("更新维保公司失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
