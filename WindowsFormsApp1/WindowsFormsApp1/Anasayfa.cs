using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        //GÜNÜN SÖZÜ FONKSİYONU
        void gununSozu()
        {
            try
            {
            DateTime dt = DateTime.Now;
            lblGununSozu.Visible = true;
            lblGununSozu.Text = dt.DayOfWeek.ToString();
            if (lblGununSozu.Text == "Monday")
            {
                MessageBox.Show("Başarı seni bulmaz. Sen çıkıp onu yakalamalısın.", "Günün Sözü");
            }
            else if (lblGununSozu.Text == "Tuesday")
            {
                MessageBox.Show("Gelecek, bugünden hazırlananlara aittir.", "Günün Sözü");
            }
            else if (lblGununSozu.Text == "Wednesday")
            {
                MessageBox.Show("Bu hayatta her şey zor olsa da hiçbir zaman imkansız değildir.", "Günün Sözü");
            }
            else if (lblGununSozu.Text == "Thursday")
            {
                MessageBox.Show("Yalnızca bugün yaptıkların,bütün yarınlarını değiştirebilir.", "Günün Sözü");
            }
            else if (lblGununSozu.Text == "Friday")
            {
                MessageBox.Show("Senin almaya cesaret edemediğin riskleri alanlar,senin yaşamak istediğin hayatı yaşarlar.", "Günün Sözü");
            }
            else if (lblGununSozu.Text == "Saturday")
            {
                MessageBox.Show("Durmadığın sürece ne kadar yavaş gittiğin önemli değil.", "Günün Sözü");
            }
            else if (lblGununSozu.Text == "Sunday")
            {
                MessageBox.Show("Önce farkı yaratırsın, sonra da fark yaratırsın.", "Günün Sözü");
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        //GÜNÜN KİTABI FONKSİYONU
        void gununKitabı()
        {
            try
            {
            DateTime dt = DateTime.Now;
            lblGununKitabı.Visible = true;
            lblGununKitabı.Text = dt.DayOfWeek.ToString();
            if (lblGununKitabı.Text == "Monday")
            {
                MessageBox.Show("Sefiller – Victor Hugo", "Günün Kitabı");
            }
            else if (lblGununKitabı.Text == "Tuesday")
            {
                MessageBox.Show("Suç ve Ceza – Fyodor Dostoyevski", "Günün Kitabı");
            }
            else if (lblGununKitabı.Text == "Wednesday")
            {
                MessageBox.Show("Anna Karenina – Lev Tolstoy", "Günün Kitabı");
            }
            else if (lblGununKitabı.Text == "Thursday")
            {
                MessageBox.Show("Vadideki Zambak – Honoré de Balzac", "Günün Kitabı");
            }
            else if (lblGununKitabı.Text == "Friday")
            {
                MessageBox.Show("Notre Dame’ın Kamburu – Victor Hugo", "Günün Kitabı");
            }
            else if (lblGununKitabı.Text == "Saturday")
            {
                MessageBox.Show("Aşk ve Gurur – Jane Austen", "Günün Kitabı");
            }
            else if (lblGununKitabı.Text == "Sunday")
            {
                MessageBox.Show("Romeo ve Juliet – William Shakespeare", "Günün Kitabı");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }



        //Exit Butonu
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

        private void btnPersonelGirişi_Click(object sender, EventArgs e)
        {
            try
            {
                
            PersonelGirişi frm = new PersonelGirişi();
            frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        //GİRİŞ EKRANI KAPANIRKEN SORU
        private void GirişEkranı_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dr = new DialogResult();
                //sınıf dialogresult class
                //nesne dr object
                dr = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Exit!", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.No || dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
     

        //GÜNÜN SÖZÜNÜ AKTARDIĞIMIZ LABEL
        private void lblGününSözü_Click(object sender, EventArgs e)
        {

            try
            {
                gununSozu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        private void btnGününKitabı_Click(object sender, EventArgs e)
        {
            try
            {
                gununKitabı();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                PersonelGirişi frm = new PersonelGirişi();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //SOL ÜST MENÜ ÇIKIŞ BUTONU
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gününSözüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                gununSozu();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



        }

        private void gününKitabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                gununKitabı();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



        }

        //FORM AÇILINCA TİMER BAŞLAR.
        private void GirişEkranı_Load(object sender, EventArgs e)
        {

            try
            {
             timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       

        //TOOL STRİP STATUS LABEL'E TİMER'E AKTARDIK.
        private void timer1_Tick_2(object sender, EventArgs e)
        {
            try
            {
                tssl1.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void btnKitapSorgulama_Click(object sender, EventArgs e)
        {
            try
            {
                                KitapSorgulama frm = new KitapSorgulama();
                                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lblHoşgeldin_Click(object sender, EventArgs e)
        {

        }

        private void personelGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                           
                            PersonelGirişi frm = new PersonelGirişi();
                            frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void görünümAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            
            KitapSorgulama frm = new KitapSorgulama();
            frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnWebBrowser_Click(object sender, EventArgs e)
        {
            try
            {
         
                
                WebBrowser frm = new WebBrowser();
                frm.ShowDialog();
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                            WebBrowser frm = new WebBrowser();
                            frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cntxtMenuArkaPlan_Opening(object sender, CancelEventArgs e)
        {

        }


        //FORM RESİZE ÖZELLİĞİ ANASAYFA TAM EKRANDAN ÇIKMAZ!
        private void Anasayfa_Resize(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void kitapSorguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                KitapSorgulama frm = new KitapSorgulama();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void internetTarayıcısıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                WebBrowser frm = new WebBrowser();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gününKitabıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                gununKitabı();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gününSözüToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                gununSozu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pctrBeykent_Click(object sender, EventArgs e)
        {

        }

        private void tssl1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //MOUSE BUTONUN ÜZERİNDEYKEN KIRMIZI
        private void btnPersonelGirişi_MouseMove(object sender, MouseEventArgs e)
        {
            btnPersonelGirişi.ForeColor = Color.Red;
        }
        //MOUSE BUTONDAN ÇIKTIĞINDA BEYAZ 
        private void btnPersonelGirişi_MouseLeave(object sender, EventArgs e)
        {
            if( btnPersonelGirişi.ForeColor == Color.Red)
            {
                btnPersonelGirişi.ForeColor = Color.White;
            }
        }

        private void btnKitapSorgulama_MouseMove(object sender, MouseEventArgs e)
        {
            btnKitapSorgulama.ForeColor = Color.Red;
        }

        private void btnKitapSorgulama_MouseLeave(object sender, EventArgs e)
        {
            if (btnKitapSorgulama.ForeColor == Color.Red)
            {
                btnKitapSorgulama.ForeColor = Color.White;
            }
        }

        private void btnWebBrowser_MouseMove(object sender, MouseEventArgs e)
        {
            btnWebBrowser.ForeColor = Color.Red;
        }

        private void btnWebBrowser_MouseLeave(object sender, EventArgs e)
        {
            if (btnWebBrowser.ForeColor == Color.Red)
            {
                btnWebBrowser.ForeColor = Color.White;
            }
        }

        private void btnGününKitabı_MouseMove(object sender, MouseEventArgs e)
        {
            btnGününKitabı.ForeColor = Color.Red;
        }

        private void btnGününKitabı_MouseLeave(object sender, EventArgs e)
        {
            if (btnGününKitabı.ForeColor == Color.Red)
            {
                btnGününKitabı.ForeColor = Color.White;
            }
        }

        private void lblGününSözü_MouseMove(object sender, MouseEventArgs e)
        {
            btnGününSözü.ForeColor = Color.Red;
        }

        private void btnGününSözü_MouseLeave(object sender, EventArgs e)
        {
            if (btnGününSözü.ForeColor == Color.Red)
            {
                btnGününSözü.ForeColor = Color.White;
            }
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            if (btnExit.ForeColor == Color.Red)
            {
                btnExit.ForeColor = Color.White;
            }
        }

        private void tssl1_MouseMove(object sender, MouseEventArgs e)
        {
            tssl1.ForeColor = Color.Red;
        }

        private void tssl1_MouseLeave(object sender, EventArgs e)
        {
            if (tssl1.ForeColor == Color.Red)
            {
                tssl1.ForeColor = Color.White;
            }
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
