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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        galeriEntities galeri = new galeriEntities();
        public void goruntule()
        {
            dataGridView1.DataSource = galeri.araclars.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            araclar ekle = new araclar();
            ekle.aracadet = int.Parse(txtaracadet.Text);
            ekle.aracfiyat = decimal.Parse(txtaracfiyat.Text);
            ekle.aracmarka =txtaracmarka.Text;
            ekle.aracmodel = txtaracmodel.Text;
            ekle.motor = txtmotor.Text;
            ekle.ozellik = txtozellik.Text;
            ekle.paket = txtpaket.Text;
            ekle.renk = txtrenk.Text;
            ekle.subeno =int.Parse (txtsubeno.Text);
            ekle.yıl = txtyıl.Text;
            galeri.araclars.Add(ekle);
            galeri.SaveChanges();
            goruntule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtaracadet.Tag);
            araclar sil = galeri.araclars.Single(x => x.aracno == no);
            galeri.araclars.Remove(sil);
            galeri.SaveChanges();
            goruntule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(txtaracadet.Tag);
            araclar guncelle = galeri.araclars.SingleOrDefault(x => x.aracno == no);
            guncelle.aracadet = int.Parse(txtaracadet.Text);
            guncelle.aracfiyat = decimal.Parse(txtaracfiyat.Text);
            guncelle.aracmarka = txtaracmarka.Text;
            guncelle.aracmodel = txtaracmodel.Text;
            guncelle.motor = txtmotor.Text;
            guncelle.ozellik = txtozellik.Text;
            guncelle.paket = txtpaket.Text;
            guncelle.renk = txtrenk.Text;
            guncelle.subeno = int.Parse(txtsubeno.Text);
            guncelle.yıl = txtyıl.Text;
            galeri.SaveChanges();
            goruntule();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtaracadet.Text = satir.Cells["aracadet"].Value.ToString();
            txtaracadet.Tag = satir.Cells["aracno"].Value.ToString();
            txtaracfiyat.Text = satir.Cells["aracfiyat"].Value.ToString();
            txtaracmarka.Text = satir.Cells["aracmarka"].Value.ToString();
            txtaracmodel.Text = satir.Cells["aracmodel"].Value.ToString();
            txtyıl.Text = satir.Cells["yıl"].Value.ToString();
            txtozellik.Text = satir.Cells["ozellik"].Value.ToString();
            txtmotor.Text = satir.Cells["motor"].Value.ToString();
            txtpaket.Text = satir.Cells["paket"].Value.ToString();
            txtrenk.Text = satir.Cells["renk"].Value.ToString();
            txtaracmodel.Text = satir.Cells["aracmodel"].Value.ToString();
            txtsubeno.Text = satir.Cells["subeno"].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtsubeno.DataSource = galeri.subelers.ToList();
            txtsubeno.ValueMember = "subeno";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.araclars.Where(a => a.aracmarka.ToLower().Contains(txtaracmarka.Text) || a.aracmarka.ToUpper().Contains(txtaracmarka.Text)).ToList();
        }
    }
}
