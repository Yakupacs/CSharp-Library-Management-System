namespace WindowsFormsApp1
{
    partial class GuvenlikIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuvenlikIslemleri));
            this.btnŞifreYenileme = new System.Windows.Forms.Button();
            this.grpboxPersonelŞifreYenileme = new System.Windows.Forms.GroupBox();
            this.lblPersonelNO = new System.Windows.Forms.Label();
            this.txtboxPersonelNumara = new System.Windows.Forms.TextBox();
            this.btnŞifreSMS = new System.Windows.Forms.Button();
            this.grpboxÜyeŞifreYenileme = new System.Windows.Forms.GroupBox();
            this.comboEpostaAdresiniz = new System.Windows.Forms.ComboBox();
            this.lblEpostaAdresi = new System.Windows.Forms.Label();
            this.txtboxEpostaAdresiniz = new System.Windows.Forms.TextBox();
            this.pctrboxUye = new System.Windows.Forms.PictureBox();
            this.pctrBoxPersonel = new System.Windows.Forms.PictureBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.grpboxPersonelŞifreYenileme.SuspendLayout();
            this.grpboxÜyeŞifreYenileme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrboxUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnŞifreYenileme
            // 
            this.btnŞifreYenileme.Location = new System.Drawing.Point(9, 68);
            this.btnŞifreYenileme.Name = "btnŞifreYenileme";
            this.btnŞifreYenileme.Size = new System.Drawing.Size(398, 38);
            this.btnŞifreYenileme.TabIndex = 4;
            this.btnŞifreYenileme.Text = "Şifre Yenileme Bağlantısı Gönder";
            this.btnŞifreYenileme.UseVisualStyleBackColor = true;
            // 
            // grpboxPersonelŞifreYenileme
            // 
            this.grpboxPersonelŞifreYenileme.BackColor = System.Drawing.Color.LightCyan;
            this.grpboxPersonelŞifreYenileme.Controls.Add(this.lblPersonelNO);
            this.grpboxPersonelŞifreYenileme.Controls.Add(this.txtboxPersonelNumara);
            this.grpboxPersonelŞifreYenileme.Controls.Add(this.btnŞifreSMS);
            this.grpboxPersonelŞifreYenileme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpboxPersonelŞifreYenileme.Location = new System.Drawing.Point(36, 173);
            this.grpboxPersonelŞifreYenileme.Name = "grpboxPersonelŞifreYenileme";
            this.grpboxPersonelŞifreYenileme.Size = new System.Drawing.Size(407, 118);
            this.grpboxPersonelŞifreYenileme.TabIndex = 1;
            this.grpboxPersonelŞifreYenileme.TabStop = false;
            this.grpboxPersonelŞifreYenileme.Text = "Personel Şifre Yenileme";
            // 
            // lblPersonelNO
            // 
            this.lblPersonelNO.AutoSize = true;
            this.lblPersonelNO.Location = new System.Drawing.Point(6, 42);
            this.lblPersonelNO.Name = "lblPersonelNO";
            this.lblPersonelNO.Size = new System.Drawing.Size(131, 16);
            this.lblPersonelNO.TabIndex = 2;
            this.lblPersonelNO.Text = "Personel Numaranız:";
            // 
            // txtboxPersonelNumara
            // 
            this.txtboxPersonelNumara.Location = new System.Drawing.Point(155, 35);
            this.txtboxPersonelNumara.Multiline = true;
            this.txtboxPersonelNumara.Name = "txtboxPersonelNumara";
            this.txtboxPersonelNumara.Size = new System.Drawing.Size(246, 27);
            this.txtboxPersonelNumara.TabIndex = 0;
            // 
            // btnŞifreSMS
            // 
            this.btnŞifreSMS.Location = new System.Drawing.Point(9, 68);
            this.btnŞifreSMS.Name = "btnŞifreSMS";
            this.btnŞifreSMS.Size = new System.Drawing.Size(392, 38);
            this.btnŞifreSMS.TabIndex = 1;
            this.btnŞifreSMS.Text = "Şifremi SMS Gönder";
            this.btnŞifreSMS.UseVisualStyleBackColor = true;
            // 
            // grpboxÜyeŞifreYenileme
            // 
            this.grpboxÜyeŞifreYenileme.BackColor = System.Drawing.Color.LightCyan;
            this.grpboxÜyeŞifreYenileme.Controls.Add(this.comboEpostaAdresiniz);
            this.grpboxÜyeŞifreYenileme.Controls.Add(this.lblEpostaAdresi);
            this.grpboxÜyeŞifreYenileme.Controls.Add(this.btnŞifreYenileme);
            this.grpboxÜyeŞifreYenileme.Controls.Add(this.txtboxEpostaAdresiniz);
            this.grpboxÜyeŞifreYenileme.Location = new System.Drawing.Point(465, 175);
            this.grpboxÜyeŞifreYenileme.Name = "grpboxÜyeŞifreYenileme";
            this.grpboxÜyeŞifreYenileme.Size = new System.Drawing.Size(413, 118);
            this.grpboxÜyeŞifreYenileme.TabIndex = 2;
            this.grpboxÜyeŞifreYenileme.TabStop = false;
            this.grpboxÜyeŞifreYenileme.Text = "Üye Şifre Yenileme";
            // 
            // comboEpostaAdresiniz
            // 
            this.comboEpostaAdresiniz.FormattingEnabled = true;
            this.comboEpostaAdresiniz.Items.AddRange(new object[] {
            "@hotmail.com",
            "@gmail.com",
            "@outlook.com",
            "@yahoo.com"});
            this.comboEpostaAdresiniz.Location = new System.Drawing.Point(283, 40);
            this.comboEpostaAdresiniz.Name = "comboEpostaAdresiniz";
            this.comboEpostaAdresiniz.Size = new System.Drawing.Size(118, 24);
            this.comboEpostaAdresiniz.TabIndex = 3;
            // 
            // lblEpostaAdresi
            // 
            this.lblEpostaAdresi.AutoSize = true;
            this.lblEpostaAdresi.Location = new System.Drawing.Point(6, 43);
            this.lblEpostaAdresi.Name = "lblEpostaAdresi";
            this.lblEpostaAdresi.Size = new System.Drawing.Size(115, 16);
            this.lblEpostaAdresi.TabIndex = 1;
            this.lblEpostaAdresi.Text = "E-posta Adresiniz:";
            // 
            // txtboxEpostaAdresiniz
            // 
            this.txtboxEpostaAdresiniz.Location = new System.Drawing.Point(140, 40);
            this.txtboxEpostaAdresiniz.Multiline = true;
            this.txtboxEpostaAdresiniz.Name = "txtboxEpostaAdresiniz";
            this.txtboxEpostaAdresiniz.Size = new System.Drawing.Size(137, 24);
            this.txtboxEpostaAdresiniz.TabIndex = 2;
            // 
            // pctrboxUye
            // 
            this.pctrboxUye.Image = global::WindowsFormsApp1.Properties.Resources.Groups_Meeting_Dark_icon;
            this.pctrboxUye.Location = new System.Drawing.Point(592, 22);
            this.pctrboxUye.Name = "pctrboxUye";
            this.pctrboxUye.Size = new System.Drawing.Size(159, 135);
            this.pctrboxUye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrboxUye.TabIndex = 4;
            this.pctrboxUye.TabStop = false;
            // 
            // pctrBoxPersonel
            // 
            this.pctrBoxPersonel.Image = global::WindowsFormsApp1.Properties.Resources.Office_Customer_Male_Light_icon;
            this.pctrBoxPersonel.Location = new System.Drawing.Point(163, 32);
            this.pctrBoxPersonel.Name = "pctrBoxPersonel";
            this.pctrBoxPersonel.Size = new System.Drawing.Size(159, 135);
            this.pctrBoxPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxPersonel.TabIndex = 3;
            this.pctrBoxPersonel.TabStop = false;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(354, 311);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(206, 35);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.Text = "Anasayfaya Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // GuvenlikIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(928, 392);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.pctrboxUye);
            this.Controls.Add(this.pctrBoxPersonel);
            this.Controls.Add(this.grpboxÜyeŞifreYenileme);
            this.Controls.Add(this.grpboxPersonelŞifreYenileme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuvenlikIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenlik İşlemleri";
            this.Load += new System.EventHandler(this.Güvenlikİşlemleri_Load);
            this.grpboxPersonelŞifreYenileme.ResumeLayout(false);
            this.grpboxPersonelŞifreYenileme.PerformLayout();
            this.grpboxÜyeŞifreYenileme.ResumeLayout(false);
            this.grpboxÜyeŞifreYenileme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrboxUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnŞifreYenileme;
        private System.Windows.Forms.GroupBox grpboxPersonelŞifreYenileme;
        private System.Windows.Forms.Button btnŞifreSMS;
        private System.Windows.Forms.Label lblPersonelNO;
        private System.Windows.Forms.TextBox txtboxPersonelNumara;
        private System.Windows.Forms.GroupBox grpboxÜyeŞifreYenileme;
        private System.Windows.Forms.Label lblEpostaAdresi;
        private System.Windows.Forms.TextBox txtboxEpostaAdresiniz;
        private System.Windows.Forms.PictureBox pctrBoxPersonel;
        private System.Windows.Forms.PictureBox pctrboxUye;
        private System.Windows.Forms.ComboBox comboEpostaAdresiniz;
        private System.Windows.Forms.Button btnGeriDon;
    }
}