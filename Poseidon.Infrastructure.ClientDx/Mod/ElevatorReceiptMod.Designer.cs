namespace Poseidon.Infrastructure.ClientDx
{
    partial class ElevatorReceiptMod
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
            this.tabPageManager = new DevExpress.XtraTab.XtraTabPage();
            this.elevatorManagerMod = new Poseidon.Infrastructure.ClientDx.ElevatorManagerReceiptMod();
            this.tabPageCompany = new DevExpress.XtraTab.XtraTabPage();
            this.maintenanceInfoMod = new Poseidon.Infrastructure.ClientDx.MaintenanceInfoReceiptMod();
            this.tabManage = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.elevatorLogMod = new Poseidon.Infrastructure.ClientDx.ElevatorLogMod();
            this.tabPageInspection = new DevExpress.XtraTab.XtraTabPage();
            this.insMod = new Poseidon.Infrastructure.ClientDx.InspectionReceiptMod();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.tabPageManager.SuspendLayout();
            this.tabPageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabManage)).BeginInit();
            this.tabManage.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.tabPageInspection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabManage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(3, 3);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedTabPage = this.tabPageInfo;
            this.tabInfo.Size = new System.Drawing.Size(917, 214);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageInfo,
            this.tabPageManager,
            this.tabPageCompany});
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.elevatorInfoView);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Size = new System.Drawing.Size(911, 185);
            this.tabPageInfo.Text = "基本信息";
            // 
            // elevatorInfoView
            // 
            this.elevatorInfoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorInfoView.Location = new System.Drawing.Point(0, 0);
            this.elevatorInfoView.Name = "elevatorInfoView";
            this.elevatorInfoView.Size = new System.Drawing.Size(911, 185);
            this.elevatorInfoView.TabIndex = 0;
            // 
            // tabPageManager
            // 
            this.tabPageManager.Controls.Add(this.elevatorManagerMod);
            this.tabPageManager.Name = "tabPageManager";
            this.tabPageManager.Size = new System.Drawing.Size(911, 185);
            this.tabPageManager.Text = "管理员";
            // 
            // elevatorManagerMod
            // 
            this.elevatorManagerMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorManagerMod.Location = new System.Drawing.Point(0, 0);
            this.elevatorManagerMod.Name = "elevatorManagerMod";
            this.elevatorManagerMod.Size = new System.Drawing.Size(911, 185);
            this.elevatorManagerMod.TabIndex = 0;
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.maintenanceInfoMod);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Size = new System.Drawing.Size(911, 185);
            this.tabPageCompany.Text = "维保信息";
            // 
            // maintenanceInfoMod
            // 
            this.maintenanceInfoMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintenanceInfoMod.Location = new System.Drawing.Point(0, 0);
            this.maintenanceInfoMod.Name = "maintenanceInfoMod";
            this.maintenanceInfoMod.Size = new System.Drawing.Size(911, 185);
            this.maintenanceInfoMod.TabIndex = 0;
            // 
            // tabManage
            // 
            this.tabManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManage.Location = new System.Drawing.Point(3, 223);
            this.tabManage.Name = "tabManage";
            this.tabManage.SelectedTabPage = this.xtraTabPage1;
            this.tabManage.Size = new System.Drawing.Size(917, 364);
            this.tabManage.TabIndex = 1;
            this.tabManage.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.tabPageInspection});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.elevatorLogMod);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(911, 335);
            this.xtraTabPage1.Text = "日常运行";
            // 
            // elevatorLogMod
            // 
            this.elevatorLogMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorLogMod.Location = new System.Drawing.Point(0, 0);
            this.elevatorLogMod.Name = "elevatorLogMod";
            this.elevatorLogMod.Size = new System.Drawing.Size(911, 335);
            this.elevatorLogMod.TabIndex = 0;
            // 
            // tabPageInspection
            // 
            this.tabPageInspection.Controls.Add(this.insMod);
            this.tabPageInspection.Name = "tabPageInspection";
            this.tabPageInspection.Size = new System.Drawing.Size(911, 335);
            this.tabPageInspection.Text = "设施检验";
            // 
            // insMod
            // 
            this.insMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insMod.Location = new System.Drawing.Point(0, 0);
            this.insMod.Name = "insMod";
            this.insMod.Size = new System.Drawing.Size(911, 335);
            this.insMod.TabIndex = 0;
            // 
            // ElevatorReceiptMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ElevatorReceiptMod";
            this.Size = new System.Drawing.Size(923, 590);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageManager.ResumeLayout(false);
            this.tabPageCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabManage)).EndInit();
            this.tabManage.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.tabPageInspection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl tabInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageInfo;
        private ElevatorInfoView elevatorInfoView;
        private DevExpress.XtraTab.XtraTabPage tabPageManager;
        private DevExpress.XtraTab.XtraTabPage tabPageCompany;
        private DevExpress.XtraTab.XtraTabControl tabManage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage tabPageInspection;
        private InspectionReceiptMod insMod;
        private ElevatorManagerReceiptMod elevatorManagerMod;
        private MaintenanceInfoReceiptMod maintenanceInfoMod;
        private ElevatorLogMod elevatorLogMod;
    }
}
