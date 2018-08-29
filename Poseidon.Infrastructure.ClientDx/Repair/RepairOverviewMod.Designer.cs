namespace Poseidon.Infrastructure.ClientDx
{
    partial class RepairOverviewMod
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
            this.repairGrid = new Poseidon.Infrastructure.ClientDx.RepairGrid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.repairRecordGrid1 = new Poseidon.Infrastructure.ClientDx.RepairRecordGrid();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accGroupView = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accRepairItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.navFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.accordionControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.navFrame, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.repairGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(622, 246);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "维修改造";
            // 
            // repairGrid
            // 
            this.repairGrid.AllowFilter = true;
            this.repairGrid.AllowGroup = true;
            this.repairGrid.AllowSort = true;
            this.repairGrid.DataSource = null;
            this.repairGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairGrid.Editable = false;
            this.repairGrid.EnableMasterView = false;
            this.repairGrid.EnableMultiSelect = false;
            this.repairGrid.Location = new System.Drawing.Point(2, 21);
            this.repairGrid.Name = "repairGrid";
            this.repairGrid.ShowAddExpenseMenu = false;
            this.repairGrid.ShowAddMenu = false;
            this.repairGrid.ShowDeleteMenu = false;
            this.repairGrid.ShowEditMenu = false;
            this.repairGrid.ShowFindPanel = false;
            this.repairGrid.ShowFooter = false;
            this.repairGrid.ShowLineNumber = true;
            this.repairGrid.ShowMenu = false;
            this.repairGrid.ShowModelTypeColumn = false;
            this.repairGrid.ShowNavigator = false;
            this.repairGrid.Size = new System.Drawing.Size(618, 223);
            this.repairGrid.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.repairRecordGrid1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 255);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(622, 246);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "明细";
            // 
            // repairRecordGrid1
            // 
            this.repairRecordGrid1.AllowFilter = true;
            this.repairRecordGrid1.AllowGroup = true;
            this.repairRecordGrid1.AllowSort = true;
            this.repairRecordGrid1.DataSource = null;
            this.repairRecordGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairRecordGrid1.Editable = false;
            this.repairRecordGrid1.EnableMasterView = false;
            this.repairRecordGrid1.EnableMultiSelect = false;
            this.repairRecordGrid1.Location = new System.Drawing.Point(2, 21);
            this.repairRecordGrid1.Name = "repairRecordGrid1";
            this.repairRecordGrid1.ShowAddMenu = false;
            this.repairRecordGrid1.ShowDeleteMenu = false;
            this.repairRecordGrid1.ShowEditMenu = false;
            this.repairRecordGrid1.ShowFindPanel = false;
            this.repairRecordGrid1.ShowFooter = false;
            this.repairRecordGrid1.ShowLineNumber = true;
            this.repairRecordGrid1.ShowMenu = false;
            this.repairRecordGrid1.ShowNavigator = false;
            this.repairRecordGrid1.Size = new System.Drawing.Size(618, 223);
            this.repairRecordGrid1.TabIndex = 0;
            this.repairRecordGrid1.UseCalculatePrice = false;
            this.repairRecordGrid1.UseFacilityName = false;
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accGroupView});
            this.accordionControl1.Location = new System.Drawing.Point(3, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.ShowGroupExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(194, 504);
            this.accordionControl1.TabIndex = 2;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // accGroupView
            // 
            this.accGroupView.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accRepairItem});
            this.accGroupView.Expanded = true;
            this.accGroupView.Tag = "View";
            this.accGroupView.Text = "查看方式";
            // 
            // accRepairItem
            // 
            this.accRepairItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accRepairItem.Tag = "Repair";
            this.accRepairItem.Text = "维修改造项目";
            // 
            // navFrame
            // 
            this.navFrame.Controls.Add(this.navigationPage1);
            this.navFrame.Controls.Add(this.navigationPage2);
            this.navFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame.Location = new System.Drawing.Point(203, 3);
            this.navFrame.Name = "navFrame";
            this.navFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navFrame.SelectedPage = this.navigationPage1;
            this.navFrame.SelectedPageIndex = 0;
            this.navFrame.Size = new System.Drawing.Size(628, 504);
            this.navFrame.TabIndex = 3;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.tableLayoutPanel2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(628, 504);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(628, 504);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(628, 504);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // RepairOverviewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RepairOverviewMod";
            this.Size = new System.Drawing.Size(834, 510);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.navFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private RepairGrid repairGrid;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accGroupView;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accRepairItem;
        private RepairRecordGrid repairRecordGrid1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
    }
}
