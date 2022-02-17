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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        galeriEntities galeri = new galeriEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.subelers.ToList();
        }
        public void goruntule()
        {
            dataGridView1.DataSource = galeri.subelers.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            subeler ekle = new subeler();
            ekle.subeadi = txtsubead.Text;
            ekle.subeciro = decimal.Parse(txtciro.Text);
            ekle.calisansayisi = int.Parse(txtcalisansayisi.Text);
            ekle.musterino = int.Parse(txtmusterino.Text);
            galeri.subelers.Add(ekle);
            galeri.SaveChanges();
            goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtsubead.Tag);
            subeler sil = galeri.subelers.Single(x => x.subeno == no);
            galeri.subelers.Remove(sil);
            galeri.SaveChanges();
            goruntule();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtsubead.Tag);
            subeler guncelle = galeri.subelers.SingleOrDefault(x => x.subeno == no);
            guncelle.subeadi = txtsubead.Text;
            guncelle.musterino = int.Parse(txtmusterino.Text);
            guncelle.subeciro = decimal.Parse(txtciro.Text);
            guncelle.calisansayisi = int.Parse(txtcalisansayisi.Text);
            galeri.SaveChanges();
            goruntule();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtsubead.Text = satir.Cells["subeadi"].Value.ToString();
            txtsubead.Tag = satir.Cells["subeno"].Value.ToString();
            txtmusterino.Text = satir.Cells["musterino"].Value.ToString();
            txtciro.Text = satir.Cells["subeciro"].Value.ToString();
            txtcalisansayisi.Text = satir.Cells["calisansayisi"].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtmusterino.DataSource = galeri.musterilers.ToList();
            txtmusterino.ValueMember = "musterino";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.subelers.Where(a => a.subeadi.ToLower().Contains(txtsubead.Text) || a.subeadi.ToUpper().Contains(txtsubead.Text)).ToList();
        }
    }
}
