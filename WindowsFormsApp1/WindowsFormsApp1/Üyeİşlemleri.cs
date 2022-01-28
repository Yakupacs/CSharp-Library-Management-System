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


namespace WindowsFormsApp1
{
    public partial class Üyeİşlemleri : Form
    {
        public Üyeİşlemleri()
        {
            InitializeComponent();
        }
        
        ProjeEntities2 db = new ProjeEntities2();

        void ClickListe()
        {
            try
            {
            string tc = Convert.ToString(dataGridViewÜYE.Rows[dataGridViewÜYE.CurrentRow.Index].Cells[0].Value);
            txtÜyeTC.Text = tc.ToString();

            string ad = Convert.ToString(dataGridViewÜYE.Rows[dataGridViewÜYE.CurrentRow.Index].Cells[1].Value);
            txtÜyeAd.Text = ad.ToString();

            string soyad = Convert.ToString(dataGridViewÜYE.Rows[dataGridViewÜYE.CurrentRow.Index].Cells[2].Value);
            txtÜyeSoyad.Text = soyad.ToString();

            string telefon = Convert.ToString(dataGridViewÜYE.Rows[dataGridViewÜYE.CurrentRow.Index].Cells[3].Value);
            txtÜyeTelefon.Text = telefon.ToString();

            string adres = Convert.ToString(dataGridViewÜYE.Rows[dataGridViewÜYE.CurrentRow.Index].Cells[4].Value);
            txtÜyeAdres.Text = adres.ToString();

            string mail = Convert.ToString(dataGridViewÜYE.Rows[dataGridViewÜYE.CurrentRow.Index].Cells[5].Value);
            txtÜyeEmail.Text = mail.ToString();
            string[] result = mail.Split('@');
            for (int i = 0; i < result.Length; i++)
                {
                    txtÜyeEmail.Text = result[0].ToString();
                    comboBoxEmail.Text = result[1].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

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

        

        private void Üyeİşlemleri_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewÜYE.DataSource = db.tbl_Uyee.ToList();
                dataGridViewÜYE.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        Bitmap bmp;
        private void btnTabloYazdır_Click(object sender, EventArgs e)
        {
            try
            {
            int height = dataGridViewÜYE.Height;
            dataGridViewÜYE.Height = dataGridViewÜYE.RowCount * dataGridViewÜYE.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridViewÜYE.Width, dataGridViewÜYE.Height);
            dataGridViewÜYE.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewÜYE.Width, dataGridViewÜYE.Height));
            dataGridViewÜYE.Height = height;
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
               
                dataGridViewÜYE.Font = new Font("Microsoft Sans Serif", trackBarTabloYazıBoyutu.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnÜyeEkle_Click_1(object sender, EventArgs e)
        {

            try
            {
                if(txtÜyeAd.Text != "" && txtÜyeAdres.Text != "" && txtÜyeEmail.Text != "" && txtÜyeSoyad.Text != "" && txtÜyeTC.Text != "" && txtÜyeTelefon.Text != "" && comboBoxEmail.Text != "")
                {
                    tbl_Uyee tbl = new tbl_Uyee();
                    tbl.UyeTC = txtÜyeTC.Text;
                    tbl.UyeAdı = txtÜyeAd.Text;
                    tbl.UyeSoyadı = txtÜyeSoyad.Text;
                    tbl.UyeTelefon = Convert.ToInt64(txtÜyeTelefon.Text);
                    tbl.UyeAçıkAdres = txtÜyeAdres.Text; 
                    tbl.UyeMail = txtÜyeEmail.Text+comboBoxEmail.Text;
                    db.tbl_Uyee.Add(tbl);
                    db.SaveChanges();

                    File.AppendAllText("Uye Log.txt", "\n(ÜYE EKLENDİ) \nEklenen Üye TC: " + txtÜyeTC.Text + "\nEklenen Üye Adı Soyadı: " + txtÜyeAd.Text + " " + txtÜyeSoyad.Text + "\nTarih: " + DateTime.Now.ToString() + "\nÜye Eklendi.\n");
                    btnÜyeListesi.PerformClick();
                    txtÜyeAd.Text = String.Empty;
                    txtÜyeSoyad.Text = String.Empty;
                    txtÜyeTC.Text = String.Empty;
                    txtÜyeTelefon.Text = String.Empty;
                    txtÜyeAdres.Text = String.Empty;
                    txtÜyeEmail.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Lütfen Üye Oluşturmak İçin Bütün Satırları Doldurduğunuzdan Emin Olun.", "Uyarı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnÜyeListesi_Click(object sender, EventArgs e)
        {
            try
            {
            dataGridViewÜYE.DataSource = db.tbl_Uyee.ToList();
            dataGridViewÜYE.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnÜyeSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtÜyeTC.Text != "")
                {                
                            string kod = txtÜyeTC.Text;
                            var sonuc = db.tbl_Uyee.Where(x => x.UyeTC == kod).FirstOrDefault();
                            if (sonuc != null)
                            {
                                DialogResult silinsinMi = MessageBox.Show("Üyeyi Silmek İstediğinize Emin misiniz?\nGeri Dönüşü Yok.",
                                    "Silme İşlemi", MessageBoxButtons.YesNo);
                                        if (silinsinMi != DialogResult.No)
                                        {
                                                db.tbl_Uyee.Remove(sonuc);
                                                db.SaveChanges();
                                                txtÜyeAd.Text = String.Empty;
                                                txtÜyeSoyad.Text = String.Empty;
                                                txtÜyeTC.Text = String.Empty;
                                                txtÜyeTelefon.Text = String.Empty;
                                                txtÜyeAdres.Text = String.Empty;
                                                txtÜyeEmail.Text = String.Empty;
                                                btnÜyeListesi.PerformClick();
                                                MessageBox.Show("Üye Başarıyla Silindi.", "Uyarı!");
                                                File.AppendAllText("Uye Log.txt", "\n(ÜYE SİLİNDİ) \nSilinen Üye TC: " + txtÜyeTC.Text + "\nSilinen Üye Adı Soyadı: " + txtÜyeAd.Text + " " + txtÜyeSoyad.Text + "\nTarih: " + DateTime.Now.ToString() + "\nÜye Silindi.\n");
                                            }
                                        else
                                        {
                                            MessageBox.Show("Silme İşlemi İptal Edildi.", "Silme İşlemi");
                                            btnÜyeListesi.PerformClick();
                                        }
                    
                            }
                            else
                            {
                                MessageBox.Show("Böyle bir üye yoktur.", "Uyarı!");
                            }
                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Üyenin TC No'sunu Giriniz Veya Aşağıda Listeden Seçiniz."
                        , "Uyarı!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridViewÜYE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnÜyeAra_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridViewÜYE.DataSource = db.tbl_Uyee.ToList();
                if (radioÜyeTC.Checked)
                {
                    if(txtÜyeAra.Text != "")
                    {
                            string tc = txtÜyeAra.Text;
                            var sonuc = db.tbl_Uyee.Where(x => x.UyeTC == tc).ToList();
                            if (sonuc.Count != 0)
                            {
                                dataGridViewÜYE.DataSource = sonuc;
                                MessageBox.Show("Üye Başarıyla Bulundu.", "Uyarı");
                            }
                            else
                            {
                                MessageBox.Show("Bu TC'ye Ait Üye Bulunamadı.", "Uyarı");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Üye TC No Giriniz!", "Uyarı!");
                    }
                }
                if (radioÜyeAdı.Checked)
                {
                    if(txtÜyeAra.Text != "")
                    {
                                var sonuc = db.tbl_Uyee.Where(x => x.UyeAdı.Contains(txtÜyeAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewÜYE.DataSource = sonuc;
                                    MessageBox.Show("Üye Başarıyla Bulundu.", "Uyarı");
                                }
                                else
                                {
                        
                                    MessageBox.Show("Bu İsme Ait Üye Bulunamadı.", "Uyarı");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Üye Adını Giriniz!", "Uyarı!");
                    }
                }
                if (radioÜyeSoyisim.Checked)
                {
                    if(txtÜyeAra.Text != "")
                    {
                                var sonuc = db.tbl_Uyee.Where(x => x.UyeSoyadı.Contains(txtÜyeAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewÜYE.DataSource = sonuc;
                                    MessageBox.Show("Üye Başarıyla Bulundu.", "Uyarı");
                                }
                                else
                                {
                        
                                    MessageBox.Show("Bu Soyisme Ait Üye Bulunamadı.", "Uyarı");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Üye Soyadını Giriniz!", "Uyarı!");
                    }
                }
                if (radioÜyeTelefon.Checked)
                {
                    if(txtÜyeAra.Text != "")
                    {
                            string telefon = (string)txtÜyeTelefon.Text;
                            var sonuc = db.tbl_Uyee.Where(x => x.UyeTelefon.ToString().Contains(txtÜyeAra.Text)).ToList();
                            if (sonuc.Count != 0)
                            {
                                dataGridViewÜYE.DataSource = sonuc;
                                MessageBox.Show("Üye Başarıyla Bulundu.", "Uyarı");
                            }
                            else
                            {
                                MessageBox.Show("Bu Telefon No'ya Ait Üye Bulunamadı.", "Uyarı");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Üye Telefonunu Giriniz!", "Uyarı!");
                    }
                }
                if (radioÜyeAdres.Checked)
                {
                    if(txtÜyeAra.Text != "")
                    {
                                var sonuc = db.tbl_Uyee.Where(x => x.UyeAçıkAdres.Contains(txtÜyeAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewÜYE.DataSource = sonuc;
                                    MessageBox.Show("Üye Başarıyla Bulundu.", "Uyarı");
                                }
                                else
                                {
                        
                                    MessageBox.Show("Bu Adrese Ait Üye Bulunamadı.", "Uyarı");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Üye Adresini Giriniz!", "Uyarı!");
                    }
                }
                if (radioÜyeEmail.Checked)
                {
                    if(txtÜyeAra.Text != "")
                    {
                                var sonuc = db.tbl_Uyee.Where(x => x.UyeMail.Contains(txtÜyeAra.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    dataGridViewÜYE.DataSource = sonuc;
                                    MessageBox.Show("Üye Başarıyla Bulundu.", "Uyarı");
                                }
                                else
                                {
                        
                                    MessageBox.Show("Bu Mail'e Ait Üye Bulunamadı.", "Uyarı");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Aramak İstediğiniz Üye Emailini Giriniz!", "Uyarı!");
                    }
                }
                if(radioÜyeAdres.Checked == false && radioÜyeAdı.Checked == false && radioÜyeEmail.Checked == false 
                    && radioÜyeSoyisim.Checked == false && radioÜyeTC.Checked == false && radioÜyeTelefon.Checked == false)
                {
                    MessageBox.Show("Lütfen Aramak İstediğiniz Özelliği Seçiniz!", "Uyarı!");
                }
                txtÜyeAra.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void btnÜyeGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtÜyeAd.Text != "" && txtÜyeAdres.Text !=  "" && txtÜyeEmail.Text != "" && txtÜyeSoyad.Text != "" && txtÜyeTC.Text != "" && txtÜyeTelefon.Text != "")
                {
                string kod = txtÜyeTC.Text;
                var sonuc = db.tbl_Uyee.Where(x => x.UyeTC == kod).FirstOrDefault();
                            if (sonuc != null)
                            {
                                sonuc.UyeTC = txtÜyeTC.Text;
                                sonuc.UyeAdı = txtÜyeAd.Text;
                                sonuc.UyeSoyadı = txtÜyeSoyad.Text;
                                sonuc.UyeTelefon = Convert.ToInt64(txtÜyeTelefon.Text);
                                sonuc.UyeAçıkAdres = txtÜyeAdres.Text;
                                sonuc.UyeMail = txtÜyeEmail.Text+comboBoxEmail.Text;
                                db.SaveChanges();
                                btnÜyeListesi.PerformClick();
                                MessageBox.Show("Üye Başarıyla Güncellendi.", "Uyarı!");
                                File.AppendAllText("Uye Log.txt", "\n(ÜYE GÜNCELLENDİ) \nGüncellenen Üye TC: " + txtÜyeTC.Text + "\nÜye Adı Soyadı: " + txtÜyeAd.Text + " " + txtÜyeSoyad.Text + "\nÜye Telefon NO: " + txtÜyeTelefon.Text + "\nÜye Adres: " + txtÜyeAdres.Text + "\nÜye Mail: " + txtÜyeEmail.Text + "\nTarih:" + DateTime.Now.ToString() + "\nÜye Güncellendi.\n");
                            }
                            else
                            {
                                MessageBox.Show("Böyle bir kayıt yoktur.", "Uyarı!");
                            }
                }
                else
                {
                    MessageBox.Show("Lütfen Üye Güncellemek İçin Bütün Satırları Doldurunuz.", "Uyarı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radioÜyeEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioÜyeAdres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioÜyeTelefon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioÜyeSoyisim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioÜyeAdı_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioÜyeTC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblÜyeEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtÜyeEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblÜyeAdres_Click(object sender, EventArgs e)
        {

        }

        private void lblÜyeTelefon_Click(object sender, EventArgs e)
        {

        }

        private void txtÜyeAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtÜyeTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblÜyeTC_Click(object sender, EventArgs e)
        {

        }

        private void lblÜyeSoyad_Click(object sender, EventArgs e)
        {

        }

        private void lblÜyeAd_Click(object sender, EventArgs e)
        {

        }

        private void txtÜyeTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtÜyeSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtÜyeAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtÜyeAra_TextChanged(object sender, EventArgs e)
        {

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

        private void lblTabloFont_Click(object sender, EventArgs e)
        {

        }

        private void Üyeİşlemleri_Resize(object sender, EventArgs e)
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

        private void txtÜyeTC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtÜyeTelefon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtÜyeAd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtÜyeSoyad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridViewÜYE_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ClickListe();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
