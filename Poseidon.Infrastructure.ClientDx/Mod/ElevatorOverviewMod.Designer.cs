namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorOverviewMod
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
            this.tabInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageInfo = new DevExpress.XtraTab.XtraTabPage();
            this.elevatorInfoView = new Poseidon.Infrastructure.ClientDx.ElevatorInfoView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tabBusiness = new DevExpress.XtraTab.XtraTabControl();
            this.tabInspection = new DevExpress.XtraTab.XtraTabPage();
            this.insOvMod = new Poseidon.Infrastructure.ClientDx.InspectionOverviewMod();
            this.tabRepair = new DevExpress.XtraTab.XtraTabPage();
            this.repairOvMod = new Poseidon.Infrastructure.ClientDx.FacilityRepairMod();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).BeginInit();
            this.tabBusiness.SuspendLayout();
            this.tabInspection.SuspendLayout();
            this.tabRepair.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.tabInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabBusiness, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(3, 3);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedTabPage = this.tabPageInfo;
            this.tabInfo.Size = new System.Drawing.Size(956, 227);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageInfo,
            this.xtraTabPage2});
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.elevatorInfoView);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Size = new System.Drawing.Size(950, 198);
            this.tabPageInfo.Text = "电梯信息";
            // 
            // elevatorInfoView
            // 
            this.elevatorInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorInfoView.Location = new System.Drawing.Point(0, 0);
            this.elevatorInfoView.Name = "elevatorInfoView";
            this.elevatorInfoView.Size = new System.Drawing.Size(950, 198);
            this.elevatorInfoView.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(950, 198);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // tabBusiness
            // 
            this.tabBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBusiness.Location = new System.Drawing.Point(3, 236);
            this.tabBusiness.Name = "tabBusiness";
            this.tabBusiness.SelectedTabPage = this.tabInspection;
            this.tabBusiness.Size = new System.Drawing.Size(956, 411);
            this.tabBusiness.TabIndex = 1;
            this.tabBusiness.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabInspection,
            this.tabRepair});
            // 
            // tabInspection
            // 
            this.tabInspection.Controls.Add(this.insOvMod);
            this.tabInspection.Name = "tabInspection";
            this.tabInspection.Size = new System.Drawing.Size(950, 382);
            this.tabInspection.Text = "设施检验";
            // 
            // insOvMod
            // 
            this.insOvMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insOvMod.Location = new System.Drawing.Point(0, 0);
            this.insOvMod.Name = "insOvMod";
            this.insOvMod.Size = new System.Drawing.Size(950, 382);
            this.insOvMod.TabIndex = 0;
            // 
            // tabRepair
            // 
            this.tabRepair.Controls.Add(this.repairOvMod);
            this.tabRepair.Name = "tabRepair";
            this.tabRepair.Size = new System.Drawing.Size(950, 382);
            this.tabRepair.Text = "维修改造";
            // 
            // repairOvMod
            // 
            this.repairOvMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairOvMod.Location = new System.Drawing.Point(0, 0);
            this.repairOvMod.Name = "repairOvMod";
            this.repairOvMod.Size = new System.Drawing.Size(950, 382);
            this.repairOvMod.TabIndex = 0;
            // 
            // ElevatorOverviewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ElevatorOverviewMod";
            this.Size = new System.Drawing.Size(962, 650);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).EndInit();
            this.tabBusiness.ResumeLayout(false);
            this.tabInspection.ResumeLayout(false);
            this.tabRepair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl tabInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageInfo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ElevatorInfoView elevatorInfoView;
        private DevExpress.XtraTab.XtraTabControl tabBusiness;
        private DevExpress.XtraTab.XtraTabPage tabInspection;
        private DevExpress.XtraTab.XtraTabPage tabRepair;
        private InspectionOverviewMod insOvMod;
        private FacilityRepairMod repairOvMod;
    }
}
