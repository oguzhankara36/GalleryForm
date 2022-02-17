using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GALERİ
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void subeler_Click(object sender, EventArgs e)
        {
            Form2 sube = new Form2();
            sube.Show();
            this.Hide();
        }

        private void musteriler_Click(object sender, EventArgs e)
        {
            Form1 musteriler = new Form1();
            musteriler.Show();
            this.Hide();
        }

        private void araclar_Click(object sender, EventArgs e)
        {
            Form3 araclar = new Form3();
            araclar.Show();
            this.Hide();
        }
    }
}
