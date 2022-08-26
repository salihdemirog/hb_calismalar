using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersDemo
{
    internal static class Matematik
    {
        private static int _sayi = 0;

        static Matematik()
        {
            Console.WriteLine("Static ctor çalıştı");
        }

        public static double PiSayisi => 3.1415;

        public static long FaktoriyelHesapla(int sayi)
        {
            var sonuc = 1L;

            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }

        public static double OrtalamaAl(int a, int b, int c) => (a + b + c) / 3d;
    }
}
