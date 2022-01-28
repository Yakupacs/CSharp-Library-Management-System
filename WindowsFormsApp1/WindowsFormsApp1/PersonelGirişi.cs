using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class PersonelGirişi : Form
    {
        public PersonelGirişi()
        {
            InitializeComponent();
        }

        //GÜVENLİK KODU FONKSİYONU
        void GuvenlikKodu()
        {
            try
            {
                            Random rnd = new Random();

                            string guvenlikKodu = "";
                            string harfler = "QAZWSXEDCRFVTGBYHNUJMKOLPqazwsxedcrfvtgbyhnujmıkopi1234567890";

                            ///6 karakter
                            for (int i = 0; i < 6; i++)
                            {
                                guvenlikKodu += harfler[rnd.Next(harfler.Length)];
                                //harfler[1] + harfler[23] + harfler[66]
                            }

                            lblGüvenlikKodu.Text = guvenlikKodu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        ProjeEntities2 db = new ProjeEntities2();



        private void Anasayfa_Load(object sender, EventArgs e)
        {
            try
            {
                                GuvenlikKodu();
                                txtPersonelŞifre.PasswordChar = '*'; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void Anasayfa_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }

        private void Anasayfa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            }

       
       
        int count = 3;
        private void GirisBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPersonelKullanıcıAdı.Text != "" && txtPersonelŞifre.Text != "" && txtGüvenlikKodu.Text != "")
                {
                            var sonuc = db.tbl_Personel.Where(x => x.PersonelKullanıcıAdı == txtPersonelKullanıcıAdı.Text && x.PersonelŞifre == txtPersonelŞifre.Text).FirstOrDefault();
                            if (sonuc != null)
                            {
                                    if(txtGüvenlikKodu.Text == lblGüvenlikKodu.Text)
                                    {

                                    MessageBox.Show("Sayın "+sonuc.PersonelAdı+" "+sonuc.PersonelSoyadı+" Hoş Geldiniz.", "Hoş Geldiniz!");

                                    File.AppendAllText("Girişler Log.txt", "(GİRİŞ)\n" + "Personel Kullanıcı Adı: " + txtPersonelKullanıcıAdı.Text 
                                        + "\nTarih: " + DateTime.Now.ToString() + "\nSisteme Giriş Gerçekleşti.\n\n");

                                    txtPersonelKullanıcıAdı.Text = String.Empty;
                                    txtPersonelŞifre.Text = String.Empty;
                                    txtGüvenlikKodu.Text = String.Empty;

                                    PersonelMenusu frm = new PersonelMenusu(sonuc.PersonelID);

                                    frm.ShowDialog();
                                    count = 3;
                                    lblPersonelHataSayısı.Visible = true;
                                    lblPersonelHataSayısı.Text = count.ToString();
                                    }
                                    else
                                    {
                                    MessageBox.Show("Güvenlik Kodunu Yanlış Girdiniz.\nTekrar Deneyiniz.", "Uyarı!");
                                    txtGüvenlikKodu.Text = String.Empty;
                                    GuvenlikKodu();
                                    }
                                


                            }
                            else
                            {
                                count--;
                                MessageBox.Show("Hatalı Giriş Yapıldı.\nKullanıcı Adınızı veya Şifrenizi Kontrol Ediniz.\n" +count + " Hakkınız Kaldı." , "Uyarı!");
                                GuvenlikKodu();

                                File.AppendAllText("Girişler Log.txt", "(HATALI GİRİŞ)\n" + "Personel Kullanıcı Adı: " 
                                    + txtPersonelKullanıcıAdı.Text + "\nTarih: " 
                                    + DateTime.Now.ToString() + "\nSisteme Hatalı Bir Giriş Gerçekleşti.\n\n");

                                txtPersonelKullanıcıAdı.Text = String.Empty;
                                txtPersonelŞifre.Text = String.Empty;
                                txtGüvenlikKodu.Text = String.Empty;
                                
                                lblPersonelHataSayısı.Visible = true;
                                lblPersonelHataSayısı.Text = count.ToString();
                                if (count <= 0)
                                {
                                    MessageBox.Show("Lütfen IT Departmanıyla Görüşünüz. Yetkili Personellerden Yardım İsteyiniz.", "Dikkat!");
                                    txtPersonelKullanıcıAdı.ReadOnly = true;
                                    txtPersonelŞifre.ReadOnly = true;
                                    txtGüvenlikKodu.ReadOnly = true;
                                    btnPersonelGiris.Enabled = false;
                        }
                            }
                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Bilgileri Doldurunuz.", "Uyarı!");
                }
                

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
                File.AppendAllText("Girişler Log.txt", "(SİSTEM HATASI)\n" + "Kullanıcı Adı: " + txtPersonelKullanıcıAdı.Text +
                   "\nTarih: " + DateTime.Now.ToString() + "\nOluşan Hata: " + exp.Source + "\n" + exp.TargetSite.ToString());
            }

;
        }


        private void lblHata_Click(object sender, EventArgs e)
        {

        }

        private void btnGeriDön_Click(object sender, EventArgs e)
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



        private void lblPersonelKalanDeneme_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonelŞifre_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonelKullanıcıAdı_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonelGirişi_Click(object sender, EventArgs e)
        {

        }   
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GuvenlikKodu();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PersonelGirişi_Resize(object sender, EventArgs e)
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

        private void lblGüvenlikKodu_Click(object sender, EventArgs e)
        {
            try
            {
                GuvenlikKodu();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
    }
