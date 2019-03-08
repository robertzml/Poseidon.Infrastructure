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
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 电梯分组管理组件
    /// </summary>
    public partial class ElevatorGroupMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 分组记录
        /// </summary>
        private List<GroupItem> groupItems;

        /// <summary>
        /// 相关检验记录
        /// </summary>
        private List<Inspection> inspectionList = new List<Inspection>();
        #endregion //Field

        #region Constructor
        public ElevatorGroupMod()
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
            var data = BusinessFactory<ElevatorBusiness>.Instance.FindListInIds(groupItems.Select(r => r.EntityId).ToList());
            this.elevatorGrid.DataSource = data.ToList();
        }

        /// <summary>
        /// 载入检验信息
        /// </summary>
        /// <param name="group">分组</param>
        private void LoadInspectionData(Group group)
        {
            this.inspectionList = BusinessFactory<InspectionBusiness>.Instance.FindByFacilityIds(groupItems.Select(r => r.EntityId).ToList()).ToList();
            this.inspectionGrid.DataSource = inspectionList;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init(string groupId)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(groupId);
            this.groupItems = BusinessFactory<GroupBusiness>.Instance.FindAllItems(currentGroup.Id).ToList();

            this.inspectionGrid.Init(ModelTypeCode.Elevator);

            LoadElevatorData(currentGroup);
            LoadInspectionData(currentGroup);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 检验年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpInspectionYear_EditValueChanged(object sender, EventArgs e)
        {
            if  (this.dpInspectionYear.EditValue == null)
            {
                this.inspectionGrid.DataSource = inspectionList;
            }
            else
            {
                var year = this.dpInspectionYear.DateTime.Year;

                var data = inspectionList.Where(r => r.PlanDate.Year == year).ToList();
                this.inspectionGrid.DataSource = data;
            }
        }
        #endregion //Event
    }
}
