namespace Poseidon.Infrastructure.ClientDx
{
    partial class FrmMaintenanceInfoBatch
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dpEnd = new DevExpress.XtraEditors.DateEdit();
            this.dpStart = new DevExpress.XtraEditors.DateEdit();
            this.spMaintenanceFee = new DevExpress.XtraEditors.SpinEdit();
            this.luMaintenanceCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bsMaintenanceCompany = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceInfoGrid = new Poseidon.Infrastructure.ClientDx.MaintenanceInfoGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMaintenanceFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luMaintenanceCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaintenanceCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(747, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(638, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(844, 442);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 442);
            this.plBottom.Size = new System.Drawing.Size(844, 60);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(838, 114);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "批量设置";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dpEnd);
            this.layoutControl1.Controls.Add(this.dpStart);
            this.layoutControl1.Controls.Add(this.spMaintenanceFee);
            this.layoutControl1.Controls.Add(this.luMaintenanceCompany);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(834, 91);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dpEnd
            // 
            this.dpEnd.EditValue = null;
            this.dpEnd.Location = new System.Drawing.Point(469, 36);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpEnd.Size = new System.Drawing.Size(353, 20);
            this.dpEnd.StyleController = this.layoutControl1;
            this.dpEnd.TabIndex = 7;
            this.dpEnd.EditValueChanged += new System.EventHandler(this.dpEnd_EditValueChanged);
            // 
            // dpStart
            // 
            this.dpStart.EditValue = null;
            this.dpStart.Location = new System.Drawing.Point(63, 36);
            this.dpStart.Name = "dpStart";
            this.dpStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpStart.Size = new System.Drawing.Size(351, 20);
            this.dpStart.StyleController = this.layoutControl1;
            this.dpStart.TabIndex = 6;
            this.dpStart.EditValueChanged += new System.EventHandler(this.dpStart_EditValueChanged);
            // 
            // spMaintenanceFee
            // 
            this.spMaintenanceFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spMaintenanceFee.Location = new System.Drawing.Point(469, 12);
            this.spMaintenanceFee.Name = "spMaintenanceFee";
            this.spMaintenanceFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spMaintenanceFee.Size = new System.Drawing.Size(353, 20);
            this.spMaintenanceFee.StyleController = this.layoutControl1;
            this.spMaintenanceFee.TabIndex = 5;
            this.spMaintenanceFee.EditValueChanged += new System.EventHandler(this.spMaintenanceFee_EditValueChanged);
            // 
            // luMaintenanceCompany
            // 
            this.luMaintenanceCompany.Location = new System.Drawing.Point(63, 12);
            this.luMaintenanceCompany.Name = "luMaintenanceCompany";
            this.luMaintenanceCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luMaintenanceCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShortName", "简称", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "地址", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Contact", "联系人", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.luMaintenanceCompany.Properties.DataSource = this.bsMaintenanceCompany;
            this.luMaintenanceCompany.Properties.DisplayMember = "Name";
            this.luMaintenanceCompany.Properties.NullText = "请选择";
            this.luMaintenanceCompany.Properties.ValueMember = "Id";
            this.luMaintenanceCompany.Size = new System.Drawing.Size(351, 20);
            this.luMaintenanceCompany.StyleController = this.layoutControl1;
            this.luMaintenanceCompany.TabIndex = 4;
            this.luMaintenanceCompany.EditValueChanged += new System.EventHandler(this.luMaintenanceCompany_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(834, 91);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luMaintenanceCompany;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(406, 24);
            this.layoutControlItem1.Text = "维保公司";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(406, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(408, 23);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spMaintenanceFee;
            this.layoutControlItem2.Location = new System.Drawing.Point(406, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem2.Text = "维保费用";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dpStart;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(406, 47);
            this.layoutControlItem3.Text = "开始日期";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dpEnd;
            this.layoutControlItem4.Location = new System.Drawing.Point(406, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(408, 24);
            this.layoutControlItem4.Text = "结束日期";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.maintenanceInfoGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(838, 316);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "电梯列表";
            // 
            // bsMaintenanceCompany
            // 
            this.bsMaintenanceCompany.DataSource = typeof(Poseidon.Infrastructure.Core.DL.MaintenanceCompany);
            // 
            // maintenanceInfoGrid
            // 
            this.maintenanceInfoGrid.AllowFilter = false;
            this.maintenanceInfoGrid.AllowGroup = false;
            this.maintenanceInfoGrid.AllowSort = true;
            this.maintenanceInfoGrid.DataSource = null;
            this.maintenanceInfoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenanceInfoGrid.Editable = true;
            this.maintenanceInfoGrid.EnableMasterView = false;
            this.maintenanceInfoGrid.EnableMultiSelect = false;
            this.maintenanceInfoGrid.Location = new System.Drawing.Point(2, 21);
            this.maintenanceInfoGrid.Name = "maintenanceInfoGrid";
            this.maintenanceInfoGrid.ShowAddMenu = false;
            this.maintenanceInfoGrid.ShowDeleteMenu = false;
            this.maintenanceInfoGrid.ShowEditMenu = false;
            this.maintenanceInfoGrid.ShowFindPanel = false;
            this.maintenanceInfoGrid.ShowFooter = false;
            this.maintenanceInfoGrid.ShowLineNumber = true;
            this.maintenanceInfoGrid.ShowMenu = false;
            this.maintenanceInfoGrid.ShowNavigator = true;
            this.maintenanceInfoGrid.Size = new System.Drawing.Size(834, 293);
            this.maintenanceInfoGrid.TabIndex = 0;
            // 
            // FrmMaintenanceInfoBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Name = "FrmMaintenanceInfoBatch";
            this.Text = "批量设置维保信息";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMaintenanceFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luMaintenanceCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsMaintenanceCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private MaintenanceInfoGrid maintenanceInfoGrid;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit luMaintenanceCompany;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bsMaintenanceCompany;
        private DevExpress.XtraEditors.SpinEdit spMaintenanceFee;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dpEnd;
        private DevExpress.XtraEditors.DateEdit dpStart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}