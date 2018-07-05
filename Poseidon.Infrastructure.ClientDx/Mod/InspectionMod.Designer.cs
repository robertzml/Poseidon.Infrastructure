namespace Poseidon.Infrastructure.ClientDx
{
    partial class InspectionMod
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
            this.insGrid = new Poseidon.Infrastructure.ClientDx.InspectionGrid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 629);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.insGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 120);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1045, 506);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "检验信息";
            // 
            // insGrid
            // 
            this.insGrid.AllowFilter = true;
            this.insGrid.AllowGroup = true;
            this.insGrid.AllowSort = true;
            this.insGrid.DataSource = null;
            this.insGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insGrid.Editable = false;
            this.insGrid.EnableMasterView = false;
            this.insGrid.EnableMultiSelect = true;
            this.insGrid.Location = new System.Drawing.Point(2, 21);
            this.insGrid.Name = "insGrid";
            this.insGrid.ShowAddMenu = false;
            this.insGrid.ShowFooter = false;
            this.insGrid.ShowLineNumber = true;
            this.insGrid.ShowMenu = false;
            this.insGrid.ShowNavigator = false;
            this.insGrid.Size = new System.Drawing.Size(1041, 483);
            this.insGrid.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1045, 111);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1041, 88);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(506, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加检验信息";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1041, 88);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(510, 68);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(522, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(507, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "编辑检验信息";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(510, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(511, 68);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // InspectionMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InspectionMod";
            this.Size = new System.Drawing.Size(1051, 629);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private InspectionGrid insGrid;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
