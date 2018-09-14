namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorLogReceiptMod
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
            this.logGrid = new Poseidon.Infrastructure.ClientDx.ElevatorLogGrid();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.logGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(714, 470);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "日志记录";
            // 
            // logGrid
            // 
            this.logGrid.AllowFilter = true;
            this.logGrid.AllowGroup = true;
            this.logGrid.AllowSort = true;
            this.logGrid.DataSource = null;
            this.logGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGrid.Editable = false;
            this.logGrid.EnableMasterView = false;
            this.logGrid.EnableMultiSelect = true;
            this.logGrid.Location = new System.Drawing.Point(2, 21);
            this.logGrid.Name = "logGrid";
            this.logGrid.ShowAddMenu = false;
            this.logGrid.ShowDeleteMenu = false;
            this.logGrid.ShowEditMenu = false;
            this.logGrid.ShowFindPanel = false;
            this.logGrid.ShowFooter = true;
            this.logGrid.ShowLineNumber = true;
            this.logGrid.ShowMenu = false;
            this.logGrid.ShowNavigator = false;
            this.logGrid.Size = new System.Drawing.Size(710, 447);
            this.logGrid.TabIndex = 0;
            // 
            // ElevatorLogReceiptMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ElevatorLogReceiptMod";
            this.Size = new System.Drawing.Size(720, 476);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private ElevatorLogGrid logGrid;
    }
}
