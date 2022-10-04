using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class dalbaglanti
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=hastanesistemi;Integrated Security=True"); 
    }
}
