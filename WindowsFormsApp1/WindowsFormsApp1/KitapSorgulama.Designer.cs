namespace WindowsFormsApp1
{
    partial class KitapSorgulama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapSorgulama));
            this.grpKitapAra = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblAra = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtKitapArama = new System.Windows.Forms.TextBox();
            this.radioKitapKategori = new System.Windows.Forms.RadioButton();
            this.radioKitapYayinevi = new System.Windows.Forms.RadioButton();
            this.radioKitapYazari = new System.Windows.Forms.RadioButton();
            this.radioKitapAdi = new System.Windows.Forms.RadioButton();
            this.radioKitapID = new System.Windows.Forms.RadioButton();
            this.datagridKitaplar = new System.Windows.Forms.DataGridView();
            this.btnAnasayfayaDön = new System.Windows.Forms.Button();
            this.lblTabloFont = new System.Windows.Forms.Label();
            this.trackBarTabloYazıBoyutu = new System.Windows.Forms.TrackBar();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpKitapAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTabloYazıBoyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKitapAra
            // 
            this.grpKitapAra.BackColor = System.Drawing.Color.Transparent;
            this.grpKitapAra.Controls.Add(this.btnListele);
            this.grpKitapAra.Controls.Add(this.lblAra);
            this.grpKitapAra.Controls.Add(this.btnAra);
            this.grpKitapAra.Controls.Add(this.txtKitapArama);
            this.grpKitapAra.Controls.Add(this.radioKitapKategori);
            this.grpKitapAra.Controls.Add(this.radioKitapYayinevi);
            this.grpKitapAra.Controls.Add(this.radioKitapYazari);
            this.grpKitapAra.Controls.Add(this.radioKitapAdi);
            this.grpKitapAra.Controls.Add(this.radioKitapID);
            this.grpKitapAra.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKitapAra.ForeColor = System.Drawing.Color.White;
            this.grpKitapAra.Location = new System.Drawing.Point(316, 37);
            this.grpKitapAra.Name = "grpKitapAra";
            this.grpKitapAra.Size = new System.Drawing.Size(651, 382);
            this.grpKitapAra.TabIndex = 47;
            this.grpKitapAra.TabStop = false;
            this.grpKitapAra.Text = "KİTAP ARA";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListele.Image = global::WindowsFormsApp1.Properties.Resources.Moleskine_Yellow_Book_icon;
            this.btnListele.Location = new System.Drawing.Point(360, 223);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(277, 97);
            this.btnListele.TabIndex = 42;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.ForeColor = System.Drawing.Color.Red;
            this.lblAra.Location = new System.Drawing.Point(384, 109);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(0, 22);
            this.lblAra.TabIndex = 41;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAra.Image = global::WindowsFormsApp1.Properties.Resources.Start_Menu_Search_icon;
            this.btnAra.Location = new System.Drawing.Point(360, 112);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(277, 105);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtKitapArama
            // 
            this.txtKitapArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapArama.Location = new System.Drawing.Point(360, 73);
            this.txtKitapArama.Multiline = true;
            this.txtKitapArama.Name = "txtKitapArama";
            this.txtKitapArama.Size = new System.Drawing.Size(277, 33);
            this.txtKitapArama.TabIndex = 0;
            // 
            // radioKitapKategori
            // 
            this.radioKitapKategori.AutoSize = true;
            this.radioKitapKategori.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapKategori.Location = new System.Drawing.Point(37, 253);
            this.radioKitapKategori.Name = "radioKitapKategori";
            this.radioKitapKategori.Size = new System.Drawing.Size(295, 36);
            this.radioKitapKategori.TabIndex = 6;
            this.radioKitapKategori.TabStop = true;
            this.radioKitapKategori.Text = "KİTAP KATEGORİ";
            this.radioKitapKategori.UseVisualStyleBackColor = true;
            this.radioKitapKategori.CheckedChanged += new System.EventHandler(this.radioKitapKategori_CheckedChanged);
            // 
            // radioKitapYayinevi
            // 
            this.radioKitapYayinevi.AutoSize = true;
            this.radioKitapYayinevi.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapYayinevi.Location = new System.Drawing.Point(37, 211);
            this.radioKitapYayinevi.Name = "radioKitapYayinevi";
            this.radioKitapYayinevi.Size = new System.Drawing.Size(279, 36);
            this.radioKitapYayinevi.TabIndex = 8;
            this.radioKitapYayinevi.TabStop = true;
            this.radioKitapYayinevi.Text = "KİTAP YAYINEVİ";
            this.radioKitapYayinevi.UseVisualStyleBackColor = true;
            // 
            // radioKitapYazari
            // 
            this.radioKitapYazari.AutoSize = true;
            this.radioKitapYazari.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapYazari.Location = new System.Drawing.Point(37, 169);
            this.radioKitapYazari.Name = "radioKitapYazari";
            this.radioKitapYazari.Size = new System.Drawing.Size(247, 36);
            this.radioKitapYazari.TabIndex = 7;
            this.radioKitapYazari.TabStop = true;
            this.radioKitapYazari.Text = "KİTAP YAZARI";
            this.radioKitapYazari.UseVisualStyleBackColor = true;
            // 
            // radioKitapAdi
            // 
            this.radioKitapAdi.AutoSize = true;
            this.radioKitapAdi.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapAdi.Location = new System.Drawing.Point(37, 130);
            this.radioKitapAdi.Name = "radioKitapAdi";
            this.radioKitapAdi.Size = new System.Drawing.Size(189, 36);
            this.radioKitapAdi.TabIndex = 5;
            this.radioKitapAdi.TabStop = true;
            this.radioKitapAdi.Text = "KİTAP ADI";
            this.radioKitapAdi.UseVisualStyleBackColor = true;
            // 
            // radioKitapID
            // 
            this.radioKitapID.AutoSize = true;
            this.radioKitapID.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapID.Location = new System.Drawing.Point(37, 89);
            this.radioKitapID.Name = "radioKitapID";
            this.radioKitapID.Size = new System.Drawing.Size(169, 36);
            this.radioKitapID.TabIndex = 4;
            this.radioKitapID.TabStop = true;
            this.radioKitapID.Text = "KİTAP ID";
            this.radioKitapID.UseVisualStyleBackColor = true;
            // 
            // datagridKitaplar
            // 
            this.datagridKitaplar.AllowUserToOrderColumns = true;
            this.datagridKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridKitaplar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridKitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridKitaplar.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridKitaplar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.datagridKitaplar.Location = new System.Drawing.Point(110, 436);
            this.datagridKitaplar.Name = "datagridKitaplar";
            this.datagridKitaplar.ReadOnly = true;
            this.datagridKitaplar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridKitaplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridKitaplar.RowHeadersVisible = false;
            this.datagridKitaplar.RowHeadersWidth = 70;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.datagridKitaplar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridKitaplar.RowTemplate.Height = 24;
            this.datagridKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridKitaplar.Size = new System.Drawing.Size(1819, 558);
            this.datagridKitaplar.TabIndex = 10;
            // 
            // btnAnasayfayaDön
            // 
            this.btnAnasayfayaDön.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnAnasayfayaDön.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnasayfayaDön.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDön.ForeColor = System.Drawing.Color.Black;
            this.btnAnasayfayaDön.Image = global::WindowsFormsApp1.Properties.Resources.Industry_Return_icon;
            this.btnAnasayfayaDön.Location = new System.Drawing.Point(1643, 236);
            this.btnAnasayfayaDön.Name = "btnAnasayfayaDön";
            this.btnAnasayfayaDön.Size = new System.Drawing.Size(271, 109);
            this.btnAnasayfayaDön.TabIndex = 3;
            this.btnAnasayfayaDön.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfayaDön.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfayaDön.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDön.Click += new System.EventHandler(this.btnAnasayfayaDön_Click);
            // 
            // lblTabloFont
            // 
            this.lblTabloFont.AutoSize = true;
            this.lblTabloFont.BackColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTabloFont.ForeColor = System.Drawing.Color.White;
            this.lblTabloFont.Location = new System.Drawing.Point(1374, 110);
            this.lblTabloFont.Name = "lblTabloFont";
            this.lblTabloFont.Size = new System.Drawing.Size(468, 47);
            this.lblTabloFont.TabIndex = 91;
            this.lblTabloFont.Text = "TABLO YAZI BOYUTU";
            // 
            // trackBarTabloYazıBoyutu
            // 
            this.trackBarTabloYazıBoyutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.trackBarTabloYazıBoyutu.Location = new System.Drawing.Point(1343, 173);
            this.trackBarTabloYazıBoyutu.Maximum = 15;
            this.trackBarTabloYazıBoyutu.Minimum = 7;
            this.trackBarTabloYazıBoyutu.Name = "trackBarTabloYazıBoyutu";
            this.trackBarTabloYazıBoyutu.Size = new System.Drawing.Size(574, 56);
            this.trackBarTabloYazıBoyutu.TabIndex = 9;
            this.trackBarTabloYazıBoyutu.Value = 7;
            this.trackBarTabloYazıBoyutu.Scroll += new System.EventHandler(this.trackBarTabloYazıBoyutu_Scroll);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnYazdır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdır.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdır.ForeColor = System.Drawing.Color.Black;
            this.btnYazdır.Image = global::WindowsFormsApp1.Properties.Resources.print_icon;
            this.btnYazdır.Location = new System.Drawing.Point(1343, 235);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(274, 110);
            this.btnYazdır.TabIndex = 2;
            this.btnYazdır.Text = "TABLOYU YAZDIR";
            this.btnYazdır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.tenor__3_;
            this.pictureBox1.Location = new System.Drawing.Point(990, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // KitapSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.thumb_1920_389875;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.lblTabloFont);
            this.Controls.Add(this.trackBarTabloYazıBoyutu);
            this.Controls.Add(this.btnAnasayfayaDön);
            this.Controls.Add(this.grpKitapAra);
            this.Controls.Add(this.datagridKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Sorgulama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitapSorgulama_Load);
            this.Resize += new System.EventHandler(this.KitapSorgulama_Resize);
            this.grpKitapAra.ResumeLayout(false);
            this.grpKitapAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTabloYazıBoyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKitapAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtKitapArama;
        private System.Windows.Forms.RadioButton radioKitapKategori;
        private System.Windows.Forms.RadioButton radioKitapYayinevi;
        private System.Windows.Forms.RadioButton radioKitapYazari;
        private System.Windows.Forms.RadioButton radioKitapAdi;
        private System.Windows.Forms.RadioButton radioKitapID;
        private System.Windows.Forms.DataGridView datagridKitaplar;
        private System.Windows.Forms.Button btnAnasayfayaDön;
        private System.Windows.Forms.Label lblTabloFont;
        private System.Windows.Forms.TrackBar trackBarTabloYazıBoyutu;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}