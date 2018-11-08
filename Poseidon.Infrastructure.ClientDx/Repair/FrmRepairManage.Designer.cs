namespace Poseidon.Infrastructure.ClientDx
{
    partial class FrmRepairManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.repairGrid = new Poseidon.Infrastructure.ClientDx.RepairGrid();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.repairRecordGrid = new Poseidon.Infrastructure.ClientDx.RepairRecordGrid();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lbYears = new DevExpress.XtraEditors.ListBoxControl();
            this.expenseGrid = new Poseidon.Finance.Utility.ExpenseGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbYears)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupControl5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 567);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(163, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(746, 94);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(742, 71);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除维修改造";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(263, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(245, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "编辑维修改造";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增维修改造";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(742, 71);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(251, 51);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(249, 51);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDelete;
            this.layoutControlItem3.Location = new System.Drawing.Point(500, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 51);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // groupControl2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl2, 2);
            this.groupControl2.Controls.Add(this.repairGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(163, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(746, 227);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "维修改造信息";
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
            this.repairGrid.ShowAddExpenseMenu = true;
            this.repairGrid.ShowAddMenu = false;
            this.repairGrid.ShowDeleteMenu = false;
            this.repairGrid.ShowEditMenu = false;
            this.repairGrid.ShowFindPanel = false;
            this.repairGrid.ShowFooter = true;
            this.repairGrid.ShowLineNumber = true;
            this.repairGrid.ShowMenu = false;
            this.repairGrid.ShowModelTypeColumn = false;
            this.repairGrid.ShowNavigator = false;
            this.repairGrid.Size = new System.Drawing.Size(742, 204);
            this.repairGrid.TabIndex = 0;
            this.repairGrid.RowSelected += new System.Action<object, System.EventArgs>(this.repairGrid_RowSelected);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.repairRecordGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(163, 336);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(370, 228);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "改造记录";
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
            this.repairRecordGrid.EnableMultiSelect = true;
            this.repairRecordGrid.Location = new System.Drawing.Point(2, 21);
            this.repairRecordGrid.Name = "repairRecordGrid";
            this.repairRecordGrid.ShowAddMenu = false;
            this.repairRecordGrid.ShowColRepairNumber = false;
            this.repairRecordGrid.ShowDeleteMenu = false;
            this.repairRecordGrid.ShowEditMenu = false;
            this.repairRecordGrid.ShowFindPanel = false;
            this.repairRecordGrid.ShowFooter = true;
            this.repairRecordGrid.ShowLineNumber = true;
            this.repairRecordGrid.ShowMenu = false;
            this.repairRecordGrid.ShowNavigator = false;
            this.repairRecordGrid.Size = new System.Drawing.Size(366, 205);
            this.repairRecordGrid.TabIndex = 0;
            this.repairRecordGrid.UseCalculatePrice = false;
            this.repairRecordGrid.UseFacilityName = true;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.expenseGrid);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(539, 336);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(370, 228);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "费用记录";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.lbYears);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(3, 3);
            this.groupControl5.Name = "groupControl5";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl5, 3);
            this.groupControl5.Size = new System.Drawing.Size(154, 561);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "年度";
            // 
            // lbYears
            // 
            this.lbYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbYears.Location = new System.Drawing.Point(2, 21);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(150, 538);
            this.lbYears.TabIndex = 4;
            this.lbYears.SelectedIndexChanged += new System.EventHandler(this.lbYears_SelectedIndexChanged);
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
            this.expenseGrid.Size = new System.Drawing.Size(366, 205);
            this.expenseGrid.TabIndex = 0;
            // 
            // FrmRepairManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmRepairManage";
            this.Text = "维修改造管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbYears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private RepairGrid repairGrid;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private RepairRecordGrid repairRecordGrid;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private Finance.Utility.ExpenseGrid expenseGrid;
        private DevExpress.XtraEditors.ListBoxControl lbYears;
        private DevExpress.XtraEditors.GroupControl groupControl5;
    }
}