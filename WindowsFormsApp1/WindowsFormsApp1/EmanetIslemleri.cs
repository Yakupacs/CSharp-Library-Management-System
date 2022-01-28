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
    public partial class Emanetİşlemleri : Form
    {
        public Emanetİşlemleri()
        {
            InitializeComponent();
        }
        
        void emanetleriListele()
        {
            try
            {
                var emanetListesi = from kayit in db.tbl_Emanetlerrr select new { 
                kayit.EmanetID,
                kayit.tbl_Uyee.UyeAdı,
                kayit.tbl_Kitap.KitapAdı,
                kayit.EmanetVerilenTarih,
                kayit.EmanetAlınacakTarih,
                kayit.EmanetDurum};
                dataGridViewEMANET.DataSource = emanetListesi.ToList();
                dataGridViewEMANET.Columns[0].HeaderText = "Emanet NO";
                dataGridViewEMANET.Columns[1].HeaderText = "Emanet Alan Üye";
                dataGridViewEMANET.Columns[2].HeaderText = "Emanet Alınan Kitap";
                dataGridViewEMANET.Columns[3].HeaderText = "Verilen Tarih";
                dataGridViewEMANET.Columns[4].HeaderText = "Alınacak Tarih";
                dataGridViewEMANET.Columns[5].HeaderText = "Kitap Bizde mi?";
                dataGridViewEMANET.DataSource = emanetListesi.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        void kitaplarıListele()
        {
            try
            {
            dataGridViewKİTAPLAR.DataSource = db.tbl_Kitap.ToList();
            dataGridViewKİTAPLAR.Columns[7].Visible = false;
            dataGridViewKİTAPLAR.Columns[6].Visible = false;
            dataGridViewKİTAPLAR.Columns[0].HeaderText = "Kitap NO";
            dataGridViewKİTAPLAR.Columns[1].HeaderText = "Kitap Adı";
            dataGridViewKİTAPLAR.Columns[2].HeaderText = "Yazarı";
            dataGridViewKİTAPLAR.Columns[3].HeaderText = "Yayınevi";
            dataGridViewKİTAPLAR.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridViewKİTAPLAR.Columns[5].HeaderText = "Tür";
            dataGridViewKİTAPLAR.DataSource = db.tbl_Kitap.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        void üyeleriListele()
        {
            try
            {
            dataGridViewÜYELER.DataSource = db.tbl_Uyee.ToList();
            dataGridViewÜYELER.Columns[6].Visible = false;
            dataGridViewÜYELER.Columns[0].HeaderText = "Üye TC NO";
            dataGridViewÜYELER.Columns[1].HeaderText = "Üye Adı";
            dataGridViewÜYELER.Columns[2].HeaderText = "Üye Soyadı";
            dataGridViewÜYELER.Columns[3].HeaderText = "Telefon No";
            dataGridViewÜYELER.Columns[4].HeaderText = "Şehir";
            dataGridViewÜYELER.Columns[5].HeaderText = "Mail Adresi";
            dataGridViewÜYELER.DataSource = db.tbl_Uyee.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void EmanetIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
            emanetleriListele();
            üyeleriListele();
            kitaplarıListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnPersonelMenüsü_Click(object sender, EventArgs e)
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

        private void trackBarEmanet_Scroll(object sender, EventArgs e)
        {
            try
            {
                dataGridViewKİTAPLAR.Font = new Font("Microsoft Sans Serif", trackBarEmanet.Value);
                dataGridViewEMANET.Font = new Font("Microsoft Sans Serif", trackBarEmanet.Value);
                dataGridViewÜYELER.Font = new Font("Microsoft Sans Serif", trackBarEmanet.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Bitmap bmp;
        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioEmanetListesi.Checked)
                {
                    int height = dataGridViewEMANET.Height;
                    dataGridViewEMANET.Height = dataGridViewEMANET.RowCount * dataGridViewEMANET.RowTemplate.Height * 2;
                    bmp = new Bitmap(dataGridViewEMANET.Width, dataGridViewEMANET.Height);
                    dataGridViewEMANET.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewEMANET.Width, dataGridViewEMANET.Height));
                    dataGridViewEMANET.Height = height;
                    printPreviewDialog1.ShowDialog();
                }
                if (radioKitapTablosu.Checked)
                {
                    int height = dataGridViewKİTAPLAR.Height;
                    dataGridViewKİTAPLAR.Height = dataGridViewKİTAPLAR.RowCount * dataGridViewKİTAPLAR.RowTemplate.Height * 2;
                    bmp = new Bitmap(dataGridViewKİTAPLAR.Width, dataGridViewKİTAPLAR.Height);
                    dataGridViewKİTAPLAR.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewKİTAPLAR.Width, dataGridViewKİTAPLAR.Height));
                    dataGridViewKİTAPLAR.Height = height;
                    printPreviewDialog1.ShowDialog();
                }
                if (radioÜye.Checked)
                {
                    int height = dataGridViewÜYELER.Height;
                    dataGridViewÜYELER.Height = dataGridViewÜYELER.RowCount * dataGridViewÜYELER.RowTemplate.Height * 2;
                    bmp = new Bitmap(dataGridViewÜYELER.Width, dataGridViewÜYELER.Height);
                    dataGridViewÜYELER.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridViewÜYELER.Width, dataGridViewÜYELER.Height));
                    dataGridViewÜYELER.Height = height;
                    printPreviewDialog1.ShowDialog();
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
        ProjeEntities2 db = new ProjeEntities2();
        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            try
            {
            emanetleriListele();
                MessageBox.Show("Emanetler Başarıyla Listelendi.", "Uyarı!");
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
                            //Kişiyi Aldık.
                            string secilenUyeTC = (string)dataGridViewÜYELER.CurrentRow.Cells[0].Value;
                            var secilenUye = db.tbl_Uyee.Where(x => x.UyeTC == secilenUyeTC).FirstOrDefault();

                            //Kitabı Aldık.
                            int secilenKitapID = Convert.ToInt16(dataGridViewKİTAPLAR.CurrentRow.Cells[0].Value);
                            var secilenKitap = db.tbl_Kitap.Where(x => x.KitapID == secilenKitapID).FirstOrDefault();
                
                            tbl_Emanetlerrr yeniEmanet = new tbl_Emanetlerrr();
                            yeniEmanet.EmanetKitapID = secilenKitap.KitapID;
                            yeniEmanet.EmanetÜyeTC = secilenUye.UyeTC;
                            yeniEmanet.EmanetVerilenTarih = DateTime.Today;
                            yeniEmanet.EmanetAlınacakTarih = DateTime.Today.AddDays(15);
                            yeniEmanet.EmanetDurum = false;
                            db.tbl_Emanetlerrr.Add(yeniEmanet);
                            db.SaveChanges();
                            
                            var emanetList = db.tbl_Emanetlerrr.ToList();
                            emanetleriListele();
                            File.AppendAllText("Emanet Log.txt", "\n(EMANET VERİLDİ) \nSeçilen Kitap: " + secilenKitap.KitapAdı + "\nEmanet Verilen Üye: " + secilenUye.UyeAdı + " " + secilenUye.UyeSoyadı + "\nTarih: " + DateTime.Now.ToString() + "\nEmanet Verildi.\n");
                            MessageBox.Show("Emanet Başarıyla Oluşturuldu.", "Uyarı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnEmanetGelmeyenleriGör_Click(object sender, EventArgs e)
        {
            try
            {
                        var kayitlar = db.tbl_Emanetlerrr.Where(x => x.EmanetDurum == false).ToList();
                        
                        dataGridViewEMANET.DataSource = kayitlar.ToList();
                        dataGridViewEMANET.Columns[0].HeaderText = "Emanet NO";
                        dataGridViewEMANET.Columns[1].HeaderText = "Emanet Alan Üye";
                        dataGridViewEMANET.Columns[2].HeaderText = "Emanet Alınan Kitap";
                        dataGridViewEMANET.Columns[3].HeaderText = "Verilen Tarih";
                        dataGridViewEMANET.Columns[4].HeaderText = "Alınacak Tarih";
                        dataGridViewEMANET.Columns[5].HeaderText = "Kitap Bizde mi?";
                        dataGridViewEMANET.Columns[7].Visible = false;
                        dataGridViewEMANET.Columns[6].Visible = false;
                        dataGridViewEMANET.DataSource = kayitlar.ToList();
                        MessageBox.Show("Emanet İade Etmeyenler Listelendi.", "Uyarı!");
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnEmanetiGeriAl_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmanetID.Text != "")
                {
                
                int secilenEmanetID = Convert.ToInt32(txtEmanetID.Text);
                var emanet = db.tbl_Emanetlerrr.Where(x => x.EmanetID == secilenEmanetID).FirstOrDefault();
                    if(emanet.EmanetDurum == false)
                    {
                        emanet.EmanetDurum = true;  
                        db.SaveChanges();
                        var emanetler = db.tbl_Emanetlerrr.Where(x => x.EmanetDurum == false).ToList();
                        emanetleriListele();
                        MessageBox.Show("Emanet Başarıyla Geri Alındı.", "Uyarı!");
                    }
                    else
                    {
                        MessageBox.Show("Girmiş Olduğunuz Emanet Zaten Bizde!", "Uyarı!");
                    }
                }
                else
                {
                    MessageBox.Show("Emaneti Geri Almak İçin Bir Emanet ID Giriniz." , "Uyarı");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void dataGridViewKİTAPLAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewÜYELER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnEmanetEdenleriGör_Click(object sender, EventArgs e)
        {
            try
            {
                var kayitlar = db.tbl_Emanetlerrr.Where(x => x.EmanetDurum == true).ToList();

                dataGridViewEMANET.DataSource = kayitlar.ToList();
                dataGridViewEMANET.Columns[0].HeaderText = "Emanet NO";
                dataGridViewEMANET.Columns[1].HeaderText = "Emanet Alan Üye";
                dataGridViewEMANET.Columns[2].HeaderText = "Emanet Alınan Kitap";
                dataGridViewEMANET.Columns[3].HeaderText = "Verilen Tarih";
                dataGridViewEMANET.Columns[4].HeaderText = "Alınacak Tarih";
                dataGridViewEMANET.Columns[5].HeaderText = "Kitap Bizde mi?";
                dataGridViewEMANET.Columns[7].Visible = false;
                dataGridViewEMANET.Columns[6].Visible = false;
                dataGridViewEMANET.DataSource = kayitlar.ToList();
                MessageBox.Show("Emanet İade Edenler Listelendi.", "Uyarı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEmanetiSil_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmanetID.Text != "")
                {
                            int kod = Convert.ToInt32(txtEmanetID.Text);
                            var sonuc = db.tbl_Emanetlerrr.Where(x => x.EmanetID == kod).FirstOrDefault();
                            if (sonuc != null)
                            {
                                db.tbl_Emanetlerrr.Remove(sonuc);
                                db.SaveChanges();
                                emanetleriListele();
                                File.AppendAllText("Emanet Log.txt", "\n(EMANET BİLGİSİ SİLİNDİ) \nSilinen Emanet ID: " + txtEmanetID.Text + "\nTarih: " + DateTime.Now.ToString() + "\nEmanet Silindi.\n");
                                MessageBox.Show("Emanet Başarıyla Silindi.", "Uyarı!"); 
                            }
                            else
                            {
                                MessageBox.Show("Böyle bir kayıt yoktur.", "Uyarı!");
                            }
                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Emanet ID Giriniz Veya Listeden Seçiniz!", "Uyarı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridViewEMANET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            
            try
            {

                    if(txtEmanetID.Text != "")
                            {
                            int id = Convert.ToInt16(txtEmanetID.Text);
                            var sonuc = db.tbl_Emanetlerrr.Where(x => x.EmanetID == id).ToList();
                            if (sonuc.Count != 0)
                                    {
                                            dataGridViewEMANET.DataSource = sonuc.ToList();
                                            MessageBox.Show("Emanet Başarılı Bir Şekilde Bulundu.", "Uyarı!");
                                    }
                            else
                                    {
                                            MessageBox.Show("Bu ID'e Göre Bir Emanet Yoktur.", "Uyarı!");
                                    }
                            }
                    else
                            {
                                    MessageBox.Show("Lütfen Bir ID Giriniz.", "Uyarı!");
                            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lblEmanetID_Click(object sender, EventArgs e)
        {

        }

        private void lblKitapAdı_Click(object sender, EventArgs e)
        {

        }

        private void txtEmanetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKitapAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void txtÜyeSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtÜyeÜyeAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioÜye_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioKitapTablosu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioEmanetListesi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTabloFont_Click(object sender, EventArgs e)
        {

        }

        private void Emanetİşlemleri_Resize(object sender, EventArgs e)
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

        private void txtEmanetID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtÜyeÜyeAd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewKİTAPLAR_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string ad = Convert.ToString(dataGridViewKİTAPLAR.Rows[dataGridViewKİTAPLAR.CurrentRow.Index].Cells[1].Value);
                txtKitapAdı.Text = ad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridViewÜYELER_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string tc = (string)dataGridViewÜYELER.CurrentRow.Cells[0].Value;
                txtÜyeTC.Text = tc.ToString();
                string ad = Convert.ToString(dataGridViewÜYELER.Rows[dataGridViewÜYELER.CurrentRow.Index].Cells[1].Value);
                txtÜyeÜyeAd.Text = ad.ToString();
                string soyad = Convert.ToString(dataGridViewÜYELER.Rows[dataGridViewÜYELER.CurrentRow.Index].Cells[2].Value);
                txtÜyeSoyad.Text = soyad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridViewEMANET_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewEMANET.CurrentRow.Cells[0].Value);
                txtEmanetID.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
