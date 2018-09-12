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
    using DevExpress.XtraScheduler;
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 电梯日志管理模块
    /// </summary>
    public partial class ElevatorLogMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前用户
        /// </summary>
        private LoginUser currentUser;

        /// <summary>
        /// 当前关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public ElevatorLogMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 映射事件
        /// </summary>
        private void MappingAppointmentData()
        {
            this.storage.Appointments.DataSource = this.bsElevatorLog;

            AppointmentMappingInfo appoint = this.mainScheduler.Storage.Appointments.Mappings;

            appoint.AppointmentId = "Id";
            appoint.Description = "Info";
            appoint.End = "EndDate";
            appoint.Label = "LogType";
            appoint.ResourceId = "ElevatorId";
            appoint.Start = "StartDate";
            appoint.Status = "LogStatus";
            appoint.Subject = "Subject";
        }

        /// <summary>
        /// 映射资源
        /// </summary>
        private void MappingResourceData()
        {
            this.storage.Resources.Mappings.Id = "Id";
            this.storage.Resources.Mappings.Caption = "Name";
        }

        private void SetAppointmentLabels()
        {
            //this.storage.Appointments.Labels.Add(new AppointmentLabel
            //{
            //    d
            //})
        }

        private ElevatorLog MapToEntity(Appointment apt)
        {
            ElevatorLog entity = new ElevatorLog();

            entity.ElevatorId = apt.ResourceId.ToString();
            entity.Subject = apt.Subject;
            entity.StartDate = apt.Start;
            entity.EndDate = apt.End;
            entity.LogType = apt.LabelId;
            entity.Info = apt.Description;
            entity.LogStatus = apt.StatusId;

            entity.Remark = "";
            return entity;
        }

        /// <summary>
        /// 载入相关数据
        /// </summary>
        private void LoadData()
        {
            var logData = BusinessFactory<ElevatorLogBusiness>.Instance.FindAll();
            this.bsElevatorLog.DataSource = logData;

            var elevatorData = BusinessFactory<ElevatorBusiness>.Instance.FindAll();
            this.bsElevator.DataSource = elevatorData;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="elevatorId">电梯ID</param>
        public void Init(string elevatorId)
        {
            this.currentUser = Cache.Instance.Get("CurrentUser") as LoginUser;
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(elevatorId);

            LoadData();

            MappingAppointmentData();
            MappingResourceData();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {

        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 显示事件窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainScheduler_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            FrmElevatorLogAppointment form = new FrmElevatorLogAppointment(this.currentElevator, this.mainScheduler, e.Appointment);
            form.ShowDialog();
            e.Handled = true;
        }

        /// <summary>
        /// 插入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storage_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e)
        {
            Appointment apt = e.Object as Appointment;
                       
            try
            {
                ElevatorLog entity = MapToEntity(apt);
            

                BusinessFactory<ElevatorLogBusiness>.Instance.Create(entity, this.currentUser);

                //MessageUtil.ShowInfo("保存成功");
               
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增日志失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }

            e.Cancel = false;
        }
        #endregion //Event
    }
}
