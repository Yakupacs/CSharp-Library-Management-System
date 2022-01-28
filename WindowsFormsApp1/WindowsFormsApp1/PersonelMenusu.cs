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
    public partial class PersonelMenusu : Form
    {
        public PersonelMenusu(int id)
        {
            try
            {
            InitializeComponent();
            var sonuc = db.tbl_Personel.Where(x => x.PersonelID == id).FirstOrDefault();
            toolStripStatusLabelPersonelAdıSoyadı.Text = sonuc.PersonelAdı.ToString() + " " + sonuc.PersonelSoyadı.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        ProjeEntities2 db = new ProjeEntities2();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                          
                            KitapEkle frm = new KitapEkle();
                            frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAnasayfayaDön_Click(object sender, EventArgs e)
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

        private void btnEmanetAl_Click(object sender, EventArgs e)
        {
            try
            {
               
            Emanetİşlemleri frm = new Emanetİşlemleri();
            frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
         
            Personelİşlemleri frm = new Personelİşlemleri();
            frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnÜyeListele_Click(object sender, EventArgs e)
        {
            try
            {
                
                Üyeİşlemleri frm = new Üyeİşlemleri();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        private void PersonelMenusu_Load(object sender, EventArgs e)
        {

        }

        private void PersonelMenusu_Resize(object sender, EventArgs e)
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


        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                KitapEkle frm = new KitapEkle();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Personelİşlemleri frm = new Personelİşlemleri();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void emanetİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Emanetİşlemleri frm = new Emanetİşlemleri();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Üyeİşlemleri frm = new Üyeİşlemleri();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void girişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnPersonelKitapEkle_MouseMove(object sender, MouseEventArgs e)
        {
            btnPersonelKitapEkle.ForeColor = Color.Red;
        }

        private void btnPersonelKitapEkle_MouseLeave(object sender, EventArgs e)
        {
            if(btnPersonelKitapEkle.ForeColor == Color.Red)
            {
                btnPersonelKitapEkle.ForeColor = Color.White;
            }
        }

        private void btnPersonelŞifreYenile_MouseMove(object sender, MouseEventArgs e)
        {
            btnPersonelŞifreYenile.ForeColor = Color.Red;
        }

        private void btnPersonelŞifreYenile_MouseLeave(object sender, EventArgs e)
        {
            if (btnPersonelŞifreYenile.ForeColor == Color.Red)
            {
                btnPersonelŞifreYenile.ForeColor = Color.White;
            }
        }

        private void btnEmanetAl_MouseMove(object sender, MouseEventArgs e)
        {
            btnEmanetAl.ForeColor = Color.Red;
        }

        private void btnEmanetAl_MouseLeave(object sender, EventArgs e)
        {
            if (btnEmanetAl.ForeColor == Color.Red)
            {
                btnEmanetAl.ForeColor = Color.White;
            }
        }

        private void btnÜyeListele_MouseMove(object sender, MouseEventArgs e)
        {
            btnÜyeListele.ForeColor = Color.Red;
        }

        private void btnÜyeListele_MouseLeave(object sender, EventArgs e)
        {
            if (btnÜyeListele.ForeColor == Color.Red)
            {
                btnÜyeListele.ForeColor = Color.White;
            }
        }

        private void btnAnasayfayaDön_MouseMove(object sender, MouseEventArgs e)
        {
            btnAnasayfayaDön.ForeColor = Color.Red;
        }

        private void btnAnasayfayaDön_MouseLeave(object sender, EventArgs e)
        {
            if (btnAnasayfayaDön.ForeColor == Color.Red)
            {
                btnAnasayfayaDön.ForeColor = Color.Black;
            }
        }
    }
}
