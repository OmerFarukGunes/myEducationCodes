
namespace MaarifKutuphane.Forms
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.PercentageTB = new System.Windows.Forms.Label();
            this.LoadingTB = new System.Windows.Forms.Label();
            this.LoadingProgress = new System.Windows.Forms.ProgressBar();
            this.LogoLbl = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainTitleTB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).BeginInit();
            this.SuspendLayout();
            // 
            // PercentageTB
            // 
            this.PercentageTB.AutoSize = true;
            this.PercentageTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PercentageTB.ForeColor = System.Drawing.Color.ForestGreen;
            this.PercentageTB.Location = new System.Drawing.Point(182, 464);
            this.PercentageTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentageTB.Name = "PercentageTB";
            this.PercentageTB.Size = new System.Drawing.Size(32, 28);
            this.PercentageTB.TabIndex = 9;
            this.PercentageTB.Text = "%";
            // 
            // LoadingTB
            // 
            this.LoadingTB.AutoSize = true;
            this.LoadingTB.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoadingTB.ForeColor = System.Drawing.Color.ForestGreen;
            this.LoadingTB.Location = new System.Drawing.Point(25, 464);
            this.LoadingTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadingTB.Name = "LoadingTB";
            this.LoadingTB.Size = new System.Drawing.Size(158, 28);
            this.LoadingTB.TabIndex = 8;
            this.LoadingTB.Text = "Yükleniyor...";
            // 
            // LoadingProgress
            // 
            this.LoadingProgress.BackColor = System.Drawing.SystemColors.ControlText;
            this.LoadingProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadingProgress.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.LoadingProgress.Location = new System.Drawing.Point(25, 518);
            this.LoadingProgress.Name = "LoadingProgress";
            this.LoadingProgress.Size = new System.Drawing.Size(975, 18);
            this.LoadingProgress.TabIndex = 7;
            // 
            // LogoLbl
            // 
            this.LogoLbl.Image = ((System.Drawing.Image)(resources.GetObject("LogoLbl.Image")));
            this.LogoLbl.Location = new System.Drawing.Point(369, 101);
            this.LogoLbl.Name = "LogoLbl";
            this.LogoLbl.Size = new System.Drawing.Size(289, 310);
            this.LogoLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoLbl.TabIndex = 6;
            this.LogoLbl.TabStop = false;
            // 
            // MainTitleTB
            // 
            this.MainTitleTB.AutoSize = true;
            this.MainTitleTB.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainTitleTB.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.MainTitleTB.Location = new System.Drawing.Point(351, 30);
            this.MainTitleTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTitleTB.Name = "MainTitleTB";
            this.MainTitleTB.Size = new System.Drawing.Size(324, 40);
            this.MainTitleTB.TabIndex = 10;
            this.MainTitleTB.Text = "Kütüphane Sistemi";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.MainTitleTB);
            this.Controls.Add(this.PercentageTB);
            this.Controls.Add(this.LoadingTB);
            this.Controls.Add(this.LoadingProgress);
            this.Controls.Add(this.LogoLbl);
            this.Font = new System.Drawing.Font("Century", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.LogoLbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PercentageTB;
        private System.Windows.Forms.Label LoadingTB;
        private System.Windows.Forms.ProgressBar LoadingProgress;
        private System.Windows.Forms.PictureBox LogoLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MainTitleTB;
    }
}