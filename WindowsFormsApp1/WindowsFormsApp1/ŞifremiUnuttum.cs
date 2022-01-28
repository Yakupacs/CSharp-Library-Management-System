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
    public partial class ŞifremiUnuttum : Form
    {
        public ŞifremiUnuttum()
        {
            InitializeComponent();
        }

        private void txtÜyeTC_TextChanged(object sender, EventArgs e)
        {

        }
        ProjeEntities2 db = new ProjeEntities2();
        private void txtKullanıcıAdı_Load(object sender, EventArgs e)
        {
            
            txtTC.ReadOnly = true;  
            txtŞifre1.ReadOnly = true;
            txtŞifre2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = txtKullanıcıAdı.Text;
            var sonuc = db.tbl_Personel.Where(x => x.PersonelKullanıcıAdı == kullanıcıadı).FirstOrDefault();
            if (sonuc != null)
            {
               
                MessageBox.Show("Personel Bulundu"+ "\n" + sonuc.PersonelAdı + " " + sonuc.PersonelSoyadı + "\nLütfen TC No Giriniz.","Uyarı!");
          
                txtTC.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Adına Ait Personel Bulunamadı.", "Uyarı!");
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
           
            int tc = (int)Convert.ToInt64(txtTC.Text);
            var sonuc = db.tbl_Personel.Where(x => x.PersonelTC == tc).FirstOrDefault();
            if (sonuc != null)
            {

                MessageBox.Show("Sayın " + sonuc.PersonelAdı + " " + sonuc.PersonelSoyadı + "\n" + "\nLütfen Yeni Şifrenizi Giriniz.", "Uyarı!");
                txtŞifre1.ReadOnly = false;
                txtŞifre2.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Bu TC No'ya Ait Personel Bulunamadı.\nKullanıcı Adınızı Tekrar Giriniz.", "Uyarı!");
             
                txtTC.ReadOnly=true;
                txtTC.Text = "";
                txtKullanıcıAdı.Text = "";
        
            }
        }

        private void btnŞifreOnayla_Click(object sender, EventArgs e)
        {

        }
    }
}
