﻿namespace Poseidon.Infrastructure.ClientDx
{
    partial class FrmRepairOverview
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageReceipt = new DevExpress.XtraTab.XtraTabPage();
            this.repairReceiptMod = new Poseidon.Infrastructure.ClientDx.RepairReceiptMod();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPageReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(907, 554);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.tabPageReceipt});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(901, 525);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // tabPageReceipt
            // 
            this.tabPageReceipt.Controls.Add(this.repairReceiptMod);
            this.tabPageReceipt.Name = "tabPageReceipt";
            this.tabPageReceipt.Size = new System.Drawing.Size(901, 525);
            this.tabPageReceipt.Text = "维修改造项目";
            // 
            // repairReceiptMod
            // 
            this.repairReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.repairReceiptMod.Name = "repairReceiptMod";
            this.repairReceiptMod.Size = new System.Drawing.Size(901, 525);
            this.repairReceiptMod.TabIndex = 0;
            // 
            // FrmRepairOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 554);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmRepairOverview";
            this.Text = "维修改造总览";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabPageReceipt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage tabPageReceipt;
        private RepairReceiptMod repairReceiptMod;
    }
}