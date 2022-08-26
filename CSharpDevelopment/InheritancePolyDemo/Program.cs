namespace InheritancePolyDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ogrenci = new Ogrenci
            {
                Ad = "Salih",
                Soyad = "Demiroğ",
                OkulAdi = "Gazi Üni",
                Yas = 35
            };

            var ogretmen = new Ogretmen
            {
                Ad = "Engin",
                Soyad = "Demiroğ",
                Yas = 38,
                Maas = 15000
            };

            var basariliOgretmen = new BasariliOgretmen
            {
                Ad = "Zeynep Liya",
                Soyad = "Demiroğ",
                Yas = 50,
                Maas = 15000,
                Prim = 2500
            };

            var memur = new Memur
            {
                Ad = "Özge",
                Soyad = "Demiroğ",
                Yas = 50,
                Kurum="a"
            };

            ogrenci.BilgiYazdir();
            Console.WriteLine("------------------------------");
            ogretmen.BilgiYazdir();
            Console.WriteLine("------------------------------");
            basariliOgretmen.BilgiYazdir();
            Console.WriteLine("------------------------------");
            memur.BilgiYazdir();

            //MainBilgiYazdir(ogrenci);
            //Console.WriteLine("------------------------------");
            //MainBilgiYazdir(ogretmen);
            //Console.WriteLine("------------------------------");
            //MainBilgiYazdir(basariliOgretmen);
            //Console.WriteLine("------------------------------");
            //MainBilgiYazdir(memur);

            Console.WriteLine(ogretmen.ToString());

            Console.ReadLine();
        }

        public static void MainBilgiYazdir(Kisi kisi)
        {
            kisi.BilgiYazdir();

            if(kisi is Ogrenci)
            {
                var ogrenci = (Ogrenci)kisi;

                Console.WriteLine($"Okul Adı:{ogrenci.OkulAdi}");
            }

            if (kisi is Ogretmen ogretmen) //C# 6.0
                Console.WriteLine($"Maaş:{ogretmen.Maas}");

            var basariliOgretmen = kisi as BasariliOgretmen;
            if(basariliOgretmen is not null)
            {
                Console.WriteLine($"Prim:{basariliOgretmen.Prim}");
            }
        }
    }
}