namespace InheritanceDemo
{
    internal class Program
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

            //Console.WriteLine(ogrenci is Kisi);
            //Console.WriteLine(ogretmen is Kisi);
            //Console.WriteLine(basariliOgretmen is Kisi);
            //Console.WriteLine(basariliOgretmen is Ogretmen);
            //Console.WriteLine(ogretmen is BasariliOgretmen);
            //Console.WriteLine(ogretmen is object);
            //Console.WriteLine(ogrenci is Object);

            Console.ReadLine();
        }
    }
}