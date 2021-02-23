namespace CafeOtomasyon
{
    partial class frmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.gbxStatistics = new System.Windows.Forms.GroupBox();
            this.lvStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.gbxStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(583, 99);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(151, 20);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Başlangıç Tarihi : ";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(626, 140);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(108, 20);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "Bitiş Tarihi : ";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStart.Location = new System.Drawing.Point(761, 94);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(281, 26);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEnd.Location = new System.Drawing.Point(761, 135);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(281, 26);
            this.dtpEnd.TabIndex = 2;
            // 
            // gbxStatistics
            // 
            this.gbxStatistics.BackColor = System.Drawing.Color.Transparent;
            this.gbxStatistics.Controls.Add(this.lvStatistics);
            this.gbxStatistics.Controls.Add(this.chReport);
            this.gbxStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxStatistics.ForeColor = System.Drawing.Color.White;
            this.gbxStatistics.Location = new System.Drawing.Point(436, 195);
            this.gbxStatistics.Name = "gbxStatistics";
            this.gbxStatistics.Size = new System.Drawing.Size(653, 299);
            this.gbxStatistics.TabIndex = 4;
            this.gbxStatistics.TabStop = false;
            // 
            // lvStatistics
            // 
            this.lvStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvStatistics.HideSelection = false;
            this.lvStatistics.Location = new System.Drawing.Point(588, 91);
            this.lvStatistics.Name = "lvStatistics";
            this.lvStatistics.Size = new System.Drawing.Size(17, 14);
            this.lvStatistics.TabIndex = 1;
            this.lvStatistics.UseCompatibleStateImageBehavior = false;
            this.lvStatistics.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductName";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // chReport
            // 
            this.chReport.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chReport.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chReport.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chReport.Legends.Add(legend2);
            this.chReport.Location = new System.Drawing.Point(6, 19);
            this.chReport.Name = "chReport";
            this.chReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Satışlar";
            this.chReport.Series.Add(series2);
            this.chReport.Size = new System.Drawing.Size(641, 274);
            this.chReport.TabIndex = 0;
            this.chReport.Click += new System.EventHandler(this.chReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(22, 494);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 81);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(110, 494);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 81);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.BackColor = System.Drawing.Color.Crimson;
            this.btnAllProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllProducts.ForeColor = System.Drawing.Color.Snow;
            this.btnAllProducts.Location = new System.Drawing.Point(232, 434);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(186, 82);
            this.btnAllProducts.TabIndex = 4;
            this.btnAllProducts.Text = "TÜM ÜRÜNLER";
            this.btnAllProducts.UseVisualStyleBackColor = false;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 587);
            this.Controls.Add(this.btnAllProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxStatistics);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.gbxStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox gbxStatistics;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chReport;
        private System.Windows.Forms.ListView lvStatistics;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAllProducts;
    }
}