using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccessLayer;

namespace LogicLayer
{
    public class logichasta
    {
        public static List<tbl_hasta> Hastalistesi()
        {
            return dalhasta.Hastalistesi();
        }
        public static int Hastaekle(tbl_hasta p)
        {
            if (p.hastaadsoyad != "")
            {
                return dalhasta.Hastaekle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool Hastasil(int per)
        {
            if (per >= 1)
            {
                return dalhasta.Hastasil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool Hastaguncelle(tbl_hasta p)
        {
            if (p.hastaadsoyad != "")
            {
                return dalhasta.hastaguncelle(p);
            }
            else
            {
                return false;
            }


        }

    }
}

