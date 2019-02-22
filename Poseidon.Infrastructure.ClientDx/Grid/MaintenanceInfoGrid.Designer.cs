namespace Poseidon.Infrastructure.ClientDx
{
    partial class MaintenanceInfoGrid
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
            this.colFacilityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaintenanceCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaintenanceFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacilityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoLuFacility = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.bsElevator = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstallDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaintenanceCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoLuMaintenanceCompany = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.bsMaintenanceCompany = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLuFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLuMaintenanceCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaintenanceCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Infrastructure.Core.DL.MaintenanceInfo);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoLuFacility,
            this.repoLuMaintenanceCompany});
            this.dgcEntity.Size = new System.Drawing.Size(655, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFacilityId,
            this.colFacilityName,
            this.colMaintenanceCompanyId,
            this.colMaintenanceCompanyName,
            this.colStartDate,
            this.colEndDate,
            this.colMaintenanceFee,
            this.colIsFree,
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
            // colFacilityName
            // 
            this.colFacilityName.Caption = "设施名称";
            this.colFacilityName.FieldName = "FacilityName";
            this.colFacilityName.Name = "colFacilityName";
            this.colFacilityName.Visible = true;
            this.colFacilityName.VisibleIndex = 1;
            // 
            // colMaintenanceCompanyName
            // 
            this.colMaintenanceCompanyName.Caption = "维保公司";
            this.colMaintenanceCompanyName.FieldName = "MaintenanceCompanyName";
            this.colMaintenanceCompanyName.Name = "colMaintenanceCompanyName";
            this.colMaintenanceCompanyName.Visible = true;
            this.colMaintenanceCompanyName.VisibleIndex = 3;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "开始日期";
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 4;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "结束日期";
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 5;
            // 
            // colMaintenanceFee
            // 
            this.colMaintenanceFee.Caption = "维保费用(元)";
            this.colMaintenanceFee.FieldName = "MaintenanceFee";
            this.colMaintenanceFee.Name = "colMaintenanceFee";
            this.colMaintenanceFee.Visible = true;
            this.colMaintenanceFee.VisibleIndex = 6;
            // 
            // colIsFree
            // 
            this.colIsFree.Caption = "是否免保";
            this.colIsFree.FieldName = "IsFree";
            this.colIsFree.Name = "colIsFree";
            this.colIsFree.Visible = true;
            this.colIsFree.VisibleIndex = 7;
            // 
            // colRemark
            // 
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 8;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
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
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
            // 
            // colInstallDate
            // 
            this.colInstallDate.FieldName = "InstallDate";
            this.colInstallDate.Name = "colInstallDate";
            this.colInstallDate.Visible = true;
            this.colInstallDate.VisibleIndex = 2;
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
            // colMaintenanceCompanyId
            // 
            this.colMaintenanceCompanyId.Caption = "维保公司";
            this.colMaintenanceCompanyId.ColumnEdit = this.repoLuMaintenanceCompany;
            this.colMaintenanceCompanyId.FieldName = "MaintenanceCompanyId";
            this.colMaintenanceCompanyId.Name = "colMaintenanceCompanyId";
            this.colMaintenanceCompanyId.Visible = true;
            this.colMaintenanceCompanyId.VisibleIndex = 2;
            // 
            // repoLuMaintenanceCompany
            // 
            this.repoLuMaintenanceCompany.AutoHeight = false;
            this.repoLuMaintenanceCompany.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoLuMaintenanceCompany.DataSource = this.bsMaintenanceCompany;
            this.repoLuMaintenanceCompany.DisplayMember = "Name";
            this.repoLuMaintenanceCompany.Name = "repoLuMaintenanceCompany";
            this.repoLuMaintenanceCompany.NullText = "请选择维保公司";
            this.repoLuMaintenanceCompany.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.repoLuMaintenanceCompany.ValueMember = "Id";
            // 
            // bsMaintenanceCompany
            // 
            this.bsMaintenanceCompany.DataSource = typeof(Poseidon.Infrastructure.Core.DL.MaintenanceCompany);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colShortName,
            this.colAddress,
            this.colContact});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "Name";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 0;
            // 
            // colShortName
            // 
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colContact
            // 
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 3;
            // 
            // MaintenanceInfoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MaintenanceInfoGrid";
            this.Size = new System.Drawing.Size(655, 378);
            this.Load += new System.EventHandler(this.MaintenanceInfoGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLuFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLuMaintenanceCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaintenanceCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityName;
        private DevExpress.XtraGrid.Columns.GridColumn colMaintenanceCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaintenanceFee;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFree;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repoLuFacility;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colFacilityId;
        private System.Windows.Forms.BindingSource bsElevator;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colInstallDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacity;
        private DevExpress.XtraGrid.Columns.GridColumn colSpeed;
        private DevExpress.XtraGrid.Columns.GridColumn colStation;
        private DevExpress.XtraGrid.Columns.GridColumn colVendor;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repoLuMaintenanceCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMaintenanceCompanyId;
        private System.Windows.Forms.BindingSource bsMaintenanceCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
    }
}
