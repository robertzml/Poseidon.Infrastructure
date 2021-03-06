﻿using System;
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
    using DevExpress.XtraScheduler;
    using DevExpress.XtraScheduler.UI;
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 自定义电梯运行日志事件编辑窗体
    /// </summary>
    public partial class FrmElevatorLogAppointment : BaseSingleForm
    {
        #region Field
        private AppointmentFormController controller;

        /// <summary>
        /// 关联日历控件
        /// </summary>
        private SchedulerControl schedulerControl;

        /// <summary>
        /// 关联事件
        /// </summary>
        private Appointment appointment;

        /// <summary>
        /// 关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 自定义电梯运行日志事件编辑窗体
        /// </summary>
        /// <param name="elevator">电梯</param>
        /// <param name="schedulerControl"></param>
        /// <param name="apt"></param>
        public FrmElevatorLogAppointment(Elevator elevator, SchedulerControl schedulerControl, Appointment apt)
        {
            InitializeComponent();

            this.currentElevator = elevator;
            this.schedulerControl = schedulerControl;
            this.appointment = apt;

            this.controller = new AppointmentFormController(schedulerControl, apt);
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsElevator.DataSource = BusinessFactory<ElevatorBusiness>.Instance.FindAll();

            this.aptLabel.Storage = schedulerControl.Storage;
            this.aptStatus.Storage = schedulerControl.Storage;

            DisplayInfo();

            base.InitForm();
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        private void DisplayInfo()
        {
            this.luElevator.EditValue = this.currentElevator.Id;
            this.txtSubject.Text = this.appointment.Subject;
            this.dpStartDate.EditValue = this.appointment.Start;
            this.txtInfo.Text = this.appointment.Description;

            if (this.appointment.Id != null)
            {
                this.aptLabel.AppointmentLabel = controller.AppointmentLabel;
                this.aptStatus.AppointmentStatus = controller.AppointmentStatus;

                var log = BusinessFactory<ElevatorLogBusiness>.Instance.FindById(appointment.Id.ToString());
                this.txtCreator.Text = log.CreateBy.Name;
                this.txtCreateTime.Text = log.CreateBy.Time.ToDateTimeString();
                this.txtEditor.Text = log.UpdateBy.Name;
                this.txtEditTime.Text = log.UpdateBy.Time.ToDateTimeString();
            }
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.luElevator.EditValue == null)
            {
                errorMessage = "请选择电梯";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtSubject.Text.Trim()))
            {
                errorMessage = "请输入主题";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.aptLabel.EditValue == null)
            {
                errorMessage = "请选择事件类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.aptStatus.EditValue == null)
            {
                errorMessage = "请选择事件状态";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpStartDate.EditValue == null)
            {
                errorMessage = "请选择日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置事件
        /// </summary>
        private void SetAppointment()
        {
            this.controller.ResourceId = this.currentElevator.Id;
            this.controller.Subject = this.txtSubject.Text;
            this.controller.Start = this.dpStartDate.DateTime;
            this.controller.End = this.dpStartDate.DateTime.AddDays(1);
            this.controller.Description = this.txtInfo.Text ?? "";
            this.controller.AppointmentLabel = this.aptLabel.AppointmentLabel;
            this.controller.AppointmentStatus = this.aptStatus.AppointmentStatus;
            //this.controller.LabelKey = Convert.ToInt32(this.aptLabel.AppointmentLabel.Id);
            //this.controller.StatusKey = Convert.ToInt32(this.aptStatus.AppointmentStatus.Id);
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.schedulerControl.Storage.BeginUpdate();

            SetAppointment();
            this.controller.ApplyChanges();

            this.schedulerControl.Storage.EndUpdate();

            this.Close();
        }
        #endregion //Event

        #region Property
        public AppointmentFormController Controller
        {
            get
            {
                return controller;
            }
        }
        #endregion //Property        
    }
}
