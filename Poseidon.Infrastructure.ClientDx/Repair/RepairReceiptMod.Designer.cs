namespace Poseidon.Infrastructure.ClientDx
{
    partial class RepairReceiptMod
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.repairGrid = new Poseidon.Infrastructure.ClientDx.RepairGrid();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.expenseGrid = new Poseidon.Finance.Utility.ExpenseGrid();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.repairInfoView = new Poseidon.Infrastructure.ClientDx.RepairInfoView();
            this.lbYears = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl6, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.repairGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(163, 3);
            this.groupControl2.Name = "groupControl2";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl2, 2);
            this.groupControl2.Size = new System.Drawing.Size(377, 532);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "维修改造列表";
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
            this.repairGrid.EnableMultiSelect = true;
            this.repairGrid.Location = new System.Drawing.Point(2, 21);
            this.repairGrid.Name = "repairGrid";
            this.repairGrid.ShowAddExpenseMenu = false;
            this.repairGrid.ShowAddMenu = false;
            this.repairGrid.ShowDeleteMenu = false;
            this.repairGrid.ShowEditMenu = false;
            this.repairGrid.ShowFindPanel = false;
            this.repairGrid.ShowFooter = true;
            this.repairGrid.ShowLineNumber = true;
            this.repairGrid.ShowMenu = false;
            this.repairGrid.ShowModelTypeColumn = true;
            this.repairGrid.ShowNavigator = false;
            this.repairGrid.Size = new System.Drawing.Size(373, 509);
            this.repairGrid.TabIndex = 0;
            this.repairGrid.RowSelected += new System.Action<object, System.EventArgs>(this.repairGrid_RowSelected);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.expenseGrid);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(546, 325);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(378, 210);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "费用记录";
            // 
            // expenseGrid
            // 
            this.expenseGrid.AllowFilter = true;
            this.expenseGrid.AllowGroup = true;
            this.expenseGrid.AllowSort = true;
            this.expenseGrid.DataSource = null;
            this.expenseGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenseGrid.Editable = false;
            this.expenseGrid.EnableMasterView = false;
            this.expenseGrid.EnableMultiCheckSelect = false;
            this.expenseGrid.EnableMultiSelect = true;
            this.expenseGrid.Location = new System.Drawing.Point(2, 21);
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.ShowAddMenu = false;
            this.expenseGrid.ShowAssembly = false;
            this.expenseGrid.ShowDeleteMenu = false;
            this.expenseGrid.ShowEditMenu = false;
            this.expenseGrid.ShowFindPanel = false;
            this.expenseGrid.ShowFooter = true;
            this.expenseGrid.ShowLineNumber = true;
            this.expenseGrid.ShowMenu = false;
            this.expenseGrid.ShowNavigator = false;
            this.expenseGrid.Size = new System.Drawing.Size(374, 187);
            this.expenseGrid.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.repairInfoView);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl6.Location = new System.Drawing.Point(546, 3);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(378, 316);
            this.groupControl6.TabIndex = 7;
            this.groupControl6.Text = "维修改造信息";
            // 
            // repairInfoView
            // 
            this.repairInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairInfoView.Location = new System.Drawing.Point(2, 21);
            this.repairInfoView.Name = "repairInfoView";
            this.repairInfoView.Size = new System.Drawing.Size(374, 293);
            this.repairInfoView.TabIndex = 0;
            // 
            // lbYears
            // 
            this.lbYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbYears.Location = new System.Drawing.Point(2, 21);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(150, 509);
            this.lbYears.TabIndex = 4;
            this.lbYears.SelectedIndexChanged += new System.EventHandler(this.lbYears_SelectedIndexChanged);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.lbYears);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(3, 3);
            this.groupControl5.Name = "groupControl5";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl5, 2);
            this.groupControl5.Size = new System.Drawing.Size(154, 532);
            this.groupControl5.TabIndex = 6;
            this.groupControl5.Text = "年度";
            // 
            // RepairReceiptMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RepairReceiptMod";
            this.Size = new System.Drawing.Size(927, 538);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private RepairGrid repairGrid;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private Finance.Utility.ExpenseGrid expenseGrid;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private RepairInfoView repairInfoView;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.ListBoxControl lbYears;
    }
}
