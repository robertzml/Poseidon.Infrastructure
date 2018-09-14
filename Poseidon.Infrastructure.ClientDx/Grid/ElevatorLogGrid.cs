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
    using Poseidon.Common;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 电梯运行日志表格
    /// </summary>
    public partial class ElevatorLogGrid : WinEntityGrid<ElevatorLog>
    {
        #region Field
        /// <summary>
        /// 日志类型字典
        /// </summary>
        private List<DictItem> logTypeDict;

        /// <summary>
        /// 日志状态字典
        /// </summary>
        private List<DictItem> logStatusDict;

        /// <summary>
        /// 缓存电梯数据
        /// </summary>
        private List<Elevator> elevatorList;
        #endregion //Field

        #region Constructor
        public ElevatorLogGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.elevatorList = BusinessFactory<ElevatorBusiness>.Instance.FindAll().ToList();
            this.logTypeDict = DictUtility.GetDictItem(typeof(ElevatorLog), "LogType");
            this.logStatusDict = DictUtility.GetDictItem(typeof(ElevatorLog), "LogStatus");
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[rowIndex] as ElevatorLog;
            if (e.Column.FieldName == "ElevatorId")
            {
                var ele = elevatorList.Find(r => r.Id == record.ElevatorId);
                if (ele != null)
                    e.DisplayText = ele.Name;
            }
            if (e.Column.FieldName == "LogType")
            {
                var dict = logTypeDict.Find(r => r.Key == record.LogType);
                if (dict != null)
                    e.DisplayText = dict.Value;
            }
            if (e.Column.FieldName == "LogStatus")
            {
                var dict = logStatusDict.Find(r => r.Key == record.LogStatus);
                if (dict != null)
                    e.DisplayText = dict.Value;
            }
        }
        #endregion //Event
    }
}
