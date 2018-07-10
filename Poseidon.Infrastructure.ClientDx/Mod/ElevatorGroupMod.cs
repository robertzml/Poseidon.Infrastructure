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

    /// <summary>
    /// 电梯分组管理组件
    /// </summary>
    public partial class ElevatorGroupMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Group currentGroup;
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
            var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

            var data = BusinessFactory<ElevatorBusiness>.Instance.FindListInIds(items.Select(r => r.EntityId).ToList());
            this.elevatorGrid.DataSource = data.ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init(string groupId)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(groupId);

            LoadElevatorData(currentGroup);
        }
        #endregion //Method

        #region Event

        #endregion //Event
    }
}
