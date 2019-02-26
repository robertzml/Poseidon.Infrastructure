namespace Poseidon.Infrastructure.ClientDx
{
    partial class FrmInspectionBatch
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
            this.cmbInspectionType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dpPlanDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spInspectionFee = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionGrid = new Poseidon.Infrastructure.ClientDx.InspectionGrid();
            this.txtInspectionCompany = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInspectionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpPlanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spInspectionFee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInspectionCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(724, 18);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(615, 18);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(844, 427);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 427);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 427);
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
            this.layoutControl1.Controls.Add(this.txtInspectionCompany);
            this.layoutControl1.Controls.Add(this.spInspectionFee);
            this.layoutControl1.Controls.Add(this.dpPlanDate);
            this.layoutControl1.Controls.Add(this.cmbInspectionType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(834, 91);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbInspectionType
            // 
            this.cmbInspectionType.Location = new System.Drawing.Point(63, 12);
            this.cmbInspectionType.Name = "cmbInspectionType";
            this.cmbInspectionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInspectionType.Size = new System.Drawing.Size(352, 20);
            this.cmbInspectionType.StyleController = this.layoutControl1;
            this.cmbInspectionType.TabIndex = 4;
            this.cmbInspectionType.SelectedIndexChanged += new System.EventHandler(this.cmbInspectionType_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(834, 91);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbInspectionType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(407, 24);
            this.layoutControlItem1.Text = "检验类型";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.inspectionGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 123);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(838, 301);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "检验计划列表";
            // 
            // dpPlanDate
            // 
            this.dpPlanDate.EditValue = null;
            this.dpPlanDate.Location = new System.Drawing.Point(470, 12);
            this.dpPlanDate.Name = "dpPlanDate";
            this.dpPlanDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPlanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpPlanDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpPlanDate.Size = new System.Drawing.Size(352, 20);
            this.dpPlanDate.StyleController = this.layoutControl1;
            this.dpPlanDate.TabIndex = 5;
            this.dpPlanDate.EditValueChanged += new System.EventHandler(this.dpPlanDate_EditValueChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dpPlanDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(407, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(407, 24);
            this.layoutControlItem2.Text = "计划时间";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // spInspectionFee
            // 
            this.spInspectionFee.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spInspectionFee.Location = new System.Drawing.Point(470, 36);
            this.spInspectionFee.Name = "spInspectionFee";
            this.spInspectionFee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spInspectionFee.Size = new System.Drawing.Size(352, 20);
            this.spInspectionFee.StyleController = this.layoutControl1;
            this.spInspectionFee.TabIndex = 6;
            this.spInspectionFee.EditValueChanged += new System.EventHandler(this.spInspectionFee_EditValueChanged);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spInspectionFee;
            this.layoutControlItem3.Location = new System.Drawing.Point(407, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(407, 47);
            this.layoutControlItem3.Text = "检验费用";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // inspectionGrid
            // 
            this.inspectionGrid.AllowFilter = false;
            this.inspectionGrid.AllowGroup = false;
            this.inspectionGrid.AllowSort = true;
            this.inspectionGrid.DataSource = null;
            this.inspectionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionGrid.Editable = true;
            this.inspectionGrid.EnableMasterView = false;
            this.inspectionGrid.EnableMultiSelect = false;
            this.inspectionGrid.Location = new System.Drawing.Point(2, 21);
            this.inspectionGrid.Name = "inspectionGrid";
            this.inspectionGrid.ShowAddExpenseMenu = false;
            this.inspectionGrid.ShowAddMenu = false;
            this.inspectionGrid.ShowDeleteMenu = false;
            this.inspectionGrid.ShowEditMenu = false;
            this.inspectionGrid.ShowFindPanel = false;
            this.inspectionGrid.ShowFooter = false;
            this.inspectionGrid.ShowLineNumber = true;
            this.inspectionGrid.ShowMenu = false;
            this.inspectionGrid.ShowModelTypeColumn = false;
            this.inspectionGrid.ShowNavigator = true;
            this.inspectionGrid.Size = new System.Drawing.Size(834, 278);
            this.inspectionGrid.TabIndex = 0;
            // 
            // txtInspectionCompany
            // 
            this.txtInspectionCompany.Location = new System.Drawing.Point(63, 36);
            this.txtInspectionCompany.Name = "txtInspectionCompany";
            this.txtInspectionCompany.Size = new System.Drawing.Size(352, 20);
            this.txtInspectionCompany.StyleController = this.layoutControl1;
            this.txtInspectionCompany.TabIndex = 7;
            this.txtInspectionCompany.EditValueChanged += new System.EventHandler(this.txtInspectionCompany_EditValueChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtInspectionCompany;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(407, 47);
            this.layoutControlItem4.Text = "检验单位";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FrmInspectionBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 487);
            this.Name = "FrmInspectionBatch";
            this.Text = "批量添加检验计划";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbInspectionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dpPlanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spInspectionFee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInspectionCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private InspectionGrid inspectionGrid;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbInspectionType;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit spInspectionFee;
        private DevExpress.XtraEditors.DateEdit dpPlanDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtInspectionCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}