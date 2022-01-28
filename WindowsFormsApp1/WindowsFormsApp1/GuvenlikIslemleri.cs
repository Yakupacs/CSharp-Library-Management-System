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
    public partial class GuvenlikIslemleri : Form
    {
        public GuvenlikIslemleri()
        {
            InitializeComponent();
        }

        private void btnAnasayfayaDön_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa frm = new Anasayfa();
            frm.Show();
            
        }

        private void Güvenlikİşlemleri_Load(object sender, EventArgs e)
        {
            comboEpostaAdresiniz.Text = "@mail.com";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa frm = new Anasayfa();
            frm.Show();
        }
    }
}
