using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriGetir
{
    public static class Tarih
    {
        static Random rnd = new Random();
        //burdaki metodda olur fakat aşağıdaki metodda ay ve günüde random olarak atar
        public static string TarihAzalt(int min, int max)
        {
            string ay = DateTime.Now.Month.ToString();
            string gun = DateTime.Now.Day.ToString();
            string yil = rnd.Next(DateTime.Now.Year - max, DateTime.Now.Year - min).ToString();
            return ay + "/" + gun + "/" + yil;
        }
        public static string UretimTarihi()
        {
            return DateTime.Now.ToShortDateString();
        }

        public static string TarihArttır(int min, int max)
        {
            string ay = DateTime.Now.Month.ToString();
            string gun = DateTime.Now.Day.ToString();
            string yil = rnd.Next(DateTime.Now.Year + min, DateTime.Now.Year + max).ToString();
            return ay + "/" + gun + "/" + yil;
        }
        public static DateTime GeriTarih(int sayi)
        {
            //Bu Yöntem ilede olur
            //DateTime Tarih = DateTime.Now.AddYears(sayi * -1);
            //int Ay = Tarih.Month * 30;
            //return Tarih = Tarih.AddDays(rnd.Next(1,365-Ay));

            int Yil = DateTime.Now.Year - sayi;
            int Ay = rnd.Next(1, 13);
            int MaxGun = DateTime.DaysInMonth(Yil, Ay);//Hangi ay ise o aya göre maksimum olan günü bulur
            int Gun = rnd.Next(1, MaxGun + 1);
            return Convert.ToDateTime(Gun + "/" + Ay + "/" + Yil);
        }

        public static DateTime iLeriTarih(int sayi)
        {
            int Yil = DateTime.Now.Year + sayi;
            int Ay = rnd.Next(1, 13);
            int MaxGun = DateTime.DaysInMonth(Yil, Ay);//Hangi ay ise o aya göre maksimum olan günü bulur
            int Gun = rnd.Next(1, MaxGun + 1);
            return Convert.ToDateTime(Gun + "/" + Ay + "/" + Yil);
        }

    }
}
