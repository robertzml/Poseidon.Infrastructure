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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).BeginInit();
            this.tabBusiness.SuspendLayout();
            this.tabPageElevator.SuspendLayout();
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
            this.tabPageElevator});
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ElevatorGrid elevatorGrid;
        private DevExpress.XtraTab.XtraTabControl tabBusiness;
        private DevExpress.XtraTab.XtraTabPage tabPageElevator;
    }
}
