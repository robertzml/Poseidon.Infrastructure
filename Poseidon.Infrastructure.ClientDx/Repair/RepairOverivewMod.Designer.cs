namespace Poseidon.Infrastructure.ClientDx
{
    partial class RepairOverivewMod
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
            this.repairYearSumGrid = new Poseidon.Infrastructure.ClientDx.RepairYearSummaryGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.repairYearSumGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 279);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "历年汇总";
            // 
            // repairYearSumGrid
            // 
            this.repairYearSumGrid.AllowFilter = false;
            this.repairYearSumGrid.AllowGroup = false;
            this.repairYearSumGrid.AllowSort = true;
            this.repairYearSumGrid.DataSource = null;
            this.repairYearSumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairYearSumGrid.Editable = false;
            this.repairYearSumGrid.EnableMasterView = false;
            this.repairYearSumGrid.EnableMultiSelect = true;
            this.repairYearSumGrid.Location = new System.Drawing.Point(2, 21);
            this.repairYearSumGrid.Name = "repairYearSumGrid";
            this.repairYearSumGrid.ShowAddMenu = false;
            this.repairYearSumGrid.ShowDeleteMenu = false;
            this.repairYearSumGrid.ShowEditMenu = false;
            this.repairYearSumGrid.ShowFindPanel = false;
            this.repairYearSumGrid.ShowFooter = true;
            this.repairYearSumGrid.ShowLineNumber = true;
            this.repairYearSumGrid.ShowMenu = false;
            this.repairYearSumGrid.ShowNavigator = false;
            this.repairYearSumGrid.Size = new System.Drawing.Size(422, 256);
            this.repairYearSumGrid.TabIndex = 0;
            // 
            // RepairOverivewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RepairOverivewMod";
            this.Size = new System.Drawing.Size(864, 571);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private RepairYearSummaryGrid repairYearSumGrid;
    }
}
