using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;  //XML KÜTÜPHANESİ

namespace WindowsFormsApp1
{
    public partial class WebBrowser : Form
    {


        XDocument mb = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");


        public WebBrowser()
        {
            InitializeComponent();
        }



        private void WebBrowser_Load(object sender, EventArgs e)
        {
            try
            {
              
            Uri adres = new Uri("http://google.com");
            webBrowser1.Url = adres;
            var sonuc = from x in mb.Descendants("Currency") select new { doviz = x.Element("Isim").Value }; //LİSTBOX'A CURRENCY ISİMLERİ ALIYORUZ.
            foreach (var item in sonuc)
            {
                lstboxDövizKurları.Items.Add(item.doviz.ToString());//LİSTBOX'A HER DÖNEN KUR İÇİN EKLE!
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            webBrowser1.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            webBrowser1.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            webBrowser1.GoHome();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            webBrowser1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void durToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            webBrowser1.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            Uri adres = new Uri("http://" + txtURL.Text);
            webBrowser1.Url = adres;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }



        private void lstboxDövizKurları_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            var KurBilgileri = from x in mb.Descendants("Currency")
                               where
                               x.Element("Isim").Value == lstboxDövizKurları.SelectedItem.ToString() //LİSTBOXTAN SEÇTİĞİN ITEMLERİ AŞAĞIDAKİ ÖZELLİKLERE GÖRE ARA.
                               select new
                               {
                                   ad = x.Element("CurrencyName").Value,
                                   alis = x.Element("ForexSelling").Value,
                                   satis = x.Element("ForexBuying").Value
                               };
            foreach (var x in KurBilgileri)
            {
                lblDövizAdı.Text = x.ad;
                lblDövizAlım.Text = x.satis;
                lblDövizSatım.Text = x.alis;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void grpboxDövizKurları_Enter(object sender, EventArgs e)
        {

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

        private void WebBrowser_Resize(object sender, EventArgs e)
        {
            try
            {
            WindowState = FormWindowState.Maximized; //FORM SAYFASI TAM EKRANDA KALSIN.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
