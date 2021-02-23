namespace CafeOtomasyon
{
    partial class frmCashTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashTransactions));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new CafeOtomasyon.DataSet1();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnZReport = new System.Windows.Forms.Button();
            this.lblMonthlyReport = new System.Windows.Forms.Label();
            this.rpvZReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new CafeOtomasyon.DataSet1TableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new CafeOtomasyon.DataSet1TableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(36, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(121, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMonthlyReport.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyReport.Location = new System.Drawing.Point(36, 62);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(234, 107);
            this.btnMonthlyReport.TabIndex = 1;
            this.btnMonthlyReport.Text = "AYLIK RAPOR";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnZReport
            // 
            this.btnZReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZReport.ForeColor = System.Drawing.Color.White;
            this.btnZReport.Location = new System.Drawing.Point(36, 192);
            this.btnZReport.Name = "btnZReport";
            this.btnZReport.Size = new System.Drawing.Size(190, 98);
            this.btnZReport.TabIndex = 2;
            this.btnZReport.Text = "Z RAPORU";
            this.btnZReport.UseVisualStyleBackColor = false;
            this.btnZReport.Click += new System.EventHandler(this.btnZReport_Click);
            // 
            // lblMonthlyReport
            // 
            this.lblMonthlyReport.AutoSize = true;
            this.lblMonthlyReport.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMonthlyReport.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyReport.Location = new System.Drawing.Point(565, 21);
            this.lblMonthlyReport.Name = "lblMonthlyReport";
            this.lblMonthlyReport.Size = new System.Drawing.Size(180, 29);
            this.lblMonthlyReport.TabIndex = 6;
            this.lblMonthlyReport.Text = "AYLIK RAPOR";
            // 
            // rpvZReport
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable2BindingSource;
            this.rpvZReport.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvZReport.LocalReport.ReportEmbeddedResource = "CafeOtomasyon.Report2.rdlc";
            this.rpvZReport.Location = new System.Drawing.Point(293, 62);
            this.rpvZReport.Name = "rpvZReport";
            this.rpvZReport.ServerReport.BearerToken = null;
            this.rpvZReport.Size = new System.Drawing.Size(644, 386);
            this.rpvZReport.TabIndex = 7;
            // 
            // rpvReport
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.DataTable1BindingSource;
            this.rpvReport.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvReport.LocalReport.ReportEmbeddedResource = "CafeOtomasyon.Report1.rdlc";
            this.rpvReport.Location = new System.Drawing.Point(293, 62);
            this.rpvReport.Name = "rpvReport";
            this.rpvReport.ServerReport.BearerToken = null;
            this.rpvReport.Size = new System.Drawing.Size(668, 386);
            this.rpvReport.TabIndex = 8;
            this.rpvReport.Load += new System.EventHandler(this.rpvReport_Load);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // frmCashTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 539);
            this.Controls.Add(this.rpvReport);
            this.Controls.Add(this.rpvZReport);
            this.Controls.Add(this.lblMonthlyReport);
            this.Controls.Add(this.btnZReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCashTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnZReport;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label lblMonthlyReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpvZReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReport;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1TableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
    }
}