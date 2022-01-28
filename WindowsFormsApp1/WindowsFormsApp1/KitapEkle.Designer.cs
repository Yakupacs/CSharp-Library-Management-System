namespace WindowsFormsApp1
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYayinevi = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKitapSayfaSayisi = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblKitapYazari = new System.Windows.Forms.Label();
            this.lblKitapYayinevi = new System.Windows.Forms.Label();
            this.lblKitapSayfaSayis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.datagridKitaplar = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapSayfaGuncelle = new System.Windows.Forms.TextBox();
            this.txtKitapYazariGuncelle = new System.Windows.Forms.TextBox();
            this.txtKitapYayineviGuncelle = new System.Windows.Forms.TextBox();
            this.txtKitapAdiGuncelle = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtkitapIDSil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKitapIDGuncelle = new System.Windows.Forms.TextBox();
            this.grpEkle = new System.Windows.Forms.GroupBox();
            this.comboboxKitapKategoriEkle = new System.Windows.Forms.ComboBox();
            this.grpGuncelle = new System.Windows.Forms.GroupBox();
            this.comboboxKitapKategoriGüncelle = new System.Windows.Forms.ComboBox();
            this.grpKitapSil = new System.Windows.Forms.GroupBox();
            this.radioKitapID = new System.Windows.Forms.RadioButton();
            this.radioKitapAdi = new System.Windows.Forms.RadioButton();
            this.radioKitapYazari = new System.Windows.Forms.RadioButton();
            this.radioKitapYayinevi = new System.Windows.Forms.RadioButton();
            this.radioKitapKategori = new System.Windows.Forms.RadioButton();
            this.txtKitapArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.grpKitapAra = new System.Windows.Forms.GroupBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.btnPersonelMenüsüneDön = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridKitaplar)).BeginInit();
            this.grpEkle.SuspendLayout();
            this.grpGuncelle.SuspendLayout();
            this.grpKitapSil.SuspendLayout();
            this.grpKitapAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(140, 76);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(173, 22);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // txtKitapYayinevi
            // 
            this.txtKitapYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYayinevi.Location = new System.Drawing.Point(140, 132);
            this.txtKitapYayinevi.Multiline = true;
            this.txtKitapYayinevi.Name = "txtKitapYayinevi";
            this.txtKitapYayinevi.Size = new System.Drawing.Size(173, 22);
            this.txtKitapYayinevi.TabIndex = 2;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazari.Location = new System.Drawing.Point(140, 104);
            this.txtKitapYazari.Multiline = true;
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(173, 22);
            this.txtKitapYazari.TabIndex = 1;
            this.txtKitapYazari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapYazari_KeyPress);
            // 
            // txtKitapSayfaSayisi
            // 
            this.txtKitapSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapSayfaSayisi.Location = new System.Drawing.Point(140, 160);
            this.txtKitapSayfaSayisi.MaxLength = 4;
            this.txtKitapSayfaSayisi.Multiline = true;
            this.txtKitapSayfaSayisi.Name = "txtKitapSayfaSayisi";
            this.txtKitapSayfaSayisi.Size = new System.Drawing.Size(173, 22);
            this.txtKitapSayfaSayisi.TabIndex = 3;
            this.txtKitapSayfaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapSayfaSayisi_KeyPress);
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.ForeColor = System.Drawing.Color.White;
            this.lblKitapAdi.Location = new System.Drawing.Point(27, 77);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(102, 21);
            this.lblKitapAdi.TabIndex = 4;
            this.lblKitapAdi.Text = "Kitap Adı:";
            // 
            // lblKitapYazari
            // 
            this.lblKitapYazari.AutoSize = true;
            this.lblKitapYazari.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapYazari.ForeColor = System.Drawing.Color.White;
            this.lblKitapYazari.Location = new System.Drawing.Point(56, 105);
            this.lblKitapYazari.Name = "lblKitapYazari";
            this.lblKitapYazari.Size = new System.Drawing.Size(73, 21);
            this.lblKitapYazari.TabIndex = 5;
            this.lblKitapYazari.Text = "Yazarı:";
            // 
            // lblKitapYayinevi
            // 
            this.lblKitapYayinevi.AutoSize = true;
            this.lblKitapYayinevi.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapYayinevi.ForeColor = System.Drawing.Color.White;
            this.lblKitapYayinevi.Location = new System.Drawing.Point(34, 133);
            this.lblKitapYayinevi.Name = "lblKitapYayinevi";
            this.lblKitapYayinevi.Size = new System.Drawing.Size(95, 21);
            this.lblKitapYayinevi.TabIndex = 6;
            this.lblKitapYayinevi.Text = "Yayınevi:";
            // 
            // lblKitapSayfaSayis
            // 
            this.lblKitapSayfaSayis.AutoSize = true;
            this.lblKitapSayfaSayis.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapSayfaSayis.ForeColor = System.Drawing.Color.White;
            this.lblKitapSayfaSayis.Location = new System.Drawing.Point(3, 161);
            this.lblKitapSayfaSayis.Name = "lblKitapSayfaSayis";
            this.lblKitapSayfaSayis.Size = new System.Drawing.Size(126, 21);
            this.lblKitapSayfaSayis.TabIndex = 7;
            this.lblKitapSayfaSayis.Text = "Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kategori:";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapEkle.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.ForeColor = System.Drawing.Color.Green;
            this.btnKitapEkle.Location = new System.Drawing.Point(140, 222);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(173, 42);
            this.btnKitapEkle.TabIndex = 5;
            this.btnKitapEkle.Text = "EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            this.btnKitapEkle.MouseLeave += new System.EventHandler(this.btnKitapEkle_MouseLeave);
            this.btnKitapEkle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnKitapEkle_MouseMove);
            // 
            // datagridKitaplar
            // 
            this.datagridKitaplar.AllowUserToOrderColumns = true;
            this.datagridKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridKitaplar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.datagridKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridKitaplar.ColumnHeadersVisible = false;
            this.datagridKitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridKitaplar.DefaultCellStyle = dataGridViewCellStyle1;
            this.datagridKitaplar.Location = new System.Drawing.Point(172, 341);
            this.datagridKitaplar.Name = "datagridKitaplar";
            this.datagridKitaplar.ReadOnly = true;
            this.datagridKitaplar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridKitaplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridKitaplar.RowHeadersVisible = false;
            this.datagridKitaplar.RowHeadersWidth = 70;
            this.datagridKitaplar.RowTemplate.Height = 24;
            this.datagridKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridKitaplar.Size = new System.Drawing.Size(1701, 473);
            this.datagridKitaplar.TabIndex = 19;
            this.datagridKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridKitaplar_CellContentClick);
            this.datagridKitaplar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridKitaplar_CellMouseClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.ForestGreen;
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.Transparent;
            this.btnListele.Location = new System.Drawing.Point(168, 820);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(1705, 60);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(100, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(166, 42);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kitap ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Yayınevi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Yazarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kitap Adı:";
            // 
            // txtKitapSayfaGuncelle
            // 
            this.txtKitapSayfaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapSayfaGuncelle.Location = new System.Drawing.Point(145, 167);
            this.txtKitapSayfaGuncelle.MaxLength = 5;
            this.txtKitapSayfaGuncelle.Multiline = true;
            this.txtKitapSayfaGuncelle.Name = "txtKitapSayfaGuncelle";
            this.txtKitapSayfaGuncelle.Size = new System.Drawing.Size(190, 22);
            this.txtKitapSayfaGuncelle.TabIndex = 10;
            this.txtKitapSayfaGuncelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapSayfaGuncelle_KeyPress);
            // 
            // txtKitapYazariGuncelle
            // 
            this.txtKitapYazariGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazariGuncelle.Location = new System.Drawing.Point(145, 111);
            this.txtKitapYazariGuncelle.Multiline = true;
            this.txtKitapYazariGuncelle.Name = "txtKitapYazariGuncelle";
            this.txtKitapYazariGuncelle.Size = new System.Drawing.Size(190, 22);
            this.txtKitapYazariGuncelle.TabIndex = 8;
            this.txtKitapYazariGuncelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapYazariGuncelle_KeyPress);
            // 
            // txtKitapYayineviGuncelle
            // 
            this.txtKitapYayineviGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYayineviGuncelle.Location = new System.Drawing.Point(145, 139);
            this.txtKitapYayineviGuncelle.Multiline = true;
            this.txtKitapYayineviGuncelle.Name = "txtKitapYayineviGuncelle";
            this.txtKitapYayineviGuncelle.Size = new System.Drawing.Size(190, 22);
            this.txtKitapYayineviGuncelle.TabIndex = 9;
            // 
            // txtKitapAdiGuncelle
            // 
            this.txtKitapAdiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdiGuncelle.Location = new System.Drawing.Point(145, 83);
            this.txtKitapAdiGuncelle.Multiline = true;
            this.txtKitapAdiGuncelle.Name = "txtKitapAdiGuncelle";
            this.txtKitapAdiGuncelle.Size = new System.Drawing.Size(190, 22);
            this.txtKitapAdiGuncelle.TabIndex = 7;
            this.txtKitapAdiGuncelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapAdiGuncelle_KeyPress);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Blue;
            this.btnGuncelle.Location = new System.Drawing.Point(145, 229);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(190, 42);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            this.btnGuncelle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuncelle_MouseMove);
            // 
            // txtkitapIDSil
            // 
            this.txtkitapIDSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkitapIDSil.Location = new System.Drawing.Point(100, 99);
            this.txtkitapIDSil.MaxLength = 5;
            this.txtkitapIDSil.Multiline = true;
            this.txtkitapIDSil.Name = "txtkitapIDSil";
            this.txtkitapIDSil.Size = new System.Drawing.Size(166, 22);
            this.txtkitapIDSil.TabIndex = 15;
            this.txtkitapIDSil.TextChanged += new System.EventHandler(this.txtkitapIDSil_TextChanged);
            this.txtkitapIDSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkitapIDSil_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "Kitap ID:";
            // 
            // txtKitapIDGuncelle
            // 
            this.txtKitapIDGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapIDGuncelle.Location = new System.Drawing.Point(145, 57);
            this.txtKitapIDGuncelle.MaxLength = 5;
            this.txtKitapIDGuncelle.Multiline = true;
            this.txtKitapIDGuncelle.Name = "txtKitapIDGuncelle";
            this.txtKitapIDGuncelle.Size = new System.Drawing.Size(190, 22);
            this.txtKitapIDGuncelle.TabIndex = 6;
            this.txtKitapIDGuncelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKitapIDGuncelle_KeyPress);
            // 
            // grpEkle
            // 
            this.grpEkle.BackColor = System.Drawing.Color.Transparent;
            this.grpEkle.Controls.Add(this.btnKitapEkle);
            this.grpEkle.Controls.Add(this.comboboxKitapKategoriEkle);
            this.grpEkle.Controls.Add(this.txtKitapAdi);
            this.grpEkle.Controls.Add(this.txtKitapYayinevi);
            this.grpEkle.Controls.Add(this.txtKitapYazari);
            this.grpEkle.Controls.Add(this.txtKitapSayfaSayisi);
            this.grpEkle.Controls.Add(this.lblKitapAdi);
            this.grpEkle.Controls.Add(this.lblKitapYazari);
            this.grpEkle.Controls.Add(this.lblKitapYayinevi);
            this.grpEkle.Controls.Add(this.lblKitapSayfaSayis);
            this.grpEkle.Controls.Add(this.label5);
            this.grpEkle.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkle.ForeColor = System.Drawing.Color.White;
            this.grpEkle.Location = new System.Drawing.Point(300, 36);
            this.grpEkle.Name = "grpEkle";
            this.grpEkle.Size = new System.Drawing.Size(323, 277);
            this.grpEkle.TabIndex = 32;
            this.grpEkle.TabStop = false;
            this.grpEkle.Text = "KİTAP EKLE";
            // 
            // comboboxKitapKategoriEkle
            // 
            this.comboboxKitapKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboboxKitapKategoriEkle.FormattingEnabled = true;
            this.comboboxKitapKategoriEkle.Items.AddRange(new object[] {
            "Bilgisayar",
            "Bilim & Mühendislik",
            "Çocuk Kitapları",
            "Din",
            "Edebiyat",
            "Eğlence-Mizah",
            "Ekonomi",
            "Felsefe-Düşünce",
            "Hobi",
            "Hukuk",
            "İslam",
            "Kültür",
            "Müzik",
            "Psikoloji",
            "Roman",
            "Sağlık-Tıp",
            "Siyaset",
            "Sosyoloji",
            "Spor",
            "Tarih"});
            this.comboboxKitapKategoriEkle.Location = new System.Drawing.Point(140, 188);
            this.comboboxKitapKategoriEkle.Name = "comboboxKitapKategoriEkle";
            this.comboboxKitapKategoriEkle.Size = new System.Drawing.Size(173, 28);
            this.comboboxKitapKategoriEkle.TabIndex = 43;
            this.comboboxKitapKategoriEkle.Text = "Bilgisayar";
            // 
            // grpGuncelle
            // 
            this.grpGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.grpGuncelle.Controls.Add(this.comboboxKitapKategoriGüncelle);
            this.grpGuncelle.Controls.Add(this.btnGuncelle);
            this.grpGuncelle.Controls.Add(this.txtKitapAdiGuncelle);
            this.grpGuncelle.Controls.Add(this.label9);
            this.grpGuncelle.Controls.Add(this.txtKitapYayineviGuncelle);
            this.grpGuncelle.Controls.Add(this.txtKitapIDGuncelle);
            this.grpGuncelle.Controls.Add(this.txtKitapYazariGuncelle);
            this.grpGuncelle.Controls.Add(this.txtKitapSayfaGuncelle);
            this.grpGuncelle.Controls.Add(this.label2);
            this.grpGuncelle.Controls.Add(this.label7);
            this.grpGuncelle.Controls.Add(this.label3);
            this.grpGuncelle.Controls.Add(this.label6);
            this.grpGuncelle.Controls.Add(this.label4);
            this.grpGuncelle.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGuncelle.ForeColor = System.Drawing.Color.White;
            this.grpGuncelle.Location = new System.Drawing.Point(629, 36);
            this.grpGuncelle.Name = "grpGuncelle";
            this.grpGuncelle.Size = new System.Drawing.Size(341, 277);
            this.grpGuncelle.TabIndex = 33;
            this.grpGuncelle.TabStop = false;
            this.grpGuncelle.Text = "KİTAP GÜNCELLE";
            this.grpGuncelle.Enter += new System.EventHandler(this.grpGuncelle_Enter);
            // 
            // comboboxKitapKategoriGüncelle
            // 
            this.comboboxKitapKategoriGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboboxKitapKategoriGüncelle.FormattingEnabled = true;
            this.comboboxKitapKategoriGüncelle.Items.AddRange(new object[] {
            "Bilgisayar",
            "Bilim & Mühendislik",
            "Çocuk Kitapları",
            "Din",
            "Edebiyat",
            "Eğlence-Mizah",
            "Ekonomi",
            "Felsefe-Düşünce",
            "Hobi",
            "Hukuk",
            "İslam",
            "Kültür",
            "Müzik",
            "Psikoloji",
            "Roman",
            "Sağlık-Tıp",
            "Siyaset",
            "Sosyoloji",
            "Spor",
            "Tarih"});
            this.comboboxKitapKategoriGüncelle.Location = new System.Drawing.Point(145, 195);
            this.comboboxKitapKategoriGüncelle.Name = "comboboxKitapKategoriGüncelle";
            this.comboboxKitapKategoriGüncelle.Size = new System.Drawing.Size(190, 28);
            this.comboboxKitapKategoriGüncelle.TabIndex = 44;
            this.comboboxKitapKategoriGüncelle.Text = "Bilgisayar";
            // 
            // grpKitapSil
            // 
            this.grpKitapSil.BackColor = System.Drawing.Color.Transparent;
            this.grpKitapSil.Controls.Add(this.btnTemizle);
            this.grpKitapSil.Controls.Add(this.txtkitapIDSil);
            this.grpKitapSil.Controls.Add(this.label1);
            this.grpKitapSil.Controls.Add(this.btnSil);
            this.grpKitapSil.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKitapSil.ForeColor = System.Drawing.Color.White;
            this.grpKitapSil.Location = new System.Drawing.Point(1287, 36);
            this.grpKitapSil.Name = "grpKitapSil";
            this.grpKitapSil.Size = new System.Drawing.Size(282, 277);
            this.grpKitapSil.TabIndex = 34;
            this.grpKitapSil.TabStop = false;
            this.grpKitapSil.Text = "KİTAP SİL";
            // 
            // radioKitapID
            // 
            this.radioKitapID.AutoSize = true;
            this.radioKitapID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapID.ForeColor = System.Drawing.Color.White;
            this.radioKitapID.Location = new System.Drawing.Point(20, 54);
            this.radioKitapID.Name = "radioKitapID";
            this.radioKitapID.Size = new System.Drawing.Size(84, 20);
            this.radioKitapID.TabIndex = 17;
            this.radioKitapID.TabStop = true;
            this.radioKitapID.Text = "Kitap ID";
            this.radioKitapID.UseVisualStyleBackColor = true;
            // 
            // radioKitapAdi
            // 
            this.radioKitapAdi.AutoSize = true;
            this.radioKitapAdi.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapAdi.ForeColor = System.Drawing.Color.White;
            this.radioKitapAdi.Location = new System.Drawing.Point(20, 79);
            this.radioKitapAdi.Name = "radioKitapAdi";
            this.radioKitapAdi.Size = new System.Drawing.Size(91, 20);
            this.radioKitapAdi.TabIndex = 17;
            this.radioKitapAdi.TabStop = true;
            this.radioKitapAdi.Text = "Kitap Adı";
            this.radioKitapAdi.UseVisualStyleBackColor = true;
            // 
            // radioKitapYazari
            // 
            this.radioKitapYazari.AutoSize = true;
            this.radioKitapYazari.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapYazari.ForeColor = System.Drawing.Color.White;
            this.radioKitapYazari.Location = new System.Drawing.Point(20, 104);
            this.radioKitapYazari.Name = "radioKitapYazari";
            this.radioKitapYazari.Size = new System.Drawing.Size(112, 20);
            this.radioKitapYazari.TabIndex = 19;
            this.radioKitapYazari.TabStop = true;
            this.radioKitapYazari.Text = "Kitap Yazarı";
            this.radioKitapYazari.UseVisualStyleBackColor = true;
            // 
            // radioKitapYayinevi
            // 
            this.radioKitapYayinevi.AutoSize = true;
            this.radioKitapYayinevi.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapYayinevi.ForeColor = System.Drawing.Color.White;
            this.radioKitapYayinevi.Location = new System.Drawing.Point(20, 129);
            this.radioKitapYayinevi.Name = "radioKitapYayinevi";
            this.radioKitapYayinevi.Size = new System.Drawing.Size(129, 20);
            this.radioKitapYayinevi.TabIndex = 20;
            this.radioKitapYayinevi.TabStop = true;
            this.radioKitapYayinevi.Text = "Kitap Yayınevi";
            this.radioKitapYayinevi.UseVisualStyleBackColor = true;
            // 
            // radioKitapKategori
            // 
            this.radioKitapKategori.AutoSize = true;
            this.radioKitapKategori.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKitapKategori.ForeColor = System.Drawing.Color.White;
            this.radioKitapKategori.Location = new System.Drawing.Point(20, 154);
            this.radioKitapKategori.Name = "radioKitapKategori";
            this.radioKitapKategori.Size = new System.Drawing.Size(140, 20);
            this.radioKitapKategori.TabIndex = 21;
            this.radioKitapKategori.TabStop = true;
            this.radioKitapKategori.Text = "Kitap Kategorisi";
            this.radioKitapKategori.UseVisualStyleBackColor = true;
            // 
            // txtKitapArama
            // 
            this.txtKitapArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapArama.Location = new System.Drawing.Point(37, 187);
            this.txtKitapArama.Multiline = true;
            this.txtKitapArama.Name = "txtKitapArama";
            this.txtKitapArama.Size = new System.Drawing.Size(234, 22);
            this.txtKitapArama.TabIndex = 13;
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.Blue;
            this.btnAra.Location = new System.Drawing.Point(49, 215);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(209, 42);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            this.btnAra.MouseLeave += new System.EventHandler(this.btnAra_MouseLeave);
            this.btnAra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAra_MouseMove);
            // 
            // grpKitapAra
            // 
            this.grpKitapAra.BackColor = System.Drawing.Color.Transparent;
            this.grpKitapAra.Controls.Add(this.lblAra);
            this.grpKitapAra.Controls.Add(this.btnAra);
            this.grpKitapAra.Controls.Add(this.txtKitapArama);
            this.grpKitapAra.Controls.Add(this.radioKitapKategori);
            this.grpKitapAra.Controls.Add(this.radioKitapYayinevi);
            this.grpKitapAra.Controls.Add(this.radioKitapYazari);
            this.grpKitapAra.Controls.Add(this.radioKitapAdi);
            this.grpKitapAra.Controls.Add(this.radioKitapID);
            this.grpKitapAra.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKitapAra.ForeColor = System.Drawing.Color.White;
            this.grpKitapAra.Location = new System.Drawing.Point(976, 36);
            this.grpKitapAra.Name = "grpKitapAra";
            this.grpKitapAra.Size = new System.Drawing.Size(305, 276);
            this.grpKitapAra.TabIndex = 41;
            this.grpKitapAra.TabStop = false;
            this.grpKitapAra.Text = "KİTAP ARA";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.ForeColor = System.Drawing.Color.Red;
            this.lblAra.Location = new System.Drawing.Point(62, 194);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(0, 22);
            this.lblAra.TabIndex = 41;
            // 
            // btnPersonelMenüsüneDön
            // 
            this.btnPersonelMenüsüneDön.BackColor = System.Drawing.Color.Red;
            this.btnPersonelMenüsüneDön.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelMenüsüneDön.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelMenüsüneDön.ForeColor = System.Drawing.Color.Transparent;
            this.btnPersonelMenüsüneDön.Location = new System.Drawing.Point(172, 886);
            this.btnPersonelMenüsüneDön.Name = "btnPersonelMenüsüneDön";
            this.btnPersonelMenüsüneDön.Size = new System.Drawing.Size(1705, 59);
            this.btnPersonelMenüsüneDön.TabIndex = 18;
            this.btnPersonelMenüsüneDön.Text = "PERSONEL MENÜSÜNE DÖN";
            this.btnPersonelMenüsüneDön.UseVisualStyleBackColor = false;
            this.btnPersonelMenüsüneDön.Click += new System.EventHandler(this.btnPersonelMenüsüneDön_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.tenor__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1591, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(100, 169);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(166, 46);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            this.btnTemizle.MouseLeave += new System.EventHandler(this.btnTemizle_MouseLeave);
            this.btnTemizle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTemizle_MouseMove);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._389873;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelMenüsüneDön);
            this.Controls.Add(this.grpKitapAra);
            this.Controls.Add(this.grpKitapSil);
            this.Controls.Add(this.grpGuncelle);
            this.Controls.Add(this.grpEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.datagridKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.Resize += new System.EventHandler(this.KitapEkle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.datagridKitaplar)).EndInit();
            this.grpEkle.ResumeLayout(false);
            this.grpEkle.PerformLayout();
            this.grpGuncelle.ResumeLayout(false);
            this.grpGuncelle.PerformLayout();
            this.grpKitapSil.ResumeLayout(false);
            this.grpKitapSil.PerformLayout();
            this.grpKitapAra.ResumeLayout(false);
            this.grpKitapAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYayinevi;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtKitapSayfaSayisi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblKitapYazari;
        private System.Windows.Forms.Label lblKitapYayinevi;
        private System.Windows.Forms.Label lblKitapSayfaSayis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.DataGridView datagridKitaplar;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapSayfaGuncelle;
        private System.Windows.Forms.TextBox txtKitapYazariGuncelle;
        private System.Windows.Forms.TextBox txtKitapYayineviGuncelle;
        private System.Windows.Forms.TextBox txtKitapAdiGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtkitapIDSil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKitapIDGuncelle;
        private System.Windows.Forms.GroupBox grpEkle;
        private System.Windows.Forms.GroupBox grpGuncelle;
        private System.Windows.Forms.GroupBox grpKitapSil;
        private System.Windows.Forms.RadioButton radioKitapID;
        private System.Windows.Forms.RadioButton radioKitapAdi;
        private System.Windows.Forms.RadioButton radioKitapYazari;
        private System.Windows.Forms.RadioButton radioKitapYayinevi;
        private System.Windows.Forms.RadioButton radioKitapKategori;
        private System.Windows.Forms.TextBox txtKitapArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox grpKitapAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnPersonelMenüsüneDön;
        private System.Windows.Forms.ComboBox comboboxKitapKategoriEkle;
        private System.Windows.Forms.ComboBox comboboxKitapKategoriGüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemizle;
    }
}