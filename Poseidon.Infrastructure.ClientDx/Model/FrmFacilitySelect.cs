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
    using Poseidon.Winform.Base;

    /// <summary>
    /// 设施选择
    /// </summary>
    public partial class FrmFacilitySelect : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 设施选择
        /// </summary>
        /// <param name="groupId"></param>
        public FrmFacilitySelect(string groupId)
        {
            InitializeComponent();
            InitData(groupId);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="groupId">分组ID</param>
        private void InitData(string groupId)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(groupId);
        }

        protected override void InitForm()
        {
            this.itemGrid.DataSource = this.currentGroup.Items;
            this.bsModelType.DataSource = BusinessFactory<ModelTypeBusiness>.Instance.FindWithCodes(this.currentGroup.ModelTypes).Where(r => r.Category == (int)ModelCategory.Facility);

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 模型类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luModelType_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luModelType.EditValue == null)
                return;

            var data = BusinessFactory<FacilityBusiness>.Instance.FindByModelType(this.luModelType.EditValue.ToString()).ToList();
            this.facGridLeft.DataSource = data;
        }

        /// <summary>
        /// 移入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveIn_Click(object sender, EventArgs e)
        {
            var rows = this.facGridLeft.GetSelectedRows();

            foreach (var row in rows)
            {
                if (!this.itemGrid.DataSource.Any(r => r.EntityId == row.Id))
                {
                    GroupItem item = new GroupItem
                    {
                        GroupCode = this.currentGroup.Code,
                        EntityId = row.Id,
                        ModelType = row.ModelType
                    };
                    this.itemGrid.DataSource.Add(item);
                }
            }

            this.itemGrid.UpdateBindingData();
        }

        /// <summary>
        /// 移出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveOut_Click(object sender, EventArgs e)
        {
            var select = this.itemGrid.GetCurrentSelect();
            if (select != null)
            {
                this.itemGrid.DataSource.Remove(select);
                this.itemGrid.UpdateBindingData();
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.itemGrid.CloseEditor();

            try
            {
                BusinessFactory<GroupBusiness>.Instance.SetGroupItems(this.currentGroup.Id, this.itemGrid.DataSource);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
