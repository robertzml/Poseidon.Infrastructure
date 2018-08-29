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
            this.recordGrid = new Poseidon.Infrastructure.ClientDx.RepairRecordGrid();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
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
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(921, 94);
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
            this.layoutControl1.Size = new System.Drawing.Size(917, 71);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(262, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除维修改造";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(321, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(318, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "编辑维修改造";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(305, 22);
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
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(917, 71);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(309, 51);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(309, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(322, 51);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDelete;
            this.layoutControlItem3.Location = new System.Drawing.Point(631, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(266, 51);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // groupControl2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl2, 2);
            this.groupControl2.Controls.Add(this.repairGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(921, 213);
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
            this.repairGrid.ShowAddExpenseMenu = true;
            this.repairGrid.ShowAddMenu = false;
            this.repairGrid.ShowDeleteMenu = false;
            this.repairGrid.ShowEditMenu = false;
            this.repairGrid.ShowFindPanel = false;
            this.repairGrid.ShowFooter = true;
            this.repairGrid.ShowLineNumber = true;
            this.repairGrid.ShowMenu = false;
            this.repairGrid.ShowModelTypeColumn = true;
            this.repairGrid.ShowNavigator = false;
            this.repairGrid.Size = new System.Drawing.Size(917, 190);
            this.repairGrid.TabIndex = 0;
            this.repairGrid.RowSelected += new System.Action<object, System.EventArgs>(this.repairGrid_RowSelected);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.recordGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 322);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(457, 213);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "维修改造记录";
            // 
            // recordGrid
            // 
            this.recordGrid.AllowFilter = true;
            this.recordGrid.AllowGroup = true;
            this.recordGrid.AllowSort = true;
            this.recordGrid.DataSource = null;
            this.recordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordGrid.Editable = false;
            this.recordGrid.EnableMasterView = false;
            this.recordGrid.EnableMultiSelect = true;
            this.recordGrid.Location = new System.Drawing.Point(2, 21);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.ShowAddMenu = false;
            this.recordGrid.ShowDeleteMenu = false;
            this.recordGrid.ShowEditMenu = false;
            this.recordGrid.ShowFindPanel = false;
            this.recordGrid.ShowFooter = true;
            this.recordGrid.ShowLineNumber = true;
            this.recordGrid.ShowMenu = false;
            this.recordGrid.ShowNavigator = false;
            this.recordGrid.Size = new System.Drawing.Size(453, 190);
            this.recordGrid.TabIndex = 0;
            this.recordGrid.UseCalculatePrice = false;
            this.recordGrid.UseFacilityName = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.expenseGrid);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(466, 322);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(458, 213);
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
            this.expenseGrid.EnableMultiSelect = false;
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
            this.expenseGrid.Size = new System.Drawing.Size(454, 190);
            this.expenseGrid.TabIndex = 0;
            // 
            // RepairReceiptMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RepairReceiptMod";
            this.Size = new System.Drawing.Size(927, 538);
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
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private RepairRecordGrid recordGrid;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Finance.Utility.ExpenseGrid expenseGrid;
    }
}
