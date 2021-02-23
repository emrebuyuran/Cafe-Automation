namespace CafeOtomasyon
{
    partial class frmKitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitchen));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFoodList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.tbxProductId = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.tbxCategoryId = new System.Windows.Forms.TextBox();
            this.tbxStatement = new System.Windows.Forms.TextBox();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.lblStatement = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.rbtnProduct = new System.Windows.Forms.RadioButton();
            this.rbtnCategory = new System.Windows.Forms.RadioButton();
            this.panelProduct.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(21, 635);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 72);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(106, 635);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvCategories
            // 
            this.lvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCategories.FullRowSelect = true;
            this.lvCategories.GridLines = true;
            this.lvCategories.HideSelection = false;
            this.lvCategories.Location = new System.Drawing.Point(297, 431);
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(381, 172);
            this.lvCategories.TabIndex = 15;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            this.lvCategories.View = System.Windows.Forms.View.Details;
            this.lvCategories.SelectedIndexChanged += new System.EventHandler(this.lvCategories_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CatId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori Adı";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.Width = 233;
            // 
            // lvFoodList
            // 
            this.lvFoodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFoodList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvFoodList.FullRowSelect = true;
            this.lvFoodList.GridLines = true;
            this.lvFoodList.HideSelection = false;
            this.lvFoodList.Location = new System.Drawing.Point(218, 431);
            this.lvFoodList.Name = "lvFoodList";
            this.lvFoodList.Size = new System.Drawing.Size(609, 172);
            this.lvFoodList.TabIndex = 15;
            this.lvFoodList.UseCompatibleStateImageBehavior = false;
            this.lvFoodList.View = System.Windows.Forms.View.Details;
            this.lvFoodList.SelectedIndexChanged += new System.EventHandler(this.lvFoodList_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Id";
            this.columnHeader4.Width = 1;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kategori Id";
            this.columnHeader5.Width = 1;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori";
            this.columnHeader6.Width = 175;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Adı";
            this.columnHeader7.Width = 230;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyatı";
            this.columnHeader8.Width = 197;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(119, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 59);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(315, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 59);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(509, 326);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(188, 59);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "BUL";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(703, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 59);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.Transparent;
            this.panelProduct.Controls.Add(this.tbxProductId);
            this.panelProduct.Controls.Add(this.tbxPrice);
            this.panelProduct.Controls.Add(this.tbxProductName);
            this.panelProduct.Controls.Add(this.cbxCategories);
            this.panelProduct.Controls.Add(this.lblPrice);
            this.panelProduct.Controls.Add(this.lblProductName);
            this.panelProduct.Controls.Add(this.lblCategory);
            this.panelProduct.Location = new System.Drawing.Point(218, 122);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(479, 135);
            this.panelProduct.TabIndex = 17;
            // 
            // tbxProductId
            // 
            this.tbxProductId.Location = new System.Drawing.Point(447, 52);
            this.tbxProductId.Name = "tbxProductId";
            this.tbxProductId.Size = new System.Drawing.Size(10, 20);
            this.tbxProductId.TabIndex = 49;
            this.tbxProductId.Visible = false;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPrice.Location = new System.Drawing.Point(227, 82);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(213, 24);
            this.tbxPrice.TabIndex = 5;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductName.Location = new System.Drawing.Point(227, 52);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(213, 24);
            this.tbxProductName.TabIndex = 4;
            // 
            // cbxCategories
            // 
            this.cbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(227, 17);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(213, 26);
            this.cbxCategories.TabIndex = 3;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(97, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(104, 18);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Ürün Fiyatı : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.ForeColor = System.Drawing.Color.Transparent;
            this.lblProductName.Location = new System.Drawing.Point(114, 55);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(87, 18);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı : ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.ForeColor = System.Drawing.Color.Transparent;
            this.lblCategory.Location = new System.Drawing.Point(66, 17);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(135, 18);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Ürün Kategorisi :";
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.Transparent;
            this.panelCategory.Controls.Add(this.tbxCategoryId);
            this.panelCategory.Controls.Add(this.tbxStatement);
            this.panelCategory.Controls.Add(this.tbxCategoryName);
            this.panelCategory.Controls.Add(this.lblStatement);
            this.panelCategory.Controls.Add(this.lblCategoryName);
            this.panelCategory.Location = new System.Drawing.Point(234, 91);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(712, 116);
            this.panelCategory.TabIndex = 17;
            // 
            // tbxCategoryId
            // 
            this.tbxCategoryId.Location = new System.Drawing.Point(430, 27);
            this.tbxCategoryId.Name = "tbxCategoryId";
            this.tbxCategoryId.Size = new System.Drawing.Size(10, 20);
            this.tbxCategoryId.TabIndex = 50;
            this.tbxCategoryId.Visible = false;
            // 
            // tbxStatement
            // 
            this.tbxStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStatement.Location = new System.Drawing.Point(210, 57);
            this.tbxStatement.Name = "tbxStatement";
            this.tbxStatement.Size = new System.Drawing.Size(213, 24);
            this.tbxStatement.TabIndex = 8;
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCategoryName.Location = new System.Drawing.Point(210, 23);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(213, 24);
            this.tbxCategoryName.TabIndex = 7;
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatement.ForeColor = System.Drawing.Color.Transparent;
            this.lblStatement.Location = new System.Drawing.Point(120, 60);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(91, 18);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "Açıklama : ";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.Location = new System.Drawing.Point(97, 30);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(114, 18);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Kategori Adı : ";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(190, 283);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(269, 18);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Aramak İstediğiniz Ürün/Kategori : ";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(465, 279);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(213, 26);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // rbtnProduct
            // 
            this.rbtnProduct.AutoSize = true;
            this.rbtnProduct.BackColor = System.Drawing.Color.Transparent;
            this.rbtnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnProduct.ForeColor = System.Drawing.Color.White;
            this.rbtnProduct.Location = new System.Drawing.Point(541, 29);
            this.rbtnProduct.Name = "rbtnProduct";
            this.rbtnProduct.Size = new System.Drawing.Size(157, 28);
            this.rbtnProduct.TabIndex = 1;
            this.rbtnProduct.Text = "Ürün İşlemleri";
            this.rbtnProduct.UseVisualStyleBackColor = false;
            this.rbtnProduct.CheckedChanged += new System.EventHandler(this.rbtnProduct_CheckedChanged);
            // 
            // rbtnCategory
            // 
            this.rbtnCategory.AutoSize = true;
            this.rbtnCategory.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnCategory.ForeColor = System.Drawing.Color.White;
            this.rbtnCategory.Location = new System.Drawing.Point(334, 29);
            this.rbtnCategory.Name = "rbtnCategory";
            this.rbtnCategory.Size = new System.Drawing.Size(189, 28);
            this.rbtnCategory.TabIndex = 0;
            this.rbtnCategory.Text = "Kategori İşlemleri";
            this.rbtnCategory.UseVisualStyleBackColor = false;
            this.rbtnCategory.CheckedChanged += new System.EventHandler(this.rbtnCategory_CheckedChanged);
            // 
            // frmKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 729);
            this.Controls.Add(this.rbtnCategory);
            this.Controls.Add(this.rbtnProduct);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvFoodList);
            this.Controls.Add(this.lvCategories);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKitchen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKitchen";
            this.Load += new System.EventHandler(this.frmKitchen_Load);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvFoodList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.TextBox tbxProductId;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.TextBox tbxCategoryId;
        private System.Windows.Forms.TextBox tbxStatement;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.RadioButton rbtnProduct;
        private System.Windows.Forms.RadioButton rbtnCategory;
    }
}