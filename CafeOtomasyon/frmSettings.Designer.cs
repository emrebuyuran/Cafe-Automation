namespace CafeOtomasyon
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxChangePasswordL = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangePasswordL = new System.Windows.Forms.Button();
            this.tbxPersonnelIdL = new System.Windows.Forms.TextBox();
            this.cbxPersonnel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewPasswordL = new System.Windows.Forms.TextBox();
            this.tbxPasswordL = new System.Windows.Forms.TextBox();
            this.gbxPersonnelAdd = new System.Windows.Forms.GroupBox();
            this.tbxPersonnelTask = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbxPersonnelTask = new System.Windows.Forms.ComboBox();
            this.tbxPersonnelIdM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxNewPasswordM = new System.Windows.Forms.TextBox();
            this.tbxPasswordM = new System.Windows.Forms.TextBox();
            this.gbxChangePasswordR = new System.Windows.Forms.GroupBox();
            this.btnChangePasswordR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNewPasswordR = new System.Windows.Forms.TextBox();
            this.tbxPasswordR = new System.Windows.Forms.TextBox();
            this.lvPersonnels = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxPersonnelList = new System.Windows.Forms.GroupBox();
            this.lblSignInfo = new System.Windows.Forms.Label();
            this.gbxChangePasswordL.SuspendLayout();
            this.gbxPersonnelAdd.SuspendLayout();
            this.gbxChangePasswordR.SuspendLayout();
            this.gbxPersonnelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(34, 643);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 72);
            this.btnExit.TabIndex = 19;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(119, 643);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 72);
            this.btnBack.TabIndex = 18;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxChangePasswordL
            // 
            this.gbxChangePasswordL.BackColor = System.Drawing.Color.Transparent;
            this.gbxChangePasswordL.Controls.Add(this.label10);
            this.gbxChangePasswordL.Controls.Add(this.btnChangePasswordL);
            this.gbxChangePasswordL.Controls.Add(this.tbxPersonnelIdL);
            this.gbxChangePasswordL.Controls.Add(this.cbxPersonnel);
            this.gbxChangePasswordL.Controls.Add(this.label2);
            this.gbxChangePasswordL.Controls.Add(this.label1);
            this.gbxChangePasswordL.Controls.Add(this.tbxNewPasswordL);
            this.gbxChangePasswordL.Controls.Add(this.tbxPasswordL);
            this.gbxChangePasswordL.Location = new System.Drawing.Point(34, 70);
            this.gbxChangePasswordL.Name = "gbxChangePasswordL";
            this.gbxChangePasswordL.Size = new System.Drawing.Size(314, 285);
            this.gbxChangePasswordL.TabIndex = 15;
            this.gbxChangePasswordL.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Personel :";
            // 
            // btnChangePasswordL
            // 
            this.btnChangePasswordL.BackColor = System.Drawing.Color.DarkGreen;
            this.btnChangePasswordL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePasswordL.ForeColor = System.Drawing.Color.White;
            this.btnChangePasswordL.Location = new System.Drawing.Point(127, 207);
            this.btnChangePasswordL.Name = "btnChangePasswordL";
            this.btnChangePasswordL.Size = new System.Drawing.Size(165, 51);
            this.btnChangePasswordL.TabIndex = 2;
            this.btnChangePasswordL.Text = "ŞİFREYİ YENİLE";
            this.btnChangePasswordL.UseVisualStyleBackColor = false;
            this.btnChangePasswordL.Click += new System.EventHandler(this.btnChangePasswordL_Click);
            // 
            // tbxPersonnelIdL
            // 
            this.tbxPersonnelIdL.Location = new System.Drawing.Point(197, 57);
            this.tbxPersonnelIdL.Name = "tbxPersonnelIdL";
            this.tbxPersonnelIdL.Size = new System.Drawing.Size(11, 20);
            this.tbxPersonnelIdL.TabIndex = 4;
            this.tbxPersonnelIdL.TabStop = false;
            this.tbxPersonnelIdL.Visible = false;
            // 
            // cbxPersonnel
            // 
            this.cbxPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPersonnel.FormattingEnabled = true;
            this.cbxPersonnel.Location = new System.Drawing.Point(127, 20);
            this.cbxPersonnel.Name = "cbxPersonnel";
            this.cbxPersonnel.Size = new System.Drawing.Size(165, 28);
            this.cbxPersonnel.TabIndex = 14;
            this.cbxPersonnel.SelectedIndexChanged += new System.EventHandler(this.cbxPersonnel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Şifre Tekrar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yeni Şifre :";
            // 
            // tbxNewPasswordL
            // 
            this.tbxNewPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbxNewPasswordL.Location = new System.Drawing.Point(127, 151);
            this.tbxNewPasswordL.Name = "tbxNewPasswordL";
            this.tbxNewPasswordL.Size = new System.Drawing.Size(165, 29);
            this.tbxNewPasswordL.TabIndex = 1;
            // 
            // tbxPasswordL
            // 
            this.tbxPasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbxPasswordL.Location = new System.Drawing.Point(127, 108);
            this.tbxPasswordL.Name = "tbxPasswordL";
            this.tbxPasswordL.Size = new System.Drawing.Size(165, 29);
            this.tbxPasswordL.TabIndex = 0;
            // 
            // gbxPersonnelAdd
            // 
            this.gbxPersonnelAdd.BackColor = System.Drawing.Color.Transparent;
            this.gbxPersonnelAdd.Controls.Add(this.tbxPersonnelTask);
            this.gbxPersonnelAdd.Controls.Add(this.btnUpdate);
            this.gbxPersonnelAdd.Controls.Add(this.btnAdd);
            this.gbxPersonnelAdd.Controls.Add(this.btnDelete);
            this.gbxPersonnelAdd.Controls.Add(this.btnNew);
            this.gbxPersonnelAdd.Controls.Add(this.cbxPersonnelTask);
            this.gbxPersonnelAdd.Controls.Add(this.tbxPersonnelIdM);
            this.gbxPersonnelAdd.Controls.Add(this.label6);
            this.gbxPersonnelAdd.Controls.Add(this.label7);
            this.gbxPersonnelAdd.Controls.Add(this.label3);
            this.gbxPersonnelAdd.Controls.Add(this.label5);
            this.gbxPersonnelAdd.Controls.Add(this.label4);
            this.gbxPersonnelAdd.Controls.Add(this.tbxSurname);
            this.gbxPersonnelAdd.Controls.Add(this.tbxName);
            this.gbxPersonnelAdd.Controls.Add(this.tbxNewPasswordM);
            this.gbxPersonnelAdd.Controls.Add(this.tbxPasswordM);
            this.gbxPersonnelAdd.Location = new System.Drawing.Point(415, 70);
            this.gbxPersonnelAdd.Name = "gbxPersonnelAdd";
            this.gbxPersonnelAdd.Size = new System.Drawing.Size(439, 438);
            this.gbxPersonnelAdd.TabIndex = 16;
            this.gbxPersonnelAdd.TabStop = false;
            // 
            // tbxPersonnelTask
            // 
            this.tbxPersonnelTask.Location = new System.Drawing.Point(387, 204);
            this.tbxPersonnelTask.Name = "tbxPersonnelTask";
            this.tbxPersonnelTask.Size = new System.Drawing.Size(15, 20);
            this.tbxPersonnelTask.TabIndex = 10;
            this.tbxPersonnelTask.TabStop = false;
            this.tbxPersonnelTask.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(221, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 66);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(221, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 66);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "KAYDET";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(73, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 66);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(73, 284);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 66);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "YENİ";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbxPersonnelTask
            // 
            this.cbxPersonnelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPersonnelTask.FormattingEnabled = true;
            this.cbxPersonnelTask.Location = new System.Drawing.Point(195, 204);
            this.cbxPersonnelTask.Name = "cbxPersonnelTask";
            this.cbxPersonnelTask.Size = new System.Drawing.Size(165, 28);
            this.cbxPersonnelTask.TabIndex = 15;
            this.cbxPersonnelTask.SelectedIndexChanged += new System.EventHandler(this.cbxPersonnelTask_SelectedIndexChanged);
            // 
            // tbxPersonnelIdM
            // 
            this.tbxPersonnelIdM.Location = new System.Drawing.Point(387, 18);
            this.tbxPersonnelIdM.Name = "tbxPersonnelIdM";
            this.tbxPersonnelIdM.Size = new System.Drawing.Size(16, 20);
            this.tbxPersonnelIdM.TabIndex = 7;
            this.tbxPersonnelIdM.TabStop = false;
            this.tbxPersonnelIdM.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(139, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Soyad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(137, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Görevi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre :";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSurname.Location = new System.Drawing.Point(195, 61);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(165, 26);
            this.tbxSurname.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxName.Location = new System.Drawing.Point(195, 18);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(165, 26);
            this.tbxName.TabIndex = 3;
            // 
            // tbxNewPasswordM
            // 
            this.tbxNewPasswordM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNewPasswordM.Location = new System.Drawing.Point(195, 148);
            this.tbxNewPasswordM.Name = "tbxNewPasswordM";
            this.tbxNewPasswordM.Size = new System.Drawing.Size(165, 26);
            this.tbxNewPasswordM.TabIndex = 6;
            // 
            // tbxPasswordM
            // 
            this.tbxPasswordM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPasswordM.Location = new System.Drawing.Point(195, 105);
            this.tbxPasswordM.Name = "tbxPasswordM";
            this.tbxPasswordM.Size = new System.Drawing.Size(165, 26);
            this.tbxPasswordM.TabIndex = 5;
            // 
            // gbxChangePasswordR
            // 
            this.gbxChangePasswordR.BackColor = System.Drawing.Color.Transparent;
            this.gbxChangePasswordR.Controls.Add(this.btnChangePasswordR);
            this.gbxChangePasswordR.Controls.Add(this.label8);
            this.gbxChangePasswordR.Controls.Add(this.label9);
            this.gbxChangePasswordR.Controls.Add(this.tbxNewPasswordR);
            this.gbxChangePasswordR.Controls.Add(this.tbxPasswordR);
            this.gbxChangePasswordR.Location = new System.Drawing.Point(488, 43);
            this.gbxChangePasswordR.Name = "gbxChangePasswordR";
            this.gbxChangePasswordR.Size = new System.Drawing.Size(314, 285);
            this.gbxChangePasswordR.TabIndex = 15;
            this.gbxChangePasswordR.TabStop = false;
            // 
            // btnChangePasswordR
            // 
            this.btnChangePasswordR.BackColor = System.Drawing.Color.DarkGreen;
            this.btnChangePasswordR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePasswordR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePasswordR.ForeColor = System.Drawing.Color.White;
            this.btnChangePasswordR.Location = new System.Drawing.Point(127, 207);
            this.btnChangePasswordR.Name = "btnChangePasswordR";
            this.btnChangePasswordR.Size = new System.Drawing.Size(165, 51);
            this.btnChangePasswordR.TabIndex = 13;
            this.btnChangePasswordR.Text = "ŞİFREYİ YENİLE";
            this.btnChangePasswordR.UseVisualStyleBackColor = false;
            this.btnChangePasswordR.Click += new System.EventHandler(this.btnChangePasswordR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Yeni Şifre Tekrar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(51, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yeni Şifre :";
            // 
            // tbxNewPasswordR
            // 
            this.tbxNewPasswordR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbxNewPasswordR.Location = new System.Drawing.Point(127, 151);
            this.tbxNewPasswordR.Name = "tbxNewPasswordR";
            this.tbxNewPasswordR.Size = new System.Drawing.Size(165, 29);
            this.tbxNewPasswordR.TabIndex = 12;
            // 
            // tbxPasswordR
            // 
            this.tbxPasswordR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbxPasswordR.Location = new System.Drawing.Point(127, 108);
            this.tbxPasswordR.Name = "tbxPasswordR";
            this.tbxPasswordR.Size = new System.Drawing.Size(165, 29);
            this.tbxPasswordR.TabIndex = 11;
            // 
            // lvPersonnels
            // 
            this.lvPersonnels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPersonnels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvPersonnels.FullRowSelect = true;
            this.lvPersonnels.HideSelection = false;
            this.lvPersonnels.Location = new System.Drawing.Point(6, 25);
            this.lvPersonnels.Name = "lvPersonnels";
            this.lvPersonnels.Size = new System.Drawing.Size(456, 176);
            this.lvPersonnels.TabIndex = 17;
            this.lvPersonnels.UseCompatibleStateImageBehavior = false;
            this.lvPersonnels.View = System.Windows.Forms.View.Details;
            this.lvPersonnels.SelectedIndexChanged += new System.EventHandler(this.lvPersonnels_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PersonnelId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PersonnelTaskId";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Görevi";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adı";
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyadı";
            this.columnHeader5.Width = 146;
            // 
            // gbxPersonnelList
            // 
            this.gbxPersonnelList.BackColor = System.Drawing.Color.Transparent;
            this.gbxPersonnelList.Controls.Add(this.lvPersonnels);
            this.gbxPersonnelList.Location = new System.Drawing.Point(392, 514);
            this.gbxPersonnelList.Name = "gbxPersonnelList";
            this.gbxPersonnelList.Size = new System.Drawing.Size(472, 209);
            this.gbxPersonnelList.TabIndex = 20;
            this.gbxPersonnelList.TabStop = false;
            // 
            // lblSignInfo
            // 
            this.lblSignInfo.AutoSize = true;
            this.lblSignInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSignInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignInfo.ForeColor = System.Drawing.Color.White;
            this.lblSignInfo.Location = new System.Drawing.Point(34, 27);
            this.lblSignInfo.Name = "lblSignInfo";
            this.lblSignInfo.Size = new System.Drawing.Size(103, 20);
            this.lblSignInfo.TabIndex = 21;
            this.lblSignInfo.Text = "Giriş Yapan";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 745);
            this.Controls.Add(this.lblSignInfo);
            this.Controls.Add(this.gbxPersonnelList);
            this.Controls.Add(this.gbxPersonnelAdd);
            this.Controls.Add(this.gbxChangePasswordR);
            this.Controls.Add(this.gbxChangePasswordL);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbxChangePasswordL.ResumeLayout(false);
            this.gbxChangePasswordL.PerformLayout();
            this.gbxPersonnelAdd.ResumeLayout(false);
            this.gbxPersonnelAdd.PerformLayout();
            this.gbxChangePasswordR.ResumeLayout(false);
            this.gbxChangePasswordR.PerformLayout();
            this.gbxPersonnelList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxChangePasswordL;
        private System.Windows.Forms.Button btnChangePasswordL;
        private System.Windows.Forms.TextBox tbxPersonnelIdL;
        private System.Windows.Forms.ComboBox cbxPersonnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewPasswordL;
        private System.Windows.Forms.TextBox tbxPasswordL;
        private System.Windows.Forms.GroupBox gbxPersonnelAdd;
        private System.Windows.Forms.TextBox tbxPersonnelIdM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxNewPasswordM;
        private System.Windows.Forms.TextBox tbxPasswordM;
        private System.Windows.Forms.TextBox tbxPersonnelTask;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbxPersonnelTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxChangePasswordR;
        private System.Windows.Forms.Button btnChangePasswordR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxNewPasswordR;
        private System.Windows.Forms.TextBox tbxPasswordR;
        private System.Windows.Forms.ListView lvPersonnels;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbxPersonnelList;
        private System.Windows.Forms.Label lblSignInfo;
        private System.Windows.Forms.Label label10;
    }
}