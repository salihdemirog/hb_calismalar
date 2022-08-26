namespace DelegateDemo
{
    internal class Program
    {
        public delegate void Temsilci();
        public delegate double Temsilci2(int x, int y);
        public delegate long Temsilci3(int x);
        public delegate void Temsilci4(string p);
        static void Main(string[] args)
        {
            var matematik = new Matematik();

            //Demo1(matematik);

            //Demo2(matematik);
            Temsilci3 temsilci3 = Matematik.KareAl;
            temsilci3 += matematik.FaktoriyelHesapla;
            temsilci3 += t => t * t * t;
            //temsilci3 += t =>
            //{

            //    return t * t * t;
            //};

            var sonuc = temsilci3(5);
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }

        private static void Demo2(Matematik matematik)
        {
            Temsilci2 temsilci2 = new Temsilci2(matematik.OrtalamaAl);
            temsilci2 += (a, b) => a * b;

            //double sonuc = temsilci2(10, 5);
            //Console.WriteLine(sonuc);

            foreach (Temsilci2 temsilci in temsilci2.GetInvocationList())
            {
                Console.WriteLine(temsilci.Invoke(10, 5));
            }
        }

        private static void Demo1(Matematik matematik)
        {
            int sayi = 5;

            Temsilci temsilci = matematik.PiSayisiYazdir;
            temsilci += MainBilgiYazdir;
            temsilci += MainBilgiYazdir;
            temsilci += MainBilgiYazdir;
            temsilci += matematik.PiSayisiYazdir;
            temsilci += () => Console.WriteLine("Salih Demiroğ");

            temsilci -= matematik.PiSayisiYazdir;

            //temsilci.Invoke();
            temsilci();
        }

        static void MainBilgiYazdir()
        {
            Console.WriteLine("Main Bilgi");
        }
    }
}