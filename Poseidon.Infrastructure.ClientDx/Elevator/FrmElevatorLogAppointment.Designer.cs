namespace Poseidon.Infrastructure.ClientDx
{
    partial class FrmElevatorLogAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.aptStatus = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
            this.aptLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.luElevator = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistrationNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordBag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEditTime = new DevExpress.XtraEditors.TextEdit();
            this.txtEditor = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateTime = new DevExpress.XtraEditors.TextEdit();
            this.txtCreator = new DevExpress.XtraEditors.TextEdit();
            this.txtSubject = new DevExpress.XtraEditors.TextEdit();
            this.txtInfo = new DevExpress.XtraEditors.MemoEdit();
            this.dpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsElevator = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aptStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luElevator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(410, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(301, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.groupControl1);
            this.plFill.Size = new System.Drawing.Size(504, 302);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 302);
            this.plBottom.Size = new System.Drawing.Size(504, 60);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 302);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "事件信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.aptStatus);
            this.layoutControl1.Controls.Add(this.aptLabel);
            this.layoutControl1.Controls.Add(this.luElevator);
            this.layoutControl1.Controls.Add(this.txtEditTime);
            this.layoutControl1.Controls.Add(this.txtEditor);
            this.layoutControl1.Controls.Add(this.txtCreateTime);
            this.layoutControl1.Controls.Add(this.txtCreator);
            this.layoutControl1.Controls.Add(this.txtSubject);
            this.layoutControl1.Controls.Add(this.txtInfo);
            this.layoutControl1.Controls.Add(this.dpStartDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(500, 279);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // aptStatus
            // 
            this.aptStatus.Location = new System.Drawing.Point(303, 60);
            this.aptStatus.Name = "aptStatus";
            this.aptStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aptStatus.Size = new System.Drawing.Size(185, 20);
            this.aptStatus.StyleController = this.layoutControl1;
            this.aptStatus.TabIndex = 16;
            // 
            // aptLabel
            // 
            this.aptLabel.Location = new System.Drawing.Point(63, 60);
            this.aptLabel.Name = "aptLabel";
            this.aptLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aptLabel.Size = new System.Drawing.Size(185, 20);
            this.aptLabel.StyleController = this.layoutControl1;
            this.aptLabel.TabIndex = 15;
            // 
            // luElevator
            // 
            this.luElevator.Location = new System.Drawing.Point(63, 12);
            this.luElevator.Name = "luElevator";
            this.luElevator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luElevator.Properties.DataSource = this.bsElevator;
            this.luElevator.Properties.DisplayMember = "Name";
            this.luElevator.Properties.NullText = "请选择";
            this.luElevator.Properties.ShowClearButton = false;
            this.luElevator.Properties.ValueMember = "Id";
            this.luElevator.Properties.View = this.searchLookUpEdit1View;
            this.luElevator.Size = new System.Drawing.Size(425, 20);
            this.luElevator.StyleController = this.layoutControl1;
            this.luElevator.TabIndex = 14;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colModel,
            this.colRegistrationNumber,
            this.colInstallDate,
            this.colCapacity,
            this.colSpeed,
            this.colStation,
            this.colVendor,
            this.colPosition,
            this.colRecordBag,
            this.colRecordNumber,
            this.colRemark,
            this.colStatus,
            this.colId});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsBehavior.Editable = false;
            this.searchLookUpEdit1View.OptionsCustomization.AllowFilter = false;
            this.searchLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
            // 
            // colRegistrationNumber
            // 
            this.colRegistrationNumber.FieldName = "RegistrationNumber";
            this.colRegistrationNumber.Name = "colRegistrationNumber";
            // 
            // colInstallDate
            // 
            this.colInstallDate.FieldName = "InstallDate";
            this.colInstallDate.Name = "colInstallDate";
            // 
            // colCapacity
            // 
            this.colCapacity.FieldName = "Capacity";
            this.colCapacity.Name = "colCapacity";
            this.colCapacity.Visible = true;
            this.colCapacity.VisibleIndex = 2;
            // 
            // colSpeed
            // 
            this.colSpeed.FieldName = "Speed";
            this.colSpeed.Name = "colSpeed";
            this.colSpeed.Visible = true;
            this.colSpeed.VisibleIndex = 3;
            // 
            // colStation
            // 
            this.colStation.FieldName = "Station";
            this.colStation.Name = "colStation";
            this.colStation.Visible = true;
            this.colStation.VisibleIndex = 4;
            // 
            // colVendor
            // 
            this.colVendor.FieldName = "Vendor";
            this.colVendor.Name = "colVendor";
            this.colVendor.Visible = true;
            this.colVendor.VisibleIndex = 5;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            // 
            // colRecordBag
            // 
            this.colRecordBag.FieldName = "RecordBag";
            this.colRecordBag.Name = "colRecordBag";
            // 
            // colRecordNumber
            // 
            this.colRecordNumber.FieldName = "RecordNumber";
            this.colRecordNumber.Name = "colRecordNumber";
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // txtEditTime
            // 
            this.txtEditTime.Location = new System.Drawing.Point(303, 108);
            this.txtEditTime.Name = "txtEditTime";
            this.txtEditTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEditTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditTime.Properties.ReadOnly = true;
            this.txtEditTime.Size = new System.Drawing.Size(185, 20);
            this.txtEditTime.StyleController = this.layoutControl1;
            this.txtEditTime.TabIndex = 13;
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(63, 108);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtEditor.Properties.Appearance.Options.UseBackColor = true;
            this.txtEditor.Properties.ReadOnly = true;
            this.txtEditor.Size = new System.Drawing.Size(185, 20);
            this.txtEditor.StyleController = this.layoutControl1;
            this.txtEditor.TabIndex = 12;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.Location = new System.Drawing.Point(303, 84);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreateTime.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreateTime.Properties.ReadOnly = true;
            this.txtCreateTime.Size = new System.Drawing.Size(185, 20);
            this.txtCreateTime.StyleController = this.layoutControl1;
            this.txtCreateTime.TabIndex = 11;
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(63, 84);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCreator.Properties.Appearance.Options.UseBackColor = true;
            this.txtCreator.Properties.ReadOnly = true;
            this.txtCreator.Size = new System.Drawing.Size(185, 20);
            this.txtCreator.StyleController = this.layoutControl1;
            this.txtCreator.TabIndex = 10;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(63, 36);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(185, 20);
            this.txtSubject.StyleController = this.layoutControl1;
            this.txtSubject.TabIndex = 8;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(63, 132);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(425, 135);
            this.txtInfo.StyleController = this.layoutControl1;
            this.txtInfo.TabIndex = 7;
            // 
            // dpStartDate
            // 
            this.dpStartDate.EditValue = null;
            this.dpStartDate.Location = new System.Drawing.Point(303, 36);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStartDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpStartDate.Size = new System.Drawing.Size(185, 20);
            this.dpStartDate.StyleController = this.layoutControl1;
            this.dpStartDate.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem12});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 279);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtInfo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(480, 139);
            this.layoutControlItem4.Text = "事件内容";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtSubject;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem5.Text = "主题";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtCreator;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem7.Text = "创建人";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtCreateTime;
            this.layoutControlItem8.Location = new System.Drawing.Point(240, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem8.Text = "创建时间";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtEditor;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem9.Text = "编辑人";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtEditTime;
            this.layoutControlItem10.Location = new System.Drawing.Point(240, 96);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem10.Text = "编辑时间";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.luElevator;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem11.Text = "电梯";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dpStartDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(240, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem1.Text = "日期";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.aptLabel;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem2.Text = "类型";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.aptStatus;
            this.layoutControlItem12.Location = new System.Drawing.Point(240, 48);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(240, 24);
            this.layoutControlItem12.Text = "事件状态";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(48, 14);
            // 
            // bsElevator
            // 
            this.bsElevator.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Elevator);
            // 
            // FrmElevatorLogAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 362);
            this.MaximumSize = new System.Drawing.Size(520, 400);
            this.MinimumSize = new System.Drawing.Size(520, 400);
            this.Name = "FrmElevatorLogAppointment";
            this.Text = "事件";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aptStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luElevator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtInfo;
        private DevExpress.XtraEditors.DateEdit dpStartDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtSubject;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtEditTime;
        private DevExpress.XtraEditors.TextEdit txtEditor;
        private DevExpress.XtraEditors.TextEdit txtCreateTime;
        private DevExpress.XtraEditors.TextEdit txtCreator;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource bsElevator;
        private DevExpress.XtraEditors.SearchLookUpEdit luElevator;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistrationNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacity;
        private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
        private DevExpress.XtraGrid.Columns.GridColumn colStation;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordBag;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraScheduler.UI.AppointmentLabelEdit aptLabel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraScheduler.UI.AppointmentStatusEdit aptStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
    }
}