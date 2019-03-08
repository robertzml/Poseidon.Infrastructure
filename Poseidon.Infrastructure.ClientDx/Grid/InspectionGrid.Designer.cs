namespace Poseidon.Infrastructure.ClientDx
{
    partial class InspectionGrid
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
            this.colFacilityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoLuFacility = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bsElevator = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAddExpense = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBindExpense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLuFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Inspection);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbType,
            this.repoLuFacility});
            this.dgcEntity.Size = new System.Drawing.Size(746, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFacilityId,
            this.colFacilityName,
            this.colModelType,
            this.colType,
            this.colPlanDate,
            this.colInspectionDate,
            this.colInspectionFee,
            this.colInspectionCompany,
            this.colInspectionResult,
            this.colIsDone,
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
            this.dgvEntity.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.dgvEntity_CellValueChanged);
            // 
            // colFacilityId
            // 
            this.colFacilityId.Caption = "设施名称";
            this.colFacilityId.ColumnEdit = this.repoLuFacility;
            this.colFacilityId.FieldName = "FacilityId";
            this.colFacilityId.Name = "colFacilityId";
            this.colFacilityId.Visible = true;
            this.colFacilityId.VisibleIndex = 0;
            // 
            // repoLuFacility
            // 
            this.repoLuFacility.AutoHeight = false;
            this.repoLuFacility.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoLuFacility.DataSource = this.bsElevator;
            this.repoLuFacility.DisplayMember = "Name";
            this.repoLuFacility.Name = "repoLuFacility";
            this.repoLuFacility.NullText = "请选择设施";
            this.repoLuFacility.PopupFormSize = new System.Drawing.Size(500, 300);
            this.repoLuFacility.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repoLuFacility.ValueMember = "Id";
            // 
            // bsElevator
            // 
            this.bsElevator.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Elevator);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRecordNumber,
            this.colModel,
            this.colInstallDate,
            this.colCapacity,
            this.colSpeed,
            this.colStation,
            this.colVendor,
            this.colPosition});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.repositoryItemGridLookUpEdit1View.OptionsCustomization.AllowFilter = false;
            this.repositoryItemGridLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colRecordNumber
            // 
            this.colRecordNumber.Caption = "档案号";
            this.colRecordNumber.FieldName = "RecordNumber";
            this.colRecordNumber.Name = "colRecordNumber";
            this.colRecordNumber.Visible = true;
            this.colRecordNumber.VisibleIndex = 1;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
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
            this.colCapacity.VisibleIndex = 3;
            // 
            // colSpeed
            // 
            this.colSpeed.FieldName = "Speed";
            this.colSpeed.Name = "colSpeed";
            this.colSpeed.Visible = true;
            this.colSpeed.VisibleIndex = 4;
            // 
            // colStation
            // 
            this.colStation.FieldName = "Station";
            this.colStation.Name = "colStation";
            this.colStation.Visible = true;
            this.colStation.VisibleIndex = 5;
            // 
            // colVendor
            // 
            this.colVendor.FieldName = "Vendor";
            this.colVendor.Name = "colVendor";
            this.colVendor.Visible = true;
            this.colVendor.VisibleIndex = 6;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 7;
            // 
            // colFacilityName
            // 
            this.colFacilityName.FieldName = "FacilityName";
            this.colFacilityName.Name = "colFacilityName";
            this.colFacilityName.Visible = true;
            this.colFacilityName.VisibleIndex = 1;
            // 
            // colModelType
            // 
            this.colModelType.FieldName = "ModelType";
            this.colModelType.Name = "colModelType";
            this.colModelType.Visible = true;
            this.colModelType.VisibleIndex = 2;
            // 
            // colType
            // 
            this.colType.Caption = "检验类型";
            this.colType.ColumnEdit = this.cmbType;
            this.colType.FieldName = "Type";
            this.colType.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.AutoHeight = false;
            this.cmbType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Name = "cmbType";
            // 
            // colPlanDate
            // 
            this.colPlanDate.FieldName = "PlanDate";
            this.colPlanDate.Name = "colPlanDate";
            this.colPlanDate.Visible = true;
            this.colPlanDate.VisibleIndex = 4;
            // 
            // colInspectionDate
            // 
            this.colInspectionDate.FieldName = "InspectionDate";
            this.colInspectionDate.Name = "colInspectionDate";
            this.colInspectionDate.Visible = true;
            this.colInspectionDate.VisibleIndex = 6;
            // 
            // colInspectionFee
            // 
            this.colInspectionFee.FieldName = "InspectionFee";
            this.colInspectionFee.Name = "colInspectionFee";
            this.colInspectionFee.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InspectionFee", "合计={0:0.##}")});
            this.colInspectionFee.Visible = true;
            this.colInspectionFee.VisibleIndex = 7;
            // 
            // colInspectionCompany
            // 
            this.colInspectionCompany.FieldName = "InspectionCompany";
            this.colInspectionCompany.Name = "colInspectionCompany";
            this.colInspectionCompany.Visible = true;
            this.colInspectionCompany.VisibleIndex = 8;
            // 
            // colInspectionResult
            // 
            this.colInspectionResult.FieldName = "InspectionResult";
            this.colInspectionResult.Name = "colInspectionResult";
            this.colInspectionResult.Visible = true;
            this.colInspectionResult.VisibleIndex = 9;
            // 
            // colIsDone
            // 
            this.colIsDone.FieldName = "IsDone";
            this.colIsDone.Name = "colIsDone";
            this.colIsDone.Visible = true;
            this.colIsDone.VisibleIndex = 5;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 10;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddExpense,
            this.menuBindExpense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // menuAddExpense
            // 
            this.menuAddExpense.Name = "menuAddExpense";
            this.menuAddExpense.Size = new System.Drawing.Size(148, 22);
            this.menuAddExpense.Text = "添加费用记录";
            this.menuAddExpense.Click += new System.EventHandler(this.menuAddExpense_Click);
            // 
            // menuBindExpense
            // 
            this.menuBindExpense.Name = "menuBindExpense";
            this.menuBindExpense.Size = new System.Drawing.Size(148, 22);
            this.menuBindExpense.Text = "绑定费用记录";
            this.menuBindExpense.Click += new System.EventHandler(this.menuBindExpense_Click);
            // 
            // InspectionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "InspectionGrid";
            this.Size = new System.Drawing.Size(746, 378);
            this.Load += new System.EventHandler(this.InspectionGrid_Load);
            this.Controls.SetChildIndex(this.dataNavigator, 0);
            this.Controls.SetChildIndex(this.dgcEntity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLuFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colFacilityId;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityName;
        private DevExpress.XtraGrid.Columns.GridColumn colModelType;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectionFee;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectionCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectionResult;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDone;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAddExpense;
        private System.Windows.Forms.ToolStripMenuItem menuBindExpense;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repoLuFacility;
        private System.Windows.Forms.BindingSource bsElevator;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacity;
        private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
        private DevExpress.XtraGrid.Columns.GridColumn colStation;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordNumber;
    }
}
