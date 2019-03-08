namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorGroupMod
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
            this.tabBusiness = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageElevator = new DevExpress.XtraTab.XtraTabPage();
            this.elevatorGrid = new Poseidon.Infrastructure.ClientDx.ElevatorGrid();
            this.tabPageInspection = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dpInspectionYear = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionGrid = new Poseidon.Infrastructure.ClientDx.InspectionGrid();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).BeginInit();
            this.tabBusiness.SuspendLayout();
            this.tabPageElevator.SuspendLayout();
            this.tabPageInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpInspectionYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpInspectionYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.tabBusiness, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabBusiness
            // 
            this.tabBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBusiness.Location = new System.Drawing.Point(3, 3);
            this.tabBusiness.Name = "tabBusiness";
            this.tableLayoutPanel1.SetRowSpan(this.tabBusiness, 2);
            this.tabBusiness.SelectedTabPage = this.tabPageElevator;
            this.tabBusiness.Size = new System.Drawing.Size(806, 507);
            this.tabBusiness.TabIndex = 2;
            this.tabBusiness.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageElevator,
            this.tabPageInspection});
            // 
            // tabPageElevator
            // 
            this.tabPageElevator.Controls.Add(this.elevatorGrid);
            this.tabPageElevator.Name = "tabPageElevator";
            this.tabPageElevator.Size = new System.Drawing.Size(800, 478);
            this.tabPageElevator.Text = "电梯列表";
            // 
            // elevatorGrid
            // 
            this.elevatorGrid.AllowFilter = true;
            this.elevatorGrid.AllowGroup = true;
            this.elevatorGrid.AllowSort = true;
            this.elevatorGrid.DataSource = null;
            this.elevatorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorGrid.Editable = false;
            this.elevatorGrid.EnableMasterView = false;
            this.elevatorGrid.EnableMultiSelect = true;
            this.elevatorGrid.Location = new System.Drawing.Point(0, 0);
            this.elevatorGrid.Name = "elevatorGrid";
            this.elevatorGrid.ShowAddMenu = false;
            this.elevatorGrid.ShowDeleteMenu = false;
            this.elevatorGrid.ShowEditMenu = false;
            this.elevatorGrid.ShowFindPanel = false;
            this.elevatorGrid.ShowFooter = false;
            this.elevatorGrid.ShowLineNumber = true;
            this.elevatorGrid.ShowMenu = false;
            this.elevatorGrid.ShowNavigator = false;
            this.elevatorGrid.Size = new System.Drawing.Size(800, 478);
            this.elevatorGrid.TabIndex = 0;
            // 
            // tabPageInspection
            // 
            this.tabPageInspection.Controls.Add(this.layoutControl1);
            this.tabPageInspection.Name = "tabPageInspection";
            this.tabPageInspection.Size = new System.Drawing.Size(800, 478);
            this.tabPageInspection.Text = "检验信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.inspectionGrid);
            this.layoutControl1.Controls.Add(this.dpInspectionYear);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 478);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 478);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dpInspectionYear
            // 
            this.dpInspectionYear.EditValue = null;
            this.dpInspectionYear.Location = new System.Drawing.Point(64, 12);
            this.dpInspectionYear.Name = "dpInspectionYear";
            this.dpInspectionYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpInspectionYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpInspectionYear.Properties.DisplayFormat.FormatString = "yyyy年";
            this.dpInspectionYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dpInspectionYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpInspectionYear.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView;
            this.dpInspectionYear.Properties.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)((DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView | DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView)));
            this.dpInspectionYear.Size = new System.Drawing.Size(724, 20);
            this.dpInspectionYear.StyleController = this.layoutControl1;
            this.dpInspectionYear.TabIndex = 4;
            this.dpInspectionYear.EditValueChanged += new System.EventHandler(this.dpInspectionYear_EditValueChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dpInspectionYear;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem1.Text = "计划年度";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // inspectionGrid
            // 
            this.inspectionGrid.AllowFilter = true;
            this.inspectionGrid.AllowGroup = true;
            this.inspectionGrid.AllowSort = true;
            this.inspectionGrid.DataSource = null;
            this.inspectionGrid.Editable = false;
            this.inspectionGrid.EnableMasterView = false;
            this.inspectionGrid.EnableMultiSelect = true;
            this.inspectionGrid.Location = new System.Drawing.Point(12, 36);
            this.inspectionGrid.Name = "inspectionGrid";
            this.inspectionGrid.ShowAddExpenseMenu = false;
            this.inspectionGrid.ShowAddMenu = false;
            this.inspectionGrid.ShowBindExpenseMenu = false;
            this.inspectionGrid.ShowDeleteMenu = false;
            this.inspectionGrid.ShowEditMenu = false;
            this.inspectionGrid.ShowFindPanel = false;
            this.inspectionGrid.ShowFooter = false;
            this.inspectionGrid.ShowLineNumber = true;
            this.inspectionGrid.ShowMenu = false;
            this.inspectionGrid.ShowModelTypeColumn = false;
            this.inspectionGrid.ShowNavigator = false;
            this.inspectionGrid.Size = new System.Drawing.Size(776, 430);
            this.inspectionGrid.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.inspectionGrid;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 434);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ElevatorGroupMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ElevatorGroupMod";
            this.Size = new System.Drawing.Size(812, 513);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).EndInit();
            this.tabBusiness.ResumeLayout(false);
            this.tabPageElevator.ResumeLayout(false);
            this.tabPageInspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpInspectionYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpInspectionYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ElevatorGrid elevatorGrid;
        private DevExpress.XtraTab.XtraTabControl tabBusiness;
        private DevExpress.XtraTab.XtraTabPage tabPageElevator;
        private DevExpress.XtraTab.XtraTabPage tabPageInspection;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dpInspectionYear;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private InspectionGrid inspectionGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
