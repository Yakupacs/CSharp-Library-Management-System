namespace WindowsFormsApp1
{
    partial class Personelİşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personelİşlemleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.radioPersonelEmail = new System.Windows.Forms.RadioButton();
            this.radioPersonelAdres = new System.Windows.Forms.RadioButton();
            this.radioPersonelTelefon = new System.Windows.Forms.RadioButton();
            this.radioPersonelSoyisim = new System.Windows.Forms.RadioButton();
            this.radioPersonelAdı = new System.Windows.Forms.RadioButton();
            this.radioPersonelTC = new System.Windows.Forms.RadioButton();
            this.lblPersonelEmail = new System.Windows.Forms.Label();
            this.txtPersonelEmail = new System.Windows.Forms.TextBox();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelGüncelle = new System.Windows.Forms.Button();
            this.lblPersonelAdres = new System.Windows.Forms.Label();
            this.lblPersonelTelefon = new System.Windows.Forms.Label();
            this.txtPersonelAdres = new System.Windows.Forms.TextBox();
            this.txtPersonelTelefon = new System.Windows.Forms.TextBox();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.lblTabloFont = new System.Windows.Forms.Label();
            this.trackBarTabloYazıBoyutu = new System.Windows.Forms.TrackBar();
            this.btnPersonelAra = new System.Windows.Forms.Button();
            this.lblPersonelTC = new System.Windows.Forms.Label();
            this.lblPersonelSoyad = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.txtPersonelAdı = new System.Windows.Forms.TextBox();
            this.txtPersonelTC = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.dataGridViewPERSONEL = new System.Windows.Forms.DataGridView();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnPersonelMenüsü = new System.Windows.Forms.Button();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.txtPersonelŞifre = new System.Windows.Forms.TextBox();
            this.lblPersonelKullanıcıAdı = new System.Windows.Forms.Label();
            this.txtPersonelKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.radioPersonelID = new System.Windows.Forms.RadioButton();
            this.radioPersonelKullanıcıAdı = new System.Windows.Forms.RadioButton();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.btnGuvenliSifreOlustur = new System.Windows.Forms.Button();
            this.lblGuvenliSifre = new System.Windows.Forms.Label();
            this.txtGüvenliSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTabloYazıBoyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPERSONEL)).BeginInit();
            this.SuspendLayout();
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
            // txtPersonelAra
            // 
            this.txtPersonelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAra.Location = new System.Drawing.Point(510, 602);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(243, 27);
            this.txtPersonelAra.TabIndex = 9;
            // 
            // radioPersonelEmail
            // 
            this.radioPersonelEmail.AutoSize = true;
            this.radioPersonelEmail.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelEmail.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelEmail.ForeColor = System.Drawing.Color.White;
            this.radioPersonelEmail.Location = new System.Drawing.Point(324, 748);
            this.radioPersonelEmail.Name = "radioPersonelEmail";
            this.radioPersonelEmail.Size = new System.Drawing.Size(142, 24);
            this.radioPersonelEmail.TabIndex = 23;
            this.radioPersonelEmail.TabStop = true;
            this.radioPersonelEmail.Text = "Email\'e Göre";
            this.radioPersonelEmail.UseVisualStyleBackColor = false;
            // 
            // radioPersonelAdres
            // 
            this.radioPersonelAdres.AutoSize = true;
            this.radioPersonelAdres.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelAdres.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelAdres.ForeColor = System.Drawing.Color.White;
            this.radioPersonelAdres.Location = new System.Drawing.Point(324, 718);
            this.radioPersonelAdres.Name = "radioPersonelAdres";
            this.radioPersonelAdres.Size = new System.Drawing.Size(137, 24);
            this.radioPersonelAdres.TabIndex = 22;
            this.radioPersonelAdres.TabStop = true;
            this.radioPersonelAdres.Text = "Adrese Göre";
            this.radioPersonelAdres.UseVisualStyleBackColor = false;
            // 
            // radioPersonelTelefon
            // 
            this.radioPersonelTelefon.AutoSize = true;
            this.radioPersonelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelTelefon.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelTelefon.ForeColor = System.Drawing.Color.White;
            this.radioPersonelTelefon.Location = new System.Drawing.Point(324, 688);
            this.radioPersonelTelefon.Name = "radioPersonelTelefon";
            this.radioPersonelTelefon.Size = new System.Drawing.Size(152, 24);
            this.radioPersonelTelefon.TabIndex = 21;
            this.radioPersonelTelefon.TabStop = true;
            this.radioPersonelTelefon.Text = "Telefona Göre";
            this.radioPersonelTelefon.UseVisualStyleBackColor = false;
            // 
            // radioPersonelSoyisim
            // 
            this.radioPersonelSoyisim.AutoSize = true;
            this.radioPersonelSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelSoyisim.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelSoyisim.ForeColor = System.Drawing.Color.White;
            this.radioPersonelSoyisim.Location = new System.Drawing.Point(324, 631);
            this.radioPersonelSoyisim.Name = "radioPersonelSoyisim";
            this.radioPersonelSoyisim.Size = new System.Drawing.Size(151, 24);
            this.radioPersonelSoyisim.TabIndex = 19;
            this.radioPersonelSoyisim.TabStop = true;
            this.radioPersonelSoyisim.Text = "Soyisme Göre";
            this.radioPersonelSoyisim.UseVisualStyleBackColor = false;
            // 
            // radioPersonelAdı
            // 
            this.radioPersonelAdı.AutoSize = true;
            this.radioPersonelAdı.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelAdı.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelAdı.ForeColor = System.Drawing.Color.White;
            this.radioPersonelAdı.Location = new System.Drawing.Point(324, 601);
            this.radioPersonelAdı.Name = "radioPersonelAdı";
            this.radioPersonelAdı.Size = new System.Drawing.Size(120, 24);
            this.radioPersonelAdı.TabIndex = 18;
            this.radioPersonelAdı.TabStop = true;
            this.radioPersonelAdı.Text = "İsme Göre";
            this.radioPersonelAdı.UseVisualStyleBackColor = false;
            // 
            // radioPersonelTC
            // 
            this.radioPersonelTC.AutoSize = true;
            this.radioPersonelTC.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelTC.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelTC.ForeColor = System.Drawing.Color.White;
            this.radioPersonelTC.Location = new System.Drawing.Point(324, 658);
            this.radioPersonelTC.Name = "radioPersonelTC";
            this.radioPersonelTC.Size = new System.Drawing.Size(127, 24);
            this.radioPersonelTC.TabIndex = 20;
            this.radioPersonelTC.TabStop = true;
            this.radioPersonelTC.Text = "TC\'ye Göre";
            this.radioPersonelTC.UseVisualStyleBackColor = false;
            // 
            // lblPersonelEmail
            // 
            this.lblPersonelEmail.AutoSize = true;
            this.lblPersonelEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelEmail.Location = new System.Drawing.Point(112, 366);
            this.lblPersonelEmail.Name = "lblPersonelEmail";
            this.lblPersonelEmail.Size = new System.Drawing.Size(85, 24);
            this.lblPersonelEmail.TabIndex = 129;
            this.lblPersonelEmail.Text = "EMAİL:";
            // 
            // txtPersonelEmail
            // 
            this.txtPersonelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelEmail.Location = new System.Drawing.Point(223, 372);
            this.txtPersonelEmail.Name = "txtPersonelEmail";
            this.txtPersonelEmail.Size = new System.Drawing.Size(145, 27);
            this.txtPersonelEmail.TabIndex = 6;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelSil.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.ForeColor = System.Drawing.Color.White;
            this.btnPersonelSil.Image = global::WindowsFormsApp1.Properties.Resources.user_delete_icon;
            this.btnPersonelSil.Location = new System.Drawing.Point(510, 155);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelSil.TabIndex = 13;
            this.btnPersonelSil.Text = "PERSONEL SİL";
            this.btnPersonelSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelGüncelle
            // 
            this.btnPersonelGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelGüncelle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelGüncelle.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnPersonelGüncelle.Location = new System.Drawing.Point(510, 12);
            this.btnPersonelGüncelle.Name = "btnPersonelGüncelle";
            this.btnPersonelGüncelle.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelGüncelle.TabIndex = 12;
            this.btnPersonelGüncelle.Text = "PERSONEL GÜNCELLE";
            this.btnPersonelGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelGüncelle.UseVisualStyleBackColor = false;
            this.btnPersonelGüncelle.Click += new System.EventHandler(this.btnPersonelGüncelle_Click);
            // 
            // lblPersonelAdres
            // 
            this.lblPersonelAdres.AutoSize = true;
            this.lblPersonelAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelAdres.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAdres.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelAdres.Location = new System.Drawing.Point(106, 333);
            this.lblPersonelAdres.Name = "lblPersonelAdres";
            this.lblPersonelAdres.Size = new System.Drawing.Size(91, 24);
            this.lblPersonelAdres.TabIndex = 125;
            this.lblPersonelAdres.Text = "ADRES:";
            // 
            // lblPersonelTelefon
            // 
            this.lblPersonelTelefon.AutoSize = true;
            this.lblPersonelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelTelefon.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelTelefon.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelTelefon.Location = new System.Drawing.Point(78, 300);
            this.lblPersonelTelefon.Name = "lblPersonelTelefon";
            this.lblPersonelTelefon.Size = new System.Drawing.Size(119, 24);
            this.lblPersonelTelefon.TabIndex = 124;
            this.lblPersonelTelefon.Text = "TELEFON:";
            // 
            // txtPersonelAdres
            // 
            this.txtPersonelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdres.Location = new System.Drawing.Point(223, 339);
            this.txtPersonelAdres.Name = "txtPersonelAdres";
            this.txtPersonelAdres.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelAdres.TabIndex = 5;
            // 
            // txtPersonelTelefon
            // 
            this.txtPersonelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelTelefon.Location = new System.Drawing.Point(223, 304);
            this.txtPersonelTelefon.Name = "txtPersonelTelefon";
            this.txtPersonelTelefon.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelTelefon.TabIndex = 4;
            this.txtPersonelTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelTelefon_KeyPress);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnYazdır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdır.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdır.ForeColor = System.Drawing.Color.White;
            this.btnYazdır.Image = global::WindowsFormsApp1.Properties.Resources.print_icon;
            this.btnYazdır.Location = new System.Drawing.Point(510, 829);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(243, 137);
            this.btnYazdır.TabIndex = 16;
            this.btnYazdır.Text = "TABLOYU YAZDIR";
            this.btnYazdır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click_1);
            // 
            // lblTabloFont
            // 
            this.lblTabloFont.AutoSize = true;
            this.lblTabloFont.BackColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTabloFont.ForeColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Location = new System.Drawing.Point(39, 869);
            this.lblTabloFont.Name = "lblTabloFont";
            this.lblTabloFont.Size = new System.Drawing.Size(269, 28);
            this.lblTabloFont.TabIndex = 120;
            this.lblTabloFont.Text = "TABLO YAZI BOYUTU";
            // 
            // trackBarTabloYazıBoyutu
            // 
            this.trackBarTabloYazıBoyutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.trackBarTabloYazıBoyutu.Location = new System.Drawing.Point(36, 907);
            this.trackBarTabloYazıBoyutu.Maximum = 15;
            this.trackBarTabloYazıBoyutu.Minimum = 7;
            this.trackBarTabloYazıBoyutu.Name = "trackBarTabloYazıBoyutu";
            this.trackBarTabloYazıBoyutu.Size = new System.Drawing.Size(285, 56);
            this.trackBarTabloYazıBoyutu.TabIndex = 25;
            this.trackBarTabloYazıBoyutu.Value = 7;
            this.trackBarTabloYazıBoyutu.Scroll += new System.EventHandler(this.trackBarTabloYazıBoyutu_Scroll);
            // 
            // btnPersonelAra
            // 
            this.btnPersonelAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelAra.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelAra.ForeColor = System.Drawing.Color.White;
            this.btnPersonelAra.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnPersonelAra.Location = new System.Drawing.Point(510, 635);
            this.btnPersonelAra.Name = "btnPersonelAra";
            this.btnPersonelAra.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelAra.TabIndex = 15;
            this.btnPersonelAra.Text = "PERSONEL ARA";
            this.btnPersonelAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelAra.UseVisualStyleBackColor = false;
            this.btnPersonelAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // lblPersonelTC
            // 
            this.lblPersonelTC.AutoSize = true;
            this.lblPersonelTC.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelTC.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelTC.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelTC.Location = new System.Drawing.Point(151, 267);
            this.lblPersonelTC.Name = "lblPersonelTC";
            this.lblPersonelTC.Size = new System.Drawing.Size(46, 24);
            this.lblPersonelTC.TabIndex = 117;
            this.lblPersonelTC.Text = "TC:";
            // 
            // lblPersonelSoyad
            // 
            this.lblPersonelSoyad.AutoSize = true;
            this.lblPersonelSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelSoyad.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSoyad.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelSoyad.Location = new System.Drawing.Point(99, 234);
            this.lblPersonelSoyad.Name = "lblPersonelSoyad";
            this.lblPersonelSoyad.Size = new System.Drawing.Size(98, 24);
            this.lblPersonelSoyad.TabIndex = 116;
            this.lblPersonelSoyad.Text = "SOYADI:";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelAd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAd.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelAd.Location = new System.Drawing.Point(142, 201);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(55, 24);
            this.lblPersonelAd.TabIndex = 115;
            this.lblPersonelAd.Text = "ADI:";
            // 
            // txtPersonelAdı
            // 
            this.txtPersonelAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdı.Location = new System.Drawing.Point(223, 199);
            this.txtPersonelAdı.Name = "txtPersonelAdı";
            this.txtPersonelAdı.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelAdı.TabIndex = 1;
            this.txtPersonelAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelAdı_KeyPress);
            // 
            // txtPersonelTC
            // 
            this.txtPersonelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelTC.Location = new System.Drawing.Point(223, 269);
            this.txtPersonelTC.MaxLength = 11;
            this.txtPersonelTC.Name = "txtPersonelTC";
            this.txtPersonelTC.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelTC.TabIndex = 3;
            this.txtPersonelTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelTC_KeyPress);
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSoyad.Location = new System.Drawing.Point(223, 234);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelSoyad.TabIndex = 2;
            this.txtPersonelSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelSoyad_KeyPress);
            // 
            // dataGridViewPERSONEL
            // 
            this.dataGridViewPERSONEL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPERSONEL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPERSONEL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPERSONEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPERSONEL.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPERSONEL.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPERSONEL.Location = new System.Drawing.Point(767, 13);
            this.dataGridViewPERSONEL.Name = "dataGridViewPERSONEL";
            this.dataGridViewPERSONEL.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPERSONEL.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPERSONEL.RowHeadersVisible = false;
            this.dataGridViewPERSONEL.RowHeadersWidth = 51;
            this.dataGridViewPERSONEL.RowTemplate.Height = 24;
            this.dataGridViewPERSONEL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPERSONEL.Size = new System.Drawing.Size(1278, 1035);
            this.dataGridViewPERSONEL.TabIndex = 26;
            this.dataGridViewPERSONEL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPERSONEL_CellContentClick);
            this.dataGridViewPERSONEL.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPERSONEL_CellMouseClick);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelEkle.Image = global::WindowsFormsApp1.Properties.Resources.user_add_icon;
            this.btnPersonelEkle.Location = new System.Drawing.Point(510, 298);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelEkle.TabIndex = 14;
            this.btnPersonelEkle.Text = "PERSONEL OLUŞTUR";
            this.btnPersonelEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelListesi.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListesi.ForeColor = System.Drawing.Color.White;
            this.btnPersonelListesi.Image = global::WindowsFormsApp1.Properties.Resources.user_info_2_icon;
            this.btnPersonelListesi.Location = new System.Drawing.Point(261, 12);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelListesi.TabIndex = 11;
            this.btnPersonelListesi.Text = "PERSONELLERİ LİSTELE";
            this.btnPersonelListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelListesi.UseVisualStyleBackColor = false;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnPersonelMenüsü
            // 
            this.btnPersonelMenüsü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelMenüsü.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelMenüsü.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelMenüsü.ForeColor = System.Drawing.Color.White;
            this.btnPersonelMenüsü.Image = global::WindowsFormsApp1.Properties.Resources.Industry_Return_icon;
            this.btnPersonelMenüsü.Location = new System.Drawing.Point(12, 12);
            this.btnPersonelMenüsü.Name = "btnPersonelMenüsü";
            this.btnPersonelMenüsü.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelMenüsü.TabIndex = 10;
            this.btnPersonelMenüsü.Text = "PERSONEL MENÜSÜNE DÖN";
            this.btnPersonelMenüsü.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelMenüsü.UseVisualStyleBackColor = false;
            this.btnPersonelMenüsü.Click += new System.EventHandler(this.btnPersonelMenüsü_Click_1);
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.BackColor = System.Drawing.Color.Transparent;
            this.lblŞifre.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.ForeColor = System.Drawing.Color.Transparent;
            this.lblŞifre.Location = new System.Drawing.Point(114, 432);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(83, 24);
            this.lblŞifre.TabIndex = 140;
            this.lblŞifre.Text = "ŞİFRE:";
            // 
            // txtPersonelŞifre
            // 
            this.txtPersonelŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelŞifre.Location = new System.Drawing.Point(223, 438);
            this.txtPersonelŞifre.Name = "txtPersonelŞifre";
            this.txtPersonelŞifre.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelŞifre.TabIndex = 8;
            // 
            // lblPersonelKullanıcıAdı
            // 
            this.lblPersonelKullanıcıAdı.AutoSize = true;
            this.lblPersonelKullanıcıAdı.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelKullanıcıAdı.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKullanıcıAdı.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelKullanıcıAdı.Location = new System.Drawing.Point(18, 399);
            this.lblPersonelKullanıcıAdı.Name = "lblPersonelKullanıcıAdı";
            this.lblPersonelKullanıcıAdı.Size = new System.Drawing.Size(179, 24);
            this.lblPersonelKullanıcıAdı.TabIndex = 138;
            this.lblPersonelKullanıcıAdı.Text = "KULLANICI ADI:";
            // 
            // txtPersonelKullanıcıAdı
            // 
            this.txtPersonelKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelKullanıcıAdı.Location = new System.Drawing.Point(223, 405);
            this.txtPersonelKullanıcıAdı.Name = "txtPersonelKullanıcıAdı";
            this.txtPersonelKullanıcıAdı.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelKullanıcıAdı.TabIndex = 7;
            // 
            // radioPersonelID
            // 
            this.radioPersonelID.AutoSize = true;
            this.radioPersonelID.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelID.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelID.ForeColor = System.Drawing.Color.White;
            this.radioPersonelID.Location = new System.Drawing.Point(324, 571);
            this.radioPersonelID.Name = "radioPersonelID";
            this.radioPersonelID.Size = new System.Drawing.Size(111, 24);
            this.radioPersonelID.TabIndex = 17;
            this.radioPersonelID.TabStop = true;
            this.radioPersonelID.Text = "ID\'e Göre";
            this.radioPersonelID.UseVisualStyleBackColor = false;
            // 
            // radioPersonelKullanıcıAdı
            // 
            this.radioPersonelKullanıcıAdı.AutoSize = true;
            this.radioPersonelKullanıcıAdı.BackColor = System.Drawing.Color.Transparent;
            this.radioPersonelKullanıcıAdı.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioPersonelKullanıcıAdı.ForeColor = System.Drawing.Color.White;
            this.radioPersonelKullanıcıAdı.Location = new System.Drawing.Point(324, 778);
            this.radioPersonelKullanıcıAdı.Name = "radioPersonelKullanıcıAdı";
            this.radioPersonelKullanıcıAdı.Size = new System.Drawing.Size(213, 24);
            this.radioPersonelKullanıcıAdı.TabIndex = 24;
            this.radioPersonelKullanıcıAdı.TabStop = true;
            this.radioPersonelKullanıcıAdı.Text = "Kullanıcı Adına Göre";
            this.radioPersonelKullanıcıAdı.UseVisualStyleBackColor = false;
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonelID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelID.ForeColor = System.Drawing.Color.Transparent;
            this.lblPersonelID.Location = new System.Drawing.Point(33, 168);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(164, 24);
            this.lblPersonelID.TabIndex = 144;
            this.lblPersonelID.Text = "PERSONEL ID:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(223, 166);
            this.txtPersonelID.MaxLength = 5;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(272, 27);
            this.txtPersonelID.TabIndex = 0;
            this.txtPersonelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelID_KeyPress);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@yahoo.com",
            "@outlook.com"});
            this.comboBoxEmail.Location = new System.Drawing.Point(374, 372);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEmail.TabIndex = 145;
            this.comboBoxEmail.Text = "@gmail.com";
            // 
            // btnGuvenliSifreOlustur
            // 
            this.btnGuvenliSifreOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnGuvenliSifreOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuvenliSifreOlustur.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuvenliSifreOlustur.ForeColor = System.Drawing.Color.White;
            this.btnGuvenliSifreOlustur.Image = global::WindowsFormsApp1.Properties.Resources.user_add_icon;
            this.btnGuvenliSifreOlustur.Location = new System.Drawing.Point(510, 437);
            this.btnGuvenliSifreOlustur.Name = "btnGuvenliSifreOlustur";
            this.btnGuvenliSifreOlustur.Size = new System.Drawing.Size(243, 137);
            this.btnGuvenliSifreOlustur.TabIndex = 146;
            this.btnGuvenliSifreOlustur.Text = "GÜVENLİ ŞİFRE OLUŞTUR";
            this.btnGuvenliSifreOlustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuvenliSifreOlustur.UseVisualStyleBackColor = false;
            this.btnGuvenliSifreOlustur.Click += new System.EventHandler(this.btnGuvenliSifreOlustur_Click);
            // 
            // lblGuvenliSifre
            // 
            this.lblGuvenliSifre.AutoSize = true;
            this.lblGuvenliSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblGuvenliSifre.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenliSifre.ForeColor = System.Drawing.Color.Transparent;
            this.lblGuvenliSifre.Location = new System.Drawing.Point(8, 471);
            this.lblGuvenliSifre.Name = "lblGuvenliSifre";
            this.lblGuvenliSifre.Size = new System.Drawing.Size(186, 24);
            this.lblGuvenliSifre.TabIndex = 148;
            this.lblGuvenliSifre.Text = "GÜVENLİ ŞİFRE:";
            // 
            // txtGüvenliSifre
            // 
            this.txtGüvenliSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGüvenliSifre.Location = new System.Drawing.Point(223, 471);
            this.txtGüvenliSifre.Name = "txtGüvenliSifre";
            this.txtGüvenliSifre.Size = new System.Drawing.Size(272, 27);
            this.txtGüvenliSifre.TabIndex = 147;
            // 
            // Personelİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._389873;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.lblGuvenliSifre);
            this.Controls.Add(this.txtGüvenliSifre);
            this.Controls.Add(this.btnGuvenliSifreOlustur);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.radioPersonelKullanıcıAdı);
            this.Controls.Add(this.radioPersonelID);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.txtPersonelŞifre);
            this.Controls.Add(this.lblPersonelKullanıcıAdı);
            this.Controls.Add(this.txtPersonelKullanıcıAdı);
            this.Controls.Add(this.txtPersonelAra);
            this.Controls.Add(this.radioPersonelEmail);
            this.Controls.Add(this.radioPersonelAdres);
            this.Controls.Add(this.radioPersonelTelefon);
            this.Controls.Add(this.radioPersonelSoyisim);
            this.Controls.Add(this.radioPersonelAdı);
            this.Controls.Add(this.radioPersonelTC);
            this.Controls.Add(this.lblPersonelEmail);
            this.Controls.Add(this.txtPersonelEmail);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelGüncelle);
            this.Controls.Add(this.lblPersonelAdres);
            this.Controls.Add(this.lblPersonelTelefon);
            this.Controls.Add(this.txtPersonelAdres);
            this.Controls.Add(this.txtPersonelTelefon);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.lblTabloFont);
            this.Controls.Add(this.trackBarTabloYazıBoyutu);
            this.Controls.Add(this.btnPersonelAra);
            this.Controls.Add(this.lblPersonelTC);
            this.Controls.Add(this.lblPersonelSoyad);
            this.Controls.Add(this.lblPersonelAd);
            this.Controls.Add(this.txtPersonelAdı);
            this.Controls.Add(this.txtPersonelTC);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.dataGridViewPERSONEL);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnPersonelMenüsü);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personelİşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personelİşlemleri_Load);
            this.Resize += new System.EventHandler(this.Personelİşlemleri_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTabloYazıBoyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPERSONEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.RadioButton radioPersonelEmail;
        private System.Windows.Forms.RadioButton radioPersonelAdres;
        private System.Windows.Forms.RadioButton radioPersonelTelefon;
        private System.Windows.Forms.RadioButton radioPersonelSoyisim;
        private System.Windows.Forms.RadioButton radioPersonelAdı;
        private System.Windows.Forms.RadioButton radioPersonelTC;
        private System.Windows.Forms.Label lblPersonelEmail;
        private System.Windows.Forms.TextBox txtPersonelEmail;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelGüncelle;
        private System.Windows.Forms.Label lblPersonelAdres;
        private System.Windows.Forms.Label lblPersonelTelefon;
        private System.Windows.Forms.TextBox txtPersonelAdres;
        private System.Windows.Forms.TextBox txtPersonelTelefon;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Label lblTabloFont;
        private System.Windows.Forms.TrackBar trackBarTabloYazıBoyutu;
        private System.Windows.Forms.Button btnPersonelAra;
        private System.Windows.Forms.Label lblPersonelTC;
        private System.Windows.Forms.Label lblPersonelSoyad;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelAdı;
        private System.Windows.Forms.TextBox txtPersonelTC;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.DataGridView dataGridViewPERSONEL;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListesi;
        private System.Windows.Forms.Button btnPersonelMenüsü;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.TextBox txtPersonelŞifre;
        private System.Windows.Forms.Label lblPersonelKullanıcıAdı;
        private System.Windows.Forms.TextBox txtPersonelKullanıcıAdı;
        private System.Windows.Forms.RadioButton radioPersonelID;
        private System.Windows.Forms.RadioButton radioPersonelKullanıcıAdı;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Button btnGuvenliSifreOlustur;
        private System.Windows.Forms.Label lblGuvenliSifre;
        private System.Windows.Forms.TextBox txtGüvenliSifre;
    }
}