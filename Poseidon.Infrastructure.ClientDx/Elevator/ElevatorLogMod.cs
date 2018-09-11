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
        #region Constructor
        public ElevatorLogMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
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

        private void LoadLogData()
        {
            var data = BusinessFactory<ElevatorLogBusiness>.Instance.FindAll();
            this.bsElevatorLog.DataSource = data;
        }
        #endregion //Function

        #region Event


        private void storage_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e)
        {
            Appointment apt = e.Object as Appointment;

            e.Cancel = false;
        }
        #endregion //Event

        private void mainScheduler_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            //CustomAppointmentForm form = new CustomAppointmentForm();
            //form.ShowDialog();
            //e.Handled = true;

            FrmElevatorLogAdd form = new FrmElevatorLogAdd();
            form.ShowDialog();
            e.Handled = true;
        }
    }
}
