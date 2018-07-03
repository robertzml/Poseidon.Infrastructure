﻿namespace Poseidon.Infrastructure.ClientDx
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.elevatorReceiptMod = new Poseidon.Infrastructure.ClientDx.ElevatorReceiptMod();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
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
            this.elevatorTree.EntitySelected += new System.EventHandler(this.elevatorTree_EntitySelected);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Winform.Core.GroupChildrenTree elevatorTree;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ElevatorReceiptMod elevatorReceiptMod;
    }
}