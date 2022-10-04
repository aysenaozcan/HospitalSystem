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
   public class logicbolum
    {
        public static List<tbl_bolum> Bolumlistesi()
        {
            return dalbolum.Bolumlistesi();
        }
        public static int Bolumekle(tbl_bolum p)
        {
            if (p.bolumad != "")
            {
                return dalbolum.Bolumekle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool Bolumsil(int per)
        {
            if (per >= 1)
            {
                return dalbolum.Bolumsil(per);
            }
            else
            {
                return false;
            }

        }
        public static bool Bolumguncelle(tbl_bolum p)
        {
            return dalbolum.bolumguncelle(p);


        }
    }
}
