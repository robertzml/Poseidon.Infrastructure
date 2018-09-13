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
    using Poseidon.Core.Utility;
    using Poseidon.Common;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 电梯日志信息组件
    /// </summary>
    public partial class ElevatorLogInfoView : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 关联电梯
        /// </summary>
        private Elevator currentElevator;

        /// <summary>
        /// 关联日志信息
        /// </summary>
        private ElevatorLog currentLog;
        #endregion //Field

        #region Constructor
        public ElevatorLogInfoView()
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
            this.txtElevator.Text = this.currentElevator.Name;
            this.txtSubject.Text = this.currentLog.Subject;
            this.txtStartDate.Text = this.currentLog.StartDate.ToDateString();
            this.txtLogType.Text = DictUtility.GetDictValue(this.currentLog, "LogType", this.currentLog.LogType);
            this.txtLogStatus.Text = DictUtility.GetDictValue(this.currentLog, "LogStatus", this.currentLog.LogStatus);
            this.txtCreator.Text = this.currentLog.CreateBy.Name;
            this.txtCreateTime.Text = this.currentLog.CreateBy.Time.ToDateTimeString();
            this.txtEditor.Text = this.currentLog.UpdateBy.Name;
            this.txtEditTime.Text = this.currentLog.UpdateBy.Time.ToDateTimeString();
            this.txtInfo.Text = this.currentLog.Info;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置电梯日志
        /// </summary>
        /// <param name="elevatorLog">电梯日志</param>
        /// <param name="elevator">电梯</param>
        public void SetElevator(ElevatorLog elevatorLog, Elevator elevator)
        {
            this.currentLog = elevatorLog;
            this.currentElevator = elevator;

            if (elevator != null)
                this.Display();
            else
                this.Clear();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtElevator.Text = "";
            this.txtSubject.Text = "";
            this.txtStartDate.Text = "";
            this.txtLogType.Text = "";
            this.txtLogStatus.Text = "";
            this.txtCreator.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditor.Text = "";
            this.txtEditTime.Text = "";
            this.txtInfo.Text = "";
        }
        #endregion //Method
    }
}
