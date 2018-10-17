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
    using DevExpress.XtraEditors.Controls;
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

        /// <summary>
        /// 日志数据
        /// </summary>
        private List<ElevatorLog> logData;

        /// <summary>
        /// 标签颜色列表
        /// </summary>
        private Color[] labelColors = new Color[] {
            System.Drawing.SystemColors.Window,
            ColorTranslator.FromHtml("#FFFFC2BE"),
            ColorTranslator.FromHtml("#FFA8D5FF"),
            ColorTranslator.FromHtml("#FFC1F49C"),
            ColorTranslator.FromHtml("#FFF3E4C7"),
            ColorTranslator.FromHtml("#FFF4CE93"),
            ColorTranslator.FromHtml("#FFC7F4FF"),
            ColorTranslator.FromHtml("#FFCFDB98"),
            ColorTranslator.FromHtml("#FFE0CFE9"),
            ColorTranslator.FromHtml("#FF8DE9DF"),
            ColorTranslator.FromHtml("#FFFFF7A5"),
                };

        /// <summary>
        /// 状态颜色列表
        /// </summary>
        private Color[] statusColors = new Color[]
        {
            ColorTranslator.FromHtml("#FFFFFFFF"),
            ColorTranslator.FromHtml("#FF4A87E2"),
            ColorTranslator.FromHtml("#FF4A87E2"),
            ColorTranslator.FromHtml("#FF800080"),
            ColorTranslator.FromHtml("#FF937BD1")
        };

        /// <summary>
        /// 日志类型字典
        /// </summary>
        private List<DictItem> logTypeDict;

        /// <summary>
        /// 日志状态字典
        /// </summary>
        private List<DictItem> logStatusDict;

        /// <summary>
        /// 是否可以编辑
        /// </summary>
        private bool editable = true;
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
        /// 设置事件类型
        /// </summary>
        private void SetAppointmentLabels()
        {
            this.storage.Appointments.Labels.Clear();

            for (int i = 0; i < logTypeDict.Count; i++)
            {
                if (i >= labelColors.Length)
                    return;

                AppointmentLabel label = new AppointmentLabel(logTypeDict[i].Value);
                label.Color = labelColors[i];

                this.storage.Appointments.Labels.Add(label);
            }
        }

        /// <summary>
        /// 设置事件状态
        /// </summary>
        private void SetAppointmentStatus()
        {
            this.storage.Appointments.Statuses.Clear();

            for (int i = 0; i < logStatusDict.Count; i++)
            {
                if (i >= statusColors.Length)
                    return;

                AppointmentStatus status = new AppointmentStatus((AppointmentStatusType)i, logStatusDict[i].Value);
                status.Color = statusColors[i];

                this.storage.Appointments.Statuses.Add(status);
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
            entity.Info = apt.Description;
            entity.LogType = apt.LabelId;
            entity.LogStatus = apt.StatusId;

            entity.Remark = "";
            return;
        }

        /// <summary>
        /// 载入日志类型筛选
        /// </summary>
        private void LoadTypeFilter()
        {
            this.chkListLogType.Items.Clear();

            foreach (var item in this.logTypeDict)
            {
                this.chkListLogType.Items.Add(item.Key, item.Value, CheckState.Checked, true);
            }
        }

        /// <summary>
        /// 载入日志数据
        /// </summary>
        private void LoadLogData()
        {
            this.logData = BusinessFactory<ElevatorLogBusiness>.Instance.FindByElevator(this.currentElevator.Id).ToList();
            this.bsElevatorLog.DataSource = logData;
        }

        /// <summary>
        /// 载入相关数据
        /// </summary>
        private void LoadData()
        {
            LoadLogData();

            var elevatorData = BusinessFactory<ElevatorBusiness>.Instance.FindAll();
            this.bsElevator.DataSource = elevatorData;

            this.logTypeDict = DictUtility.GetDictItem(typeof(ElevatorLog), "LogType");
            this.logStatusDict = DictUtility.GetDictItem(typeof(ElevatorLog), "LogStatus");
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="elevatorId">电梯ID</param>
        public void SetElevator(string elevatorId)
        {
            this.currentUser = Cache.Instance.Get("CurrentUser") as LoginUser;
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(elevatorId);

            LoadData();

            MappingAppointmentData();
            MappingResourceData();
            SetAppointmentLabels();
            SetAppointmentStatus();

            LoadTypeFilter();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.currentElevator = null;
            this.bsElevatorLog.Clear();
            this.logInfoView.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElevatorLogMod_Load(object sender, EventArgs e)
        {
            this.mainScheduler.OptionsCustomization.AllowAppointmentCreate = editable ? UsedAppointmentType.All : UsedAppointmentType.None;
            this.mainScheduler.OptionsCustomization.AllowAppointmentDelete = editable ? UsedAppointmentType.All : UsedAppointmentType.None;
            this.mainScheduler.OptionsCustomization.AllowAppointmentResize = editable ? UsedAppointmentType.All : UsedAppointmentType.None;
        }

        /// <summary>
        /// 显示事件窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainScheduler_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            if (this.currentElevator == null)
            {
                e.Handled = true;
                return;
            }

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
            if (this.currentElevator == null)
                return;

            try
            {
                Appointment apt = e.Object as Appointment;
                ElevatorLog entity = new ElevatorLog();
                MapToEntity(apt, entity);

                BusinessFactory<ElevatorLogBusiness>.Instance.Create(entity, this.currentUser);

                LoadLogData();
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
            if (this.currentElevator == null || !this.editable)
                return;

            try
            {
                Appointment apt = e.Object as Appointment;
                ElevatorLog entity = BusinessFactory<ElevatorLogBusiness>.Instance.FindById(apt.Id.ToString());
                MapToEntity(apt, entity);

                var resutl = BusinessFactory<ElevatorLogBusiness>.Instance.Update(entity, this.currentUser);

                if (resutl.success)
                {
                    LoadLogData();
                }
                else
                {
                    MessageUtil.ShowClaim("编辑日志失败: " + resutl.errorMessage);
                }
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
            if (this.currentElevator == null)
                return;

            try
            {
                if (MessageUtil.ConfirmYesNo("是否删除该事件日志") == DialogResult.Yes)
                {
                    Appointment apt = e.Object as Appointment;
                    var result = BusinessFactory<ElevatorLogBusiness>.Instance.Delete(apt.Id.ToString());

                    if (result.success)
                    {
                        LoadLogData();
                    }
                    else
                    {
                        MessageUtil.ShowClaim("删除日志失败: " + result.errorMessage);
                    }
                }
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("删除日志失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }

            e.Cancel = false;
        }

        /// <summary>
        /// 选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainScheduler_SelectionChanged(object sender, EventArgs e)
        {
            if (this.currentElevator == null)
                return;

            var data = this.mainScheduler.SelectedAppointments;
            if (data.Count == 0)
            {
                this.logInfoView.Clear();
                return;
            }

            var apt = data[0];
            if (apt.Id == null)
                return;
            var log = BusinessFactory<ElevatorLogBusiness>.Instance.FindById(apt.Id.ToString());

            this.logInfoView.SetElevator(log, this.currentElevator);
        }

        /// <summary>
        /// 日志类型筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkListLogType_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (this.currentElevator == null)
                return;

            var checkedItems = this.chkListLogType.CheckedItems;

            List<int> types = new List<int>();
            foreach (ListBoxItem item in checkedItems)
            {
                types.Add(Convert.ToInt32(item.Value));
            }

            this.bsElevatorLog.DataSource = this.logData.Where(r => types.Contains(r.LogType));
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 能否编辑
        /// </summary>
        [Description("能否编辑"), Category("功能")]
        public bool Editable
        {
            get
            {
                return this.editable;
            }
            set
            {
                this.editable = value;
            }
        }
        #endregion //Property
    }
}
