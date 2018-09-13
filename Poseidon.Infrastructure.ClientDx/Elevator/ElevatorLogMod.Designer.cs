namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorLogMod
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mainScheduler = new DevExpress.XtraScheduler.SchedulerControl();
            this.storage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.bsElevatorLog = new System.Windows.Forms.BindingSource(this.components);
            this.bsElevator = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chkListLogType = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.logInfoView = new Poseidon.Infrastructure.ClientDx.ElevatorLogInfoView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevatorLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkListLogType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.mainScheduler);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl1, 2);
            this.groupControl1.Size = new System.Drawing.Size(559, 535);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "运行日志";
            // 
            // mainScheduler
            // 
            this.mainScheduler.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.mainScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScheduler.Location = new System.Drawing.Point(2, 21);
            this.mainScheduler.Name = "mainScheduler";
            this.mainScheduler.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.mainScheduler.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.mainScheduler.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.mainScheduler.Size = new System.Drawing.Size(555, 512);
            this.mainScheduler.Start = new System.DateTime(2018, 9, 9, 0, 0, 0, 0);
            this.mainScheduler.Storage = this.storage;
            this.mainScheduler.TabIndex = 0;
            this.mainScheduler.Text = "schedulerControl1";
            this.mainScheduler.Views.DayView.Enabled = false;
            this.mainScheduler.Views.DayView.TimeRulers.Add(timeRuler1);
            this.mainScheduler.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.mainScheduler.Views.GanttView.Enabled = false;
            this.mainScheduler.Views.MonthView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds;
            this.mainScheduler.Views.TimelineView.Enabled = false;
            this.mainScheduler.Views.WeekView.Enabled = false;
            this.mainScheduler.Views.WorkWeekView.Enabled = false;
            this.mainScheduler.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.mainScheduler.SelectionChanged += new System.EventHandler(this.mainScheduler_SelectionChanged);
            this.mainScheduler.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.mainScheduler_EditAppointmentFormShowing);
            // 
            // storage
            // 
            this.storage.Appointments.DataSource = this.bsElevatorLog;
            this.storage.Resources.DataSource = this.bsElevator;
            this.storage.AppointmentInserting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.storage_AppointmentInserting);
            this.storage.AppointmentChanging += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.storage_AppointmentChanging);
            this.storage.AppointmentDeleting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.storage_AppointmentDeleting);
            // 
            // bsElevatorLog
            // 
            this.bsElevatorLog.DataSource = typeof(Poseidon.Infrastructure.Core.DL.ElevatorLog);
            // 
            // bsElevator
            // 
            this.bsElevator.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Elevator);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chkListLogType);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(568, 273);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(294, 265);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "事件类型";
            // 
            // chkListLogType
            // 
            this.chkListLogType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListLogType.Location = new System.Drawing.Point(2, 21);
            this.chkListLogType.Name = "chkListLogType";
            this.chkListLogType.Size = new System.Drawing.Size(290, 242);
            this.chkListLogType.TabIndex = 0;
            this.chkListLogType.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkListLogType_ItemCheck);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.logInfoView);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(568, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(294, 264);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "日志信息";
            // 
            // logInfoView
            // 
            this.logInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logInfoView.Location = new System.Drawing.Point(2, 21);
            this.logInfoView.Name = "logInfoView";
            this.logInfoView.Size = new System.Drawing.Size(290, 241);
            this.logInfoView.TabIndex = 0;
            // 
            // ElevatorLogMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ElevatorLogMod";
            this.Size = new System.Drawing.Size(865, 541);
            this.Load += new System.EventHandler(this.ElevatorLogMod_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevatorLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkListLogType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraScheduler.SchedulerControl mainScheduler;
        private DevExpress.XtraScheduler.SchedulerStorage storage;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bsElevatorLog;
        private System.Windows.Forms.BindingSource bsElevator;
        private DevExpress.XtraEditors.CheckedListBoxControl chkListLogType;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private ElevatorLogInfoView logInfoView;
    }
}
