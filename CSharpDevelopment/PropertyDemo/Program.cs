namespace PropertyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            var sahis = new Sahis();
            sahis.AdSoyad = "Salih Demiroğ";
            sahis.DogumTarihi = new DateTime(1986, 11, 10);
            //sahis.Yas = 18;

            Console.WriteLine($"Ad Soyad: {sahis.AdSoyad}");
            Console.WriteLine($"D. Tarihi: {sahis.DogumTarihi}");
            Console.WriteLine($"Yaş: {sahis.Yas}");

            Console.ReadLine();
        }

        private static void Demo1()
        {
            var kisi = new Kisi();
            //kisi.AdSoyad = "Salih Demiroğ";
            //kisi.DogumTarihi = new DateTime(1986, 11, 10);
            //kisi.Yas = 150;
            kisi.Set_AdSoyad("Salih Demiroğ");
            kisi.Set_DogumTarihi(new DateTime(1986, 11, 10));
            //kisi.Set_Yas(15);

            //Console.WriteLine($"Ad Soyad: {kisi.AdSoyad}");
            //Console.WriteLine($"D. Tarihi: {kisi.DogumTarihi}");
            //Console.WriteLine($"Yaş: {kisi.Yas}");

            Console.WriteLine($"Ad Soyad: {kisi.Get_AdSoyad()}");
            Console.WriteLine($"D. Tarihi: {kisi.Get_DogumTarihi()}");
            Console.WriteLine($"Yaş: {kisi.Get_Yas()}");
        }
    }
}