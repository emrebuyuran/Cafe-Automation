namespace CafeOtomasyon
{
    partial class frmPackageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackageOrders));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxOrders = new System.Windows.Forms.GroupBox();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxMenuList = new System.Windows.Forms.GroupBox();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lvNewAdded = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxOrders.SuspendLayout();
            this.gbxMenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(27, 590);
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
            this.btnBack.Location = new System.Drawing.Point(112, 590);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.lvCustomers.Location = new System.Drawing.Point(473, 12);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(828, 295);
            this.lvCustomers.TabIndex = 15;
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
            // gbxOrders
            // 
            this.gbxOrders.BackColor = System.Drawing.Color.Transparent;
            this.gbxOrders.Controls.Add(this.lvOrders);
            this.gbxOrders.ForeColor = System.Drawing.Color.White;
            this.gbxOrders.Location = new System.Drawing.Point(763, 344);
            this.gbxOrders.Name = "gbxOrders";
            this.gbxOrders.Size = new System.Drawing.Size(284, 176);
            this.gbxOrders.TabIndex = 16;
            this.gbxOrders.TabStop = false;
            this.gbxOrders.Text = "Siparişler";
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(6, 19);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(272, 151);
            this.lvOrders.TabIndex = 2;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.DoubleClick += new System.EventHandler(this.lvOrders_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Adet";
            this.columnHeader7.Width = 64;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "UrunId";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün Fiyat";
            this.columnHeader9.Width = 123;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SatisId";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SilinenId";
            this.columnHeader11.Width = 0;
            // 
            // gbxMenuList
            // 
            this.gbxMenuList.BackColor = System.Drawing.Color.Transparent;
            this.gbxMenuList.Controls.Add(this.lvMenu);
            this.gbxMenuList.ForeColor = System.Drawing.Color.White;
            this.gbxMenuList.Location = new System.Drawing.Point(473, 344);
            this.gbxMenuList.Name = "gbxMenuList";
            this.gbxMenuList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxMenuList.Size = new System.Drawing.Size(284, 176);
            this.gbxMenuList.TabIndex = 17;
            this.gbxMenuList.TabStop = false;
            this.gbxMenuList.Text = "Menü";
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvMenu.FullRowSelect = true;
            this.lvMenu.GridLines = true;
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(6, 19);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvMenu.Size = new System.Drawing.Size(272, 151);
            this.lvMenu.TabIndex = 2;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            this.lvMenu.DoubleClick += new System.EventHandler(this.lvMenu_DoubleClick);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ürün Adı";
            this.columnHeader12.Width = 142;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ürün Fiyatı";
            this.columnHeader13.Width = 125;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ürün No";
            this.columnHeader14.Width = 0;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(1095, 344);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(177, 20);
            this.tbxQuantity.TabIndex = 29;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gold;
            this.btn9.Location = new System.Drawing.Point(1217, 488);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 49);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gold;
            this.btn6.Location = new System.Drawing.Point(1217, 433);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 49);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gold;
            this.btn3.Location = new System.Drawing.Point(1217, 378);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 49);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gold;
            this.btn0.Location = new System.Drawing.Point(1217, 542);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 49);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gold;
            this.btn8.Location = new System.Drawing.Point(1156, 488);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 49);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gold;
            this.btn5.Location = new System.Drawing.Point(1156, 433);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 49);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gold;
            this.btn2.Location = new System.Drawing.Point(1156, 378);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 49);
            this.btn2.TabIndex = 24;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(1095, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 49);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gold;
            this.btn7.Location = new System.Drawing.Point(1095, 488);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 49);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gold;
            this.btn4.Location = new System.Drawing.Point(1095, 433);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 49);
            this.btn4.TabIndex = 27;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.Location = new System.Drawing.Point(1095, 378);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 49);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(1095, 610);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 52);
            this.btnOrder.TabIndex = 30;
            this.btnOrder.Text = "SİPARİŞ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lvNewAdded
            // 
            this.lvNewAdded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.lvNewAdded.HideSelection = false;
            this.lvNewAdded.Location = new System.Drawing.Point(676, 526);
            this.lvNewAdded.Name = "lvNewAdded";
            this.lvNewAdded.Size = new System.Drawing.Size(127, 97);
            this.lvNewAdded.TabIndex = 32;
            this.lvNewAdded.UseCompatibleStateImageBehavior = false;
            this.lvNewAdded.View = System.Windows.Forms.View.Details;
            this.lvNewAdded.Visible = false;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "AdisyonId";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ürün Id";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Adet";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "MasaId";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "SilinenId";
            // 
            // frmPackageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 690);
            this.Controls.Add(this.lvNewAdded);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gbxOrders);
            this.Controls.Add(this.gbxMenuList);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPackageOrders";
            this.Load += new System.EventHandler(this.frmPackageOrders_Load);
            this.gbxOrders.ResumeLayout(false);
            this.gbxMenuList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbxOrders;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox gbxMenuList;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListView lvNewAdded;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}