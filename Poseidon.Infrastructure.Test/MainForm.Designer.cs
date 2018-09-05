namespace Poseidon.Infrastructure.Test
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuElevator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuElevatorMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuElevatorList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuElevatorOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaintenanceMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepairMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRepairOv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuElevator,
            this.menuSystem,
            this.menuCompany,
            this.menuRepair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuElevator
            // 
            this.menuElevator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuElevatorMan,
            this.menuElevatorList,
            this.menuElevatorOverview});
            this.menuElevator.Name = "menuElevator";
            this.menuElevator.Size = new System.Drawing.Size(68, 21);
            this.menuElevator.Text = "电梯管理";
            // 
            // menuElevatorMan
            // 
            this.menuElevatorMan.Name = "menuElevatorMan";
            this.menuElevatorMan.Size = new System.Drawing.Size(124, 22);
            this.menuElevatorMan.Text = "电梯管理";
            this.menuElevatorMan.Click += new System.EventHandler(this.menuElevatorMan_Click);
            // 
            // menuElevatorList
            // 
            this.menuElevatorList.Name = "menuElevatorList";
            this.menuElevatorList.Size = new System.Drawing.Size(124, 22);
            this.menuElevatorList.Text = "电梯列表";
            this.menuElevatorList.Click += new System.EventHandler(this.menuElevatorList_Click);
            // 
            // menuElevatorOverview
            // 
            this.menuElevatorOverview.Name = "menuElevatorOverview";
            this.menuElevatorOverview.Size = new System.Drawing.Size(124, 22);
            this.menuElevatorOverview.Text = "电梯总览";
            this.menuElevatorOverview.Click += new System.EventHandler(this.menuElevatorOverview_Click);
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModel});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(68, 21);
            this.menuSystem.Text = "系统管理";
            // 
            // menuModel
            // 
            this.menuModel.Name = "menuModel";
            this.menuModel.Size = new System.Drawing.Size(124, 22);
            this.menuModel.Text = "模型管理";
            this.menuModel.Click += new System.EventHandler(this.menuModel_Click);
            // 
            // menuCompany
            // 
            this.menuCompany.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaintenanceMan});
            this.menuCompany.Name = "menuCompany";
            this.menuCompany.Size = new System.Drawing.Size(92, 21);
            this.menuCompany.Text = "维保公司管理";
            // 
            // menuMaintenanceMan
            // 
            this.menuMaintenanceMan.Name = "menuMaintenanceMan";
            this.menuMaintenanceMan.Size = new System.Drawing.Size(124, 22);
            this.menuMaintenanceMan.Text = "维保公司";
            this.menuMaintenanceMan.Click += new System.EventHandler(this.menuMaintenanceMan_Click);
            // 
            // menuRepair
            // 
            this.menuRepair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRepairMan,
            this.menuRepairOv});
            this.menuRepair.Name = "menuRepair";
            this.menuRepair.Size = new System.Drawing.Size(68, 21);
            this.menuRepair.Text = "维修改造";
            // 
            // menuRepairMan
            // 
            this.menuRepairMan.Name = "menuRepairMan";
            this.menuRepairMan.Size = new System.Drawing.Size(152, 22);
            this.menuRepairMan.Text = "维修改造管理";
            this.menuRepairMan.Click += new System.EventHandler(this.menuRepairMan_Click);
            // 
            // menuRepairOv
            // 
            this.menuRepairOv.Name = "menuRepairOv";
            this.menuRepairOv.Size = new System.Drawing.Size(152, 22);
            this.menuRepairOv.Text = "维修改造总览";
            this.menuRepairOv.Click += new System.EventHandler(this.menuRepairOv_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 483);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "测试";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuElevator;
        private System.Windows.Forms.ToolStripMenuItem menuElevatorMan;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuModel;
        private System.Windows.Forms.ToolStripMenuItem menuElevatorList;
        private System.Windows.Forms.ToolStripMenuItem menuCompany;
        private System.Windows.Forms.ToolStripMenuItem menuMaintenanceMan;
        private System.Windows.Forms.ToolStripMenuItem menuElevatorOverview;
        private System.Windows.Forms.ToolStripMenuItem menuRepair;
        private System.Windows.Forms.ToolStripMenuItem menuRepairMan;
        private System.Windows.Forms.ToolStripMenuItem menuRepairOv;
    }
}

