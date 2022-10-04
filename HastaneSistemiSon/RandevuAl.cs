using DataAccessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneSistemiSon
{
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_randevu ra = new tbl_randevu();
            ra.randevuadsoyad = textBox1.Text;
            ra.randevutcno = textBox2.Text;
            ra.randevutel = textBox4.Text;
            ra.randevutarihsaat = Convert.ToDateTime(textBox3.Text);
            ra.randevudoktorid = Convert.ToInt32(textBox5.Text);
            ra.randevubolumid = Convert.ToInt32(textBox6.Text);
            dalrandevu.Randevuekle(ra);
            MessageBox.Show("Randevunuz Oluşturulmuştur");
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {

        }
    }
}
