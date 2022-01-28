namespace WindowsFormsApp1
{
    partial class ŞifremiUnuttum
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblBaşlık = new System.Windows.Forms.Label();
            this.lblŞifreGir2 = new System.Windows.Forms.Label();
            this.lblŞifreGir1 = new System.Windows.Forms.Label();
            this.txtŞifre1 = new System.Windows.Forms.TextBox();
            this.txtŞifre2 = new System.Windows.Forms.TextBox();
            this.btnŞifreOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnayla.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(890, 484);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(243, 43);
            this.btnOnayla.TabIndex = 11;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(890, 451);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(243, 27);
            this.txtTC.TabIndex = 12;
            this.txtTC.TextChanged += new System.EventHandler(this.txtÜyeTC_TextChanged);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(890, 369);
            this.txtKullanıcıAdı.MaxLength = 11;
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(243, 27);
            this.txtKullanıcıAdı.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(890, 402);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(243, 43);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.Transparent;
            this.lblTC.Location = new System.Drawing.Point(779, 451);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(80, 24);
            this.lblTC.TabIndex = 47;
            this.lblTC.Text = "TC No:";
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.ForeColor = System.Drawing.Color.Transparent;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(707, 369);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(152, 24);
            this.lblKullanıcıAdı.TabIndex = 45;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // lblBaşlık
            // 
            this.lblBaşlık.AutoSize = true;
            this.lblBaşlık.BackColor = System.Drawing.Color.Transparent;
            this.lblBaşlık.Font = new System.Drawing.Font("Bookman Old Style", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaşlık.ForeColor = System.Drawing.Color.White;
            this.lblBaşlık.Location = new System.Drawing.Point(508, 156);
            this.lblBaşlık.Name = "lblBaşlık";
            this.lblBaşlık.Size = new System.Drawing.Size(1003, 140);
            this.lblBaşlık.TabIndex = 48;
            this.lblBaşlık.Text = "ŞİFRE SIFIRLA";
            // 
            // lblŞifreGir2
            // 
            this.lblŞifreGir2.AutoSize = true;
            this.lblŞifreGir2.BackColor = System.Drawing.Color.Transparent;
            this.lblŞifreGir2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifreGir2.ForeColor = System.Drawing.Color.Transparent;
            this.lblŞifreGir2.Location = new System.Drawing.Point(666, 568);
            this.lblŞifreGir2.Name = "lblŞifreGir2";
            this.lblŞifreGir2.Size = new System.Drawing.Size(193, 24);
            this.lblŞifreGir2.TabIndex = 52;
            this.lblŞifreGir2.Text = "Yeni Şifre Tekrar:";
            // 
            // lblŞifreGir1
            // 
            this.lblŞifreGir1.AutoSize = true;
            this.lblŞifreGir1.BackColor = System.Drawing.Color.Transparent;
            this.lblŞifreGir1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifreGir1.ForeColor = System.Drawing.Color.Transparent;
            this.lblŞifreGir1.Location = new System.Drawing.Point(741, 535);
            this.lblŞifreGir1.Name = "lblŞifreGir1";
            this.lblŞifreGir1.Size = new System.Drawing.Size(118, 24);
            this.lblŞifreGir1.TabIndex = 51;
            this.lblŞifreGir1.Text = "Yeni Şifre:";
            // 
            // txtŞifre1
            // 
            this.txtŞifre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre1.Location = new System.Drawing.Point(890, 532);
            this.txtŞifre1.MaxLength = 11;
            this.txtŞifre1.Name = "txtŞifre1";
            this.txtŞifre1.PasswordChar = '*';
            this.txtŞifre1.Size = new System.Drawing.Size(243, 27);
            this.txtŞifre1.TabIndex = 50;
            // 
            // txtŞifre2
            // 
            this.txtŞifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre2.Location = new System.Drawing.Point(890, 565);
            this.txtŞifre2.MaxLength = 11;
            this.txtŞifre2.Name = "txtŞifre2";
            this.txtŞifre2.PasswordChar = '*';
            this.txtŞifre2.Size = new System.Drawing.Size(243, 27);
            this.txtŞifre2.TabIndex = 49;
            // 
            // btnŞifreOnayla
            // 
            this.btnŞifreOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnŞifreOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnŞifreOnayla.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnŞifreOnayla.ForeColor = System.Drawing.Color.White;
            this.btnŞifreOnayla.Location = new System.Drawing.Point(890, 598);
            this.btnŞifreOnayla.Name = "btnŞifreOnayla";
            this.btnŞifreOnayla.Size = new System.Drawing.Size(243, 43);
            this.btnŞifreOnayla.TabIndex = 53;
            this.btnŞifreOnayla.Text = "ŞİFRE ONAYLA";
            this.btnŞifreOnayla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnŞifreOnayla.UseVisualStyleBackColor = false;
            this.btnŞifreOnayla.Click += new System.EventHandler(this.btnŞifreOnayla_Click);
            // 
            // ŞifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnŞifreOnayla);
            this.Controls.Add(this.lblŞifreGir2);
            this.Controls.Add(this.lblŞifreGir1);
            this.Controls.Add(this.txtŞifre1);
            this.Controls.Add(this.txtŞifre2);
            this.Controls.Add(this.lblBaşlık);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnOnayla);
            this.Name = "ŞifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.txtKullanıcıAdı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblBaşlık;
        private System.Windows.Forms.Label lblŞifreGir2;
        private System.Windows.Forms.Label lblŞifreGir1;
        private System.Windows.Forms.TextBox txtŞifre1;
        private System.Windows.Forms.TextBox txtŞifre2;
        private System.Windows.Forms.Button btnŞifreOnayla;
    }
}