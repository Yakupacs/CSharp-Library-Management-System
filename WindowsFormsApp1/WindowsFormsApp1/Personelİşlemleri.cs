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
using System.Security.Cryptography;


namespace WindowsFormsApp1
{
    public partial class Personelİşlemleri : Form
    {
        public Personelİşlemleri()
        {
            InitializeComponent();
        }
        ProjeEntities2 db = new ProjeEntities2();


        private void Personelİşlemleri_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPERSONEL.DataSource = db.tbl_Personel.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            try
            {
            dataGridViewPERSONEL.DataSource = db.tbl_Personel.ToList();
                MessageBox.Show("Personeller Listelendi.","Uyarı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnPersonelGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPersonelAdres.Text != "" && txtPersonelAdı.Text != "" && txtPersonelEmail.Text != "" && txtPersonelKullanıcıAdı.Text != "" &&
                    txtPersonelSoyad.Text != "" && txtPersonelTC.Text != "" && txtPersonelTelefon.Text != "" && txtPersonelŞifre.Text != "")
                {
                                int kod = Convert.ToInt16(txtPersonelID.Text);
                                var sonuc = db.tbl_Personel.Where(x => x.PersonelID == kod).FirstOrDefault();
                                if (sonuc != null)
                                {
                                    sonuc.PersonelTC = Convert.ToInt64(txtPersonelTC.Text);
                                    sonuc.PersonelAdı = txtPersonelAdı.Text;
                                    sonuc.PersonelSoyadı = txtPersonelSoyad.Text;
                                    sonuc.PersonelTelefon = Convert.ToInt64(txtPersonelTelefon.Text);
                                    sonuc.PersonelAçıkAdres = txtPersonelAdres.Text;
                                    sonuc.PersonelMail = txtPersonelEmail.Text+comboBoxEmail.Text;
                                    db.SaveChanges();
                                    btnPersonelListesi.PerformClick();
                                    MessageBox.Show("Personel Başarıyla Güncellendi.", "Uyarı!");
                                    File.AppendAllText("Personel Log.txt", "\n(PERSONEL GÜNCELLENDİ) \nPersonel Adı Soyadı: " + txtPersonelAdı.Text + " " + txtPersonelSoyad.Text + "\nPersonel Telefon NO: "
                                        + txtPersonelTelefon.Text + "\nPersonel Adres: " + txtPersonelAdres.Text + "\nPersonel Mail: "
                                        + txtPersonelEmail.Text + "\nPersonel Kullanıcı Adı: " + txtPersonelKullanıcıAdı.Text + "\nTarih:"
                                        + DateTime.Now.ToString() + "\nPersonel Güncellendi.\n");
                                }
                                else
                                {
                                    MessageBox.Show("Böyle bir kayıt yoktur.", "Uyarı!");
                                }
                }
                else
                {
                    MessageBox.Show("Personeli Güncellemek İçin Listeden Seçim Yapınız.", "Uyarı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridViewPERSONEL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonelID.Text != "")
                {
                    int kod = Convert.ToInt16(txtPersonelID.Text);
                    var sonuc = db.tbl_Personel.Where(x => x.PersonelID == kod).FirstOrDefault();
                    if (sonuc != null)
                    {
                        DialogResult silinsinMi = MessageBox.Show("Personeli Silmek İstediğinize Emin misiniz?\nGeri Dönüşü Yok.",
                            "Silme İşlemi", MessageBoxButtons.YesNo);
                        if (silinsinMi != DialogResult.No)
                        {
                            db.tbl_Personel.Remove(sonuc);
                            db.SaveChanges();
                            btnPersonelListesi.PerformClick();
                            MessageBox.Show("Personel Başarıyla Silindi.", "Uyarı!");
                            File.AppendAllText("Personel Log.txt", "\n(PERSONEL SİLİNDİ) \nSilinen Personel ID: " + txtPersonelID.Text + "\nSilinen Personel Adı Soyadı: " + txtPersonelAdı.Text + " " + txtPersonelSoyad.Text + "\nTarih: " + DateTime.Now.ToString() + "\nPersonel Silindi.\n\n");
                            txtPersonelID.Text = String.Empty;
                            txtPersonelAdı.Text = String.Empty;
                            txtPersonelSoyad.Text = String.Empty;
                            txtPersonelTC.Text = String.Empty;
                            txtPersonelTelefon.Text = String.Empty;
                            txtPersonelAdres.Text = String.Empty;
                            txtPersonelEmail.Text = String.Empty;
                            txtPersonelKullanıcıAdı.Text = String.Empty;
                            txtPersonelŞifre.Text = String.Empty;

                        }
                        else
                        {
                            MessageBox.Show("Silme İşlemi İptal Edildi.", "Silme İşlemi");
                            btnPersonelListesi.PerformClick();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Böyle bir personel yoktur.", "Uyarı!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Personel ID Giriniz Veya Listeden Seçiniz!", "Uyarı!");
                }
                        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonelAdres.Text != "" && txtPersonelAdı.Text != "" && txtPersonelEmail.Text != "" && txtPersonelKullanıcıAdı.Text != "" &&
                    txtPersonelSoyad.Text != "" && txtPersonelTC.Text != "" && txtPersonelTelefon.Text != "" && txtPersonelŞifre.Text != "")
                {
                                tbl_Personel tbl = new tbl_Personel();
                            tbl.PersonelAdı = txtPersonelAdı.Text;
                            tbl.PersonelSoyadı = txtPersonelSoyad.Text;
                            tbl.PersonelTC = Convert.ToInt64(txtPersonelTC.Text);
                            tbl.PersonelTelefon = Convert.ToInt64(txtPersonelTelefon.Text);
                            tbl.PersonelAçıkAdres = txtPersonelAdres.Text;
                            tbl.PersonelMail = txtPersonelEmail.Text+comboBoxEmail.Text;
                            tbl.PersonelKullanıcıAdı = txtPersonelKullanıcıAdı.Text;
                            tbl.PersonelŞifre = txtPersonelŞifre.Text;
                            db.tbl_Personel.Add(tbl);
                            db.SaveChanges();
                            File.AppendAllText("Personel Log.txt", "\n(PERSONEL EKLENDİ) \nEklenen Personel ID: " + txtPersonelID.Text + "\nEklenen Personel Adı Soyadı: " + txtPersonelAdı.Text + " " + txtPersonelSoyad.Text + "\nTarih: " + DateTime.Now.ToString() + "\nPersonel Eklendi.\n");
                            btnPersonelListesi.PerformClick();
                            txtPersonelID.Text = String.Empty;
                            txtPersonelAdı.Text = String.Empty;
                            txtPersonelSoyad.Text = String.Empty;
                            txtPersonelTC.Text = String.Empty;
                            txtPersonelAdres.Text = String.Empty;
                            txtPersonelTelefon.Text = String.Empty;
                            txtPersonelKullanıcıAdı.Text = String.Empty;
                            txtPersonelEmail.Text = String.Empty;
                            txtPersonelŞifre.Text = String.Empty;
                            MessageBox.Show("Personel Başarıyla Oluşturuldu.", "Uyarı!");
                }
                else
                {
                    MessageBox.Show("Lütfen Oluşturmak İstediğiniz Üyenin Bilgilerini Eksiksiz Giriniz!", "Uyarı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPERSONEL.DataSource = db.tbl_Personel.ToList();
                if (radioPersonelID.Checked)
                {
                    if(txtPersonelAra.Text != "")
                    {
                                int id = Convert.ToInt16(txtPersonelAra.Text);
                                var sonuc = db.tbl_Personel.Where(x => x.PersonelID == id).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewPERSONEL.DataSource = sonuc;
                                    MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı!");
                                }
                                else
                                {
                                    MessageBox.Show("Bu ID'ye Ait Personel Bulunamadı.", "Uyarı!");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin ID'sini Giriniz!", "Uyarı!");
                    }
                }
                if (radioPersonelAdı.Checked)
                {
                    if (txtPersonelAra.Text != "")
                    {
                                    var sonuc = db.tbl_Personel.Where(x => x.PersonelAdı.Contains(txtPersonelAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewPERSONEL.DataSource = sonuc;
                                    MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı!");
                                }
                                else
                                {

                                    MessageBox.Show("Bu İsme Ait Personel Bulunamadı.", "Uyarı!");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin Adını Giriniz!", "Uyarı!");
                    }
                }
                if (radioPersonelSoyisim.Checked)
                {
                    if (txtPersonelAra.Text != "")
                    {
                                    var sonuc = db.tbl_Personel.Where(x => x.PersonelSoyadı.Contains(txtPersonelAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewPERSONEL.DataSource = sonuc;
                                    MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı!");
                                }
                                else
                                {

                                    MessageBox.Show("Bu Soyisme Ait Personel Bulunamadı.", "Uyarı!");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin Soyadını Giriniz!", "Uyarı!");
                    }
                }
                if (radioPersonelTC.Checked)
                {
                    if (txtPersonelAra.Text != "")
                    {
                                string tc = (string)txtPersonelTC.Text;
                            var sonuc = db.tbl_Personel.Where(x => x.PersonelTC.ToString().Contains(txtPersonelAra.Text)).ToList();
                            if (sonuc.Count != 0)
                            {
                                dataGridViewPERSONEL.DataSource = sonuc;
                                MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı!");
                            }
                            else
                            {
                                MessageBox.Show("Bu TC'ye Ait Personel Bulunamadı.", "Uyarı!");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin TC'sini Giriniz!", "Uyarı!");
                    }
                }
                if (radioPersonelTelefon.Checked)
                {
                    if (txtPersonelAra.Text != "")
                    {
                                    string tc = (string)txtPersonelTelefon.Text;
                                var sonuc = db.tbl_Personel.Where(x => x.PersonelTelefon.ToString().Contains(txtPersonelAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewPERSONEL.DataSource = sonuc;
                                    MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı");
                                }
                                else
                                {
                                    MessageBox.Show("Bu Telefon Numarasına Ait Personel Bulunamadı.", "Uyarı!");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin Telefon Numarasını Giriniz!", "Uyarı!");
                    }
                }
                if (radioPersonelAdres.Checked)
                {
                    if (txtPersonelAra.Text != "")
                    {
                                    var sonuc = db.tbl_Personel.Where(x => x.PersonelAçıkAdres.Contains(txtPersonelAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewPERSONEL.DataSource = sonuc;
                                    MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı!");
                                }
                                else
                                {

                                    MessageBox.Show("Bu Adrese Ait Personel Bulunamadı.", "Uyarı!");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin Adresini Giriniz!", "Uyarı!");
                    }
                }
                if (radioPersonelEmail.Checked)
                    {
                        if (txtPersonelAra.Text != "")
                        {
                                        var sonuc = db.tbl_Personel.Where(x => x.PersonelMail.Contains(txtPersonelAra.Text)).ToList();
                                    if (sonuc.Count != 0)
                                    {
                                        dataGridViewPERSONEL.DataSource = sonuc;
                                        MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı");
                                    }
                                    else
                                    {

                                        MessageBox.Show("Bu E-mail'e Ait Personel Bulunamadı.", "Uyarı");
                                    }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Aramak İstediğiniz Personelin E-mail'ini Giriniz!", "Uyarı!");
                        }
                    }
                if (radioPersonelKullanıcıAdı.Checked)
                {
                    if (txtPersonelAra.Text != "")
                    {
                                var sonuc = db.tbl_Personel.Where(x => x.PersonelKullanıcıAdı.Contains(txtPersonelAra.Text)).ToList();
                            if (sonuc.Count != 0)
                            {
                                dataGridViewPERSONEL.DataSource = sonuc;
                                MessageBox.Show("Personel Başarıyla Bulundu.", "Uyarı");
                            }
                            else
                            {

                                MessageBox.Show("Bu Kullanıcı Adına Ait Personel Bulunamadı.", "Uyarı");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Personelin Kullanıcı Adını Giriniz!", "Uyarı!");
                    }
                }
                if(radioPersonelAdres.Checked == false && radioPersonelAdı.Checked == false &&
                    radioPersonelEmail.Checked == false && radioPersonelID.Checked == false &&
                    radioPersonelKullanıcıAdı.Checked == false && radioPersonelSoyisim.Checked == false &&
                    radioPersonelTC.Checked == false && radioPersonelTelefon.Checked == false)
                {
                    MessageBox.Show("Lütfen Arama Yapmak İstediğiniz Özelliği Seçiniz!", "Uyarı!");
                }
                txtPersonelAra.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        private void btnYazdır_Click_1(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridViewPERSONEL.Height;
                dataGridViewPERSONEL.Height = dataGridViewPERSONEL.RowCount * dataGridViewPERSONEL.RowTemplate.Height * 2;
                bmp = new Bitmap(dataGridViewPERSONEL.Width, dataGridViewPERSONEL.Height);
                dataGridViewPERSONEL.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewPERSONEL.Width, dataGridViewPERSONEL.Height));
                dataGridViewPERSONEL.Height = height;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void trackBarTabloYazıBoyutu_Scroll(object sender, EventArgs e)
        {
            try
            {

                dataGridViewPERSONEL.Font = new Font("Microsoft Sans Serif", trackBarTabloYazıBoyutu.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPersonelMenüsü_Click_1(object sender, EventArgs e)
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

        private void Personelİşlemleri_Resize(object sender, EventArgs e)
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

        private void txtPersonelID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPersonelTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPersonelTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPersonelAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnGuvenliSifreOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPersonelAdı.Text != "")
                {
                    txtGüvenliSifre.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPersonelAdı.Text));
                    byte[] datas = Convert.FromBase64String(txtGüvenliSifre.Text);
                    MessageBox.Show("Güvenli Şifreniz Oluşturuldu.", "Uyarı!");
                }
                else
                {
                    MessageBox.Show("Lütfen Listeden Bir Personel Seçiniz!", "Uyarı!");
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridViewPERSONEL_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            string id = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[0].Value);
            txtPersonelID.Text = id.ToString();

            string ad = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[1].Value);
            txtPersonelAdı.Text = ad.ToString();

            string soyad = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[2].Value);
            txtPersonelSoyad.Text = soyad.ToString();

            string tc = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[3].Value);
            txtPersonelTC.Text = tc.ToString();

            string telefon = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[4].Value);
            txtPersonelTelefon.Text = telefon.ToString();

            string adres = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[5].Value);
            txtPersonelAdres.Text = adres.ToString();



             string mail = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[6].Value);
             string[] result = mail.Split('@');
             for (int i = 0; i < result.Length; i++)
                {
                    txtPersonelEmail.Text =result[0].ToString();
                    comboBoxEmail.Text = result[1].ToString();
                }

                string kullaniciAdi = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[7].Value);
            txtPersonelKullanıcıAdı.Text = kullaniciAdi.ToString();

            string sifre = Convert.ToString(dataGridViewPERSONEL.Rows[dataGridViewPERSONEL.CurrentRow.Index].Cells[8].Value);
            txtPersonelŞifre.Text = sifre.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
