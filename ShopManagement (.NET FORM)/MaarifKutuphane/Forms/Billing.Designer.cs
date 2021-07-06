
namespace MaarifKutuphane.Forms
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogoLbl = new System.Windows.Forms.PictureBox();
            this.ExitTB = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BookQuantityInpt = new System.Windows.Forms.TextBox();
            this.BookTittleInpt = new System.Windows.Forms.TextBox();
            this.FormName1TB = new System.Windows.Forms.Label();
            this.FormName2TB = new System.Windows.Forms.Label();
            this.MainTitleTB = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitTBL = new System.Windows.Forms.Panel();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShutDownLbl = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.Label();
            this.UserIconLbl = new System.Windows.Forms.PictureBox();
            this.totalBillTB = new System.Windows.Forms.Label();
            this.BookDGNameTB = new System.Windows.Forms.Label();
            this.BookDGV = new System.Windows.Forms.DataGridView();
            this.BillDGNameTB = new System.Windows.Forms.Label();
            this.BookPriceInpt = new System.Windows.Forms.TextBox();
            this.ClientNameInpt = new System.Windows.Forms.TextBox();
            this.FormName3TB = new System.Windows.Forms.Label();
            this.FormName4TB = new System.Windows.Forms.Label();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TCTB = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).BeginInit();
            this.ExitTBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoLbl
            // 
            this.LogoLbl.Image = ((System.Drawing.Image)(resources.GetObject("LogoLbl.Image")));
            this.LogoLbl.Location = new System.Drawing.Point(52, 13);
            this.LogoLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoLbl.Name = "LogoLbl";
            this.LogoLbl.Size = new System.Drawing.Size(134, 94);
            this.LogoLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoLbl.TabIndex = 2;
            this.LogoLbl.TabStop = false;
            // 
            // ExitTB
            // 
            this.ExitTB.AutoSize = true;
            this.ExitTB.BackColor = System.Drawing.Color.Transparent;
            this.ExitTB.Font = new System.Drawing.Font("Century", 14F);
            this.ExitTB.ForeColor = System.Drawing.Color.White;
            this.ExitTB.Location = new System.Drawing.Point(74, 14);
            this.ExitTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitTB.Name = "ExitTB";
            this.ExitTB.Size = new System.Drawing.Size(70, 28);
            this.ExitTB.TabIndex = 12;
            this.ExitTB.Text = "Çıkış";
            this.ExitTB.Click += new System.EventHandler(this.ExitLb_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetBtn.Location = new System.Drawing.Point(283, 215);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(140, 35);
            this.ResetBtn.TabIndex = 20;
            this.ResetBtn.Text = "Sıfırla";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PrintBtn.Location = new System.Drawing.Point(681, 391);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(140, 35);
            this.PrintBtn.TabIndex = 18;
            this.PrintBtn.Text = "Yazdır";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
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
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBtn.Location = new System.Drawing.Point(136, 215);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 35);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Faturaya ekle";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BookQuantityInpt
            // 
            this.BookQuantityInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookQuantityInpt.Location = new System.Drawing.Point(191, 154);
            this.BookQuantityInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookQuantityInpt.Name = "BookQuantityInpt";
            this.BookQuantityInpt.Size = new System.Drawing.Size(156, 32);
            this.BookQuantityInpt.TabIndex = 8;
            // 
            // BookTittleInpt
            // 
            this.BookTittleInpt.Enabled = false;
            this.BookTittleInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookTittleInpt.Location = new System.Drawing.Point(29, 154);
            this.BookTittleInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookTittleInpt.Name = "BookTittleInpt";
            this.BookTittleInpt.Size = new System.Drawing.Size(156, 32);
            this.BookTittleInpt.TabIndex = 7;
            // 
            // FormName1TB
            // 
            this.FormName1TB.AutoSize = true;
            this.FormName1TB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormName1TB.ForeColor = System.Drawing.Color.DimGray;
            this.FormName1TB.Location = new System.Drawing.Point(25, 124);
            this.FormName1TB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName1TB.Name = "FormName1TB";
            this.FormName1TB.Size = new System.Drawing.Size(132, 28);
            this.FormName1TB.TabIndex = 6;
            this.FormName1TB.Text = "Kitap İsmi";
            // 
            // FormName2TB
            // 
            this.FormName2TB.AutoSize = true;
            this.FormName2TB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormName2TB.ForeColor = System.Drawing.Color.DimGray;
            this.FormName2TB.Location = new System.Drawing.Point(186, 124);
            this.FormName2TB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName2TB.Name = "FormName2TB";
            this.FormName2TB.Size = new System.Drawing.Size(64, 28);
            this.FormName2TB.TabIndex = 5;
            this.FormName2TB.Text = "Adet";
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
            // Column5
            // 
            this.Column5.HeaderText = "Toplam";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adet";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ücret";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // ExitTBL
            // 
            this.ExitTBL.BackColor = System.Drawing.Color.Transparent;
            this.ExitTBL.Controls.Add(this.ExitTB);
            this.ExitTBL.Location = new System.Drawing.Point(12, 630);
            this.ExitTBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitTBL.Name = "ExitTBL";
            this.ExitTBL.Size = new System.Drawing.Size(224, 57);
            this.ExitTBL.TabIndex = 17;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitaplar";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
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
            this.ShutDownLbl.Click += new System.EventHandler(this.ShutDown_Click);
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
            // totalBillTB
            // 
            this.totalBillTB.AutoSize = true;
            this.totalBillTB.Font = new System.Drawing.Font("Century", 14F);
            this.totalBillTB.ForeColor = System.Drawing.Color.DimGray;
            this.totalBillTB.Location = new System.Drawing.Point(703, 361);
            this.totalBillTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalBillTB.Name = "totalBillTB";
            this.totalBillTB.Size = new System.Drawing.Size(96, 28);
            this.totalBillTB.TabIndex = 32;
            this.totalBillTB.Text = "Toplam";
            // 
            // BookDGNameTB
            // 
            this.BookDGNameTB.AutoSize = true;
            this.BookDGNameTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookDGNameTB.ForeColor = System.Drawing.Color.DimGray;
            this.BookDGNameTB.Location = new System.Drawing.Point(398, 391);
            this.BookDGNameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookDGNameTB.Name = "BookDGNameTB";
            this.BookDGNameTB.Size = new System.Drawing.Size(222, 40);
            this.BookDGNameTB.TabIndex = 31;
            this.BookDGNameTB.Text = "Kitap Listesi";
            // 
            // BookDGV
            // 
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDGV.Location = new System.Drawing.Point(8, 433);
            this.BookDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookDGV.MultiSelect = false;
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.BookDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century", 10F);
            this.BookDGV.RowTemplate.Height = 24;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(1003, 254);
            this.BookDGV.TabIndex = 30;
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // BillDGNameTB
            // 
            this.BillDGNameTB.AutoSize = true;
            this.BillDGNameTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillDGNameTB.ForeColor = System.Drawing.Color.DimGray;
            this.BillDGNameTB.Location = new System.Drawing.Point(688, 58);
            this.BillDGNameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BillDGNameTB.Name = "BillDGNameTB";
            this.BillDGNameTB.Size = new System.Drawing.Size(127, 40);
            this.BillDGNameTB.TabIndex = 29;
            this.BillDGNameTB.Text = "Fatura";
            // 
            // BookPriceInpt
            // 
            this.BookPriceInpt.Enabled = false;
            this.BookPriceInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookPriceInpt.Location = new System.Drawing.Point(353, 154);
            this.BookPriceInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookPriceInpt.Name = "BookPriceInpt";
            this.BookPriceInpt.Size = new System.Drawing.Size(156, 32);
            this.BookPriceInpt.TabIndex = 28;
            // 
            // ClientNameInpt
            // 
            this.ClientNameInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClientNameInpt.Location = new System.Drawing.Point(30, 303);
            this.ClientNameInpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientNameInpt.Name = "ClientNameInpt";
            this.ClientNameInpt.Size = new System.Drawing.Size(156, 32);
            this.ClientNameInpt.TabIndex = 27;
            // 
            // FormName3TB
            // 
            this.FormName3TB.AutoSize = true;
            this.FormName3TB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormName3TB.ForeColor = System.Drawing.Color.DimGray;
            this.FormName3TB.Location = new System.Drawing.Point(25, 271);
            this.FormName3TB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName3TB.Name = "FormName3TB";
            this.FormName3TB.Size = new System.Drawing.Size(158, 28);
            this.FormName3TB.TabIndex = 26;
            this.FormName3TB.Text = "Müşteri İsmi";
            // 
            // FormName4TB
            // 
            this.FormName4TB.AutoSize = true;
            this.FormName4TB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormName4TB.ForeColor = System.Drawing.Color.DimGray;
            this.FormName4TB.Location = new System.Drawing.Point(348, 124);
            this.FormName4TB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormName4TB.Name = "FormName4TB";
            this.FormName4TB.Size = new System.Drawing.Size(75, 28);
            this.FormName4TB.TabIndex = 25;
            this.FormName4TB.Text = "Ücret";
            // 
            // BillDGV
            // 
            this.BillDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDGV.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillDGV.Location = new System.Drawing.Point(515, 109);
            this.BillDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillDGV.MultiSelect = false;
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersWidth = 51;
            this.BillDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.BillDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century", 10F);
            this.BillDGV.RowTemplate.Height = 24;
            this.BillDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDGV.Size = new System.Drawing.Size(486, 241);
            this.BillDGV.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.checkBox1);
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.TCTB);
            this.MainPanel.Controls.Add(this.ShutDownLbl);
            this.MainPanel.Controls.Add(this.UserNameTB);
            this.MainPanel.Controls.Add(this.UserIconLbl);
            this.MainPanel.Controls.Add(this.totalBillTB);
            this.MainPanel.Controls.Add(this.BookDGNameTB);
            this.MainPanel.Controls.Add(this.BookDGV);
            this.MainPanel.Controls.Add(this.BillDGNameTB);
            this.MainPanel.Controls.Add(this.BookPriceInpt);
            this.MainPanel.Controls.Add(this.ClientNameInpt);
            this.MainPanel.Controls.Add(this.FormName3TB);
            this.MainPanel.Controls.Add(this.FormName4TB);
            this.MainPanel.Controls.Add(this.BillDGV);
            this.MainPanel.Controls.Add(this.ResetBtn);
            this.MainPanel.Controls.Add(this.PrintBtn);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.SaveBtn);
            this.MainPanel.Controls.Add(this.BookQuantityInpt);
            this.MainPanel.Controls.Add(this.BookTittleInpt);
            this.MainPanel.Controls.Add(this.FormName1TB);
            this.MainPanel.Controls.Add(this.FormName2TB);
            this.MainPanel.Controls.Add(this.MainTitleTB);
            this.MainPanel.Location = new System.Drawing.Point(254, 11);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1014, 698);
            this.MainPanel.TabIndex = 35;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.LeftPanel.Controls.Add(this.ExitTBL);
            this.LeftPanel.Controls.Add(this.LogoLbl);
            this.LeftPanel.Location = new System.Drawing.Point(12, 11);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(244, 698);
            this.LeftPanel.TabIndex = 36;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(196, 303);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 32);
            this.textBox1.TabIndex = 36;
            // 
            // TCTB
            // 
            this.TCTB.AutoSize = true;
            this.TCTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCTB.ForeColor = System.Drawing.Color.DimGray;
            this.TCTB.Location = new System.Drawing.Point(191, 271);
            this.TCTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TCTB.Name = "TCTB";
            this.TCTB.Size = new System.Drawing.Size(141, 28);
            this.TCTB.TabIndex = 35;
            this.TCTB.Text = "Müşteri TC";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(371, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 21);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Öğrenci İndirimi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).EndInit();
            this.ExitTBL.ResumeLayout(false);
            this.ExitTBL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoLbl;
        private System.Windows.Forms.Label ExitTB;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox BookQuantityInpt;
        private System.Windows.Forms.TextBox BookTittleInpt;
        private System.Windows.Forms.Label FormName1TB;
        private System.Windows.Forms.Label FormName2TB;
        private System.Windows.Forms.Label MainTitleTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel ExitTBL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label ShutDownLbl;
        private System.Windows.Forms.Label UserNameTB;
        private System.Windows.Forms.PictureBox UserIconLbl;
        private System.Windows.Forms.Label totalBillTB;
        private System.Windows.Forms.Label BookDGNameTB;
        private System.Windows.Forms.DataGridView BookDGV;
        private System.Windows.Forms.Label BillDGNameTB;
        private System.Windows.Forms.TextBox BookPriceInpt;
        private System.Windows.Forms.TextBox ClientNameInpt;
        private System.Windows.Forms.Label FormName3TB;
        private System.Windows.Forms.Label FormName4TB;
        private System.Windows.Forms.DataGridView BillDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TCTB;
    }
}