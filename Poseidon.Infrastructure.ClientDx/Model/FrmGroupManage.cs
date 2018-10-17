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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 模型管理窗体
    /// </summary>
    public partial class FrmGroupManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选中分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public FrmGroupManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.LoadGroups();

            base.InitForm();
        }

        /// <summary>
        /// 载入分组
        /// </summary>
        private void LoadGroups()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindByModule(InfrastructureConstant.ModuleName).ToList();

            this.trGroup.DataSource = groups;
        }

        /// <summary>
        /// 设置分组基本信息
        /// </summary>
        private void SetGroupInfo()
        {
            this.txtName.Text = this.currentGroup.Name;
            this.txtCode.Text = this.currentGroup.Code;
            this.txtModule.Text = this.currentGroup.Module;
            this.txtStatus.Text = ((EntityStatus)this.currentGroup.Status).DisplayName();
            this.txtRemark.Text = this.currentGroup.Remark;
        }

        /// <summary>
        /// 载入分组项
        /// </summary>
        private void LoadGroupItems()
        {
            var data = BusinessFactory<GroupBusiness>.Instance.FindAllItems(this.currentGroup.Id).ToList();
            this.groupItemGrid.DataSource = data;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择分组
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void trGroup_GroupSelected(object arg1, EventArgs arg2)
        {
            this.currentGroup = this.trGroup.GetCurrentSelect();
            if (this.currentGroup == null)
                return;

            SetGroupInfo();
            LoadGroupItems();
        }

        /// <summary>
        /// 添加分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmGroupAdd));

            this.LoadGroups();
        }

        /// <summary>
        /// 编辑分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentGroup == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmGroupEdit), new object[] { this.currentGroup.Id });
            LoadGroups();
        }
        
        /// <summary>
        /// 删除分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.currentGroup == null)
                return;
            if (MessageUtil.ConfirmYesNo("是否确认删除该分组") == DialogResult.Yes)
            {
                try
                {
                    var result = BusinessFactory<GroupBusiness>.Instance.Delete(this.currentGroup);

                    if (result.success)
                    {
                        LoadGroups();
                        MessageUtil.ShowInfo("删除成功");
                    }
                    else
                    {
                        MessageUtil.ShowClaim("删除分组失败: " + result.errorMessage);
                    }
                }
                catch (PoseidonException pe)
                {
                    Logger.Instance.Exception("删除分组失败", pe);
                    MessageUtil.ShowError(string.Format("删除失败，错误消息:{0}", pe.Message));
                }
            }
        }
        
        /// <summary>
        /// 模型绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModelTypeBind_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmModelTypeBind), new object[] { this.currentGroup.Id });
            LoadGroups();
        }
        
        /// <summary>
        /// 选择设施
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFacility_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmFacilitySelect), new object[] { this.currentGroup.Id });
            LoadGroups();
        }
        #endregion //Event
    }
}
