using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriGetir
{
    public static class Sayi
    {
        static Random rnd = new Random();

        public static int Sayilar()
        {
            return rnd.Next();
        }
        public static int Sayilar(int min, int max)
        {
            return rnd.Next(min,max);
        }

        public static double SayilarDouble()
        {
            return rnd.NextDouble();
        }
    }
}
