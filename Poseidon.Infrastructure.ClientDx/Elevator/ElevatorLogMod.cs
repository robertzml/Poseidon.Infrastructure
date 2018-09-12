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
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
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

        private Color[] labelColors = new Color[] {
            Color.FromArgb(0xFF, 0xFF, 0xC2, 0xBE),
            Color.FromArgb(0xFF, 0xA8, 0xD5, 0xFF),
            Color.FromArgb(0xFF, 0xC1, 0xF4, 0x9C)
                };

        /// <summary>
        /// 日志类型字典
        /// </summary>
        private List<DictItem> logTypeDict;

        /// <summary>
        /// 日志状态字典
        /// </summary>
        private List<DictItem> logStatusDict;
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

        /// <summary>
        /// 设置事件标签
        /// </summary>
        private void SetAppointmentLabels()
        {
            this.storage.Appointments.Labels.Clear();

            var dictItems = DictUtility.GetDictItem(typeof(ElevatorLog), "LogType");

            for (int i = 0; i < dictItems.Count; i++)
            {
                AppointmentLabel label = new AppointmentLabel(dictItems[i].Value);

                label.MenuCaption = dictItems[i].Key.ToString();
                label.Color = labelColors[i];

                this.storage.Appointments.Labels.Add(label);
            }
        }

        /// <summary>
        /// 映射事件到日志对象
        /// </summary>
        /// <param name="apt">事件</param>
        /// <param name="entity">日志对象</param>
        private void MapToEntity(Appointment apt, ElevatorLog entity)
        {
            entity.ElevatorId = apt.ResourceId.ToString();
            entity.Subject = apt.Subject;
            entity.StartDate = apt.Start;
            entity.EndDate = apt.End;
            entity.LogType = apt.LabelId;
            entity.Info = apt.Description;
            entity.LogStatus = apt.StatusId;

            entity.Remark = "";
            return;
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
            SetAppointmentLabels();
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
            try
            {
                Appointment apt = e.Object as Appointment;
                ElevatorLog entity = new ElevatorLog();
                MapToEntity(apt, entity);

                BusinessFactory<ElevatorLogBusiness>.Instance.Create(entity, this.currentUser);
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增日志失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }

            e.Cancel = false;
        }

        /// <summary>
        /// 修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storage_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {
            try
            {
                Appointment apt = e.Object as Appointment;
                ElevatorLog entity = BusinessFactory<ElevatorLogBusiness>.Instance.FindById(apt.Id.ToString());
                MapToEntity(apt, entity);

                BusinessFactory<ElevatorLogBusiness>.Instance.Update(entity, this.currentUser);
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("编辑日志失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }

            e.Cancel = false;
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {

        }
        #endregion //Event
    }
}
