using System.Collections;

namespace StaticMembersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo();

            for (int i = 0; i < 10; i++)
            {
                var s = new Sinif();
            }

            Console.WriteLine("Bitti");
            Console.ReadLine();
        }

        private static void Demo()
        {
            //Math math = new Math();
            var sonuc = Math.Sqrt(144);
            //var matematik = new Matematik();

            var pi = Matematik.PiSayisi;
            var fakt = Matematik.FaktoriyelHesapla(5);
            var ort = Matematik.OrtalamaAl(5, 8, 6);
        }
    }
}