namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorGrid
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
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistrationNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRescueNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordBag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Elevator);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(735, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colModel,
            this.colRegistrationNumber,
            this.colCapacity,
            this.colSpeed,
            this.colStation,
            this.colVendor,
            this.colInstallDate,
            this.colPosition,
            this.colRescueNumber,
            this.colRecordBag,
            this.colRecordNumber,
            this.colModelType,
            this.colDatasetCode,
            this.colRemark,
            this.colStatus,
            this.colId});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colModel
            // 
            this.colModel.Caption = "型号";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
            // 
            // colRegistrationNumber
            // 
            this.colRegistrationNumber.Caption = "注册号";
            this.colRegistrationNumber.FieldName = "RegistrationNumber";
            this.colRegistrationNumber.Name = "colRegistrationNumber";
            this.colRegistrationNumber.Visible = true;
            this.colRegistrationNumber.VisibleIndex = 2;
            // 
            // colRescueNumber
            // 
            this.colRescueNumber.Caption = "救援识别码";
            this.colRescueNumber.FieldName = "RescueNumber";
            this.colRescueNumber.Name = "colRescueNumber";
            this.colRescueNumber.Visible = true;
            this.colRescueNumber.VisibleIndex = 9;
            // 
            // colCapacity
            // 
            this.colCapacity.Caption = "载重(kg)";
            this.colCapacity.FieldName = "Capacity";
            this.colCapacity.Name = "colCapacity";
            this.colCapacity.Visible = true;
            this.colCapacity.VisibleIndex = 3;
            // 
            // colSpeed
            // 
            this.colSpeed.Caption = "速度(m/s)";
            this.colSpeed.FieldName = "Speed";
            this.colSpeed.Name = "colSpeed";
            this.colSpeed.Visible = true;
            this.colSpeed.VisibleIndex = 4;
            // 
            // colStation
            // 
            this.colStation.Caption = "层站";
            this.colStation.FieldName = "Station";
            this.colStation.Name = "colStation";
            this.colStation.Visible = true;
            this.colStation.VisibleIndex = 5;
            // 
            // colVendor
            // 
            this.colVendor.Caption = "生产厂商";
            this.colVendor.FieldName = "Vendor";
            this.colVendor.Name = "colVendor";
            this.colVendor.Visible = true;
            this.colVendor.VisibleIndex = 7;
            // 
            // colPosition
            // 
            this.colPosition.Caption = "安装地点";
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 8;
            // 
            // colRecordBag
            // 
            this.colRecordBag.Caption = "档案袋";
            this.colRecordBag.FieldName = "RecordBag";
            this.colRecordBag.Name = "colRecordBag";
            this.colRecordBag.Visible = true;
            this.colRecordBag.VisibleIndex = 10;
            // 
            // colRecordNumber
            // 
            this.colRecordNumber.Caption = "档案号";
            this.colRecordNumber.FieldName = "RecordNumber";
            this.colRecordNumber.Name = "colRecordNumber";
            this.colRecordNumber.Visible = true;
            this.colRecordNumber.VisibleIndex = 11;
            // 
            // colModelType
            // 
            this.colModelType.FieldName = "ModelType";
            this.colModelType.Name = "colModelType";
            // 
            // colDatasetCode
            // 
            this.colDatasetCode.FieldName = "DatasetCode";
            this.colDatasetCode.Name = "colDatasetCode";
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 12;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 13;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colInstallDate
            // 
            this.colInstallDate.Caption = "安装日期";
            this.colInstallDate.DisplayFormat.FormatString = "yyyy-MM";
            this.colInstallDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colInstallDate.FieldName = "InstallDate";
            this.colInstallDate.Name = "colInstallDate";
            this.colInstallDate.Visible = true;
            this.colInstallDate.VisibleIndex = 6;
            // 
            // ElevatorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ElevatorGrid";
            this.Size = new System.Drawing.Size(735, 378);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistrationNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colRescueNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacity;
        private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
        private DevExpress.XtraGrid.Columns.GridColumn colStation;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordBag;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colModelType;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasetCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallDate;
    }
}
