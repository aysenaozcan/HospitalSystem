using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class daldoktor
    {

        public static List<tbl_doktor> Doktorlistesi()
        {
            List<tbl_doktor> deger = new List<tbl_doktor>();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_doktor ", dalbaglanti.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                tbl_doktor r = new tbl_doktor();
                r.doktorid = int.Parse(dr["doktorid"].ToString());
                r.doktoradisoyadi = dr["doktoradisoyadi"].ToString();
                deger.Add(r);
            }
            dr.Close();
            return deger;
        }

        public static int Doktorekle(tbl_doktor n)
        {


            SqlCommand komut2 = new SqlCommand("insert into tbl_doktor (doktoradisoyadi) values (@p1)", dalbaglanti.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", n.doktoradisoyadi);
            return komut2.ExecuteNonQuery();

        }

        public static bool Doktorsil(int p)
        {
            tbl_doktor sil = new tbl_doktor();
            SqlCommand komut3 = new SqlCommand("delete from tbl_doktor where doktorid=@p1", dalbaglanti.baglanti);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;

        }

        public static bool Doktorguncelle(tbl_doktor n)
        {
            SqlCommand komut4 = new SqlCommand("update tbl_doktor set doktoradisoyadi = @p1 where doktorid = @p2", dalbaglanti.baglanti);
            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", n.doktoradisoyadi);
            komut4.Parameters.AddWithValue("@p2", n.doktorid);

            return komut4.ExecuteNonQuery() > 0;

        }
    }
}

