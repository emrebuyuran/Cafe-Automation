namespace CafeOtomasyon
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblTableId = new System.Windows.Forms.Label();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxMenuList = new System.Windows.Forms.GroupBox();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxOrders = new System.Windows.Forms.GroupBox();
            this.tbxSearchById = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNewAdded = new System.Windows.Forms.ListView();
            this.gbxMenuList.SuspendLayout();
            this.gbxOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(25, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 81);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(115, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 81);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.Transparent;
            this.lblProductId.ForeColor = System.Drawing.Color.White;
            this.lblProductId.Location = new System.Drawing.Point(226, 36);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(53, 13);
            this.lblProductId.TabIndex = 3;
            this.lblProductId.Text = "Ürün No :";
            // 
            // lblTableId
            // 
            this.lblTableId.AutoSize = true;
            this.lblTableId.BackColor = System.Drawing.Color.Transparent;
            this.lblTableId.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTableId.ForeColor = System.Drawing.Color.White;
            this.lblTableId.Location = new System.Drawing.Point(34, 24);
            this.lblTableId.Name = "lblTableId";
            this.lblTableId.Size = new System.Drawing.Size(149, 39);
            this.lblTableId.TabIndex = 4;
            this.lblTableId.Text = "MASA 1";
            this.lblTableId.Click += new System.EventHandler(this.lblTableId_Click);
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
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
            this.lvMenu.SelectedIndexChanged += new System.EventHandler(this.lvMenu_SelectedIndexChanged);
            this.lvMenu.DoubleClick += new System.EventHandler(this.lvMenu_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyatı";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün No";
            this.columnHeader3.Width = 0;
            // 
            // gbxMenuList
            // 
            this.gbxMenuList.BackColor = System.Drawing.Color.Transparent;
            this.gbxMenuList.Controls.Add(this.lvMenu);
            this.gbxMenuList.ForeColor = System.Drawing.Color.White;
            this.gbxMenuList.Location = new System.Drawing.Point(472, 70);
            this.gbxMenuList.Name = "gbxMenuList";
            this.gbxMenuList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxMenuList.Size = new System.Drawing.Size(284, 176);
            this.gbxMenuList.TabIndex = 1;
            this.gbxMenuList.TabStop = false;
            this.gbxMenuList.Text = "Menü";
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9});
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(6, 19);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(272, 151);
            this.lvOrders.TabIndex = 2;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.SelectedIndexChanged += new System.EventHandler(this.lvOrders_SelectedIndexChanged);
            this.lvOrders.DoubleClick += new System.EventHandler(this.lvOrders_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Adı";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün Adet";
            this.columnHeader5.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UrunId";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Fiyat";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "SatisId";
            this.columnHeader8.Width = 1;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SilinenId";
            this.columnHeader9.Width = 0;
            // 
            // gbxOrders
            // 
            this.gbxOrders.BackColor = System.Drawing.Color.Transparent;
            this.gbxOrders.Controls.Add(this.lvOrders);
            this.gbxOrders.ForeColor = System.Drawing.Color.White;
            this.gbxOrders.Location = new System.Drawing.Point(472, 252);
            this.gbxOrders.Name = "gbxOrders";
            this.gbxOrders.Size = new System.Drawing.Size(284, 176);
            this.gbxOrders.TabIndex = 1;
            this.gbxOrders.TabStop = false;
            this.gbxOrders.Text = "Siparişler";
            // 
            // tbxSearchById
            // 
            this.tbxSearchById.Location = new System.Drawing.Point(300, 33);
            this.tbxSearchById.Name = "tbxSearchById";
            this.tbxSearchById.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchById.TabIndex = 2;
            this.tbxSearchById.TextChanged += new System.EventHandler(this.tbxSearchById_TextChanged);
            this.tbxSearchById.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearchById_KeyPress);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gold;
            this.btn1.Location = new System.Drawing.Point(819, 123);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 49);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Gold;
            this.btn4.Location = new System.Drawing.Point(819, 178);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 49);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Gold;
            this.btn7.Location = new System.Drawing.Point(819, 233);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 49);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(819, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 49);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gold;
            this.btn2.Location = new System.Drawing.Point(880, 123);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 49);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gold;
            this.btn5.Location = new System.Drawing.Point(880, 178);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 49);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Gold;
            this.btn8.Location = new System.Drawing.Point(880, 233);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 49);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Gold;
            this.btn0.Location = new System.Drawing.Point(941, 287);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 49);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gold;
            this.btn3.Location = new System.Drawing.Point(941, 123);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 49);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gold;
            this.btn6.Location = new System.Drawing.Point(941, 178);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 49);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Gold;
            this.btn9.Location = new System.Drawing.Point(941, 233);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 49);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(819, 89);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(177, 20);
            this.tbxQuantity.TabIndex = 6;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Red;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(758, 457);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(151, 52);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "ÖDEME";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(915, 457);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(153, 52);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "SİPARİŞ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "AdisyonId";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ürün Id";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Adet";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "MasaId";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "SilinenId";
            // 
            // lvNewAdded
            // 
            this.lvNewAdded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvNewAdded.HideSelection = false;
            this.lvNewAdded.Location = new System.Drawing.Point(544, 457);
            this.lvNewAdded.Name = "lvNewAdded";
            this.lvNewAdded.Size = new System.Drawing.Size(127, 97);
            this.lvNewAdded.TabIndex = 10;
            this.lvNewAdded.UseCompatibleStateImageBehavior = false;
            this.lvNewAdded.View = System.Windows.Forms.View.Details;
            this.lvNewAdded.Visible = false;
            this.lvNewAdded.SelectedIndexChanged += new System.EventHandler(this.lvNewAdded_SelectedIndexChanged);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 587);
            this.Controls.Add(this.lvNewAdded);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
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
            this.Controls.Add(this.lblTableId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.tbxSearchById);
            this.Controls.Add(this.gbxOrders);
            this.Controls.Add(this.gbxMenuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.gbxMenuList.ResumeLayout(false);
            this.gbxOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblTableId;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbxMenuList;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox gbxOrders;
        private System.Windows.Forms.TextBox tbxSearchById;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView lvNewAdded;
    }
}