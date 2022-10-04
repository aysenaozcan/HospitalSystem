using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class dalrandevu
    {
        public static List<tbl_randevu> Randevulistesi()
        {
            List<tbl_randevu> deger = new List<tbl_randevu>();
            SqlCommand komut1 = new SqlCommand("select * from tbl_randevu", dalbaglanti.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                tbl_randevu r = new tbl_randevu();
                r.randevuid = int.Parse(dr["randevuid"].ToString());
                r.randevuadsoyad = dr["randevuadsoyad"].ToString();
                r.randevutcno = dr["randevutcno"].ToString();
                r.randevutel = dr["randevutel"].ToString();
                r.randevutarihsaat = DateTime.Parse(dr["randevutarihsaat"].ToString());
                r.randevudoktorid = int.Parse(dr["randevudoktorid"].ToString());
                r.randevubolumid = int.Parse(dr["randevubolumid"].ToString());
                deger.Add(r);
            }
            dr.Close();
            return deger;
        }


        public static int Randevuekle(tbl_randevu n)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_randevu (randevuadsoyad,randevutcno,randevutel,randevutarihsaat,randevudoktorid,randevubolumid) values (@p1,@p2,@p3,@p4,@p5,@p6)", dalbaglanti.baglanti);
            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", n.randevuadsoyad);
            komut2.Parameters.AddWithValue("@p2", n.randevutcno);
            komut2.Parameters.AddWithValue("@p3", n.randevutel);
            komut2.Parameters.AddWithValue("@p4", n.randevutarihsaat);
            komut2.Parameters.AddWithValue("@p5", n.randevudoktorid);
            komut2.Parameters.AddWithValue("@p6", n.randevubolumid);
            return komut2.ExecuteNonQuery();

        }

        public static bool Randevusil(int p)
        {
            tbl_randevu sil = new tbl_randevu();
            SqlCommand komut3 = new SqlCommand("delete from tbl_randevu where randevuid = @p1", dalbaglanti.baglanti);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;


        }

        public static bool Randevuguncelle(tbl_randevu n)
        {
            SqlCommand komut4 = new SqlCommand("update tbl_randevu set randevuadsoyad = @p1, randevutcno = @p2, randevutel = @p3, randevutarihsaat = @p4, randevudoktorid = @p5, randevubolumid = @p6 where randevuid = @p7", dalbaglanti.baglanti);
            if (komut4.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", n.randevuadsoyad);
            komut4.Parameters.AddWithValue("@p2", n.randevutcno);
            komut4.Parameters.AddWithValue("@p3", n.randevutel);
            komut4.Parameters.AddWithValue("@p4", n.randevutarihsaat);
            komut4.Parameters.AddWithValue("@p5", n.randevudoktorid);
            komut4.Parameters.AddWithValue("@p6", n.randevubolumid);
            komut4.Parameters.AddWithValue("@p7", n.randevuid);

            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
