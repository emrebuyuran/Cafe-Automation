using System;

namespace CafeOtomasyon
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxDiscount = new System.Windows.Forms.GroupBox();
            this.chbxDiscount = new System.Windows.Forms.CheckBox();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTL4 = new System.Windows.Forms.Label();
            this.lblTL3 = new System.Windows.Forms.Label();
            this.lblSubtotalAmount = new System.Windows.Forms.Label();
            this.lblDiscountPrice = new System.Windows.Forms.Label();
            this.lblTL2 = new System.Windows.Forms.Label();
            this.lblTL1 = new System.Windows.Forms.Label();
            this.lblTaxPrice = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbxPaymentType = new System.Windows.Forms.GroupBox();
            this.rbtnTicket = new System.Windows.Forms.RadioButton();
            this.rbtnCreditCard = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblAdditionId = new System.Windows.Forms.Label();
            this.gbxDiscountAmount = new System.Windows.Forms.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gbxDiscount.SuspendLayout();
            this.gbxPaymentDetails.SuspendLayout();
            this.gbxPaymentType.SuspendLayout();
            this.gbxDiscountAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(24, 63);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(465, 247);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunId";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SatisId";
            this.columnHeader5.Width = 90;
            // 
            // gbxDiscount
            // 
            this.gbxDiscount.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiscount.Controls.Add(this.chbxDiscount);
            this.gbxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDiscount.ForeColor = System.Drawing.Color.White;
            this.gbxDiscount.Location = new System.Drawing.Point(537, 63);
            this.gbxDiscount.Name = "gbxDiscount";
            this.gbxDiscount.Size = new System.Drawing.Size(272, 95);
            this.gbxDiscount.TabIndex = 1;
            this.gbxDiscount.TabStop = false;
            this.gbxDiscount.Text = "İndirim";
            // 
            // chbxDiscount
            // 
            this.chbxDiscount.AutoSize = true;
            this.chbxDiscount.Location = new System.Drawing.Point(17, 39);
            this.chbxDiscount.Name = "chbxDiscount";
            this.chbxDiscount.Size = new System.Drawing.Size(142, 24);
            this.chbxDiscount.TabIndex = 0;
            this.chbxDiscount.Text = "İndirim Uygula";
            this.chbxDiscount.UseVisualStyleBackColor = true;
            this.chbxDiscount.CheckedChanged += new System.EventHandler(this.chbxDiscount_CheckedChanged);
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.Location = new System.Drawing.Point(13, 46);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(143, 20);
            this.lblYuzde.TabIndex = 2;
            this.lblYuzde.Text = "İndirim Oranı (%)";
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(162, 46);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(99, 26);
            this.tbxDiscount.TabIndex = 1;
            this.tbxDiscount.TextChanged += new System.EventHandler(this.tbxDiscount_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(28, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 72);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(113, 589);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxPaymentDetails
            // 
            this.gbxPaymentDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbxPaymentDetails.Controls.Add(this.lblSubtotal);
            this.gbxPaymentDetails.Controls.Add(this.lblTL4);
            this.gbxPaymentDetails.Controls.Add(this.lblTL3);
            this.gbxPaymentDetails.Controls.Add(this.lblSubtotalAmount);
            this.gbxPaymentDetails.Controls.Add(this.lblDiscountPrice);
            this.gbxPaymentDetails.Controls.Add(this.lblTL2);
            this.gbxPaymentDetails.Controls.Add(this.lblTL1);
            this.gbxPaymentDetails.Controls.Add(this.lblTaxPrice);
            this.gbxPaymentDetails.Controls.Add(this.lblTotalAmount);
            this.gbxPaymentDetails.Controls.Add(this.lblDiscount);
            this.gbxPaymentDetails.Controls.Add(this.lblTax);
            this.gbxPaymentDetails.Controls.Add(this.lblPrice);
            this.gbxPaymentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxPaymentDetails.ForeColor = System.Drawing.Color.White;
            this.gbxPaymentDetails.Location = new System.Drawing.Point(24, 349);
            this.gbxPaymentDetails.Name = "gbxPaymentDetails";
            this.gbxPaymentDetails.Size = new System.Drawing.Size(309, 206);
            this.gbxPaymentDetails.TabIndex = 11;
            this.gbxPaymentDetails.TabStop = false;
            this.gbxPaymentDetails.Text = "Ödeme Detayı";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(20, 168);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 20);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Ara Toplam";
            // 
            // lblTL4
            // 
            this.lblTL4.AutoSize = true;
            this.lblTL4.Location = new System.Drawing.Point(261, 168);
            this.lblTL4.Name = "lblTL4";
            this.lblTL4.Size = new System.Drawing.Size(29, 20);
            this.lblTL4.TabIndex = 3;
            this.lblTL4.Text = "TL";
            // 
            // lblTL3
            // 
            this.lblTL3.AutoSize = true;
            this.lblTL3.Location = new System.Drawing.Point(261, 39);
            this.lblTL3.Name = "lblTL3";
            this.lblTL3.Size = new System.Drawing.Size(29, 20);
            this.lblTL3.TabIndex = 3;
            this.lblTL3.Text = "TL";
            // 
            // lblSubtotalAmount
            // 
            this.lblSubtotalAmount.AutoSize = true;
            this.lblSubtotalAmount.Location = new System.Drawing.Point(198, 168);
            this.lblSubtotalAmount.Name = "lblSubtotalAmount";
            this.lblSubtotalAmount.Size = new System.Drawing.Size(19, 20);
            this.lblSubtotalAmount.TabIndex = 3;
            this.lblSubtotalAmount.Text = "0";
            // 
            // lblDiscountPrice
            // 
            this.lblDiscountPrice.AutoSize = true;
            this.lblDiscountPrice.Location = new System.Drawing.Point(198, 39);
            this.lblDiscountPrice.Name = "lblDiscountPrice";
            this.lblDiscountPrice.Size = new System.Drawing.Size(19, 20);
            this.lblDiscountPrice.TabIndex = 3;
            this.lblDiscountPrice.Text = "0";
            this.lblDiscountPrice.TextChanged += new System.EventHandler(this.lblDiscountPrice_TextChanged);
            // 
            // lblTL2
            // 
            this.lblTL2.AutoSize = true;
            this.lblTL2.Location = new System.Drawing.Point(261, 84);
            this.lblTL2.Name = "lblTL2";
            this.lblTL2.Size = new System.Drawing.Size(29, 20);
            this.lblTL2.TabIndex = 3;
            this.lblTL2.Text = "TL";
            // 
            // lblTL1
            // 
            this.lblTL1.AutoSize = true;
            this.lblTL1.Location = new System.Drawing.Point(261, 127);
            this.lblTL1.Name = "lblTL1";
            this.lblTL1.Size = new System.Drawing.Size(29, 20);
            this.lblTL1.TabIndex = 3;
            this.lblTL1.Text = "TL";
            // 
            // lblTaxPrice
            // 
            this.lblTaxPrice.AutoSize = true;
            this.lblTaxPrice.Location = new System.Drawing.Point(198, 84);
            this.lblTaxPrice.Name = "lblTaxPrice";
            this.lblTaxPrice.Size = new System.Drawing.Size(19, 20);
            this.lblTaxPrice.TabIndex = 3;
            this.lblTaxPrice.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(198, 127);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(19, 20);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(20, 39);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(63, 20);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "İndirim";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(20, 84);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(97, 20);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "KDV (%18)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 125);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 20);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Fiyat";
            // 
            // gbxPaymentType
            // 
            this.gbxPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.gbxPaymentType.Controls.Add(this.rbtnTicket);
            this.gbxPaymentType.Controls.Add(this.rbtnCreditCard);
            this.gbxPaymentType.Controls.Add(this.rbtnCash);
            this.gbxPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxPaymentType.ForeColor = System.Drawing.Color.White;
            this.gbxPaymentType.Location = new System.Drawing.Point(352, 349);
            this.gbxPaymentType.Name = "gbxPaymentType";
            this.gbxPaymentType.Size = new System.Drawing.Size(227, 206);
            this.gbxPaymentType.TabIndex = 12;
            this.gbxPaymentType.TabStop = false;
            this.gbxPaymentType.Text = "Ödeme Türü";
            // 
            // rbtnTicket
            // 
            this.rbtnTicket.AutoSize = true;
            this.rbtnTicket.Location = new System.Drawing.Point(22, 127);
            this.rbtnTicket.Name = "rbtnTicket";
            this.rbtnTicket.Size = new System.Drawing.Size(75, 24);
            this.rbtnTicket.TabIndex = 2;
            this.rbtnTicket.TabStop = true;
            this.rbtnTicket.Text = "Ticket";
            this.rbtnTicket.UseVisualStyleBackColor = true;
            // 
            // rbtnCreditCard
            // 
            this.rbtnCreditCard.AutoSize = true;
            this.rbtnCreditCard.Location = new System.Drawing.Point(22, 84);
            this.rbtnCreditCard.Name = "rbtnCreditCard";
            this.rbtnCreditCard.Size = new System.Drawing.Size(110, 24);
            this.rbtnCreditCard.TabIndex = 1;
            this.rbtnCreditCard.TabStop = true;
            this.rbtnCreditCard.Text = "Kredi Kartı";
            this.rbtnCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(22, 39);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(68, 24);
            this.rbtnCash.TabIndex = 0;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Nakit";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCash_CheckedChanged);
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.Color.Green;
            this.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtract.ForeColor = System.Drawing.Color.White;
            this.btnExtract.Location = new System.Drawing.Point(691, 363);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(199, 74);
            this.btnExtract.TabIndex = 13;
            this.btnExtract.Text = "HESAP ÖZETİ";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Red;
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(691, 466);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(199, 71);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "ÖDEME AL";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrders.ForeColor = System.Drawing.Color.White;
            this.lblOrders.Location = new System.Drawing.Point(18, 18);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(137, 31);
            this.lblOrders.TabIndex = 15;
            this.lblOrders.Text = "Siparişler";
            // 
            // lblAdditionId
            // 
            this.lblAdditionId.AutoSize = true;
            this.lblAdditionId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdditionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdditionId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdditionId.Location = new System.Drawing.Point(197, 18);
            this.lblAdditionId.Name = "lblAdditionId";
            this.lblAdditionId.Size = new System.Drawing.Size(44, 31);
            this.lblAdditionId.TabIndex = 16;
            this.lblAdditionId.Text = "ID";
            this.lblAdditionId.Click += new System.EventHandler(this.lblAdditionId_Click);
            // 
            // gbxDiscountAmount
            // 
            this.gbxDiscountAmount.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiscountAmount.Controls.Add(this.lblYuzde);
            this.gbxDiscountAmount.Controls.Add(this.tbxDiscount);
            this.gbxDiscountAmount.Enabled = false;
            this.gbxDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxDiscountAmount.ForeColor = System.Drawing.Color.White;
            this.gbxDiscountAmount.Location = new System.Drawing.Point(537, 175);
            this.gbxDiscountAmount.Name = "gbxDiscountAmount";
            this.gbxDiscountAmount.Size = new System.Drawing.Size(272, 97);
            this.gbxDiscountAmount.TabIndex = 17;
            this.gbxDiscountAmount.TabStop = false;
            this.gbxDiscountAmount.Text = "İndirim Oranı";
            this.gbxDiscountAmount.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 716);
            this.Controls.Add(this.gbxDiscountAmount);
            this.Controls.Add(this.lblAdditionId);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.gbxPaymentType);
            this.Controls.Add(this.gbxPaymentDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxDiscount);
            this.Controls.Add(this.lvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.gbxDiscount.ResumeLayout(false);
            this.gbxDiscount.PerformLayout();
            this.gbxPaymentDetails.ResumeLayout(false);
            this.gbxPaymentDetails.PerformLayout();
            this.gbxPaymentType.ResumeLayout(false);
            this.gbxPaymentType.PerformLayout();
            this.gbxDiscountAmount.ResumeLayout(false);
            this.gbxDiscountAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.GroupBox gbxDiscount;
        private System.Windows.Forms.Label lblYuzde;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.CheckBox chbxDiscount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxPaymentDetails;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbxPaymentType;
        private System.Windows.Forms.RadioButton rbtnCreditCard;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTL3;
        private System.Windows.Forms.Label lblDiscountPrice;
        private System.Windows.Forms.Label lblTL2;
        private System.Windows.Forms.Label lblTL1;
        private System.Windows.Forms.Label lblTaxPrice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTL4;
        private System.Windows.Forms.Label lblSubtotalAmount;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblAdditionId;
        private System.Windows.Forms.GroupBox gbxDiscountAmount;
        private System.Windows.Forms.RadioButton rbtnTicket;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}