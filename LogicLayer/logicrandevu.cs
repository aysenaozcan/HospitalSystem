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
    public class logicrandevu
    {
        public static List<tbl_randevu> Randevulistesi()
        {
            return dalrandevu.Randevulistesi();
        }

        public static int Randevuekle(tbl_randevu n)
        {
            return dalrandevu.Randevuekle(n);


        }

        public static bool Randevusil(int p)
        {
            return dalrandevu.Randevusil(p);

        }

        public static bool Randevuguncelle(tbl_randevu n)
        {
            return dalrandevu.Randevuguncelle(n);

        }
    }
}
