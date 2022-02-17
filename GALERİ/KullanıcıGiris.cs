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
    public partial class KullanıcıGiris : Form
    {
        public KullanıcıGiris()
        {
            InitializeComponent();
        }

        private bool girisyap(string ad,string sifre)
        {
            galeriEntities baglanti = new galeriEntities();
            var sorgu = from p in baglanti.kullanıcılar where p.kullanıcıadı == ad && p.sifre == sifre select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (girisyap(textBox1.Text,textBox2.Text))
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }
    }
}
