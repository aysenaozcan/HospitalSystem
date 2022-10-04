using Entity;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemiSon
{
    public partial class HastaKontrol : Form
    {
        public HastaKontrol()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_hasta> bollist = logichasta.Hastalistesi();
            dataGridView1.DataSource = bollist;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            tbl_hasta ent = new tbl_hasta();
            ent.hastaid = Convert.ToInt32(txtid.Text);
            logichasta.Hastasil(ent.hastaid);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_hasta ent = new tbl_hasta();
            ent.hastaadsoyad = txtsehir.Text;
            logichasta.Hastaekle(ent);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_hasta ent = new tbl_hasta();
             ent.hastaid = Convert.ToInt32(txtid.Text);
            ent.hastaadsoyad = txtsehir.Text;

            logichasta.Hastaguncelle(ent);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiEkrani x = new YoneticiEkrani();
            x.Show();
            this.Hide();
        }

        private void txtsehir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            YoneticiEkrani fr = new YoneticiEkrani();
            fr.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
