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
    public partial class GorunumAyarlari : Form
    {
        public GorunumAyarlari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Firebrick;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SaddleBrown;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PeachPuff;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FloralWhite;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Khaki;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOliveGreen;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Crimson;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orchid;
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Close();
            Anasayfa frm = new Anasayfa();
            frm.Show();
        }
    }
}
