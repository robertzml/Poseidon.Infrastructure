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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.bsElevator = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevatorLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
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
            this.groupControl1.Size = new System.Drawing.Size(659, 535);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "运行日志";
            // 
            // mainScheduler
            // 
            this.mainScheduler.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.mainScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScheduler.Location = new System.Drawing.Point(2, 21);
            this.mainScheduler.Name = "mainScheduler";
            this.mainScheduler.Size = new System.Drawing.Size(655, 512);
            this.mainScheduler.Start = new System.DateTime(2018, 9, 9, 0, 0, 0, 0);
            this.mainScheduler.Storage = this.storage;
            this.mainScheduler.TabIndex = 0;
            this.mainScheduler.Text = "schedulerControl1";
            this.mainScheduler.Views.DayView.TimeRulers.Add(timeRuler1);
            this.mainScheduler.Views.FullWeekView.Enabled = true;
            this.mainScheduler.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.mainScheduler.Views.WeekView.Enabled = false;
            this.mainScheduler.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.mainScheduler.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.mainScheduler_EditAppointmentFormShowing);
            // 
            // storage
            // 
            this.storage.Appointments.DataSource = this.bsElevatorLog;
            this.storage.Resources.DataSource = this.bsElevator;
            this.storage.AppointmentInserting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.storage_AppointmentInserting);
            // 
            // bsElevatorLog
            // 
            this.bsElevatorLog.DataSource = typeof(Poseidon.Infrastructure.Core.DL.ElevatorLog);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dateNavigator1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(668, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(194, 318);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator1.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
            this.dateNavigator1.HotDate = null;
            this.dateNavigator1.Location = new System.Drawing.Point(2, 21);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.mainScheduler;
            this.dateNavigator1.Size = new System.Drawing.Size(190, 295);
            this.dateNavigator1.TabIndex = 0;
            // 
            // bsElevator
            // 
            this.bsElevator.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Elevator);
            // 
            // ElevatorLogMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ElevatorLogMod";
            this.Size = new System.Drawing.Size(865, 541);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevatorLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraScheduler.SchedulerControl mainScheduler;
        private DevExpress.XtraScheduler.SchedulerStorage storage;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private System.Windows.Forms.BindingSource bsElevatorLog;
        private System.Windows.Forms.BindingSource bsElevator;
    }
}
