namespace DelegateDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>()
            {
                "Umut","Onur","Ömer",
                "Metin","Ayşe","Elif",
                "Gizem","Leyla","Mustafa",
                "Muhammet"
            };

            //List<string> besKarakterliIsimler = new();
            //foreach (var isim in isimler)
            //{
            //    if (isim.Length == 5)
            //        besKarakterliIsimler.Add(isim);
            //}

            //List<string> besKarakterliIsimler = Filtrele(isimler, isim => isim.Length == 5);
            //List<string> besKarakterliIsimler = isimler.Where(t => t.Length == 5).ToList();
            List<string> besKarakterliIsimler = isimler.Where((isim, i) => isim.Length == i).ToList();
            var enUzunIsim= isimler.Max(isim => isim.Length);

            Console.WriteLine("5 Karakterli İsimler:{0}", string.Join(",", besKarakterliIsimler));

            //List<string> icindeEHarfiGecenIsimler = new();
            //foreach (var isim in isimler)
            //{
            //    if (isim.ToLower().Contains("e"))
            //        icindeEHarfiGecenIsimler.Add(isim);
            //}
            List<string> icindeEHarfiGecenIsimler = Filtrele(isimler, isim => isim.ToLower().Contains("e"));
            Console.WriteLine("İçinde e Harfi Geçen İsimler:{0}", string.Join(",", icindeEHarfiGecenIsimler));

            //List<string> ozelIsimler = new();
            //foreach (var isim in isimler)
            //{
            //    if (isim.ToLower().StartsWith("a") && isim.ToLower().EndsWith("e"))
            //        ozelIsimler.Add(isim);
            //}
            List<string> ozelIsimler = Filtrele(isimler, OzelIsimMi);
            Console.WriteLine("a ile başlayan ve e ile biten isimler:{0}", string.Join(",", ozelIsimler));

            Console.ReadLine();
        }

        static List<string> Filtrele(List<string> liste, Func<string, bool> filtre)
        {
            List<string> filtreliListe = new();
            foreach (var isim in liste)
            {
                bool durum = filtre.Invoke(isim); //OzelIsimMi(isim);
                if (durum)
                    filtreliListe.Add(isim);
            }

            return filtreliListe;
        }

        private static bool OzelIsimMi(string isim)
        {
            return isim.ToLower().StartsWith("a") && isim.ToLower().EndsWith("e");
        }

    }
}