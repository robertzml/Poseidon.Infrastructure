namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorBatchMod
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
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageAction = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAddInspectionPlan = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetMaintenanceInfo = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPageInspection = new DevExpress.XtraTab.XtraTabPage();
            this.inspectionGrid = new Poseidon.Infrastructure.ClientDx.InspectionGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.tabPageInspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabPageAction;
            this.tabMain.Size = new System.Drawing.Size(735, 437);
            this.tabMain.TabIndex = 1;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageAction,
            this.tabPageInspection});
            // 
            // tabPageAction
            // 
            this.tabPageAction.Controls.Add(this.groupControl1);
            this.tabPageAction.Name = "tabPageAction";
            this.tabPageAction.Size = new System.Drawing.Size(729, 408);
            this.tabPageAction.Text = "操作";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(729, 408);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAddInspectionPlan);
            this.layoutControl1.Controls.Add(this.btnSetMaintenanceInfo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(377, 171, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(725, 385);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAddInspectionPlan
            // 
            this.btnAddInspectionPlan.Location = new System.Drawing.Point(364, 12);
            this.btnAddInspectionPlan.Name = "btnAddInspectionPlan";
            this.btnAddInspectionPlan.Size = new System.Drawing.Size(349, 22);
            this.btnAddInspectionPlan.StyleController = this.layoutControl1;
            this.btnAddInspectionPlan.TabIndex = 5;
            this.btnAddInspectionPlan.Text = "批量添加检验计划";
            this.btnAddInspectionPlan.Click += new System.EventHandler(this.btnAddInspectionPlan_Click);
            // 
            // btnSetMaintenanceInfo
            // 
            this.btnSetMaintenanceInfo.Location = new System.Drawing.Point(12, 12);
            this.btnSetMaintenanceInfo.Name = "btnSetMaintenanceInfo";
            this.btnSetMaintenanceInfo.Size = new System.Drawing.Size(348, 22);
            this.btnSetMaintenanceInfo.StyleController = this.layoutControl1;
            this.btnSetMaintenanceInfo.TabIndex = 4;
            this.btnSetMaintenanceInfo.Text = "批量设置维保信息";
            this.btnSetMaintenanceInfo.Click += new System.EventHandler(this.btnSetMaintenanceInfo_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(725, 385);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSetMaintenanceInfo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(352, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(705, 339);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAddInspectionPlan;
            this.layoutControlItem2.Location = new System.Drawing.Point(352, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // tabPageInspection
            // 
            this.tabPageInspection.Controls.Add(this.inspectionGrid);
            this.tabPageInspection.Name = "tabPageInspection";
            this.tabPageInspection.Size = new System.Drawing.Size(729, 408);
            this.tabPageInspection.Text = "检验信息";
            // 
            // inspectionGrid
            // 
            this.inspectionGrid.AllowFilter = true;
            this.inspectionGrid.AllowGroup = true;
            this.inspectionGrid.AllowSort = true;
            this.inspectionGrid.DataSource = null;
            this.inspectionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionGrid.Editable = false;
            this.inspectionGrid.EnableMasterView = false;
            this.inspectionGrid.EnableMultiSelect = true;
            this.inspectionGrid.Location = new System.Drawing.Point(0, 0);
            this.inspectionGrid.Name = "inspectionGrid";
            this.inspectionGrid.ShowAddExpenseMenu = false;
            this.inspectionGrid.ShowAddMenu = false;
            this.inspectionGrid.ShowDeleteMenu = false;
            this.inspectionGrid.ShowEditMenu = false;
            this.inspectionGrid.ShowFindPanel = false;
            this.inspectionGrid.ShowFooter = false;
            this.inspectionGrid.ShowLineNumber = true;
            this.inspectionGrid.ShowMenu = false;
            this.inspectionGrid.ShowModelTypeColumn = false;
            this.inspectionGrid.ShowNavigator = false;
            this.inspectionGrid.Size = new System.Drawing.Size(729, 408);
            this.inspectionGrid.TabIndex = 0;
            // 
            // ElevatorBatchMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "ElevatorBatchMod";
            this.Size = new System.Drawing.Size(735, 437);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.tabPageInspection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSetMaintenanceInfo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnAddInspectionPlan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage tabPageAction;
        private DevExpress.XtraTab.XtraTabPage tabPageInspection;
        private InspectionGrid inspectionGrid;
    }
}
