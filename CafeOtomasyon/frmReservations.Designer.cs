namespace CafeOtomasyon
{
    partial class frmReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservations));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblStatement = new System.Windows.Forms.Label();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.lblGSM = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.tbxStatement = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxGSM = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxTable = new System.Windows.Forms.TextBox();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.tbxTableId = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnShowReservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(31, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 72);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(116, 462);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(51, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 20);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Tarih :";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(12, 120);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(98, 20);
            this.lblTable.TabIndex = 15;
            this.lblTable.Text = "Masa Seç :";
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.BackColor = System.Drawing.Color.Transparent;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatement.ForeColor = System.Drawing.Color.White;
            this.lblStatement.Location = new System.Drawing.Point(19, 185);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(91, 20);
            this.lblStatement.TabIndex = 15;
            this.lblStatement.Text = "Açıklama :";
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.lblCustomerSearch.Location = new System.Drawing.Point(572, 16);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(100, 24);
            this.lblCustomerSearch.TabIndex = 15;
            this.lblCustomerSearch.Text = "MÜŞTERİ";
            // 
            // lblGSM
            // 
            this.lblGSM.AutoSize = true;
            this.lblGSM.BackColor = System.Drawing.Color.Transparent;
            this.lblGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGSM.ForeColor = System.Drawing.Color.White;
            this.lblGSM.Location = new System.Drawing.Point(767, 16);
            this.lblGSM.Name = "lblGSM";
            this.lblGSM.Size = new System.Drawing.Size(106, 24);
            this.lblGSM.TabIndex = 15;
            this.lblGSM.Text = "TELEFON";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(971, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 24);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "ADRES";
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(322, 120);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(19, 28);
            this.cbTable.TabIndex = 1;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            this.cbTable.MouseEnter += new System.EventHandler(this.cbTable_MouseEnter);
            this.cbTable.MouseLeave += new System.EventHandler(this.cbTable_MouseLeave);
            // 
            // tbxStatement
            // 
            this.tbxStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStatement.Location = new System.Drawing.Point(116, 182);
            this.tbxStatement.Multiline = true;
            this.tbxStatement.Name = "tbxStatement";
            this.tbxStatement.Size = new System.Drawing.Size(161, 222);
            this.tbxStatement.TabIndex = 2;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCustomerName.Location = new System.Drawing.Point(575, 54);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(190, 28);
            this.tbxCustomerName.TabIndex = 3;
            this.tbxCustomerName.TextChanged += new System.EventHandler(this.tbxCustomerName_TextChanged);
            // 
            // tbxGSM
            // 
            this.tbxGSM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGSM.Location = new System.Drawing.Point(771, 54);
            this.tbxGSM.Name = "tbxGSM";
            this.tbxGSM.Size = new System.Drawing.Size(198, 28);
            this.tbxGSM.TabIndex = 4;
            this.tbxGSM.TextChanged += new System.EventHandler(this.tbxGSM_TextChanged);
            // 
            // tbxAddress
            // 
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAddress.Location = new System.Drawing.Point(975, 54);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(184, 28);
            this.tbxAddress.TabIndex = 5;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(575, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 61);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "MÜŞTERİ EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(866, 372);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(293, 61);
            this.btnAddReservation.TabIndex = 7;
            this.btnAddReservation.Text = "REZERVASYONU AÇ";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(575, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(285, 61);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "MÜŞTERİ GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxTable
            // 
            this.tbxTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTable.Location = new System.Drawing.Point(116, 120);
            this.tbxTable.Name = "tbxTable";
            this.tbxTable.ReadOnly = true;
            this.tbxTable.Size = new System.Drawing.Size(188, 22);
            this.tbxTable.TabIndex = 17;
            // 
            // tbxDate
            // 
            this.tbxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDate.Location = new System.Drawing.Point(116, 66);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.ReadOnly = true;
            this.tbxDate.Size = new System.Drawing.Size(188, 22);
            this.tbxDate.TabIndex = 0;
            this.tbxDate.TextChanged += new System.EventHandler(this.tbxDate_TextChanged);
            // 
            // tbxTableId
            // 
            this.tbxTableId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTableId.Location = new System.Drawing.Point(356, 120);
            this.tbxTableId.Name = "tbxTableId";
            this.tbxTableId.Size = new System.Drawing.Size(10, 26);
            this.tbxTableId.TabIndex = 17;
            this.tbxTableId.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDate.Location = new System.Drawing.Point(322, 65);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(19, 26);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.Enter += new System.EventHandler(this.dtpDate_Enter);
            this.dtpDate.MouseEnter += new System.EventHandler(this.dtpDate_MouseEnter);
            this.dtpDate.MouseLeave += new System.EventHandler(this.dtpDate_MouseLeave);
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.GridLines = true;
            this.lvCustomers.HideSelection = false;
            this.lvCustomers.Location = new System.Drawing.Point(575, 93);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(584, 273);
            this.lvCustomers.TabIndex = 18;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 226;
            // 
            // btnShowReservations
            // 
            this.btnShowReservations.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnShowReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowReservations.ForeColor = System.Drawing.Color.White;
            this.btnShowReservations.Location = new System.Drawing.Point(866, 439);
            this.btnShowReservations.Name = "btnShowReservations";
            this.btnShowReservations.Size = new System.Drawing.Size(293, 61);
            this.btnShowReservations.TabIndex = 8;
            this.btnShowReservations.Text = "REZERVASYONLARI GÖSTER";
            this.btnShowReservations.UseVisualStyleBackColor = false;
            this.btnShowReservations.Click += new System.EventHandler(this.btnShowReservations_Click_1);
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 573);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShowReservations);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxGSM);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.tbxTableId);
            this.Controls.Add(this.tbxTable);
            this.Controls.Add(this.tbxStatement);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGSM);
            this.Controls.Add(this.lblCustomerSearch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservations";
            this.Load += new System.EventHandler(this.frmReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Label lblCustomerSearch;
        private System.Windows.Forms.Label lblGSM;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.TextBox tbxStatement;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxGSM;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxTable;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.TextBox tbxTableId;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnShowReservations;
    }
}