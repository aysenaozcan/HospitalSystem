using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DataAccessLayer
{
    public class dalbolum
    {
        public static List<tbl_bolum> Bolumlistesi()
        {
            List<tbl_bolum> deger = new List<tbl_bolum>();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_bolum ", dalbaglanti.baglanti);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                tbl_bolum r = new tbl_bolum();
                r.bolumid = int.Parse(dr["bolumid"].ToString());
                r.bolumad = dr["bolumad"].ToString();
                deger.Add(r);
            }
            dr.Close();
            return deger;


        }

        public static int Bolumekle(tbl_bolum n)
        {

            SqlCommand komut2 = new SqlCommand("insert into tbl_bolum (bolumad) values (@p1)", dalbaglanti.baglanti);
            if (komut2.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut2.Connection.Open();
            }

            komut2.Parameters.AddWithValue("@p1", n.bolumad);
            return komut2.ExecuteNonQuery();


        }



        public static bool Bolumsil(int p)
        {
            tbl_bolum sil = new tbl_bolum();
            SqlCommand komut3 = new SqlCommand("delete from tbl_bolum where bolumid = @p1", dalbaglanti.baglanti);
            if (komut3.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;



        }

        public static bool bolumguncelle(tbl_bolum n)
        {


            SqlCommand komut4 = new SqlCommand("update tbl_bolum set bolumad = @p1 where bolumid = @p2", dalbaglanti.baglanti);
            if (komut4.Connection.State == System.Data.ConnectionState.Closed)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", n.bolumad);
            komut4.Parameters.AddWithValue("@p2", n.bolumid);

            return komut4.ExecuteNonQuery() > 0;


        }
    }
}
  
