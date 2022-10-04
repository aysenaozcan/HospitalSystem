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
    public partial class DoktorKontrol : Form
    {
        public DoktorKontrol()
        {
            InitializeComponent();
        }

        private void DoktorKontrol_Load(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_doktor> bollist = logicdoktor.Doktorlistesi();
            dataGridView1.DataSource = bollist;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_doktor ent = new tbl_doktor();
            ent.doktorid = Convert.ToInt32(txtid.Text);
            ent.doktoradisoyadi = txtsehir.Text;

            logicdoktor.Doktorguncelle(ent);

        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            tbl_doktor ent = new tbl_doktor();
            ent.doktoradisoyadi = txtsehir.Text;
            logicdoktor.doktorekle(ent);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            tbl_doktor ent = new tbl_doktor();
            ent.doktorid = Convert.ToInt32(txtid.Text);
            logicdoktor.Doktorsil(ent.doktorid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiEkrani x = new YoneticiEkrani();
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YoneticiEkrani fr = new YoneticiEkrani();
            fr.Show();
            this.Hide();
        }
    }
}
