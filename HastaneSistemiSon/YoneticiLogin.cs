using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneSistemiSon
{
    public partial class YoneticiLogin : Form
    {
        public YoneticiLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =.; Initial Catalog = hastanesistemi; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand login = new SqlCommand("Select * from slogin where tcno=@p1 and sifre=@p2", baglanti);
            login.Parameters.AddWithValue("@p1", textBox1.Text);
            login.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = login.ExecuteReader();

            if (oku.Read())
            {
                YoneticiEkrani fr = new YoneticiEkrani();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı");
            }
            baglanti.Close();
        }

        private void SekreterLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa fr = new Anasayfa();
            fr.Show();
            this.Hide();
        }
    }
}
