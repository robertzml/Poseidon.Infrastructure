namespace Poseidon.Infrastructure.ClientDx
{
    partial class FrmElevatorManage
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.elevatorTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.elevatorReceiptMod = new Poseidon.Infrastructure.ClientDx.ElevatorReceiptMod();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.elevatorBatchMod = new Poseidon.Infrastructure.ClientDx.ElevatorBatchMod();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navFrame)).BeginInit();
            this.navFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.navFrame);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(935, 580);
            this.splitContainerControl1.SplitterPosition = 251;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.elevatorTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(251, 580);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "电梯列表";
            // 
            // elevatorTree
            // 
            this.elevatorTree.CascadeEntity = false;
            this.elevatorTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorTree.Location = new System.Drawing.Point(2, 21);
            this.elevatorTree.Name = "elevatorTree";
            this.elevatorTree.ShowFindPanel = false;
            this.elevatorTree.Size = new System.Drawing.Size(247, 557);
            this.elevatorTree.TabIndex = 0;
            this.elevatorTree.GroupSelected += new System.EventHandler(this.elevatorTree_GroupSelected);
            this.elevatorTree.EntitySelected += new System.EventHandler(this.elevatorTree_EntitySelected);
            // 
            // navFrame
            // 
            this.navFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navFrame.Controls.Add(this.navigationPage1);
            this.navFrame.Controls.Add(this.navigationPage2);
            this.navFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame.Location = new System.Drawing.Point(0, 0);
            this.navFrame.Name = "navFrame";
            this.navFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navFrame.SelectedPage = this.navigationPage1;
            this.navFrame.Size = new System.Drawing.Size(679, 580);
            this.navFrame.TabIndex = 1;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.groupControl2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(679, 580);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.elevatorReceiptMod);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(679, 580);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "电梯信息";
            // 
            // elevatorReceiptMod
            // 
            this.elevatorReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorReceiptMod.Location = new System.Drawing.Point(2, 21);
            this.elevatorReceiptMod.Name = "elevatorReceiptMod";
            this.elevatorReceiptMod.Size = new System.Drawing.Size(675, 557);
            this.elevatorReceiptMod.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.groupControl3);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(679, 580);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.elevatorBatchMod);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(679, 580);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "批量管理";
            // 
            // elevatorBatchMod
            // 
            this.elevatorBatchMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorBatchMod.Location = new System.Drawing.Point(2, 21);
            this.elevatorBatchMod.Name = "elevatorBatchMod";
            this.elevatorBatchMod.Size = new System.Drawing.Size(675, 557);
            this.elevatorBatchMod.TabIndex = 0;
            // 
            // FrmElevatorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 580);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmElevatorManage";
            this.Text = "电梯管理";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navFrame)).EndInit();
            this.navFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Winform.Core.GroupChildrenTree elevatorTree;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ElevatorReceiptMod elevatorReceiptMod;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private ElevatorBatchMod elevatorBatchMod;
    }
}