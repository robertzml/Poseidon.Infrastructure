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
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.elevatorGroupMod = new Poseidon.Infrastructure.ClientDx.ElevatorGroupMod();
            this.elevatorReceiptMod = new Poseidon.Infrastructure.ClientDx.ElevatorReceiptMod();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.navFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
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
            this.navFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navFrame.SelectedPage = this.navigationPage1;
            this.navFrame.SelectedPageIndex = 0;
            this.navFrame.Size = new System.Drawing.Size(679, 580);
            this.navFrame.TabIndex = 0;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.elevatorGroupMod);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(679, 580);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.elevatorReceiptMod);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(679, 580);
            // 
            // elevatorGroupMod
            // 
            this.elevatorGroupMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorGroupMod.Location = new System.Drawing.Point(0, 0);
            this.elevatorGroupMod.Name = "elevatorGroupMod";
            this.elevatorGroupMod.Size = new System.Drawing.Size(679, 580);
            this.elevatorGroupMod.TabIndex = 0;
            // 
            // elevatorReceiptMod
            // 
            this.elevatorReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elevatorReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.elevatorReceiptMod.Name = "elevatorReceiptMod";
            this.elevatorReceiptMod.Size = new System.Drawing.Size(679, 580);
            this.elevatorReceiptMod.TabIndex = 0;
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
            this.navFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private ElevatorGroupMod elevatorGroupMod;
        private Winform.Core.GroupChildrenTree elevatorTree;
        private ElevatorReceiptMod elevatorReceiptMod;
    }
}