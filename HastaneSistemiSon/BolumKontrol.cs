using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HastaneSistemiSon
{
    public partial class BolumKontrol : Form
    {
        public BolumKontrol()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_bolum> bollist = logicbolum.Bolumlistesi();
            dataGridView1.DataSource = bollist;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            tbl_bolum sil = new tbl_bolum();
            sil.bolumid = Convert.ToInt32(txtid.Text);
            logicbolum.Bolumsil(sil.bolumid);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_bolum ekle = new tbl_bolum();
            ekle.bolumad = txtsehir.Text;
            logicbolum.Bolumekle(ekle);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_bolum guncelle = new tbl_bolum();
            guncelle.bolumid = int.Parse(txtid.Text);
            guncelle.bolumad = txtsehir.Text;

            logicbolum.Bolumguncelle(guncelle);

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

        private void BolumKontrol_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
