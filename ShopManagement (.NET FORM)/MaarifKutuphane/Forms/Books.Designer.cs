
namespace MaarifKutuphane.Forms
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DashboardLbl = new System.Windows.Forms.Panel();
            this.DashboardTB = new System.Windows.Forms.Label();
            this.UsersLbl = new System.Windows.Forms.Panel();
            this.UsersTB = new System.Windows.Forms.Label();
            this.BooksTB = new System.Windows.Forms.Label();
            this.BooksLbl = new System.Windows.Forms.Panel();
            this.ExitLbl = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.LogoLbl = new System.Windows.Forms.PictureBox();
            this.ShutDownLbl = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.Label();
            this.UserIconLbl = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MainTitleTB = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.CategoryFilterInpt = new System.Windows.Forms.ComboBox();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.RecordsDGVMainTitleTB = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BookCategoryInpt = new System.Windows.Forms.ComboBox();
            this.CategoryTB = new System.Windows.Forms.Label();
            this.BookPriceInpt = new System.Windows.Forms.TextBox();
            this.BookQuantityInpt = new System.Windows.Forms.TextBox();
            this.StockTB = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.Label();
            this.BookAuthorInpt = new System.Windows.Forms.TextBox();
            this.BookTittleInpt = new System.Windows.Forms.TextBox();
            this.BookNameTB = new System.Windows.Forms.Label();
            this.AuthorTB = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.DashboardLbl.SuspendLayout();
            this.UsersLbl.SuspendLayout();
            this.BooksLbl.SuspendLayout();
            this.ExitLbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLbl)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardLbl
            // 
            this.DashboardLbl.BackColor = System.Drawing.Color.Transparent;
            this.DashboardLbl.Controls.Add(this.DashboardTB);
            this.DashboardLbl.Location = new System.Drawing.Point(12, 332);
            this.DashboardLbl.Name = "DashboardLbl";
            this.DashboardLbl.Size = new System.Drawing.Size(224, 57);
            this.DashboardLbl.TabIndex = 20;
            // 
            // DashboardTB
            // 
            this.DashboardTB.AutoSize = true;
            this.DashboardTB.BackColor = System.Drawing.Color.Transparent;
            this.DashboardTB.Font = new System.Drawing.Font("Century", 14F);
            this.DashboardTB.ForeColor = System.Drawing.Color.White;
            this.DashboardTB.Location = new System.Drawing.Point(19, 14);
            this.DashboardTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashboardTB.Name = "DashboardTB";
            this.DashboardTB.Size = new System.Drawing.Size(190, 28);
            this.DashboardTB.TabIndex = 12;
            this.DashboardTB.Text = "Gösterge Paneli";
            this.DashboardTB.Click += new System.EventHandler(this.DashBoardLb_Click);
            // 
            // UsersLbl
            // 
            this.UsersLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsersLbl.Controls.Add(this.UsersTB);
            this.UsersLbl.Location = new System.Drawing.Point(12, 248);
            this.UsersLbl.Name = "UsersLbl";
            this.UsersLbl.Size = new System.Drawing.Size(224, 57);
            this.UsersLbl.TabIndex = 19;
            // 
            // UsersTB
            // 
            this.UsersTB.AutoSize = true;
            this.UsersTB.BackColor = System.Drawing.Color.Transparent;
            this.UsersTB.Font = new System.Drawing.Font("Century", 14F);
            this.UsersTB.ForeColor = System.Drawing.Color.White;
            this.UsersTB.Location = new System.Drawing.Point(40, 15);
            this.UsersTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsersTB.Name = "UsersTB";
            this.UsersTB.Size = new System.Drawing.Size(149, 28);
            this.UsersTB.TabIndex = 12;
            this.UsersTB.Text = "Kullanıcılar";
            this.UsersTB.Click += new System.EventHandler(this.UsersLb_Click);
            // 
            // BooksTB
            // 
            this.BooksTB.AutoSize = true;
            this.BooksTB.BackColor = System.Drawing.Color.Transparent;
            this.BooksTB.Font = new System.Drawing.Font("Century", 14F);
            this.BooksTB.ForeColor = System.Drawing.Color.White;
            this.BooksTB.Location = new System.Drawing.Point(61, 14);
            this.BooksTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BooksTB.Name = "BooksTB";
            this.BooksTB.Size = new System.Drawing.Size(107, 28);
            this.BooksTB.TabIndex = 12;
            this.BooksTB.Text = "Kitaplar";
            // 
            // BooksLbl
            // 
            this.BooksLbl.BackColor = System.Drawing.Color.Lime;
            this.BooksLbl.Controls.Add(this.BooksTB);
            this.BooksLbl.Location = new System.Drawing.Point(12, 163);
            this.BooksLbl.Name = "BooksLbl";
            this.BooksLbl.Size = new System.Drawing.Size(224, 57);
            this.BooksLbl.TabIndex = 18;
            // 
            // ExitLbl
            // 
            this.ExitLbl.BackColor = System.Drawing.Color.Transparent;
            this.ExitLbl.Controls.Add(this.ExitBtn);
            this.ExitLbl.Location = new System.Drawing.Point(12, 630);
            this.ExitLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(224, 57);
            this.ExitLbl.TabIndex = 17;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Century", 14F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(79, 14);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(70, 28);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Çıkış";
            this.ExitBtn.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // LogoLbl
            // 
            this.LogoLbl.Image = ((System.Drawing.Image)(resources.GetObject("LogoLbl.Image")));
            this.LogoLbl.Location = new System.Drawing.Point(57, 13);
            this.LogoLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoLbl.Name = "LogoLbl";
            this.LogoLbl.Size = new System.Drawing.Size(134, 94);
            this.LogoLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoLbl.TabIndex = 2;
            this.LogoLbl.TabStop = false;
            // 
            // ShutDownLbl
            // 
            this.ShutDownLbl.AutoSize = true;
            this.ShutDownLbl.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShutDownLbl.ForeColor = System.Drawing.Color.DimGray;
            this.ShutDownLbl.Location = new System.Drawing.Point(960, 13);
            this.ShutDownLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShutDownLbl.Name = "ShutDownLbl";
            this.ShutDownLbl.Size = new System.Drawing.Size(41, 40);
            this.ShutDownLbl.TabIndex = 34;
            this.ShutDownLbl.Text = "X";
            this.ShutDownLbl.Click += new System.EventHandler(this.ShutDownLbl_Click);
            // 
            // UserNameTB
            // 
            this.UserNameTB.AutoSize = true;
            this.UserNameTB.BackColor = System.Drawing.Color.White;
            this.UserNameTB.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameTB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UserNameTB.Location = new System.Drawing.Point(76, 24);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(141, 23);
            this.UserNameTB.TabIndex = 33;
            this.UserNameTB.Text = "Kullanıcı İsmi";
            // 
            // UserIconLbl
            // 
            this.UserIconLbl.Image = ((System.Drawing.Image)(resources.GetObject("UserIconLbl.Image")));
            this.UserIconLbl.Location = new System.Drawing.Point(8, 13);
            this.UserIconLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIconLbl.Name = "UserIconLbl";
            this.UserIconLbl.Size = new System.Drawing.Size(61, 40);
            this.UserIconLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIconLbl.TabIndex = 18;
            this.UserIconLbl.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(1228, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 40);
            this.label8.TabIndex = 11;
            this.label8.Text = "X";
            // 
            // MainTitleTB
            // 
            this.MainTitleTB.AutoSize = true;
            this.MainTitleTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainTitleTB.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.MainTitleTB.Location = new System.Drawing.Point(346, 13);
            this.MainTitleTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTitleTB.Name = "MainTitleTB";
            this.MainTitleTB.Size = new System.Drawing.Size(324, 40);
            this.MainTitleTB.TabIndex = 1;
            this.MainTitleTB.Text = "Kütüphane Sistemi";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.FilterBtn);
            this.MainPanel.Controls.Add(this.CategoryFilterInpt);
            this.MainPanel.Controls.Add(this.BookDGV);
            this.MainPanel.Controls.Add(this.RecordsDGVMainTitleTB);
            this.MainPanel.Controls.Add(this.ResetBtn);
            this.MainPanel.Controls.Add(this.DeleteBtn);
            this.MainPanel.Controls.Add(this.EditBtn);
            this.MainPanel.Controls.Add(this.SaveBtn);
            this.MainPanel.Controls.Add(this.BookCategoryInpt);
            this.MainPanel.Controls.Add(this.CategoryTB);
            this.MainPanel.Controls.Add(this.BookPriceInpt);
            this.MainPanel.Controls.Add(this.BookQuantityInpt);
            this.MainPanel.Controls.Add(this.StockTB);
            this.MainPanel.Controls.Add(this.PriceTB);
            this.MainPanel.Controls.Add(this.BookAuthorInpt);
            this.MainPanel.Controls.Add(this.BookTittleInpt);
            this.MainPanel.Controls.Add(this.BookNameTB);
            this.MainPanel.Controls.Add(this.AuthorTB);
            this.MainPanel.Controls.Add(this.ShutDownLbl);
            this.MainPanel.Controls.Add(this.UserNameTB);
            this.MainPanel.Controls.Add(this.UserIconLbl);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.MainTitleTB);
            this.MainPanel.Location = new System.Drawing.Point(254, 11);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1014, 698);
            this.MainPanel.TabIndex = 35;
            // 
            // FilterBtn
            // 
            this.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FilterBtn.Location = new System.Drawing.Point(485, 332);
            this.FilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(140, 29);
            this.FilterBtn.TabIndex = 65;
            this.FilterBtn.Text = "Yenile";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // CategoryFilterInpt
            // 
            this.CategoryFilterInpt.FormattingEnabled = true;
            this.CategoryFilterInpt.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Programlama",
            "Tarih",
            "Biyografi",
            "Kimya",
            "Biyoloji",
            "Gizem",
            "Korku",
            "Roman",
            "Macera"});
            this.CategoryFilterInpt.Location = new System.Drawing.Point(323, 336);
            this.CategoryFilterInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryFilterInpt.Name = "CategoryFilterInpt";
            this.CategoryFilterInpt.Size = new System.Drawing.Size(156, 25);
            this.CategoryFilterInpt.TabIndex = 64;
            this.CategoryFilterInpt.Text = "Kategori";
            // 
            // BookDGV
            // 
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Location = new System.Drawing.Point(3, 372);
            this.BookDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookDGV.MultiSelect = false;
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.BookDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century", 10F);
            this.BookDGV.RowTemplate.Height = 24;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(1008, 315);
            this.BookDGV.TabIndex = 63;
            // 
            // RecordsDGVMainTitleTB
            // 
            this.RecordsDGVMainTitleTB.AutoSize = true;
            this.RecordsDGVMainTitleTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RecordsDGVMainTitleTB.ForeColor = System.Drawing.Color.DimGray;
            this.RecordsDGVMainTitleTB.Location = new System.Drawing.Point(408, 290);
            this.RecordsDGVMainTitleTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecordsDGVMainTitleTB.Name = "RecordsDGVMainTitleTB";
            this.RecordsDGVMainTitleTB.Size = new System.Drawing.Size(149, 40);
            this.RecordsDGVMainTitleTB.TabIndex = 62;
            this.RecordsDGVMainTitleTB.Text = "Kayıtlar";
            // 
            // ResetBtn
            // 
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetBtn.Location = new System.Drawing.Point(632, 212);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(140, 35);
            this.ResetBtn.TabIndex = 61;
            this.ResetBtn.Text = "Sıfırla";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteBtn.Location = new System.Drawing.Point(485, 212);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(140, 35);
            this.DeleteBtn.TabIndex = 60;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditBtn.Location = new System.Drawing.Point(337, 212);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(140, 35);
            this.EditBtn.TabIndex = 59;
            this.EditBtn.Text = "Düzenle";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBtn.Location = new System.Drawing.Point(190, 212);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 35);
            this.SaveBtn.TabIndex = 58;
            this.SaveBtn.Text = "Kaydet";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BookCategoryInpt
            // 
            this.BookCategoryInpt.FormattingEnabled = true;
            this.BookCategoryInpt.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Programlama",
            "Tarih",
            "Biyografi",
            "Kimya",
            "Biyoloji",
            "Gizem",
            "Korku",
            "Roman",
            "Macera"});
            this.BookCategoryInpt.Location = new System.Drawing.Point(339, 139);
            this.BookCategoryInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookCategoryInpt.Name = "BookCategoryInpt";
            this.BookCategoryInpt.Size = new System.Drawing.Size(156, 25);
            this.BookCategoryInpt.TabIndex = 57;
            this.BookCategoryInpt.Text = "Seç";
            // 
            // CategoryTB
            // 
            this.CategoryTB.AutoSize = true;
            this.CategoryTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryTB.ForeColor = System.Drawing.Color.DimGray;
            this.CategoryTB.Location = new System.Drawing.Point(334, 107);
            this.CategoryTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(109, 28);
            this.CategoryTB.TabIndex = 56;
            this.CategoryTB.Text = "Kategori";
            // 
            // BookPriceInpt
            // 
            this.BookPriceInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookPriceInpt.Location = new System.Drawing.Point(663, 136);
            this.BookPriceInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookPriceInpt.Name = "BookPriceInpt";
            this.BookPriceInpt.Size = new System.Drawing.Size(156, 32);
            this.BookPriceInpt.TabIndex = 55;
            // 
            // BookQuantityInpt
            // 
            this.BookQuantityInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookQuantityInpt.Location = new System.Drawing.Point(500, 137);
            this.BookQuantityInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookQuantityInpt.Name = "BookQuantityInpt";
            this.BookQuantityInpt.Size = new System.Drawing.Size(156, 32);
            this.BookQuantityInpt.TabIndex = 54;
            // 
            // StockTB
            // 
            this.StockTB.AutoSize = true;
            this.StockTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StockTB.ForeColor = System.Drawing.Color.DimGray;
            this.StockTB.Location = new System.Drawing.Point(495, 107);
            this.StockTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockTB.Name = "StockTB";
            this.StockTB.Size = new System.Drawing.Size(62, 28);
            this.StockTB.TabIndex = 53;
            this.StockTB.Text = "Stok";
            // 
            // PriceTB
            // 
            this.PriceTB.AutoSize = true;
            this.PriceTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PriceTB.ForeColor = System.Drawing.Color.DimGray;
            this.PriceTB.Location = new System.Drawing.Point(658, 106);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(75, 28);
            this.PriceTB.TabIndex = 52;
            this.PriceTB.Text = "Ücret";
            // 
            // BookAuthorInpt
            // 
            this.BookAuthorInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookAuthorInpt.Location = new System.Drawing.Point(176, 137);
            this.BookAuthorInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookAuthorInpt.Name = "BookAuthorInpt";
            this.BookAuthorInpt.Size = new System.Drawing.Size(156, 32);
            this.BookAuthorInpt.TabIndex = 51;
            // 
            // BookTittleInpt
            // 
            this.BookTittleInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookTittleInpt.Location = new System.Drawing.Point(14, 137);
            this.BookTittleInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookTittleInpt.Name = "BookTittleInpt";
            this.BookTittleInpt.Size = new System.Drawing.Size(156, 32);
            this.BookTittleInpt.TabIndex = 50;
            // 
            // BookNameTB
            // 
            this.BookNameTB.AutoSize = true;
            this.BookNameTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookNameTB.ForeColor = System.Drawing.Color.DimGray;
            this.BookNameTB.Location = new System.Drawing.Point(9, 106);
            this.BookNameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookNameTB.Name = "BookNameTB";
            this.BookNameTB.Size = new System.Drawing.Size(132, 28);
            this.BookNameTB.TabIndex = 49;
            this.BookNameTB.Text = "Kitap İsmi";
            // 
            // AuthorTB
            // 
            this.AuthorTB.AutoSize = true;
            this.AuthorTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AuthorTB.ForeColor = System.Drawing.Color.DimGray;
            this.AuthorTB.Location = new System.Drawing.Point(171, 107);
            this.AuthorTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(78, 28);
            this.AuthorTB.TabIndex = 48;
            this.AuthorTB.Text = "Yazar";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.LeftPanel.Controls.Add(this.DashboardLbl);
            this.LeftPanel.Controls.Add(this.UsersLbl);
            this.LeftPanel.Controls.Add(this.BooksLbl);
            this.LeftPanel.Controls.Add(this.ExitLbl);
            this.LeftPanel.Controls.Add(this.LogoLbl);
            this.LeftPanel.Location = new System.Drawing.Point(12, 11);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(244, 698);
            this.LeftPanel.TabIndex = 36;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.DashboardLbl.ResumeLayout(false);
            this.DashboardLbl.PerformLayout();
            this.UsersLbl.ResumeLayout(false);
            this.UsersLbl.PerformLayout();
            this.BooksLbl.ResumeLayout(false);
            this.BooksLbl.PerformLayout();
            this.ExitLbl.ResumeLayout(false);
            this.ExitLbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLbl)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DashboardLbl;
        private System.Windows.Forms.Label DashboardTB;
        private System.Windows.Forms.Panel UsersLbl;
        private System.Windows.Forms.Label UsersTB;
        private System.Windows.Forms.Label BooksTB;
        private System.Windows.Forms.Panel BooksLbl;
        private System.Windows.Forms.Panel ExitLbl;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.PictureBox LogoLbl;
        private System.Windows.Forms.Label ShutDownLbl;
        private System.Windows.Forms.Label UserNameTB;
        private System.Windows.Forms.PictureBox UserIconLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MainTitleTB;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.ComboBox BookCategoryInpt;
        private System.Windows.Forms.Label CategoryTB;
        private System.Windows.Forms.TextBox BookPriceInpt;
        private System.Windows.Forms.TextBox BookQuantityInpt;
        private System.Windows.Forms.Label StockTB;
        private System.Windows.Forms.Label PriceTB;
        private System.Windows.Forms.TextBox BookAuthorInpt;
        private System.Windows.Forms.TextBox BookTittleInpt;
        private System.Windows.Forms.Label BookNameTB;
        private System.Windows.Forms.Label AuthorTB;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.ComboBox CategoryFilterInpt;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Label RecordsDGVMainTitleTB;
    }
}