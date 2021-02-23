namespace CafeOtomasyon
{
    partial class frmOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderControl));
            this.lvCustomerDetails = new System.Windows.Forms.ListView();
            this.CustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdditionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.SellId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblLastOrderDate = new System.Windows.Forms.Label();
            this.lvControl = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCustomerDetails
            // 
            this.lvCustomerDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerId,
            this.CustomerName,
            this.CustomerSurname,
            this.OrderDate,
            this.AdditionId});
            this.lvCustomerDetails.FullRowSelect = true;
            this.lvCustomerDetails.HideSelection = false;
            resources.ApplyResources(this.lvCustomerDetails, "lvCustomerDetails");
            this.lvCustomerDetails.Name = "lvCustomerDetails";
            this.lvCustomerDetails.UseCompatibleStateImageBehavior = false;
            this.lvCustomerDetails.View = System.Windows.Forms.View.Details;
            this.lvCustomerDetails.SelectedIndexChanged += new System.EventHandler(this.lvCustomerDetails_SelectedIndexChanged);
            // 
            // CustomerId
            // 
            resources.ApplyResources(this.CustomerId, "CustomerId");
            // 
            // CustomerName
            // 
            resources.ApplyResources(this.CustomerName, "CustomerName");
            // 
            // CustomerSurname
            // 
            resources.ApplyResources(this.CustomerSurname, "CustomerSurname");
            // 
            // OrderDate
            // 
            resources.ApplyResources(this.OrderDate, "OrderDate");
            // 
            // AdditionId
            // 
            resources.ApplyResources(this.AdditionId, "AdditionId");
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SellId,
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice});
            this.lvOrderDetails.FullRowSelect = true;
            this.lvOrderDetails.HideSelection = false;
            resources.ApplyResources(this.lvOrderDetails, "lvOrderDetails");
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // SellId
            // 
            resources.ApplyResources(this.SellId, "SellId");
            // 
            // ProductName
            // 
            resources.ApplyResources(this.ProductName, "ProductName");
            // 
            // ProductQuantity
            // 
            resources.ApplyResources(this.ProductQuantity, "ProductQuantity");
            // 
            // ProductPrice
            // 
            resources.ApplyResources(this.ProductPrice, "ProductPrice");
            // 
            // tbxTotalPrice
            // 
            this.tbxTotalPrice.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.tbxTotalPrice, "tbxTotalPrice");
            this.tbxTotalPrice.Name = "tbxTotalPrice";
            this.tbxTotalPrice.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // lblTotalOrder
            // 
            resources.ApplyResources(this.lblTotalOrder, "lblTotalOrder");
            this.lblTotalOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrder.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrder.Name = "lblTotalOrder";
            // 
            // lblLastOrderDate
            // 
            resources.ApplyResources(this.lblLastOrderDate, "lblLastOrderDate");
            this.lblLastOrderDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLastOrderDate.ForeColor = System.Drawing.Color.White;
            this.lblLastOrderDate.Name = "lblLastOrderDate";
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvControl.FullRowSelect = true;
            this.lvControl.GridLines = true;
            this.lvControl.HideSelection = false;
            resources.ApplyResources(this.lvControl, "lvControl");
            this.lvControl.Name = "lvControl";
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmOrderControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLastOrderDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTotalPrice);
            this.Controls.Add(this.lvControl);
            this.Controls.Add(this.lvOrderDetails);
            this.Controls.Add(this.lvCustomerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderControl";
            this.Load += new System.EventHandler(this.frmOrderControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCustomerDetails;
        private System.Windows.Forms.ColumnHeader CustomerId;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader CustomerSurname;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader AdditionId;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.ColumnHeader SellId;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductQuantity;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.TextBox tbxTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Label lblLastOrderDate;
        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}