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
    public partial class KitapSorgulama : Form
    {
        public KitapSorgulama()
        {
            InitializeComponent();
        }

        //KİTAP LİSTELEYECEK FONKSİYON
        void KitaplariListele()
        {
                datagridKitaplar.DataSource = db.tbl_Kitap.ToList();
                datagridKitaplar.Columns[7].Visible = false;
                datagridKitaplar.Columns[6].Visible = false;
                datagridKitaplar.Columns[0].HeaderText = "Kitap ID";
                datagridKitaplar.Columns[1].HeaderText = "Adı";
                datagridKitaplar.Columns[2].HeaderText = "Yazarı";
                datagridKitaplar.Columns[3].HeaderText = "Yayınevi";
                datagridKitaplar.Columns[4].HeaderText = "Sayfa Sayısı";
                datagridKitaplar.Columns[5].HeaderText = "Kategori";
        }


        private void KitapSorgulama_Load(object sender, EventArgs e)
        {
            try
            {
                KitaplariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        ProjeEntities2 db = new ProjeEntities2();

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                KitaplariListele();
                if (radioKitapID.Checked)
                {
                                if(txtKitapArama.Text != "")
                                {
                                int id = Convert.ToInt16(txtKitapArama.Text);
                                var sonuc = db.tbl_Kitap.Where(x => x.KitapID == id).ToList(); //LINQ
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Kitap Başarıyla Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            datagridKitaplar.DataSource = null;
                                            MessageBox.Show("Bu ID'e Ait Bir Kitap Bulunamadı.", "Uyarı!");
                                        }
                                }
                                else
                                {
                                    MessageBox.Show("Aranacak Kitap İçin Bir ID Giriniz.", "Uyarı!");
                                }
                    
                }
                if (radioKitapAdi.Checked)
                {
                                if(txtKitapArama.Text != "")
                                {
                                        var sonuc = db.tbl_Kitap.Where(x => x.KitapAdı.Contains(txtKitapArama.Text)).ToList();
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Kitap Başarıyla Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Bu Ada Ait Bir Kitap Bulunamadı.", "Uyarı");
                                            datagridKitaplar.DataSource = null;
                                        }
                                }
                                else
                                {
                                MessageBox.Show("Aranacak Kitap İçin Bir Ad Giriniz.", "Uyarı!");
                    }
                    
                }
                if (radioKitapYazari.Checked)
                {
                            if (txtKitapArama.Text != "")
                            {
                                        var sonuc = db.tbl_Kitap.Where(x => x.KitapYazarı.Contains(txtKitapArama.Text)).ToList();
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Kitap Başarıyla Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            datagridKitaplar.DataSource = null;
                                            MessageBox.Show("Bu Yazara Ait Bir Kitap Bulunamadı.", "Uyarı!");
                                        }
                            }
                            else
                            {
                                MessageBox.Show("Aranacak Kitap İçin Bir Yazar Giriniz.", "Uyarı!");
                             }
                        
                }
                if (radioKitapYayinevi.Checked)
                {
                    if (txtKitapArama.Text != "")
                    {
                                var sonuc = db.tbl_Kitap.Where(x => x.KitapYayınevi.Contains(txtKitapArama.Text)).ToList();
                                if (sonuc.Count != 0)
                                {
                                    datagridKitaplar.DataSource = sonuc;
                                    MessageBox.Show("Kitap Başarıyla Bulundu.", "Uyarı");                    }
                                else
                                {
                                    datagridKitaplar.DataSource = null;
                                    MessageBox.Show("Bu Yayınevine Ait Bir Kitap Bulunamadı.", "Uyarı!");
                                }
                    }
                    else
                    {
                        MessageBox.Show("Aranacak Kitap İçin Bir Yayınevi Giriniz.", "Uyarı!");
                    }
                }
                if (radioKitapKategori.Checked)
                {
                            if (txtKitapArama.Text != "")
                            {
                                            var sonuc = db.tbl_Kitap.Where(x => x.KitapKategori.Contains(txtKitapArama.Text)).ToList();
                                            if (sonuc.Count != 0)
                                            {
                                                datagridKitaplar.DataSource = sonuc;
                                                MessageBox.Show("Kitap Başarıyla Bulundu.", "Uyarı!");
                                            }
                                            else
                                            {
                                                datagridKitaplar.DataSource = null;
                                                MessageBox.Show("Bu Kategoriye Ait Bir Kitap Bulunamadı.", "Uyarı!");
                                            }
                            }
                            else
                            {
                                MessageBox.Show("Aranacak Kitap İçin Bir Kategori Giriniz.", "Uyarı!");
                            }
                }
                if(radioKitapAdi.Checked == false && radioKitapID.Checked == false && radioKitapKategori.Checked == false
                    && radioKitapYayinevi.Checked == false && radioKitapYazari.Checked == false)
                {
                    MessageBox.Show("Aramak İstediğiniz Kitap Özelliğini Seçiniz.", "Uyarı!");
                }
                txtKitapArama.Text = String.Empty;

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

        Bitmap bmp; 

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                int height = datagridKitaplar.Height;
                datagridKitaplar.Height = datagridKitaplar.RowCount * datagridKitaplar.RowTemplate.Height * 2;
                bmp = new Bitmap(datagridKitaplar.Width, datagridKitaplar.Height);
                datagridKitaplar.DrawToBitmap(bmp, new Rectangle(0, 0, datagridKitaplar.Width, datagridKitaplar.Height));
                datagridKitaplar.Height = height;
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

                datagridKitaplar.Font = new Font("Microsoft Sans Serif", trackBarTabloYazıBoyutu.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void KitapSorgulama_Resize(object sender, EventArgs e)
        {
            try
            {
            WindowState = FormWindowState.Maximized; //TAM EKRAN ÖZELLİĞİ
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                KitaplariListele();
                MessageBox.Show("Kitaplar Listelendi.", "Uyarı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radioKitapKategori_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
