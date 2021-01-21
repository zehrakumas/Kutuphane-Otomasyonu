using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emanetduzenle formGecis5 = new emanetduzenle();
            formGecis5.Show();
            this.Hide();
        }

        private void kitapduzenle_Click(object sender, EventArgs e)
        {
            kitapduzenle formGecis2 = new kitapduzenle();
            formGecis2.Show();
            this.Hide();
        }

      

        private void uyeduzenle_Click(object sender, EventArgs e)
        {
            uyeduzenle formGecis8 = new uyeduzenle();
            formGecis8.Show();
            this.Hide();
        }

    }
}
