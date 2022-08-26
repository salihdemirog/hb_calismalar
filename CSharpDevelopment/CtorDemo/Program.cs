using System.Collections;

namespace CtorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1();

            //var kisi = new Kisi();
            //kisi.AdSoyad = "Salih Demiroğ";
            //kisi.EvliMi = false;
            //kisi.Yas = 40;

            var kisi = new Kisi
            {
                AdSoyad = "Salih Demiroğ",
                Yas = 35,
                EvliMi = true
            };

            Console.WriteLine($"Ad Soyad: {kisi.AdSoyad}");
            Console.WriteLine($"Evli Mi: {kisi.EvliMi}");
            Console.WriteLine($"Yaş: {kisi.Yas}");

            Console.ReadLine();
        }

        private static void Demo1()
        {
            //var list = new ArrayList();
            var kisi = new Kisi("Salih Demiroğ", 35, true);
            kisi.AdSoyad = "Salih Demiroğ";

            Console.WriteLine($"Ad Soyad: {kisi.AdSoyad}");
            Console.WriteLine($"Evli Mi: {kisi.EvliMi}");
            Console.WriteLine($"Yaş: {kisi.Yas}");
        }
    }
}