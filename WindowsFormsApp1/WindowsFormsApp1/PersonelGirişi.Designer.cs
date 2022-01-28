
namespace WindowsFormsApp1
{
    partial class PersonelGirişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGirişi));
            this.txtPersonelŞifre = new System.Windows.Forms.TextBox();
            this.txtPersonelKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.lblPersonelKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblPersonelŞifre = new System.Windows.Forms.Label();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.lblPersonelHataSayısı = new System.Windows.Forms.Label();
            this.lblPersonelKalanDeneme = new System.Windows.Forms.Label();
            this.lblPersonelGirişi = new System.Windows.Forms.Label();
            this.btnPersonelGeriDön = new System.Windows.Forms.Button();
            this.txtGüvenlikKodu = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.lblGüvenlikKodu = new System.Windows.Forms.Label();
            this.btnGuvenlikKoduRefresh = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelŞifre
            // 
            this.txtPersonelŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelŞifre.Location = new System.Drawing.Point(905, 400);
            this.txtPersonelŞifre.Multiline = true;
            this.txtPersonelŞifre.Name = "txtPersonelŞifre";
            this.txtPersonelŞifre.PasswordChar = '*';
            this.txtPersonelŞifre.Size = new System.Drawing.Size(272, 35);
            this.txtPersonelŞifre.TabIndex = 1;
            this.txtPersonelŞifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPersonelKullanıcıAdı
            // 
            this.txtPersonelKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelKullanıcıAdı.ForeColor = System.Drawing.Color.Black;
            this.txtPersonelKullanıcıAdı.Location = new System.Drawing.Point(905, 359);
            this.txtPersonelKullanıcıAdı.Multiline = true;
            this.txtPersonelKullanıcıAdı.Name = "txtPersonelKullanıcıAdı";
            this.txtPersonelKullanıcıAdı.Size = new System.Drawing.Size(272, 35);
            this.txtPersonelKullanıcıAdı.TabIndex = 0;
            this.txtPersonelKullanıcıAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPersonelKullanıcıAdı
            // 
            this.lblPersonelKullanıcıAdı.AutoSize = true;
            this.lblPersonelKullanıcıAdı.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelKullanıcıAdı.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKullanıcıAdı.ForeColor = System.Drawing.Color.White;
            this.lblPersonelKullanıcıAdı.Location = new System.Drawing.Point(617, 355);
            this.lblPersonelKullanıcıAdı.Name = "lblPersonelKullanıcıAdı";
            this.lblPersonelKullanıcıAdı.Size = new System.Drawing.Size(250, 40);
            this.lblPersonelKullanıcıAdı.TabIndex = 10;
            this.lblPersonelKullanıcıAdı.Text = "Kullanıcı Adı:";
            this.lblPersonelKullanıcıAdı.Click += new System.EventHandler(this.lblPersonelKullanıcıAdı_Click);
            // 
            // lblPersonelŞifre
            // 
            this.lblPersonelŞifre.AutoSize = true;
            this.lblPersonelŞifre.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelŞifre.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelŞifre.ForeColor = System.Drawing.Color.White;
            this.lblPersonelŞifre.Location = new System.Drawing.Point(764, 396);
            this.lblPersonelŞifre.Name = "lblPersonelŞifre";
            this.lblPersonelŞifre.Size = new System.Drawing.Size(109, 40);
            this.lblPersonelŞifre.TabIndex = 11;
            this.lblPersonelŞifre.Text = "Şifre:";
            this.lblPersonelŞifre.Click += new System.EventHandler(this.lblPersonelŞifre_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelGiris.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPersonelGiris.Location = new System.Drawing.Point(906, 536);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(272, 40);
            this.btnPersonelGiris.TabIndex = 3;
            this.btnPersonelGiris.Text = "Giriş ";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.GirisBttn_Click);
            // 
            // lblPersonelHataSayısı
            // 
            this.lblPersonelHataSayısı.AutoSize = true;
            this.lblPersonelHataSayısı.BackColor = System.Drawing.Color.White;
            this.lblPersonelHataSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelHataSayısı.ForeColor = System.Drawing.Color.Red;
            this.lblPersonelHataSayısı.Location = new System.Drawing.Point(1162, 637);
            this.lblPersonelHataSayısı.Name = "lblPersonelHataSayısı";
            this.lblPersonelHataSayısı.Size = new System.Drawing.Size(27, 29);
            this.lblPersonelHataSayısı.TabIndex = 23;
            this.lblPersonelHataSayısı.Text = "3";
            this.lblPersonelHataSayısı.Click += new System.EventHandler(this.lblHata_Click);
            // 
            // lblPersonelKalanDeneme
            // 
            this.lblPersonelKalanDeneme.AutoSize = true;
            this.lblPersonelKalanDeneme.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelKalanDeneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKalanDeneme.ForeColor = System.Drawing.Color.White;
            this.lblPersonelKalanDeneme.Location = new System.Drawing.Point(894, 640);
            this.lblPersonelKalanDeneme.Name = "lblPersonelKalanDeneme";
            this.lblPersonelKalanDeneme.Size = new System.Drawing.Size(238, 25);
            this.lblPersonelKalanDeneme.TabIndex = 24;
            this.lblPersonelKalanDeneme.Text = "Kalan Deneme Sayınız:";
            this.lblPersonelKalanDeneme.Click += new System.EventHandler(this.lblPersonelKalanDeneme_Click);
            // 
            // lblPersonelGirişi
            // 
            this.lblPersonelGirişi.AutoSize = true;
            this.lblPersonelGirişi.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelGirişi.Font = new System.Drawing.Font("Comic Sans MS", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelGirişi.ForeColor = System.Drawing.Color.White;
            this.lblPersonelGirişi.Location = new System.Drawing.Point(507, 117);
            this.lblPersonelGirişi.Name = "lblPersonelGirişi";
            this.lblPersonelGirişi.Size = new System.Drawing.Size(895, 168);
            this.lblPersonelGirişi.TabIndex = 25;
            this.lblPersonelGirişi.Text = "Personel Girişi";
            this.lblPersonelGirişi.Click += new System.EventHandler(this.lblPersonelGirişi_Click);
            // 
            // btnPersonelGeriDön
            // 
            this.btnPersonelGeriDön.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelGeriDön.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPersonelGeriDön.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGeriDön.ForeColor = System.Drawing.Color.Red;
            this.btnPersonelGeriDön.Location = new System.Drawing.Point(906, 582);
            this.btnPersonelGeriDön.Name = "btnPersonelGeriDön";
            this.btnPersonelGeriDön.Size = new System.Drawing.Size(272, 40);
            this.btnPersonelGeriDön.TabIndex = 4;
            this.btnPersonelGeriDön.Text = "Geri Dön";
            this.btnPersonelGeriDön.UseVisualStyleBackColor = true;
            this.btnPersonelGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // txtGüvenlikKodu
            // 
            this.txtGüvenlikKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGüvenlikKodu.Location = new System.Drawing.Point(906, 495);
            this.txtGüvenlikKodu.MaxLength = 6;
            this.txtGüvenlikKodu.Multiline = true;
            this.txtGüvenlikKodu.Name = "txtGüvenlikKodu";
            this.txtGüvenlikKodu.Size = new System.Drawing.Size(272, 35);
            this.txtGüvenlikKodu.TabIndex = 2;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Transparent;
            this.lblG.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblG.ForeColor = System.Drawing.Color.White;
            this.lblG.Location = new System.Drawing.Point(585, 493);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(282, 40);
            this.lblG.TabIndex = 28;
            this.lblG.Text = "Güvenlik Kodu:";
            // 
            // lblGüvenlikKodu
            // 
            this.lblGüvenlikKodu.AutoSize = true;
            this.lblGüvenlikKodu.BackColor = System.Drawing.Color.White;
            this.lblGüvenlikKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGüvenlikKodu.Location = new System.Drawing.Point(921, 445);
            this.lblGüvenlikKodu.Name = "lblGüvenlikKodu";
            this.lblGüvenlikKodu.Size = new System.Drawing.Size(0, 38);
            this.lblGüvenlikKodu.TabIndex = 29;
            this.lblGüvenlikKodu.Click += new System.EventHandler(this.lblGüvenlikKodu_Click);
            // 
            // btnGuvenlikKoduRefresh
            // 
            this.btnGuvenlikKoduRefresh.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.reload_icon;
            this.btnGuvenlikKoduRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuvenlikKoduRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuvenlikKoduRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuvenlikKoduRefresh.Location = new System.Drawing.Point(1125, 441);
            this.btnGuvenlikKoduRefresh.Name = "btnGuvenlikKoduRefresh";
            this.btnGuvenlikKoduRefresh.Size = new System.Drawing.Size(52, 49);
            this.btnGuvenlikKoduRefresh.TabIndex = 7;
            this.btnGuvenlikKoduRefresh.UseVisualStyleBackColor = true;
            this.btnGuvenlikKoduRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.tenor__1_;
            this.pictureBox2.Location = new System.Drawing.Point(1228, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(643, 647);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // PersonelGirişi
            // 
            this.AcceptButton = this.btnPersonelGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Download_Desktop_HD_Wallpaper_For_Walls;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnPersonelGeriDön;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGuvenlikKoduRefresh);
            this.Controls.Add(this.lblGüvenlikKodu);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.txtGüvenlikKodu);
            this.Controls.Add(this.btnPersonelGeriDön);
            this.Controls.Add(this.lblPersonelGirişi);
            this.Controls.Add(this.lblPersonelKalanDeneme);
            this.Controls.Add(this.lblPersonelHataSayısı);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.lblPersonelŞifre);
            this.Controls.Add(this.lblPersonelKullanıcıAdı);
            this.Controls.Add(this.txtPersonelKullanıcıAdı);
            this.Controls.Add(this.txtPersonelŞifre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PersonelGirişi";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Anasayfa_FormClosed);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anasayfa_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Anasayfa_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Anasayfa_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.PersonelGirişi_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPersonelŞifre;
        private System.Windows.Forms.TextBox txtPersonelKullanıcıAdı;
        private System.Windows.Forms.Label lblPersonelKullanıcıAdı;
        private System.Windows.Forms.Label lblPersonelŞifre;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.Label lblPersonelHataSayısı;
        private System.Windows.Forms.Label lblPersonelKalanDeneme;
        private System.Windows.Forms.Label lblPersonelGirişi;
        private System.Windows.Forms.Button btnPersonelGeriDön;
        private System.Windows.Forms.TextBox txtGüvenlikKodu;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblGüvenlikKodu;
        private System.Windows.Forms.Button btnGuvenlikKoduRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}