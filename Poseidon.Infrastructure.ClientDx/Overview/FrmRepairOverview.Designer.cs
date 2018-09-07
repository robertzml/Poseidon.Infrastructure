namespace Poseidon.Infrastructure.ClientDx
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
            this.tabPageOverview = new DevExpress.XtraTab.XtraTabPage();
            this.repairOvMod = new Poseidon.Infrastructure.ClientDx.RepairOverivewMod();
            this.tabPageReceipt = new DevExpress.XtraTab.XtraTabPage();
            this.repairReceiptMod = new Poseidon.Infrastructure.ClientDx.RepairReceiptMod();
            this.tabPageRecord = new DevExpress.XtraTab.XtraTabPage();
            this.repairRecordMod = new Poseidon.Infrastructure.ClientDx.RepairRecordMod();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPageReceipt.SuspendLayout();
            this.tabPageRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabPageOverview;
            this.xtraTabControl1.Size = new System.Drawing.Size(907, 554);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageOverview,
            this.tabPageReceipt,
            this.tabPageRecord});
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.repairOvMod);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Size = new System.Drawing.Size(901, 525);
            this.tabPageOverview.Text = "总览";
            // 
            // repairOvMod
            // 
            this.repairOvMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairOvMod.Location = new System.Drawing.Point(0, 0);
            this.repairOvMod.Name = "repairOvMod";
            this.repairOvMod.Size = new System.Drawing.Size(901, 525);
            this.repairOvMod.TabIndex = 0;
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
            // tabPageRecord
            // 
            this.tabPageRecord.Controls.Add(this.repairRecordMod);
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.Size = new System.Drawing.Size(901, 525);
            this.tabPageRecord.Text = "维修改造记录";
            // 
            // repairRecordMod
            // 
            this.repairRecordMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repairRecordMod.Location = new System.Drawing.Point(0, 0);
            this.repairRecordMod.Name = "repairRecordMod";
            this.repairRecordMod.Size = new System.Drawing.Size(901, 525);
            this.repairRecordMod.TabIndex = 0;
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
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageReceipt.ResumeLayout(false);
            this.tabPageRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabPageOverview;
        private DevExpress.XtraTab.XtraTabPage tabPageReceipt;
        private RepairReceiptMod repairReceiptMod;
        private RepairOverivewMod repairOvMod;
        private DevExpress.XtraTab.XtraTabPage tabPageRecord;
        private RepairRecordMod repairRecordMod;
    }
}