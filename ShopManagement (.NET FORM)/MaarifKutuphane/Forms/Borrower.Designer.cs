
namespace MaarifKutuphane.Forms
{
    partial class Borrower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrower));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ExitTBL = new System.Windows.Forms.Panel();
            this.ExitTB = new System.Windows.Forms.Label();
            this.LogoLbl = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TCInpt = new System.Windows.Forms.TextBox();
            this.TCTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserIconLbl = new System.Windows.Forms.PictureBox();
            this.MainTitleTB = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.EmailInpt = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PhoneInpt = new System.Windows.Forms.TextBox();
            this.UserNameInpt = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.Label();
            this.PhoneTB = new System.Windows.Forms.Label();
            this.BorrowerDGVMainTitleTB = new System.Windows.Forms.Label();
            this.BorrowerDGV = new System.Windows.Forms.DataGridView();
            this.ShutDownLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressInpt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserSurnameInpt = new System.Windows.Forms.TextBox();
            this.UserSurnameTB = new System.Windows.Forms.Label();
            this.Ogrenci = new System.Windows.Forms.CheckBox();
            this.LeftPanel.SuspendLayout();
            this.ExitTBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.LeftPanel.Controls.Add(this.ExitTBL);
            this.LeftPanel.Controls.Add(this.LogoLbl);
            this.LeftPanel.Location = new System.Drawing.Point(12, 9);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(244, 700);
            this.LeftPanel.TabIndex = 37;
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.Ogrenci);
            this.MainPanel.Controls.Add(this.UserSurnameInpt);
            this.MainPanel.Controls.Add(this.UserSurnameTB);
            this.MainPanel.Controls.Add(this.AddressInpt);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TCInpt);
            this.MainPanel.Controls.Add(this.TCTB);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.UserIconLbl);
            this.MainPanel.Controls.Add(this.MainTitleTB);
            this.MainPanel.Controls.Add(this.DeleteBtn);
            this.MainPanel.Controls.Add(this.EditBtn);
            this.MainPanel.Controls.Add(this.EmailInpt);
            this.MainPanel.Controls.Add(this.EmailTB);
            this.MainPanel.Controls.Add(this.SaveBtn);
            this.MainPanel.Controls.Add(this.PhoneInpt);
            this.MainPanel.Controls.Add(this.UserNameInpt);
            this.MainPanel.Controls.Add(this.UserNameTB);
            this.MainPanel.Controls.Add(this.PhoneTB);
            this.MainPanel.Controls.Add(this.BorrowerDGVMainTitleTB);
            this.MainPanel.Controls.Add(this.BorrowerDGV);
            this.MainPanel.Controls.Add(this.ShutDownLbl);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Location = new System.Drawing.Point(254, 9);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1014, 698);
            this.MainPanel.TabIndex = 50;
            // 
            // TCInpt
            // 
            this.TCInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCInpt.Location = new System.Drawing.Point(576, 206);
            this.TCInpt.Name = "TCInpt";
            this.TCInpt.Size = new System.Drawing.Size(258, 32);
            this.TCInpt.TabIndex = 52;
            // 
            // TCTB
            // 
            this.TCTB.AutoSize = true;
            this.TCTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCTB.ForeColor = System.Drawing.Color.DimGray;
            this.TCTB.Location = new System.Drawing.Point(571, 175);
            this.TCTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TCTB.Name = "TCTB";
            this.TCTB.Size = new System.Drawing.Size(249, 28);
            this.TCTB.TabIndex = 51;
            this.TCTB.Text = "TC Kimlik Numarasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(78, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Kullanıcı İsmi";
            // 
            // UserIconLbl
            // 
            this.UserIconLbl.Image = ((System.Drawing.Image)(resources.GetObject("UserIconLbl.Image")));
            this.UserIconLbl.Location = new System.Drawing.Point(10, 13);
            this.UserIconLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIconLbl.Name = "UserIconLbl";
            this.UserIconLbl.Size = new System.Drawing.Size(61, 40);
            this.UserIconLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIconLbl.TabIndex = 49;
            this.UserIconLbl.TabStop = false;
            // 
            // MainTitleTB
            // 
            this.MainTitleTB.AutoSize = true;
            this.MainTitleTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainTitleTB.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.MainTitleTB.Location = new System.Drawing.Point(348, 13);
            this.MainTitleTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTitleTB.Name = "MainTitleTB";
            this.MainTitleTB.Size = new System.Drawing.Size(324, 40);
            this.MainTitleTB.TabIndex = 48;
            this.MainTitleTB.Text = "Kütüphane Sistemi";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteBtn.Location = new System.Drawing.Point(595, 301);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(140, 35);
            this.DeleteBtn.TabIndex = 47;
            this.DeleteBtn.Text = "Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditBtn.Location = new System.Drawing.Point(412, 301);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(140, 35);
            this.EditBtn.TabIndex = 46;
            this.EditBtn.Text = "Düzenle";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // EmailInpt
            // 
            this.EmailInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailInpt.Location = new System.Drawing.Point(576, 140);
            this.EmailInpt.Name = "EmailInpt";
            this.EmailInpt.Size = new System.Drawing.Size(258, 32);
            this.EmailInpt.TabIndex = 44;
            // 
            // EmailTB
            // 
            this.EmailTB.AutoSize = true;
            this.EmailTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailTB.ForeColor = System.Drawing.Color.DimGray;
            this.EmailTB.Location = new System.Drawing.Point(571, 109);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(86, 28);
            this.EmailTB.TabIndex = 43;
            this.EmailTB.Text = "Email ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBtn.Location = new System.Drawing.Point(228, 301);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 35);
            this.SaveBtn.TabIndex = 41;
            this.SaveBtn.Text = "Kaydet";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // PhoneInpt
            // 
            this.PhoneInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneInpt.Location = new System.Drawing.Point(27, 206);
            this.PhoneInpt.Name = "PhoneInpt";
            this.PhoneInpt.Size = new System.Drawing.Size(258, 32);
            this.PhoneInpt.TabIndex = 40;
            // 
            // UserNameInpt
            // 
            this.UserNameInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameInpt.Location = new System.Drawing.Point(27, 140);
            this.UserNameInpt.Name = "UserNameInpt";
            this.UserNameInpt.Size = new System.Drawing.Size(258, 32);
            this.UserNameInpt.TabIndex = 39;
            // 
            // UserNameTB
            // 
            this.UserNameTB.AutoSize = true;
            this.UserNameTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserNameTB.ForeColor = System.Drawing.Color.DimGray;
            this.UserNameTB.Location = new System.Drawing.Point(22, 109);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(174, 28);
            this.UserNameTB.TabIndex = 38;
            this.UserNameTB.Text = "Kullanıcı İsmi";
            // 
            // PhoneTB
            // 
            this.PhoneTB.AutoSize = true;
            this.PhoneTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneTB.ForeColor = System.Drawing.Color.DimGray;
            this.PhoneTB.Location = new System.Drawing.Point(22, 175);
            this.PhoneTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(95, 28);
            this.PhoneTB.TabIndex = 37;
            this.PhoneTB.Text = "Telefon";
            // 
            // BorrowerDGVMainTitleTB
            // 
            this.BorrowerDGVMainTitleTB.AutoSize = true;
            this.BorrowerDGVMainTitleTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BorrowerDGVMainTitleTB.ForeColor = System.Drawing.Color.DimGray;
            this.BorrowerDGVMainTitleTB.Location = new System.Drawing.Point(429, 364);
            this.BorrowerDGVMainTitleTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BorrowerDGVMainTitleTB.Name = "BorrowerDGVMainTitleTB";
            this.BorrowerDGVMainTitleTB.Size = new System.Drawing.Size(123, 40);
            this.BorrowerDGVMainTitleTB.TabIndex = 31;
            this.BorrowerDGVMainTitleTB.Text = "Uyeler";
            // 
            // BorrowerDGV
            // 
            this.BorrowerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowerDGV.BackgroundColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BorrowerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowerDGV.Location = new System.Drawing.Point(8, 407);
            this.BorrowerDGV.MultiSelect = false;
            this.BorrowerDGV.Name = "BorrowerDGV";
            this.BorrowerDGV.RowHeadersWidth = 51;
            this.BorrowerDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.BorrowerDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century", 10F);
            this.BorrowerDGV.RowTemplate.Height = 24;
            this.BorrowerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BorrowerDGV.ShowEditingIcon = false;
            this.BorrowerDGV.Size = new System.Drawing.Size(993, 280);
            this.BorrowerDGV.TabIndex = 35;
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
            // AddressInpt
            // 
            this.AddressInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddressInpt.Location = new System.Drawing.Point(301, 206);
            this.AddressInpt.Name = "AddressInpt";
            this.AddressInpt.Size = new System.Drawing.Size(258, 32);
            this.AddressInpt.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(296, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 53;
            this.label2.Text = "Adres";
            // 
            // UserSurnameInpt
            // 
            this.UserSurnameInpt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserSurnameInpt.Location = new System.Drawing.Point(301, 140);
            this.UserSurnameInpt.Name = "UserSurnameInpt";
            this.UserSurnameInpt.Size = new System.Drawing.Size(258, 32);
            this.UserSurnameInpt.TabIndex = 56;
            // 
            // UserSurnameTB
            // 
            this.UserSurnameTB.AutoSize = true;
            this.UserSurnameTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserSurnameTB.ForeColor = System.Drawing.Color.DimGray;
            this.UserSurnameTB.Location = new System.Drawing.Point(296, 109);
            this.UserSurnameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserSurnameTB.Name = "UserSurnameTB";
            this.UserSurnameTB.Size = new System.Drawing.Size(212, 28);
            this.UserSurnameTB.TabIndex = 55;
            this.UserSurnameTB.Text = "Kullanıcı Soyismi";
            // 
            // Ogrenci
            // 
            this.Ogrenci.AutoSize = true;
            this.Ogrenci.Font = new System.Drawing.Font("Century", 12F);
            this.Ogrenci.ForeColor = System.Drawing.Color.DimGray;
            this.Ogrenci.Location = new System.Drawing.Point(27, 258);
            this.Ogrenci.Name = "Ogrenci";
            this.Ogrenci.Size = new System.Drawing.Size(105, 27);
            this.Ogrenci.TabIndex = 57;
            this.Ogrenci.Text = "Ogrenci";
            this.Ogrenci.UseVisualStyleBackColor = true;
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Century", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrower";
            this.Text = "Borrower";
            this.LeftPanel.ResumeLayout(false);
            this.ExitTBL.ResumeLayout(false);
            this.ExitTBL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowerDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel ExitTBL;
        private System.Windows.Forms.Label ExitTB;
        private System.Windows.Forms.PictureBox LogoLbl;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox UserIconLbl;
        private System.Windows.Forms.Label MainTitleTB;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox EmailInpt;
        private System.Windows.Forms.Label EmailTB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox PhoneInpt;
        private System.Windows.Forms.TextBox UserNameInpt;
        private System.Windows.Forms.Label UserNameTB;
        private System.Windows.Forms.Label PhoneTB;
        private System.Windows.Forms.Label BorrowerDGVMainTitleTB;
        private System.Windows.Forms.DataGridView BorrowerDGV;
        private System.Windows.Forms.Label ShutDownLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TCInpt;
        private System.Windows.Forms.Label TCTB;
        private System.Windows.Forms.TextBox AddressInpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserSurnameInpt;
        private System.Windows.Forms.Label UserSurnameTB;
        private System.Windows.Forms.CheckBox Ogrenci;
    }
}