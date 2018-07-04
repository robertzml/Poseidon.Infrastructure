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
            this.colFacilityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectionResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Infrastructure.Core.DL.Inspection);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
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
            // 
            // colFacilityId
            // 
            this.colFacilityId.FieldName = "FacilityId";
            this.colFacilityId.Name = "colFacilityId";
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
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
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
            this.colInspectionDate.VisibleIndex = 5;
            // 
            // colInspectionFee
            // 
            this.colInspectionFee.FieldName = "InspectionFee";
            this.colInspectionFee.Name = "colInspectionFee";
            this.colInspectionFee.Visible = true;
            this.colInspectionFee.VisibleIndex = 6;
            // 
            // colInspectionCompany
            // 
            this.colInspectionCompany.FieldName = "InspectionCompany";
            this.colInspectionCompany.Name = "colInspectionCompany";
            this.colInspectionCompany.Visible = true;
            this.colInspectionCompany.VisibleIndex = 7;
            // 
            // colInspectionResult
            // 
            this.colInspectionResult.FieldName = "InspectionResult";
            this.colInspectionResult.Name = "colInspectionResult";
            this.colInspectionResult.Visible = true;
            this.colInspectionResult.VisibleIndex = 8;
            // 
            // colIsDone
            // 
            this.colIsDone.FieldName = "IsDone";
            this.colIsDone.Name = "colIsDone";
            this.colIsDone.Visible = true;
            this.colIsDone.VisibleIndex = 9;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 12;
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
            // InspectionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "InspectionGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
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
    }
}
