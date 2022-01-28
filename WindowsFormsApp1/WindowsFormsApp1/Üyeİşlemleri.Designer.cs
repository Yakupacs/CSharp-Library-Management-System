namespace WindowsFormsApp1
{
    partial class Üyeİşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üyeİşlemleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnÜyeSil = new System.Windows.Forms.Button();
            this.btnÜyeGüncelle = new System.Windows.Forms.Button();
            this.lblÜyeAdres = new System.Windows.Forms.Label();
            this.lblÜyeTelefon = new System.Windows.Forms.Label();
            this.txtÜyeAdres = new System.Windows.Forms.TextBox();
            this.txtÜyeTelefon = new System.Windows.Forms.TextBox();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.lblTabloFont = new System.Windows.Forms.Label();
            this.trackBarTabloYazıBoyutu = new System.Windows.Forms.TrackBar();
            this.btnÜyeAra = new System.Windows.Forms.Button();
            this.lblÜyeTC = new System.Windows.Forms.Label();
            this.lblÜyeSoyad = new System.Windows.Forms.Label();
            this.lblÜyeAd = new System.Windows.Forms.Label();
            this.txtÜyeTC = new System.Windows.Forms.TextBox();
            this.txtÜyeSoyad = new System.Windows.Forms.TextBox();
            this.txtÜyeAd = new System.Windows.Forms.TextBox();
            this.dataGridViewÜYE = new System.Windows.Forms.DataGridView();
            this.btnÜyeEkle = new System.Windows.Forms.Button();
            this.btnÜyeListesi = new System.Windows.Forms.Button();
            this.btnPersonelMenüsü = new System.Windows.Forms.Button();
            this.lblÜyeEmail = new System.Windows.Forms.Label();
            this.txtÜyeEmail = new System.Windows.Forms.TextBox();
            this.radioÜyeTC = new System.Windows.Forms.RadioButton();
            this.radioÜyeAdı = new System.Windows.Forms.RadioButton();
            this.radioÜyeSoyisim = new System.Windows.Forms.RadioButton();
            this.radioÜyeTelefon = new System.Windows.Forms.RadioButton();
            this.radioÜyeAdres = new System.Windows.Forms.RadioButton();
            this.radioÜyeEmail = new System.Windows.Forms.RadioButton();
            this.txtÜyeAra = new System.Windows.Forms.TextBox();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTabloYazıBoyutu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÜYE)).BeginInit();
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
            // btnÜyeSil
            // 
            this.btnÜyeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnÜyeSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeSil.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeSil.ForeColor = System.Drawing.Color.White;
            this.btnÜyeSil.Image = global::WindowsFormsApp1.Properties.Resources.user_delete_icon;
            this.btnÜyeSil.Location = new System.Drawing.Point(506, 154);
            this.btnÜyeSil.Name = "btnÜyeSil";
            this.btnÜyeSil.Size = new System.Drawing.Size(243, 137);
            this.btnÜyeSil.TabIndex = 10;
            this.btnÜyeSil.Text = "ÜYE SİL";
            this.btnÜyeSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnÜyeSil.UseVisualStyleBackColor = false;
            this.btnÜyeSil.Click += new System.EventHandler(this.btnÜyeSil_Click);
            // 
            // btnÜyeGüncelle
            // 
            this.btnÜyeGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnÜyeGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeGüncelle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnÜyeGüncelle.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnÜyeGüncelle.Location = new System.Drawing.Point(506, 11);
            this.btnÜyeGüncelle.Name = "btnÜyeGüncelle";
            this.btnÜyeGüncelle.Size = new System.Drawing.Size(243, 137);
            this.btnÜyeGüncelle.TabIndex = 9;
            this.btnÜyeGüncelle.Text = "ÜYE GÜNCELLE";
            this.btnÜyeGüncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnÜyeGüncelle.UseVisualStyleBackColor = false;
            this.btnÜyeGüncelle.Click += new System.EventHandler(this.btnÜyeGüncelle_Click);
            // 
            // lblÜyeAdres
            // 
            this.lblÜyeAdres.AutoSize = true;
            this.lblÜyeAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblÜyeAdres.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜyeAdres.ForeColor = System.Drawing.Color.Transparent;
            this.lblÜyeAdres.Location = new System.Drawing.Point(45, 337);
            this.lblÜyeAdres.Name = "lblÜyeAdres";
            this.lblÜyeAdres.Size = new System.Drawing.Size(142, 24);
            this.lblÜyeAdres.TabIndex = 97;
            this.lblÜyeAdres.Text = "ÜYE ADRES:";
            this.lblÜyeAdres.Click += new System.EventHandler(this.lblÜyeAdres_Click);
            // 
            // lblÜyeTelefon
            // 
            this.lblÜyeTelefon.AutoSize = true;
            this.lblÜyeTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblÜyeTelefon.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜyeTelefon.ForeColor = System.Drawing.Color.Transparent;
            this.lblÜyeTelefon.Location = new System.Drawing.Point(17, 303);
            this.lblÜyeTelefon.Name = "lblÜyeTelefon";
            this.lblÜyeTelefon.Size = new System.Drawing.Size(170, 24);
            this.lblÜyeTelefon.TabIndex = 96;
            this.lblÜyeTelefon.Text = "ÜYE TELEFON:";
            this.lblÜyeTelefon.Click += new System.EventHandler(this.lblÜyeTelefon_Click);
            // 
            // txtÜyeAdres
            // 
            this.txtÜyeAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeAdres.Location = new System.Drawing.Point(208, 337);
            this.txtÜyeAdres.Name = "txtÜyeAdres";
            this.txtÜyeAdres.Size = new System.Drawing.Size(272, 27);
            this.txtÜyeAdres.TabIndex = 4;
            this.txtÜyeAdres.TextChanged += new System.EventHandler(this.txtÜyeAdres_TextChanged);
            // 
            // txtÜyeTelefon
            // 
            this.txtÜyeTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeTelefon.Location = new System.Drawing.Point(208, 302);
            this.txtÜyeTelefon.Name = "txtÜyeTelefon";
            this.txtÜyeTelefon.Size = new System.Drawing.Size(272, 27);
            this.txtÜyeTelefon.TabIndex = 3;
            this.txtÜyeTelefon.TextChanged += new System.EventHandler(this.txtÜyeTelefon_TextChanged);
            this.txtÜyeTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeTelefon_KeyPress);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnYazdır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdır.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdır.ForeColor = System.Drawing.Color.White;
            this.btnYazdır.Image = global::WindowsFormsApp1.Properties.Resources.print_icon;
            this.btnYazdır.Location = new System.Drawing.Point(506, 828);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(243, 137);
            this.btnYazdır.TabIndex = 13;
            this.btnYazdır.Text = "TABLOYU YAZDIR";
            this.btnYazdır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnTabloYazdır_Click);
            // 
            // lblTabloFont
            // 
            this.lblTabloFont.AutoSize = true;
            this.lblTabloFont.BackColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTabloFont.ForeColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Location = new System.Drawing.Point(29, 868);
            this.lblTabloFont.Name = "lblTabloFont";
            this.lblTabloFont.Size = new System.Drawing.Size(269, 28);
            this.lblTabloFont.TabIndex = 89;
            this.lblTabloFont.Text = "TABLO YAZI BOYUTU";
            this.lblTabloFont.Click += new System.EventHandler(this.lblTabloFont_Click);
            // 
            // trackBarTabloYazıBoyutu
            // 
            this.trackBarTabloYazıBoyutu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.trackBarTabloYazıBoyutu.Location = new System.Drawing.Point(23, 906);
            this.trackBarTabloYazıBoyutu.Maximum = 15;
            this.trackBarTabloYazıBoyutu.Minimum = 7;
            this.trackBarTabloYazıBoyutu.Name = "trackBarTabloYazıBoyutu";
            this.trackBarTabloYazıBoyutu.Size = new System.Drawing.Size(285, 56);
            this.trackBarTabloYazıBoyutu.TabIndex = 20;
            this.trackBarTabloYazıBoyutu.Value = 7;
            this.trackBarTabloYazıBoyutu.Scroll += new System.EventHandler(this.trackBarTabloYazıBoyutu_Scroll);
            // 
            // btnÜyeAra
            // 
            this.btnÜyeAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnÜyeAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeAra.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeAra.ForeColor = System.Drawing.Color.White;
            this.btnÜyeAra.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnÜyeAra.Location = new System.Drawing.Point(506, 601);
            this.btnÜyeAra.Name = "btnÜyeAra";
            this.btnÜyeAra.Size = new System.Drawing.Size(243, 137);
            this.btnÜyeAra.TabIndex = 12;
            this.btnÜyeAra.Text = "ÜYE ARA";
            this.btnÜyeAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnÜyeAra.UseVisualStyleBackColor = false;
            this.btnÜyeAra.Click += new System.EventHandler(this.btnÜyeAra_Click);
            // 
            // lblÜyeTC
            // 
            this.lblÜyeTC.AutoSize = true;
            this.lblÜyeTC.BackColor = System.Drawing.Color.Transparent;
            this.lblÜyeTC.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜyeTC.ForeColor = System.Drawing.Color.Transparent;
            this.lblÜyeTC.Location = new System.Drawing.Point(90, 201);
            this.lblÜyeTC.Name = "lblÜyeTC";
            this.lblÜyeTC.Size = new System.Drawing.Size(97, 24);
            this.lblÜyeTC.TabIndex = 86;
            this.lblÜyeTC.Text = "ÜYE TC:";
            this.lblÜyeTC.Click += new System.EventHandler(this.lblÜyeTC_Click);
            // 
            // lblÜyeSoyad
            // 
            this.lblÜyeSoyad.AutoSize = true;
            this.lblÜyeSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblÜyeSoyad.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜyeSoyad.ForeColor = System.Drawing.Color.Transparent;
            this.lblÜyeSoyad.Location = new System.Drawing.Point(38, 269);
            this.lblÜyeSoyad.Name = "lblÜyeSoyad";
            this.lblÜyeSoyad.Size = new System.Drawing.Size(149, 24);
            this.lblÜyeSoyad.TabIndex = 85;
            this.lblÜyeSoyad.Text = "ÜYE SOYADI:";
            this.lblÜyeSoyad.Click += new System.EventHandler(this.lblÜyeSoyad_Click);
            // 
            // lblÜyeAd
            // 
            this.lblÜyeAd.AutoSize = true;
            this.lblÜyeAd.BackColor = System.Drawing.Color.Transparent;
            this.lblÜyeAd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜyeAd.ForeColor = System.Drawing.Color.Transparent;
            this.lblÜyeAd.Location = new System.Drawing.Point(81, 235);
            this.lblÜyeAd.Name = "lblÜyeAd";
            this.lblÜyeAd.Size = new System.Drawing.Size(106, 24);
            this.lblÜyeAd.TabIndex = 84;
            this.lblÜyeAd.Text = "ÜYE ADI:";
            this.lblÜyeAd.Click += new System.EventHandler(this.lblÜyeAd_Click);
            // 
            // txtÜyeTC
            // 
            this.txtÜyeTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeTC.Location = new System.Drawing.Point(208, 197);
            this.txtÜyeTC.MaxLength = 11;
            this.txtÜyeTC.Name = "txtÜyeTC";
            this.txtÜyeTC.Size = new System.Drawing.Size(272, 27);
            this.txtÜyeTC.TabIndex = 0;
            this.txtÜyeTC.TextChanged += new System.EventHandler(this.txtÜyeTC_TextChanged);
            this.txtÜyeTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeTC_KeyPress);
            // 
            // txtÜyeSoyad
            // 
            this.txtÜyeSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeSoyad.Location = new System.Drawing.Point(208, 267);
            this.txtÜyeSoyad.Name = "txtÜyeSoyad";
            this.txtÜyeSoyad.Size = new System.Drawing.Size(272, 27);
            this.txtÜyeSoyad.TabIndex = 2;
            this.txtÜyeSoyad.TextChanged += new System.EventHandler(this.txtÜyeSoyad_TextChanged);
            this.txtÜyeSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeSoyad_KeyPress);
            // 
            // txtÜyeAd
            // 
            this.txtÜyeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeAd.Location = new System.Drawing.Point(208, 232);
            this.txtÜyeAd.Name = "txtÜyeAd";
            this.txtÜyeAd.Size = new System.Drawing.Size(272, 27);
            this.txtÜyeAd.TabIndex = 1;
            this.txtÜyeAd.TextChanged += new System.EventHandler(this.txtÜyeAd_TextChanged);
            this.txtÜyeAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeAd_KeyPress);
            // 
            // dataGridViewÜYE
            // 
            this.dataGridViewÜYE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewÜYE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewÜYE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewÜYE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÜYE.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewÜYE.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewÜYE.Location = new System.Drawing.Point(763, 12);
            this.dataGridViewÜYE.Name = "dataGridViewÜYE";
            this.dataGridViewÜYE.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewÜYE.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewÜYE.RowHeadersVisible = false;
            this.dataGridViewÜYE.RowHeadersWidth = 51;
            this.dataGridViewÜYE.RowTemplate.Height = 24;
            this.dataGridViewÜYE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewÜYE.Size = new System.Drawing.Size(1278, 1035);
            this.dataGridViewÜYE.TabIndex = 21;
            this.dataGridViewÜYE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÜYE_CellContentClick);
            this.dataGridViewÜYE.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewÜYE_CellMouseClick);
            // 
            // btnÜyeEkle
            // 
            this.btnÜyeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnÜyeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeEkle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeEkle.ForeColor = System.Drawing.Color.White;
            this.btnÜyeEkle.Image = global::WindowsFormsApp1.Properties.Resources.user_add_icon;
            this.btnÜyeEkle.Location = new System.Drawing.Point(506, 297);
            this.btnÜyeEkle.Name = "btnÜyeEkle";
            this.btnÜyeEkle.Size = new System.Drawing.Size(243, 137);
            this.btnÜyeEkle.TabIndex = 11;
            this.btnÜyeEkle.Text = "ÜYE OLUŞTUR";
            this.btnÜyeEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnÜyeEkle.UseVisualStyleBackColor = false;
            this.btnÜyeEkle.Click += new System.EventHandler(this.btnÜyeEkle_Click_1);
            // 
            // btnÜyeListesi
            // 
            this.btnÜyeListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnÜyeListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeListesi.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜyeListesi.ForeColor = System.Drawing.Color.White;
            this.btnÜyeListesi.Image = global::WindowsFormsApp1.Properties.Resources.user_info_2_icon;
            this.btnÜyeListesi.Location = new System.Drawing.Point(257, 11);
            this.btnÜyeListesi.Name = "btnÜyeListesi";
            this.btnÜyeListesi.Size = new System.Drawing.Size(243, 137);
            this.btnÜyeListesi.TabIndex = 8;
            this.btnÜyeListesi.Text = "ÜYELERİ LİSTELE";
            this.btnÜyeListesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnÜyeListesi.UseVisualStyleBackColor = false;
            this.btnÜyeListesi.Click += new System.EventHandler(this.btnÜyeListesi_Click);
            // 
            // btnPersonelMenüsü
            // 
            this.btnPersonelMenüsü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelMenüsü.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelMenüsü.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelMenüsü.ForeColor = System.Drawing.Color.White;
            this.btnPersonelMenüsü.Image = global::WindowsFormsApp1.Properties.Resources.Industry_Return_icon;
            this.btnPersonelMenüsü.Location = new System.Drawing.Point(8, 11);
            this.btnPersonelMenüsü.Name = "btnPersonelMenüsü";
            this.btnPersonelMenüsü.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelMenüsü.TabIndex = 7;
            this.btnPersonelMenüsü.Text = "PERSONEL MENÜSÜNE DÖN";
            this.btnPersonelMenüsü.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelMenüsü.UseVisualStyleBackColor = false;
            this.btnPersonelMenüsü.Click += new System.EventHandler(this.btnPersonelMenüsü_Click_1);
            // 
            // lblÜyeEmail
            // 
            this.lblÜyeEmail.AutoSize = true;
            this.lblÜyeEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblÜyeEmail.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÜyeEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblÜyeEmail.Location = new System.Drawing.Point(51, 371);
            this.lblÜyeEmail.Name = "lblÜyeEmail";
            this.lblÜyeEmail.Size = new System.Drawing.Size(136, 24);
            this.lblÜyeEmail.TabIndex = 101;
            this.lblÜyeEmail.Text = "ÜYE EMAİL:";
            this.lblÜyeEmail.Click += new System.EventHandler(this.lblÜyeEmail_Click);
            // 
            // txtÜyeEmail
            // 
            this.txtÜyeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeEmail.Location = new System.Drawing.Point(208, 370);
            this.txtÜyeEmail.Name = "txtÜyeEmail";
            this.txtÜyeEmail.Size = new System.Drawing.Size(145, 27);
            this.txtÜyeEmail.TabIndex = 5;
            this.txtÜyeEmail.TextChanged += new System.EventHandler(this.txtÜyeEmail_TextChanged);
            // 
            // radioÜyeTC
            // 
            this.radioÜyeTC.AutoSize = true;
            this.radioÜyeTC.BackColor = System.Drawing.Color.Transparent;
            this.radioÜyeTC.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜyeTC.ForeColor = System.Drawing.Color.White;
            this.radioÜyeTC.Location = new System.Drawing.Point(323, 568);
            this.radioÜyeTC.Name = "radioÜyeTC";
            this.radioÜyeTC.Size = new System.Drawing.Size(127, 24);
            this.radioÜyeTC.TabIndex = 14;
            this.radioÜyeTC.TabStop = true;
            this.radioÜyeTC.Text = "TC\'ye Göre";
            this.radioÜyeTC.UseVisualStyleBackColor = false;
            this.radioÜyeTC.CheckedChanged += new System.EventHandler(this.radioÜyeTC_CheckedChanged);
            // 
            // radioÜyeAdı
            // 
            this.radioÜyeAdı.AutoSize = true;
            this.radioÜyeAdı.BackColor = System.Drawing.Color.Transparent;
            this.radioÜyeAdı.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜyeAdı.ForeColor = System.Drawing.Color.White;
            this.radioÜyeAdı.Location = new System.Drawing.Point(323, 598);
            this.radioÜyeAdı.Name = "radioÜyeAdı";
            this.radioÜyeAdı.Size = new System.Drawing.Size(120, 24);
            this.radioÜyeAdı.TabIndex = 15;
            this.radioÜyeAdı.TabStop = true;
            this.radioÜyeAdı.Text = "İsme Göre";
            this.radioÜyeAdı.UseVisualStyleBackColor = false;
            this.radioÜyeAdı.CheckedChanged += new System.EventHandler(this.radioÜyeAdı_CheckedChanged);
            // 
            // radioÜyeSoyisim
            // 
            this.radioÜyeSoyisim.AutoSize = true;
            this.radioÜyeSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.radioÜyeSoyisim.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜyeSoyisim.ForeColor = System.Drawing.Color.White;
            this.radioÜyeSoyisim.Location = new System.Drawing.Point(323, 628);
            this.radioÜyeSoyisim.Name = "radioÜyeSoyisim";
            this.radioÜyeSoyisim.Size = new System.Drawing.Size(151, 24);
            this.radioÜyeSoyisim.TabIndex = 16;
            this.radioÜyeSoyisim.TabStop = true;
            this.radioÜyeSoyisim.Text = "Soyisme Göre";
            this.radioÜyeSoyisim.UseVisualStyleBackColor = false;
            this.radioÜyeSoyisim.CheckedChanged += new System.EventHandler(this.radioÜyeSoyisim_CheckedChanged);
            // 
            // radioÜyeTelefon
            // 
            this.radioÜyeTelefon.AutoSize = true;
            this.radioÜyeTelefon.BackColor = System.Drawing.Color.Transparent;
            this.radioÜyeTelefon.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜyeTelefon.ForeColor = System.Drawing.Color.White;
            this.radioÜyeTelefon.Location = new System.Drawing.Point(323, 658);
            this.radioÜyeTelefon.Name = "radioÜyeTelefon";
            this.radioÜyeTelefon.Size = new System.Drawing.Size(152, 24);
            this.radioÜyeTelefon.TabIndex = 17;
            this.radioÜyeTelefon.TabStop = true;
            this.radioÜyeTelefon.Text = "Telefona Göre";
            this.radioÜyeTelefon.UseVisualStyleBackColor = false;
            this.radioÜyeTelefon.CheckedChanged += new System.EventHandler(this.radioÜyeTelefon_CheckedChanged);
            // 
            // radioÜyeAdres
            // 
            this.radioÜyeAdres.AutoSize = true;
            this.radioÜyeAdres.BackColor = System.Drawing.Color.Transparent;
            this.radioÜyeAdres.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜyeAdres.ForeColor = System.Drawing.Color.White;
            this.radioÜyeAdres.Location = new System.Drawing.Point(323, 688);
            this.radioÜyeAdres.Name = "radioÜyeAdres";
            this.radioÜyeAdres.Size = new System.Drawing.Size(137, 24);
            this.radioÜyeAdres.TabIndex = 18;
            this.radioÜyeAdres.TabStop = true;
            this.radioÜyeAdres.Text = "Adrese Göre";
            this.radioÜyeAdres.UseVisualStyleBackColor = false;
            this.radioÜyeAdres.CheckedChanged += new System.EventHandler(this.radioÜyeAdres_CheckedChanged);
            // 
            // radioÜyeEmail
            // 
            this.radioÜyeEmail.AutoSize = true;
            this.radioÜyeEmail.BackColor = System.Drawing.Color.Transparent;
            this.radioÜyeEmail.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜyeEmail.ForeColor = System.Drawing.Color.White;
            this.radioÜyeEmail.Location = new System.Drawing.Point(323, 718);
            this.radioÜyeEmail.Name = "radioÜyeEmail";
            this.radioÜyeEmail.Size = new System.Drawing.Size(138, 24);
            this.radioÜyeEmail.TabIndex = 19;
            this.radioÜyeEmail.TabStop = true;
            this.radioÜyeEmail.Text = "Emaile Göre";
            this.radioÜyeEmail.UseVisualStyleBackColor = false;
            this.radioÜyeEmail.CheckedChanged += new System.EventHandler(this.radioÜyeEmail_CheckedChanged);
            // 
            // txtÜyeAra
            // 
            this.txtÜyeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeAra.Location = new System.Drawing.Point(506, 568);
            this.txtÜyeAra.Name = "txtÜyeAra";
            this.txtÜyeAra.Size = new System.Drawing.Size(243, 27);
            this.txtÜyeAra.TabIndex = 6;
            this.txtÜyeAra.TextChanged += new System.EventHandler(this.txtÜyeAra_TextChanged);
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
            this.comboBoxEmail.Location = new System.Drawing.Point(359, 370);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEmail.TabIndex = 146;
            this.comboBoxEmail.Text = "@gmail.com";
            // 
            // Üyeİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._389873;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.txtÜyeAra);
            this.Controls.Add(this.radioÜyeEmail);
            this.Controls.Add(this.radioÜyeAdres);
            this.Controls.Add(this.radioÜyeTelefon);
            this.Controls.Add(this.radioÜyeSoyisim);
            this.Controls.Add(this.radioÜyeAdı);
            this.Controls.Add(this.radioÜyeTC);
            this.Controls.Add(this.lblÜyeEmail);
            this.Controls.Add(this.txtÜyeEmail);
            this.Controls.Add(this.btnÜyeSil);
            this.Controls.Add(this.btnÜyeGüncelle);
            this.Controls.Add(this.lblÜyeAdres);
            this.Controls.Add(this.lblÜyeTelefon);
            this.Controls.Add(this.txtÜyeAdres);
            this.Controls.Add(this.txtÜyeTelefon);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.lblTabloFont);
            this.Controls.Add(this.trackBarTabloYazıBoyutu);
            this.Controls.Add(this.btnÜyeAra);
            this.Controls.Add(this.lblÜyeTC);
            this.Controls.Add(this.lblÜyeSoyad);
            this.Controls.Add(this.lblÜyeAd);
            this.Controls.Add(this.txtÜyeTC);
            this.Controls.Add(this.txtÜyeSoyad);
            this.Controls.Add(this.txtÜyeAd);
            this.Controls.Add(this.dataGridViewÜYE);
            this.Controls.Add(this.btnÜyeEkle);
            this.Controls.Add(this.btnÜyeListesi);
            this.Controls.Add(this.btnPersonelMenüsü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Üyeİşlemleri";
            this.Text = "Üye İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Üyeİşlemleri_Load);
            this.Resize += new System.EventHandler(this.Üyeİşlemleri_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTabloYazıBoyutu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÜYE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnÜyeSil;
        private System.Windows.Forms.Button btnÜyeGüncelle;
        private System.Windows.Forms.Label lblÜyeAdres;
        private System.Windows.Forms.Label lblÜyeTelefon;
        private System.Windows.Forms.TextBox txtÜyeAdres;
        private System.Windows.Forms.TextBox txtÜyeTelefon;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Label lblTabloFont;
        private System.Windows.Forms.TrackBar trackBarTabloYazıBoyutu;
        private System.Windows.Forms.Button btnÜyeAra;
        private System.Windows.Forms.Label lblÜyeTC;
        private System.Windows.Forms.Label lblÜyeSoyad;
        private System.Windows.Forms.Label lblÜyeAd;
        private System.Windows.Forms.TextBox txtÜyeTC;
        private System.Windows.Forms.TextBox txtÜyeSoyad;
        private System.Windows.Forms.TextBox txtÜyeAd;
        private System.Windows.Forms.DataGridView dataGridViewÜYE;
        private System.Windows.Forms.Button btnÜyeEkle;
        private System.Windows.Forms.Button btnÜyeListesi;
        private System.Windows.Forms.Button btnPersonelMenüsü;
        private System.Windows.Forms.Label lblÜyeEmail;
        private System.Windows.Forms.TextBox txtÜyeEmail;
        private System.Windows.Forms.RadioButton radioÜyeTC;
        private System.Windows.Forms.RadioButton radioÜyeAdı;
        private System.Windows.Forms.RadioButton radioÜyeSoyisim;
        private System.Windows.Forms.RadioButton radioÜyeTelefon;
        private System.Windows.Forms.RadioButton radioÜyeAdres;
        private System.Windows.Forms.RadioButton radioÜyeEmail;
        private System.Windows.Forms.TextBox txtÜyeAra;
        private System.Windows.Forms.ComboBox comboBoxEmail;
    }
}