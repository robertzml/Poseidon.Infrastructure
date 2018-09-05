namespace Poseidon.Infrastructure.ClientDx
{
    partial class RepairRecordGrid
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
            this.colRepairId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoFacility = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.bsFacility = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalculatePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecification = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Infrastructure.Core.DL.RepairRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoFacility});
            this.dgcEntity.Size = new System.Drawing.Size(711, 390);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRepairId,
            this.colModelType,
            this.colFacilityId,
            this.colFacilityName,
            this.colItemName,
            this.colSpecification,
            this.colCount,
            this.colUnit,
            this.colUnitPrice,
            this.colCalculatePrice,
            this.colTotalPrice,
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
            // colRepairId
            // 
            this.colRepairId.FieldName = "RepairId";
            this.colRepairId.Name = "colRepairId";
            // 
            // colModelType
            // 
            this.colModelType.Caption = "设施模型类型";
            this.colModelType.FieldName = "ModelType";
            this.colModelType.Name = "colModelType";
            this.colModelType.OptionsColumn.AllowEdit = false;
            // 
            // colFacilityName
            // 
            this.colFacilityName.Caption = "设施名称";
            this.colFacilityName.FieldName = "FacilityName";
            this.colFacilityName.Name = "colFacilityName";
            this.colFacilityName.OptionsColumn.AllowEdit = false;
            this.colFacilityName.Visible = true;
            this.colFacilityName.VisibleIndex = 1;
            // 
            // repoFacility
            // 
            this.repoFacility.AutoHeight = false;
            this.repoFacility.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoFacility.DataSource = this.bsFacility;
            this.repoFacility.DisplayMember = "Name";
            this.repoFacility.Name = "repoFacility";
            this.repoFacility.NullText = "请选择设施";
            this.repoFacility.ValueMember = "Id";
            this.repoFacility.View = this.gridView1;
            // 
            // bsFacility
            // 
            this.bsFacility.DataSource = typeof(Poseidon.Core.DL.Facility);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRemark1,
            this.colStatus1,
            this.colId1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colRemark1
            // 
            this.colRemark1.Caption = "备注";
            this.colRemark1.FieldName = "Remark";
            this.colRemark1.Name = "colRemark1";
            this.colRemark1.Visible = true;
            this.colRemark1.VisibleIndex = 1;
            // 
            // colStatus1
            // 
            this.colStatus1.FieldName = "Status";
            this.colStatus1.Name = "colStatus1";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "项目名称";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            // 
            // colCount
            // 
            this.colCount.Caption = "数量";
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 4;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "总价(元)";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "合计={0:0.##}")});
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 8;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 9;
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
            // colCalculatePrice
            // 
            this.colCalculatePrice.Caption = "计算总价(元)";
            this.colCalculatePrice.FieldName = "colCalculatePrice";
            this.colCalculatePrice.Name = "colCalculatePrice";
            this.colCalculatePrice.OptionsColumn.AllowEdit = false;
            this.colCalculatePrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colCalculatePrice", "合计={0:0.##}")});
            this.colCalculatePrice.UnboundExpression = "[Count] * [UnitPrice]";
            this.colCalculatePrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colCalculatePrice.Visible = true;
            this.colCalculatePrice.VisibleIndex = 7;
            // 
            // colFacilityId
            // 
            this.colFacilityId.Caption = "设施名称";
            this.colFacilityId.ColumnEdit = this.repoFacility;
            this.colFacilityId.FieldName = "FacilityId";
            this.colFacilityId.Name = "colFacilityId";
            this.colFacilityId.Visible = true;
            this.colFacilityId.VisibleIndex = 0;
            // 
            // colSpecification
            // 
            this.colSpecification.Caption = "规格型号";
            this.colSpecification.FieldName = "Specification";
            this.colSpecification.Name = "colSpecification";
            this.colSpecification.Visible = true;
            this.colSpecification.VisibleIndex = 3;
            // 
            // RepairRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RepairRecordGrid";
            this.Size = new System.Drawing.Size(711, 390);
            this.Load += new System.EventHandler(this.RepairRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colRepairId;
        private DevExpress.XtraGrid.Columns.GridColumn colModelType;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCalculatePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource bsFacility;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoFacility;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityId;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecification;
    }
}
