namespace Poseidon.Infrastructure.ClientDx
{
    partial class InspectionOverviewMod
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
            this.inspectionGrid = new Poseidon.Infrastructure.ClientDx.InspectionGrid();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.inspectionInfo = new Poseidon.Infrastructure.ClientDx.InspectionInfoView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.expenseGrid = new Poseidon.Finance.Utility.ExpenseGrid();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(915, 597);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.inspectionGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.tableLayoutPanel1.SetRowSpan(this.groupControl2, 2);
            this.groupControl2.Size = new System.Drawing.Size(543, 591);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "检验记录";
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
            this.inspectionGrid.Location = new System.Drawing.Point(2, 21);
            this.inspectionGrid.Name = "inspectionGrid";
            this.inspectionGrid.ShowAddExpenseMenu = false;
            this.inspectionGrid.ShowAddMenu = false;
            this.inspectionGrid.ShowFooter = false;
            this.inspectionGrid.ShowLineNumber = true;
            this.inspectionGrid.ShowMenu = false;
            this.inspectionGrid.ShowModelTypeColumn = false;
            this.inspectionGrid.ShowNavigator = false;
            this.inspectionGrid.Size = new System.Drawing.Size(539, 568);
            this.inspectionGrid.TabIndex = 0;
            this.inspectionGrid.RowSelected += new System.Action<object, System.EventArgs>(this.inspectionGrid_RowSelected);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.inspectionInfo);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(552, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(360, 232);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "检验信息";
            // 
            // inspectionInfo
            // 
            this.inspectionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionInfo.Location = new System.Drawing.Point(2, 21);
            this.inspectionInfo.Name = "inspectionInfo";
            this.inspectionInfo.Size = new System.Drawing.Size(356, 209);
            this.inspectionInfo.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.expenseGrid);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(552, 241);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(360, 353);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "费用记录";
            // 
            // expenseGrid
            // 
            this.expenseGrid.AllowFilter = true;
            this.expenseGrid.AllowGroup = false;
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
            this.expenseGrid.ShowFooter = true;
            this.expenseGrid.ShowLineNumber = true;
            this.expenseGrid.ShowMenu = false;
            this.expenseGrid.ShowNavigator = false;
            this.expenseGrid.Size = new System.Drawing.Size(356, 330);
            this.expenseGrid.TabIndex = 0;
            // 
            // InspectionOverviewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InspectionOverviewMod";
            this.Size = new System.Drawing.Size(915, 597);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private InspectionGrid inspectionGrid;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private InspectionInfoView inspectionInfo;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private Finance.Utility.ExpenseGrid expenseGrid;
    }
}
