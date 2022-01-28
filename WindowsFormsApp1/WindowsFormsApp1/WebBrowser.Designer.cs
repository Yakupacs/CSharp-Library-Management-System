namespace WindowsFormsApp1
{
    partial class WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstboxDövizKurları = new System.Windows.Forms.ListBox();
            this.grpboxDövizKurları = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlım = new System.Windows.Forms.Label();
            this.lblSatım = new System.Windows.Forms.Label();
            this.lblDövizAdı = new System.Windows.Forms.Label();
            this.lblDövizSatım = new System.Windows.Forms.Label();
            this.lblDövizAlım = new System.Windows.Forms.Label();
            this.lblDÖVİZKURLARI = new System.Windows.Forms.Label();
            this.btnAnasayfayaDön = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpboxDövizKurları.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1486, 1043);
            this.webBrowser1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1029);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriToolStripMenuItem,
            this.ileriToolStripMenuItem,
            this.anasayfaToolStripMenuItem,
            this.yenileToolStripMenuItem,
            this.durToolStripMenuItem,
            this.txtURL,
            this.araToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click);
            // 
            // ileriToolStripMenuItem
            // 
            this.ileriToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            this.ileriToolStripMenuItem.Size = new System.Drawing.Size(75, 32);
            this.ileriToolStripMenuItem.Text = "İleri";
            this.ileriToolStripMenuItem.Click += new System.EventHandler(this.ileriToolStripMenuItem_Click);
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(133, 32);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // durToolStripMenuItem
            // 
            this.durToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durToolStripMenuItem.Name = "durToolStripMenuItem";
            this.durToolStripMenuItem.Size = new System.Drawing.Size(70, 32);
            this.durToolStripMenuItem.Text = "Dur";
            this.durToolStripMenuItem.Click += new System.EventHandler(this.durToolStripMenuItem_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(100, 32);
            this.txtURL.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // lstboxDövizKurları
            // 
            this.lstboxDövizKurları.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstboxDövizKurları.FormattingEnabled = true;
            this.lstboxDövizKurları.ItemHeight = 29;
            this.lstboxDövizKurları.Location = new System.Drawing.Point(1502, 166);
            this.lstboxDövizKurları.Name = "lstboxDövizKurları";
            this.lstboxDövizKurları.Size = new System.Drawing.Size(522, 439);
            this.lstboxDövizKurları.TabIndex = 1;
            this.lstboxDövizKurları.SelectedIndexChanged += new System.EventHandler(this.lstboxDövizKurları_SelectedIndexChanged);
            // 
            // grpboxDövizKurları
            // 
            this.grpboxDövizKurları.Controls.Add(this.label1);
            this.grpboxDövizKurları.Controls.Add(this.lblAlım);
            this.grpboxDövizKurları.Controls.Add(this.lblSatım);
            this.grpboxDövizKurları.Controls.Add(this.lblDövizAdı);
            this.grpboxDövizKurları.Controls.Add(this.lblDövizSatım);
            this.grpboxDövizKurları.Controls.Add(this.lblDövizAlım);
            this.grpboxDövizKurları.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxDövizKurları.ForeColor = System.Drawing.Color.Maroon;
            this.grpboxDövizKurları.Location = new System.Drawing.Point(1502, 611);
            this.grpboxDövizKurları.Name = "grpboxDövizKurları";
            this.grpboxDövizKurları.Size = new System.Drawing.Size(522, 247);
            this.grpboxDövizKurları.TabIndex = 4;
            this.grpboxDövizKurları.TabStop = false;
            this.grpboxDövizKurları.Text = "DÖVİZ BİLGİLERİ";
            this.grpboxDövizKurları.Enter += new System.EventHandler(this.grpboxDövizKurları_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "DÖVİZ:";
            // 
            // lblAlım
            // 
            this.lblAlım.AutoSize = true;
            this.lblAlım.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlım.Location = new System.Drawing.Point(19, 127);
            this.lblAlım.Name = "lblAlım";
            this.lblAlım.Size = new System.Drawing.Size(83, 28);
            this.lblAlım.TabIndex = 9;
            this.lblAlım.Text = "ALIM:";
            // 
            // lblSatım
            // 
            this.lblSatım.AutoSize = true;
            this.lblSatım.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatım.Location = new System.Drawing.Point(3, 174);
            this.lblSatım.Name = "lblSatım";
            this.lblSatım.Size = new System.Drawing.Size(99, 28);
            this.lblSatım.TabIndex = 8;
            this.lblSatım.Text = "SATIM:";
            // 
            // lblDövizAdı
            // 
            this.lblDövizAdı.AutoSize = true;
            this.lblDövizAdı.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDövizAdı.ForeColor = System.Drawing.Color.Black;
            this.lblDövizAdı.Location = new System.Drawing.Point(111, 80);
            this.lblDövizAdı.Name = "lblDövizAdı";
            this.lblDövizAdı.Size = new System.Drawing.Size(0, 28);
            this.lblDövizAdı.TabIndex = 7;
            // 
            // lblDövizSatım
            // 
            this.lblDövizSatım.AutoSize = true;
            this.lblDövizSatım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDövizSatım.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDövizSatım.ForeColor = System.Drawing.Color.Black;
            this.lblDövizSatım.Location = new System.Drawing.Point(110, 173);
            this.lblDövizSatım.Name = "lblDövizSatım";
            this.lblDövizSatım.Size = new System.Drawing.Size(0, 28);
            this.lblDövizSatım.TabIndex = 6;
            // 
            // lblDövizAlım
            // 
            this.lblDövizAlım.AutoSize = true;
            this.lblDövizAlım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDövizAlım.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDövizAlım.ForeColor = System.Drawing.Color.Black;
            this.lblDövizAlım.Location = new System.Drawing.Point(110, 126);
            this.lblDövizAlım.Name = "lblDövizAlım";
            this.lblDövizAlım.Size = new System.Drawing.Size(0, 28);
            this.lblDövizAlım.TabIndex = 5;
            // 
            // lblDÖVİZKURLARI
            // 
            this.lblDÖVİZKURLARI.AutoSize = true;
            this.lblDÖVİZKURLARI.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDÖVİZKURLARI.ForeColor = System.Drawing.Color.Maroon;
            this.lblDÖVİZKURLARI.Location = new System.Drawing.Point(1563, 45);
            this.lblDÖVİZKURLARI.Name = "lblDÖVİZKURLARI";
            this.lblDÖVİZKURLARI.Size = new System.Drawing.Size(424, 112);
            this.lblDÖVİZKURLARI.TabIndex = 11;
            this.lblDÖVİZKURLARI.Text = "GÜNLÜK DÖVİZ \r\n    KURLARI";
            // 
            // btnAnasayfayaDön
            // 
            this.btnAnasayfayaDön.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(34)))));
            this.btnAnasayfayaDön.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnasayfayaDön.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnasayfayaDön.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDön.ForeColor = System.Drawing.Color.Black;
            this.btnAnasayfayaDön.Image = global::WindowsFormsApp1.Properties.Resources.Industry_Return_icon;
            this.btnAnasayfayaDön.Location = new System.Drawing.Point(1502, 864);
            this.btnAnasayfayaDön.Name = "btnAnasayfayaDön";
            this.btnAnasayfayaDön.Size = new System.Drawing.Size(522, 102);
            this.btnAnasayfayaDön.TabIndex = 2;
            this.btnAnasayfayaDön.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfayaDön.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnasayfayaDön.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDön.Click += new System.EventHandler(this.btnAnasayfayaDön_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnAnasayfayaDön;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.btnAnasayfayaDön);
            this.Controls.Add(this.lblDÖVİZKURLARI);
            this.Controls.Add(this.grpboxDövizKurları);
            this.Controls.Add(this.lstboxDövizKurları);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.Resize += new System.EventHandler(this.WebBrowser_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpboxDövizKurları.ResumeLayout(false);
            this.grpboxDövizKurları.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ListBox lstboxDövizKurları;
        private System.Windows.Forms.GroupBox grpboxDövizKurları;
        private System.Windows.Forms.Label lblDövizSatım;
        private System.Windows.Forms.Label lblDövizAlım;
        private System.Windows.Forms.Label lblDövizAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlım;
        private System.Windows.Forms.Label lblSatım;
        private System.Windows.Forms.Label lblDÖVİZKURLARI;
        private System.Windows.Forms.Button btnAnasayfayaDön;
    }
}