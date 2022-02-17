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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        galeriEntities galeri = new galeriEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.musterilers.ToList();
        }
        public void goruntule()
        {
            dataGridView1.DataSource = galeri.musterilers.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            musteriler ekle = new musteriler();
            ekle.adsoyad = txtadsoyad.Text;
            ekle.yas = int.Parse(txtyas.Text);
            ekle.musteribakiye = decimal.Parse(txtbakiye.Text);
            galeri.musterilers.Add(ekle);
            galeri.SaveChanges();
            goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtadsoyad.Tag);
            musteriler sil = galeri.musterilers.Single(x => x.musterino == no);
            galeri.musterilers.Remove(sil);
            galeri.SaveChanges();
            goruntule();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtadsoyad.Text = satir.Cells["adsoyad"].Value.ToString();
            txtadsoyad.Tag = satir.Cells["musterino"].Value.ToString();
            txtyas.Text = satir.Cells["yas"].Value.ToString();
            txtbakiye.Text = satir.Cells["musteribakiye"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtadsoyad.Tag);
            musteriler guncelle = galeri.musterilers.SingleOrDefault(x => x.musterino == no);
            guncelle.adsoyad = txtadsoyad.Text;
            guncelle.yas = int.Parse(txtyas.Text);
            guncelle.musteribakiye = decimal.Parse(txtbakiye.Text);
            galeri.SaveChanges();
            goruntule();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.musterilers.Where(a => a.adsoyad.ToLower().Contains(txtadsoyad.Text) || a.adsoyad.ToUpper().Contains(txtadsoyad.Text)).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
