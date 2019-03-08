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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 电梯批量管理模块
    /// </summary>
    public partial class ElevatorBatchMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public ElevatorBatchMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入电梯数据
        /// </summary>
        /// <param name="group">分组</param>
        private void LoadElevatorData(Group group)
        {
            var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            var data = BusinessFactory<ElevatorBusiness>.Instance.FindListInIds(items.Select(r => r.EntityId).ToList());

            //this.elevatorGrid.DataSource = data.ToList();
        }

        /// <summary>
        /// 载入检验信息
        /// </summary>
        /// <param name="group">分组</param>
        private void LoadInspectionData(Group group)
        {
            var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            var data =  BusinessFactory<InspectionBusiness>.Instance.FindByFacilityIds(items.Select(r => r.EntityId).ToList());

            this.inspectionGrid.DataSource = data.ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="groupId">分组ID</param>
        public void Init(string groupId)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(groupId);

            this.inspectionGrid.Init(ModelTypeCode.Elevator);

            LoadInspectionData(currentGroup);
        }
        #endregion //Method

        #region Event
        #region Tab Action
        /// <summary>
        /// 批量设置维保信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMaintenanceInfo_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmMaintenanceInfoBatch));
        }
        
        /// <summary>
        /// 批量添加检验计划
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInspectionPlan_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmInspectionBatch));
        }
        #endregion //Tab Action
        #endregion //Event
    }
}
