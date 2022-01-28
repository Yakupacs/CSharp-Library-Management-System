namespace WindowsFormsApp1
{
    partial class Emanetİşlemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanetİşlemleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtÜyeTC = new System.Windows.Forms.TextBox();
            this.txtÜyeSoyad = new System.Windows.Forms.TextBox();
            this.txtÜyeÜyeAd = new System.Windows.Forms.TextBox();
            this.dataGridViewEMANET = new System.Windows.Forms.DataGridView();
            this.lblTabloFont = new System.Windows.Forms.Label();
            this.trackBarEmanet = new System.Windows.Forms.TrackBar();
            this.btnEmanetAra = new System.Windows.Forms.Button();
            this.btnEmanetiGeriAl = new System.Windows.Forms.Button();
            this.btnEmanetOluştur = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnPersonelMenüsü = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridViewKİTAPLAR = new System.Windows.Forms.DataGridView();
            this.dataGridViewÜYELER = new System.Windows.Forms.DataGridView();
            this.btnEmanetGelmeyenleriGör = new System.Windows.Forms.Button();
            this.lblEmanetID = new System.Windows.Forms.Label();
            this.lblKitapAdı = new System.Windows.Forms.Label();
            this.txtEmanetID = new System.Windows.Forms.TextBox();
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.btnEmanetEdenleriGör = new System.Windows.Forms.Button();
            this.btnEmanetiSil = new System.Windows.Forms.Button();
            this.radioÜye = new System.Windows.Forms.RadioButton();
            this.radioKitapTablosu = new System.Windows.Forms.RadioButton();
            this.radioEmanetListesi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMANET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEmanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKİTAPLAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÜYELER)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.Transparent;
            this.lblTC.Location = new System.Drawing.Point(53, 205);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(97, 24);
            this.lblTC.TabIndex = 44;
            this.lblTC.Text = "ÜYE TC:";
            this.lblTC.Click += new System.EventHandler(this.lblTC_Click);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Location = new System.Drawing.Point(1, 275);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(149, 24);
            this.lblSoyad.TabIndex = 43;
            this.lblSoyad.Text = "ÜYE SOYADI:";
            this.lblSoyad.Click += new System.EventHandler(this.lblSoyad_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Transparent;
            this.lblAd.Location = new System.Drawing.Point(44, 240);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(106, 24);
            this.lblAd.TabIndex = 42;
            this.lblAd.Text = "ÜYE ADI:";
            this.lblAd.Click += new System.EventHandler(this.lblAd_Click);
            // 
            // txtÜyeTC
            // 
            this.txtÜyeTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeTC.Location = new System.Drawing.Point(164, 203);
            this.txtÜyeTC.MaxLength = 11;
            this.txtÜyeTC.Name = "txtÜyeTC";
            this.txtÜyeTC.Size = new System.Drawing.Size(329, 27);
            this.txtÜyeTC.TabIndex = 0;
            this.txtÜyeTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtÜyeTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeTC_KeyPress);
            // 
            // txtÜyeSoyad
            // 
            this.txtÜyeSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeSoyad.Location = new System.Drawing.Point(164, 273);
            this.txtÜyeSoyad.Name = "txtÜyeSoyad";
            this.txtÜyeSoyad.Size = new System.Drawing.Size(329, 27);
            this.txtÜyeSoyad.TabIndex = 2;
            this.txtÜyeSoyad.TextChanged += new System.EventHandler(this.txtÜyeSoyad_TextChanged);
            this.txtÜyeSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeSoyad_KeyPress);
            // 
            // txtÜyeÜyeAd
            // 
            this.txtÜyeÜyeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜyeÜyeAd.Location = new System.Drawing.Point(164, 238);
            this.txtÜyeÜyeAd.Name = "txtÜyeÜyeAd";
            this.txtÜyeÜyeAd.Size = new System.Drawing.Size(329, 27);
            this.txtÜyeÜyeAd.TabIndex = 1;
            this.txtÜyeÜyeAd.TextChanged += new System.EventHandler(this.txtÜyeÜyeAd_TextChanged);
            this.txtÜyeÜyeAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtÜyeÜyeAd_KeyPress);
            // 
            // dataGridViewEMANET
            // 
            this.dataGridViewEMANET.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEMANET.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEMANET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEMANET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEMANET.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEMANET.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEMANET.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.dataGridViewEMANET.Location = new System.Drawing.Point(764, 343);
            this.dataGridViewEMANET.Name = "dataGridViewEMANET";
            this.dataGridViewEMANET.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEMANET.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEMANET.RowHeadersVisible = false;
            this.dataGridViewEMANET.RowHeadersWidth = 51;
            this.dataGridViewEMANET.RowTemplate.Height = 24;
            this.dataGridViewEMANET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEMANET.Size = new System.Drawing.Size(1278, 705);
            this.dataGridViewEMANET.TabIndex = 20;
            this.dataGridViewEMANET.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEMANET_CellContentClick);
            this.dataGridViewEMANET.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEMANET_CellMouseClick);
            // 
            // lblTabloFont
            // 
            this.lblTabloFont.AutoSize = true;
            this.lblTabloFont.BackColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTabloFont.ForeColor = System.Drawing.Color.Transparent;
            this.lblTabloFont.Location = new System.Drawing.Point(30, 910);
            this.lblTabloFont.Name = "lblTabloFont";
            this.lblTabloFont.Size = new System.Drawing.Size(269, 28);
            this.lblTabloFont.TabIndex = 55;
            this.lblTabloFont.Text = "TABLO YAZI BOYUTU";
            this.lblTabloFont.Click += new System.EventHandler(this.lblTabloFont_Click);
            // 
            // trackBarEmanet
            // 
            this.trackBarEmanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.trackBarEmanet.Location = new System.Drawing.Point(24, 948);
            this.trackBarEmanet.Maximum = 15;
            this.trackBarEmanet.Minimum = 7;
            this.trackBarEmanet.Name = "trackBarEmanet";
            this.trackBarEmanet.Size = new System.Drawing.Size(285, 56);
            this.trackBarEmanet.TabIndex = 17;
            this.trackBarEmanet.Value = 7;
            this.trackBarEmanet.Scroll += new System.EventHandler(this.trackBarEmanet_Scroll);
            // 
            // btnEmanetAra
            // 
            this.btnEmanetAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetAra.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetAra.ForeColor = System.Drawing.Color.White;
            this.btnEmanetAra.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnEmanetAra.Location = new System.Drawing.Point(507, 298);
            this.btnEmanetAra.Name = "btnEmanetAra";
            this.btnEmanetAra.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetAra.TabIndex = 9;
            this.btnEmanetAra.Text = "EMANET ARA";
            this.btnEmanetAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetAra.UseVisualStyleBackColor = false;
            this.btnEmanetAra.Click += new System.EventHandler(this.btnPersonelAra_Click);
            // 
            // btnEmanetiGeriAl
            // 
            this.btnEmanetiGeriAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetiGeriAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetiGeriAl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetiGeriAl.ForeColor = System.Drawing.Color.White;
            this.btnEmanetiGeriAl.Image = global::WindowsFormsApp1.Properties.Resources.user_delete_icon;
            this.btnEmanetiGeriAl.Location = new System.Drawing.Point(507, 441);
            this.btnEmanetiGeriAl.Name = "btnEmanetiGeriAl";
            this.btnEmanetiGeriAl.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetiGeriAl.TabIndex = 10;
            this.btnEmanetiGeriAl.Text = "EMANETİ GERİ AL";
            this.btnEmanetiGeriAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetiGeriAl.UseVisualStyleBackColor = false;
            this.btnEmanetiGeriAl.Click += new System.EventHandler(this.btnEmanetiGeriAl_Click);
            // 
            // btnEmanetOluştur
            // 
            this.btnEmanetOluştur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetOluştur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetOluştur.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetOluştur.ForeColor = System.Drawing.Color.White;
            this.btnEmanetOluştur.Image = global::WindowsFormsApp1.Properties.Resources.user_add_icon;
            this.btnEmanetOluştur.Location = new System.Drawing.Point(4, 441);
            this.btnEmanetOluştur.Name = "btnEmanetOluştur";
            this.btnEmanetOluştur.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetOluştur.TabIndex = 12;
            this.btnEmanetOluştur.Text = "EMANET OLUŞTUR";
            this.btnEmanetOluştur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetOluştur.UseVisualStyleBackColor = false;
            this.btnEmanetOluştur.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetListele.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.ForeColor = System.Drawing.Color.White;
            this.btnEmanetListele.Image = global::WindowsFormsApp1.Properties.Resources.user_info_2_icon;
            this.btnEmanetListele.Location = new System.Drawing.Point(258, 12);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetListele.TabIndex = 6;
            this.btnEmanetListele.Text = "EMANET LİSTELE";
            this.btnEmanetListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetListele.UseVisualStyleBackColor = false;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnPersonelMenüsü
            // 
            this.btnPersonelMenüsü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnPersonelMenüsü.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelMenüsü.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelMenüsü.ForeColor = System.Drawing.Color.White;
            this.btnPersonelMenüsü.Image = global::WindowsFormsApp1.Properties.Resources.Industry_Return_icon;
            this.btnPersonelMenüsü.Location = new System.Drawing.Point(9, 12);
            this.btnPersonelMenüsü.Name = "btnPersonelMenüsü";
            this.btnPersonelMenüsü.Size = new System.Drawing.Size(243, 137);
            this.btnPersonelMenüsü.TabIndex = 5;
            this.btnPersonelMenüsü.Text = "PERSONEL MENÜSÜNE DÖN";
            this.btnPersonelMenüsü.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonelMenüsü.UseVisualStyleBackColor = false;
            this.btnPersonelMenüsü.Click += new System.EventHandler(this.btnPersonelMenüsü_Click);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnYazdır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdır.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdır.ForeColor = System.Drawing.Color.White;
            this.btnYazdır.Image = global::WindowsFormsApp1.Properties.Resources.print_icon;
            this.btnYazdır.Location = new System.Drawing.Point(507, 870);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(243, 137);
            this.btnYazdır.TabIndex = 13;
            this.btnYazdır.Text = "SEÇİLEN TABLOYU YAZDIR";
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // dataGridViewKİTAPLAR
            // 
            this.dataGridViewKİTAPLAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKİTAPLAR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKİTAPLAR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewKİTAPLAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKİTAPLAR.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKİTAPLAR.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewKİTAPLAR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.dataGridViewKİTAPLAR.Location = new System.Drawing.Point(764, 4);
            this.dataGridViewKİTAPLAR.Name = "dataGridViewKİTAPLAR";
            this.dataGridViewKİTAPLAR.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKİTAPLAR.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewKİTAPLAR.RowHeadersVisible = false;
            this.dataGridViewKİTAPLAR.RowHeadersWidth = 51;
            this.dataGridViewKİTAPLAR.RowTemplate.Height = 24;
            this.dataGridViewKİTAPLAR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKİTAPLAR.Size = new System.Drawing.Size(639, 333);
            this.dataGridViewKİTAPLAR.TabIndex = 18;
            this.dataGridViewKİTAPLAR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKİTAPLAR_CellContentClick);
            this.dataGridViewKİTAPLAR.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewKİTAPLAR_CellMouseClick);
            // 
            // dataGridViewÜYELER
            // 
            this.dataGridViewÜYELER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewÜYELER.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewÜYELER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewÜYELER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÜYELER.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewÜYELER.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewÜYELER.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.dataGridViewÜYELER.Location = new System.Drawing.Point(1409, 4);
            this.dataGridViewÜYELER.Name = "dataGridViewÜYELER";
            this.dataGridViewÜYELER.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewÜYELER.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewÜYELER.RowHeadersVisible = false;
            this.dataGridViewÜYELER.RowHeadersWidth = 51;
            this.dataGridViewÜYELER.RowTemplate.Height = 24;
            this.dataGridViewÜYELER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewÜYELER.Size = new System.Drawing.Size(633, 333);
            this.dataGridViewÜYELER.TabIndex = 19;
            this.dataGridViewÜYELER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÜYELER_CellContentClick);
            this.dataGridViewÜYELER.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewÜYELER_CellMouseClick);
            // 
            // btnEmanetGelmeyenleriGör
            // 
            this.btnEmanetGelmeyenleriGör.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetGelmeyenleriGör.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetGelmeyenleriGör.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetGelmeyenleriGör.ForeColor = System.Drawing.Color.White;
            this.btnEmanetGelmeyenleriGör.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnEmanetGelmeyenleriGör.Location = new System.Drawing.Point(507, 12);
            this.btnEmanetGelmeyenleriGör.Name = "btnEmanetGelmeyenleriGör";
            this.btnEmanetGelmeyenleriGör.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetGelmeyenleriGör.TabIndex = 7;
            this.btnEmanetGelmeyenleriGör.Text = "EMANET İADE ETMEYENLERİ GÖR";
            this.btnEmanetGelmeyenleriGör.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetGelmeyenleriGör.UseVisualStyleBackColor = false;
            this.btnEmanetGelmeyenleriGör.Click += new System.EventHandler(this.btnEmanetGelmeyenleriGör_Click);
            // 
            // lblEmanetID
            // 
            this.lblEmanetID.AutoSize = true;
            this.lblEmanetID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmanetID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmanetID.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmanetID.Location = new System.Drawing.Point(4, 344);
            this.lblEmanetID.Name = "lblEmanetID";
            this.lblEmanetID.Size = new System.Drawing.Size(146, 24);
            this.lblEmanetID.TabIndex = 69;
            this.lblEmanetID.Text = "EMANET NO:";
            this.lblEmanetID.Click += new System.EventHandler(this.lblEmanetID_Click);
            // 
            // lblKitapAdı
            // 
            this.lblKitapAdı.AutoSize = true;
            this.lblKitapAdı.BackColor = System.Drawing.Color.Transparent;
            this.lblKitapAdı.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdı.ForeColor = System.Drawing.Color.Transparent;
            this.lblKitapAdı.Location = new System.Drawing.Point(23, 310);
            this.lblKitapAdı.Name = "lblKitapAdı";
            this.lblKitapAdı.Size = new System.Drawing.Size(127, 24);
            this.lblKitapAdı.TabIndex = 67;
            this.lblKitapAdı.Text = "KİTAP ADI:";
            this.lblKitapAdı.Click += new System.EventHandler(this.lblKitapAdı_Click);
            // 
            // txtEmanetID
            // 
            this.txtEmanetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmanetID.Location = new System.Drawing.Point(164, 343);
            this.txtEmanetID.Name = "txtEmanetID";
            this.txtEmanetID.Size = new System.Drawing.Size(329, 27);
            this.txtEmanetID.TabIndex = 4;
            this.txtEmanetID.TextChanged += new System.EventHandler(this.txtEmanetID_TextChanged);
            this.txtEmanetID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmanetID_KeyPress);
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdı.Location = new System.Drawing.Point(164, 308);
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(329, 27);
            this.txtKitapAdı.TabIndex = 3;
            this.txtKitapAdı.TextChanged += new System.EventHandler(this.txtKitapAdı_TextChanged);
            // 
            // btnEmanetEdenleriGör
            // 
            this.btnEmanetEdenleriGör.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetEdenleriGör.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetEdenleriGör.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetEdenleriGör.ForeColor = System.Drawing.Color.White;
            this.btnEmanetEdenleriGör.Image = global::WindowsFormsApp1.Properties.Resources.user_search_icon;
            this.btnEmanetEdenleriGör.Location = new System.Drawing.Point(507, 155);
            this.btnEmanetEdenleriGör.Name = "btnEmanetEdenleriGör";
            this.btnEmanetEdenleriGör.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetEdenleriGör.TabIndex = 8;
            this.btnEmanetEdenleriGör.Text = "EMANET İADE EDENLERİ GÖR";
            this.btnEmanetEdenleriGör.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetEdenleriGör.UseVisualStyleBackColor = false;
            this.btnEmanetEdenleriGör.Click += new System.EventHandler(this.btnEmanetEdenleriGör_Click);
            // 
            // btnEmanetiSil
            // 
            this.btnEmanetiSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnEmanetiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetiSil.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetiSil.ForeColor = System.Drawing.Color.White;
            this.btnEmanetiSil.Image = global::WindowsFormsApp1.Properties.Resources.user_delete_icon;
            this.btnEmanetiSil.Location = new System.Drawing.Point(250, 441);
            this.btnEmanetiSil.Name = "btnEmanetiSil";
            this.btnEmanetiSil.Size = new System.Drawing.Size(243, 137);
            this.btnEmanetiSil.TabIndex = 11;
            this.btnEmanetiSil.Text = "EMANETİ SİL";
            this.btnEmanetiSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmanetiSil.UseVisualStyleBackColor = false;
            this.btnEmanetiSil.Click += new System.EventHandler(this.btnEmanetiSil_Click);
            // 
            // radioÜye
            // 
            this.radioÜye.AutoSize = true;
            this.radioÜye.BackColor = System.Drawing.Color.Transparent;
            this.radioÜye.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioÜye.ForeColor = System.Drawing.Color.White;
            this.radioÜye.Location = new System.Drawing.Point(375, 915);
            this.radioÜye.Name = "radioÜye";
            this.radioÜye.Size = new System.Drawing.Size(64, 24);
            this.radioÜye.TabIndex = 14;
            this.radioÜye.TabStop = true;
            this.radioÜye.Text = "Üye";
            this.radioÜye.UseVisualStyleBackColor = false;
            this.radioÜye.CheckedChanged += new System.EventHandler(this.radioÜye_CheckedChanged);
            // 
            // radioKitapTablosu
            // 
            this.radioKitapTablosu.AutoSize = true;
            this.radioKitapTablosu.BackColor = System.Drawing.Color.Transparent;
            this.radioKitapTablosu.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapTablosu.ForeColor = System.Drawing.Color.White;
            this.radioKitapTablosu.Location = new System.Drawing.Point(375, 945);
            this.radioKitapTablosu.Name = "radioKitapTablosu";
            this.radioKitapTablosu.Size = new System.Drawing.Size(79, 24);
            this.radioKitapTablosu.TabIndex = 15;
            this.radioKitapTablosu.TabStop = true;
            this.radioKitapTablosu.Text = "Kitap";
            this.radioKitapTablosu.UseVisualStyleBackColor = false;
            this.radioKitapTablosu.CheckedChanged += new System.EventHandler(this.radioKitapTablosu_CheckedChanged);
            // 
            // radioEmanetListesi
            // 
            this.radioEmanetListesi.AutoSize = true;
            this.radioEmanetListesi.BackColor = System.Drawing.Color.Transparent;
            this.radioEmanetListesi.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioEmanetListesi.ForeColor = System.Drawing.Color.White;
            this.radioEmanetListesi.Location = new System.Drawing.Point(375, 975);
            this.radioEmanetListesi.Name = "radioEmanetListesi";
            this.radioEmanetListesi.Size = new System.Drawing.Size(98, 24);
            this.radioEmanetListesi.TabIndex = 16;
            this.radioEmanetListesi.TabStop = true;
            this.radioEmanetListesi.Text = "Emanet";
            this.radioEmanetListesi.UseVisualStyleBackColor = false;
            this.radioEmanetListesi.CheckedChanged += new System.EventHandler(this.radioEmanetListesi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 887);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "TABLOLAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Emanetİşlemleri
            // 
            this.AcceptButton = this.btnEmanetOluştur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._389873;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioEmanetListesi);
            this.Controls.Add(this.radioKitapTablosu);
            this.Controls.Add(this.radioÜye);
            this.Controls.Add(this.btnEmanetiSil);
            this.Controls.Add(this.btnEmanetEdenleriGör);
            this.Controls.Add(this.lblEmanetID);
            this.Controls.Add(this.lblKitapAdı);
            this.Controls.Add(this.txtEmanetID);
            this.Controls.Add(this.txtKitapAdı);
            this.Controls.Add(this.btnEmanetGelmeyenleriGör);
            this.Controls.Add(this.dataGridViewÜYELER);
            this.Controls.Add(this.dataGridViewKİTAPLAR);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.lblTabloFont);
            this.Controls.Add(this.trackBarEmanet);
            this.Controls.Add(this.btnEmanetAra);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtÜyeTC);
            this.Controls.Add(this.txtÜyeSoyad);
            this.Controls.Add(this.txtÜyeÜyeAd);
            this.Controls.Add(this.dataGridViewEMANET);
            this.Controls.Add(this.btnEmanetiGeriAl);
            this.Controls.Add(this.btnEmanetOluştur);
            this.Controls.Add(this.btnEmanetListele);
            this.Controls.Add(this.btnPersonelMenüsü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Emanetİşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmanetIslemleri_Load);
            this.Resize += new System.EventHandler(this.Emanetİşlemleri_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMANET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEmanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKİTAPLAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÜYELER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmanetAra;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtÜyeTC;
        private System.Windows.Forms.TextBox txtÜyeSoyad;
        private System.Windows.Forms.TextBox txtÜyeÜyeAd;
        private System.Windows.Forms.DataGridView dataGridViewEMANET;
        private System.Windows.Forms.Button btnEmanetiGeriAl;
        private System.Windows.Forms.Button btnEmanetOluştur;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnPersonelMenüsü;
        private System.Windows.Forms.Label lblTabloFont;
        private System.Windows.Forms.TrackBar trackBarEmanet;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridViewKİTAPLAR;
        private System.Windows.Forms.DataGridView dataGridViewÜYELER;
        private System.Windows.Forms.Button btnEmanetGelmeyenleriGör;
        private System.Windows.Forms.Label lblEmanetID;
        private System.Windows.Forms.Label lblKitapAdı;
        private System.Windows.Forms.TextBox txtEmanetID;
        private System.Windows.Forms.TextBox txtKitapAdı;
        private System.Windows.Forms.Button btnEmanetEdenleriGör;
        private System.Windows.Forms.Button btnEmanetiSil;
        private System.Windows.Forms.RadioButton radioÜye;
        private System.Windows.Forms.RadioButton radioKitapTablosu;
        private System.Windows.Forms.RadioButton radioEmanetListesi;
        private System.Windows.Forms.Label label1;
    }
}