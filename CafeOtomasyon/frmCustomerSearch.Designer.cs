namespace CafeOtomasyon
{
    partial class frmCustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerSearch));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxBillId = new System.Windows.Forms.TextBox();
            this.lblGSM = new System.Windows.Forms.Label();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBillId = new System.Windows.Forms.Label();
            this.tbxGSM = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(111, 320);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ADI :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(74, 358);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(87, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "SOYADI :";
            // 
            // tbxBillId
            // 
            this.tbxBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBillId.Location = new System.Drawing.Point(177, 422);
            this.tbxBillId.Multiline = true;
            this.tbxBillId.Name = "tbxBillId";
            this.tbxBillId.Size = new System.Drawing.Size(117, 32);
            this.tbxBillId.TabIndex = 3;
            this.tbxBillId.TextChanged += new System.EventHandler(this.tbxBillId_TextChanged);
            // 
            // lblGSM
            // 
            this.lblGSM.AutoSize = true;
            this.lblGSM.BackColor = System.Drawing.Color.Transparent;
            this.lblGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGSM.ForeColor = System.Drawing.Color.White;
            this.lblGSM.Location = new System.Drawing.Point(62, 396);
            this.lblGSM.Name = "lblGSM";
            this.lblGSM.Size = new System.Drawing.Size(99, 20);
            this.lblGSM.TabIndex = 1;
            this.lblGSM.Text = "TELEFON :";
            // 
            // tbxAdress
            // 
            this.tbxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdress.Location = new System.Drawing.Point(406, 306);
            this.tbxAdress.Multiline = true;
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(281, 150);
            this.tbxAdress.TabIndex = 4;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.ForeColor = System.Drawing.Color.White;
            this.lblAdress.Location = new System.Drawing.Point(310, 306);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(81, 20);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "ADRES :";
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
            this.lvCustomers.Location = new System.Drawing.Point(36, 44);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(828, 213);
            this.lvCustomers.TabIndex = 2;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri No";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 302;
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.BackColor = System.Drawing.Color.Transparent;
            this.lblBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillId.ForeColor = System.Drawing.Color.White;
            this.lblBillId.Location = new System.Drawing.Point(32, 434);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(129, 20);
            this.lblBillId.TabIndex = 1;
            this.lblBillId.Text = "ADİSYON NO :";
            // 
            // tbxGSM
            // 
            this.tbxGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGSM.Location = new System.Drawing.Point(177, 384);
            this.tbxGSM.Multiline = true;
            this.tbxGSM.Name = "tbxGSM";
            this.tbxGSM.Size = new System.Drawing.Size(117, 32);
            this.tbxGSM.TabIndex = 2;
            this.tbxGSM.TextChanged += new System.EventHandler(this.tbxGSM_TextChanged);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSurname.Location = new System.Drawing.Point(177, 346);
            this.tbxSurname.Multiline = true;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(117, 32);
            this.tbxSurname.TabIndex = 1;
            this.tbxSurname.TextChanged += new System.EventHandler(this.tbxSurname_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(177, 308);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(117, 32);
            this.tbxName.TabIndex = 0;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Green;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(216, 483);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(135, 63);
            this.btnAddNewCustomer.TabIndex = 5;
            this.btnAddNewCustomer.Text = "YENİ MÜŞTERİ EKLE";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(404, 483);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(135, 63);
            this.btnUpdateCustomer.TabIndex = 6;
            this.btnUpdateCustomer.Text = "MÜŞTERİ GÜNCELLE";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Blue;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(714, 329);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(150, 87);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "PAKET SİPARİŞLER";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(36, 583);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 72);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(121, 583);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 667);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblBillId);
            this.Controls.Add(this.lblGSM);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxGSM);
            this.Controls.Add(this.tbxBillId);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.frmCustomerSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxBillId;
        private System.Windows.Forms.Label lblGSM;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.TextBox tbxGSM;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}