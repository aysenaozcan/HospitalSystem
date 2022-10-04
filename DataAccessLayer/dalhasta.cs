using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class dalhasta
    {
        public static List<tbl_hasta> Hastalistesi()
        {
            List<tbl_hasta> deger = new List<tbl_hasta>();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_hasta ", dalbaglanti.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                tbl_hasta r = new tbl_hasta();
                r.hastaid = int.Parse(dr["hastaid"].ToString());
                r.hastaadsoyad = dr["hastaadsoyad"].ToString();
                deger.Add(r);
            }
            dr.Close();
            return deger;
        }

        public static int Hastaekle(tbl_hasta n)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_hasta (hastaadsoyad) values (@p1)", dalbaglanti.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", n.hastaadsoyad);
            return komut2.ExecuteNonQuery();


        }

        public static bool Hastasil(int p)
        {
            tbl_hasta sil = new tbl_hasta();
            SqlCommand komut3 = new SqlCommand("delete from tbl_hasta where hastaid=@p1", dalbaglanti.baglanti);
            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;

        }

        public static bool hastaguncelle(tbl_hasta n)
        {
            SqlCommand komut4 = new SqlCommand("update tbl_hasta set hastaadsoyad=@p1 where hastaid = @p2", dalbaglanti.baglanti);
            if (komut4.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", n.hastaadsoyad);
            komut4.Parameters.AddWithValue("@p2", n.hastaid);

            return komut4.ExecuteNonQuery() > 0;

        }
    }
}

