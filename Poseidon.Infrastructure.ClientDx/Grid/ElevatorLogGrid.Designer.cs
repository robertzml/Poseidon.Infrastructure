namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorLogGrid
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
            this.colElevatorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateBy = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bsEntity.DataSource = typeof(Poseidon.Infrastructure.Core.DL.ElevatorLog);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colElevatorId,
            this.colSubject,
            this.colStartDate,
            this.colEndDate,
            this.colLogType,
            this.colInfo,
            this.colLogStatus,
            this.colCreateBy,
            this.colUpdateBy,
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
            // colElevatorId
            // 
            this.colElevatorId.FieldName = "ElevatorId";
            this.colElevatorId.Name = "colElevatorId";
            this.colElevatorId.Visible = true;
            this.colElevatorId.VisibleIndex = 0;
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            // 
            // colLogType
            // 
            this.colLogType.FieldName = "LogType";
            this.colLogType.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colLogType.Name = "colLogType";
            this.colLogType.Visible = true;
            this.colLogType.VisibleIndex = 3;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 5;
            // 
            // colLogStatus
            // 
            this.colLogStatus.FieldName = "LogStatus";
            this.colLogStatus.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colLogStatus.Name = "colLogStatus";
            this.colLogStatus.Visible = true;
            this.colLogStatus.VisibleIndex = 4;
            // 
            // colCreateBy
            // 
            this.colCreateBy.FieldName = "CreateBy";
            this.colCreateBy.Name = "colCreateBy";
            // 
            // colUpdateBy
            // 
            this.colUpdateBy.FieldName = "UpdateBy";
            this.colUpdateBy.Name = "colUpdateBy";
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
            // ElevatorLogGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ElevatorLogGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colElevatorId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLogType;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colLogStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
