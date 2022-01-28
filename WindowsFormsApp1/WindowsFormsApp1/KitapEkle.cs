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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        ProjeEntities2 db = new ProjeEntities2();
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            try
            {
            datagridKitaplar.DataSource = db.tbl_Kitap.ToList();
            datagridKitaplar.Columns[7].Visible = false;
            datagridKitaplar.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtKitapAdi.Text != "" && txtKitapSayfaSayisi.Text != "" && txtKitapYayinevi.Text != "" && txtKitapYazari.Text !=  "" && comboboxKitapKategoriEkle.Text != "")
                {
                tbl_Kitap tbl = new tbl_Kitap(); 
                tbl.KitapAdı = txtKitapAdi.Text;
                tbl.KitapYazarı = txtKitapYazari.Text;
                tbl.KitapYayınevi = txtKitapYayinevi.Text;
                tbl.KitapSayfaSayısı = Convert.ToInt32(txtKitapSayfaSayisi.Text);
                tbl.KitapKategori = comboboxKitapKategoriEkle.Text;
                db.tbl_Kitap.Add(tbl);
                db.SaveChanges();
                
                File.AppendAllText("Kitap Log.txt", "\n(KİTAP EKLENDİ) \nEklenen Kitap: " + txtKitapAdi.Text + "\nTarih: " + DateTime.Now.ToString() + "\nKitap Eklendi.\n");
                btnListele.PerformClick();
                txtKitapAdi.Text = String.Empty;
                txtKitapYazari.Text = String.Empty;
                txtKitapYayinevi.Text = String.Empty;
                txtKitapSayfaSayisi.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Lütfen Kitap Eklemek İçin Kitap Özelliklerini Giriniz!", "Uyarı!");
                }
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
                datagridKitaplar.DataSource = db.tbl_Kitap.ToList();
                MessageBox.Show("Kitaplar Listelendi.", "Uyarı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtkitapIDSil.Text != "")
                {
                    int kod = Convert.ToInt32(txtkitapIDSil.Text);
                    var sonuc = db.tbl_Kitap.Where(x => x.KitapID == kod).FirstOrDefault();
                    if (sonuc != null)
                    {
                        DialogResult silinsinMi = MessageBox.Show("Kitabı Silmek İstediğinize Emin misiniz?\nGeri Dönüşü Yok.",
                            "Silme İşlemi", MessageBoxButtons.YesNo);
                        if (silinsinMi != DialogResult.No)
                        {
                            db.tbl_Kitap.Remove(sonuc);
                            db.SaveChanges();
                            datagridKitaplar.DataSource = db.tbl_Kitap.ToList();
                            MessageBox.Show("Kitap Başarıyla Silindi.", "Uyarı!");
                            File.AppendAllText("Kitap Log.txt", "\n(KİTAP SİLİNDİ) \nSilinen Kitap ID: " + txtkitapIDSil.Text + "\nTarih: " + DateTime.Now.ToString() + "\nKitap Silindi.\n");
                        }
                        else
                        {
                            MessageBox.Show("Silme İşlemi İptal Edildi.", "Silme İşlemi");
                            datagridKitaplar.DataSource = db.tbl_Kitap.ToList();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kitap yoktur.", "Uyarı!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Kitap ID Gİriniz.", "Uyarı!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtKitapAdiGuncelle.Text != "" && txtKitapIDGuncelle.Text != "" && txtKitapSayfaGuncelle.Text != "" && txtKitapYayineviGuncelle.Text != "" && txtKitapYazariGuncelle.Text != "" && comboboxKitapKategoriGüncelle.Text != "")
                {
                                int kod = Convert.ToInt32(txtKitapIDGuncelle.Text);
                                var sonuc = db.tbl_Kitap.Where(x => x.KitapID == kod).FirstOrDefault();
                                if (sonuc != null)
                                {
                                    
                                    sonuc.KitapAdı = txtKitapAdiGuncelle.Text;
                                    sonuc.KitapYazarı = txtKitapYazariGuncelle.Text;
                                    sonuc.KitapYayınevi = txtKitapYayineviGuncelle.Text;
                                    sonuc.KitapSayfaSayısı = Convert.ToInt32(txtKitapSayfaGuncelle.Text);
                                    sonuc.KitapKategori = comboboxKitapKategoriGüncelle.Text;
                                    db.SaveChanges();
                                    datagridKitaplar.DataSource = db.tbl_Kitap.ToList();

                                    File.AppendAllText("Kitap Log.txt", "\n(KİTAP GÜNCELLENDİ) \nGüncellenen Kitap: " 
                                        + txtKitapAdiGuncelle.Text + "\nKitap Yazarı: " + txtKitapYazariGuncelle.Text 
                                        + "\nKitap Yayınevi: " + txtKitapYayineviGuncelle.Text + "\nKitap Sayfa Sayısı: " 
                                        + txtKitapSayfaGuncelle.Text + "\nKitap Kategori: " + comboboxKitapKategoriGüncelle.Text 
                                        + "\nTarih:" + DateTime.Now.ToString() + "\nKitap Güncellendi.\n");

                                   MessageBox.Show("Güncelleme Başarılı.\n" + txtKitapIDGuncelle.Text
                                            + " ID'sine Ait Kitabın Güncel Bilgileri:\n" + "Kitap Adı: " + sonuc.KitapAdı +
                                            "\nKitap Yazarı: " + sonuc.KitapYazarı + "\nKitap Yayınevi: " + sonuc.KitapYayınevi +
                                            "\nKitap Sayfa Sayısı: " + sonuc.KitapSayfaSayısı + "\nKitap Kategori: " + sonuc.KitapKategori , "Güncelleme Notu");
                                    
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Böyle bir kayıt yoktur.","Uyarı!");
                                }
                }
                else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kitabı Aşağıdaki Tablodan Seçiniz.", "Uyarı!");
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void datagridKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (radioKitapID.Checked)
                            {
                                if(txtKitapArama.Text != "")
                                {
                                int id = Convert.ToInt16(txtKitapArama.Text);
                                var sonuc = db.tbl_Kitap.Where(x => x.KitapID == id).ToList();
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Aradığınız ID'e Ait Kitap Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Aradığınız ID'e Ait Kitap Bulunamadı.", "Uyarı!");
                                        }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen Aramak İstediğiniz Kitap ID Giriniz.", "Uyarı!");
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
                                            MessageBox.Show("Aradığınız İsme Ait Kitap Bulundu.", "Uyarı!");
                                        }   
                                        else
                                        {
                                            datagridKitaplar.DataSource = null;
                                            MessageBox.Show("Aradığınız İsimde Kitap Bulunamadı.", "Uyarı!");
                        }
                                }
                                else
                                {
                                        MessageBox.Show("Lütfen Aramak İstediğiniz Kitap Adını Giriniz.", "Uyarı!");
                                }
                            }
                if (radioKitapYazari.Checked)
                            {
                                
                                if(txtKitapArama.Text != "")
                                {
                                var sonuc = db.tbl_Kitap.Where(x => x.KitapYazarı.Contains(txtKitapArama.Text)).ToList();
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Aradığınız Yazara Ait Kitap Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            datagridKitaplar.DataSource = null;
                                            MessageBox.Show("Aradığınız Yazara Ait Kitap Bulunamadı.", "Uyarı!");
                                        }
                                }
                                else
                                {
                             MessageBox.Show("Lütfen Aramak İstediğiniz Kitap Yazarını Giriniz.", "Uyarı!");
                                }

                            }
                if (radioKitapYayinevi.Checked)
                            {
                                if(txtKitapArama.Text != "")
                                {
                                        var sonuc = db.tbl_Kitap.Where(x => x.KitapYayınevi.Contains(txtKitapArama.Text)).ToList();
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Aradığınız Yayınevine Ait Kitap Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            datagridKitaplar.DataSource = null;
                                            MessageBox.Show("Aradığınız Yayınevine Ait Kitap Bulunamadı.", "Uyarı!");
                                        }
                                }
                                else
                                {
                                    MessageBox.Show("Lütfen Aramak İstediğiniz Kitap Yayınevini Giriniz.", "Uyarı!");
                                 }
                            }
                if (radioKitapKategori.Checked)
                            {
                                if(txtKitapArama.Text != "")
                                {
                                var sonuc = db.tbl_Kitap.Where(x => x.KitapKategori.Contains(txtKitapArama.Text)).ToList();
                                        if (sonuc.Count != 0)
                                        {
                                            datagridKitaplar.DataSource = sonuc;
                                            MessageBox.Show("Aradığınız Kategoriye Ait Kitap Bulundu.", "Uyarı!");
                                        }
                                        else
                                        {
                                            datagridKitaplar.DataSource = null;
                                            MessageBox.Show("Aradığınız Kategoriye Ait Kitap Bulunamadı.", "Uyarı!");
                                        }
                                }
                                else
                                {
                                MessageBox.Show("Lütfen Aramak İstediğiniz Kitap Kategorisini Giriniz.", "Uyarı!");
                                }
                            }
                if(radioKitapAdi.Checked != true && radioKitapID.Checked != true && radioKitapKategori.Checked!= true && radioKitapYayinevi.Checked != true && radioKitapYazari.Checked != true)
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

        private void btnPersonelMenüsüneDön_Click(object sender, EventArgs e)
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

        private void txtkitapIDSil_TextChanged(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Resize(object sender, EventArgs e)
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

        private void txtKitapSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKitapIDGuncelle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKitapSayfaGuncelle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtkitapIDSil_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKitapYazari_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtKitapAdiGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtKitapYazariGuncelle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void grpGuncelle_Enter(object sender, EventArgs e)
        {

        }

        private void datagridKitaplar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(datagridKitaplar.Rows[datagridKitaplar.CurrentRow.Index].Cells[0].Value);
                txtkitapIDSil.Text = id.ToString();
                txtKitapIDGuncelle.Text = id.ToString();
                string ad = Convert.ToString(datagridKitaplar.Rows[datagridKitaplar.CurrentRow.Index].Cells[1].Value);
                txtKitapAdi.Text = ad.ToString();
                txtKitapAdiGuncelle.Text = ad.ToString();
                string yazar = Convert.ToString(datagridKitaplar.Rows[datagridKitaplar.CurrentRow.Index].Cells[2].Value);
                txtKitapYazari.Text = yazar.ToString();
                txtKitapYazariGuncelle.Text = yazar.ToString();
                string yayınevi = Convert.ToString(datagridKitaplar.Rows[datagridKitaplar.CurrentRow.Index].Cells[3].Value);
                txtKitapYayinevi.Text = yayınevi.ToString();
                txtKitapYayineviGuncelle.Text = yayınevi.ToString();
                string sayfasayisi = Convert.ToString(datagridKitaplar.Rows[datagridKitaplar.CurrentRow.Index].Cells[4].Value);
                txtKitapSayfaSayisi.Text = sayfasayisi.ToString();
                txtKitapSayfaGuncelle.Text = sayfasayisi.ToString();
                string kategori = Convert.ToString(datagridKitaplar.Rows[datagridKitaplar.CurrentRow.Index].Cells[5].Value);
                comboboxKitapKategoriEkle.Text = kategori.ToString();
                comboboxKitapKategoriGüncelle.Text = kategori.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if(txtKitapAdi.Text != "" || txtKitapAdiGuncelle.Text != "" || txtKitapArama.Text != ""
                || txtKitapIDGuncelle.Text != "" || txtkitapIDSil.Text != "" || txtKitapSayfaGuncelle.Text != ""
                || txtKitapSayfaSayisi.Text != "" || txtKitapYayinevi.Text != "" || txtKitapYayineviGuncelle.Text != ""
                || txtKitapYazari.Text != "" || txtKitapYazariGuncelle.Text != "")
            {
            txtKitapAdi.Text = String.Empty;
            txtKitapAdiGuncelle.Text = String.Empty;
            txtKitapArama.Text = String.Empty;
            txtKitapIDGuncelle.Text = String.Empty;
            txtkitapIDSil.Text = String.Empty;
            txtKitapSayfaGuncelle.Text = String.Empty;
            txtKitapSayfaSayisi.Text = String.Empty;
            txtKitapYayinevi.Text = String.Empty;
            txtKitapYazari.Text = String.Empty;
            txtKitapYayineviGuncelle.Text = String.Empty;
            txtKitapYazariGuncelle.Text = String.Empty;
                MessageBox.Show("Bütün Satırlar Temizlendi!", "Uyarı!");
            }
            else
            {
                MessageBox.Show("Bütün Satırlar Zaten Temiz!", "Uyarı!");
            }
        }

        private void btnKitapEkle_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void btnKitapEkle_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void btnGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
      
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void btnAra_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btnAra_MouseLeave(object sender, EventArgs e)
        {
     
        }

        private void btnTemizle_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void btnTemizle_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
