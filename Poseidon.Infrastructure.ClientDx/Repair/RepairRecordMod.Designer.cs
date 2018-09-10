namespace Poseidon.Infrastructure.ClientDx
{
    partial class RepairRecordMod
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.repairRecordGrid = new Poseidon.Infrastructure.ClientDx.RepairRecordGrid();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accGroupModelType = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accElevatorItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accSubstationItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accGroupYear = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.repairInfoView = new Poseidon.Infrastructure.ClientDx.RepairInfoView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSummary = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.recordSummaryMod = new Poseidon.Infrastructure.ClientDx.RepairRecordSummaryMod();
            this.tabPageCategory = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.accordionControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.repairRecordGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(203, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(656, 230);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "记录列表";
            // 
            // repairRecordGrid
            // 
            this.repairRecordGrid.AllowFilter = true;
            this.repairRecordGrid.AllowGroup = true;
            this.repairRecordGrid.AllowSort = true;
            this.repairRecordGrid.DataSource = null;
            this.repairRecordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairRecordGrid.Editable = false;
            this.repairRecordGrid.EnableMasterView = false;
            this.repairRecordGrid.EnableMultiSelect = false;
            this.repairRecordGrid.Location = new System.Drawing.Point(2, 21);
            this.repairRecordGrid.Name = "repairRecordGrid";
            this.repairRecordGrid.ShowAddMenu = false;
            this.repairRecordGrid.ShowColRepairNumber = true;
            this.repairRecordGrid.ShowDeleteMenu = false;
            this.repairRecordGrid.ShowEditMenu = false;
            this.repairRecordGrid.ShowFindPanel = false;
            this.repairRecordGrid.ShowFooter = true;
            this.repairRecordGrid.ShowLineNumber = true;
            this.repairRecordGrid.ShowMenu = false;
            this.repairRecordGrid.ShowNavigator = false;
            this.repairRecordGrid.Size = new System.Drawing.Size(652, 207);
            this.repairRecordGrid.TabIndex = 0;
            this.repairRecordGrid.UseCalculatePrice = false;
            this.repairRecordGrid.UseFacilityName = true;
            this.repairRecordGrid.RowSelected += new System.Action<object, System.EventArgs>(this.repairRecordGrid_RowSelected);
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accGroupModelType,
            this.accGroupYear});
            this.accordionControl1.Location = new System.Drawing.Point(3, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.tableLayoutPanel1.SetRowSpan(this.accordionControl1, 2);
            this.accordionControl1.Size = new System.Drawing.Size(194, 467);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // accGroupModelType
            // 
            this.accGroupModelType.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accElevatorItem,
            this.accSubstationItem});
            this.accGroupModelType.Expanded = true;
            this.accGroupModelType.Text = "设施类型";
            // 
            // accElevatorItem
            // 
            this.accElevatorItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accElevatorItem.Tag = "Infrastructure.Elevator";
            this.accElevatorItem.Text = "电梯";
            // 
            // accSubstationItem
            // 
            this.accSubstationItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accSubstationItem.Tag = "Infrastructure.Substation";
            this.accSubstationItem.Text = "变电所";
            // 
            // accGroupYear
            // 
            this.accGroupYear.Text = "年度";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.repairInfoView);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(203, 239);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(325, 231);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "项目信息";
            // 
            // repairInfoView
            // 
            this.repairInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairInfoView.Location = new System.Drawing.Point(2, 21);
            this.repairInfoView.Name = "repairInfoView";
            this.repairInfoView.Size = new System.Drawing.Size(321, 208);
            this.repairInfoView.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabPageSummary;
            this.xtraTabControl1.Size = new System.Drawing.Size(868, 502);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSummary,
            this.tabPageCategory});
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.tableLayoutPanel2);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(862, 473);
            this.tabPageSummary.Text = "汇总统计";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(862, 473);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.recordSummaryMod);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(425, 230);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "年度设施汇总";
            // 
            // recordSummaryMod
            // 
            this.recordSummaryMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordSummaryMod.Location = new System.Drawing.Point(2, 21);
            this.recordSummaryMod.Name = "recordSummaryMod";
            this.recordSummaryMod.Size = new System.Drawing.Size(421, 207);
            this.recordSummaryMod.TabIndex = 0;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.tableLayoutPanel1);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Size = new System.Drawing.Size(862, 473);
            this.tabPageCategory.Text = "分类统计";
            // 
            // RepairRecordMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "RepairRecordMod";
            this.Size = new System.Drawing.Size(868, 502);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private RepairRecordGrid repairRecordGrid;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accGroupModelType;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accElevatorItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accSubstationItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accGroupYear;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPageSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTab.XtraTabPage tabPageCategory;
        private RepairRecordSummaryMod recordSummaryMod;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private RepairInfoView repairInfoView;
    }
}
