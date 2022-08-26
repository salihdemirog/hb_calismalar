namespace AbstractClassDemo
{
    class RangeRule : RuleBase
    {
        private readonly int min;
        private readonly int max;

        public RangeRule(int min,int max)
        {
            this.min = min;
            this.max = max;
        }

        public override bool Validate(object value)
        {
            int deger = (int)value;

            return deger >= min && deger <= max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var kisi = new Kisi();
            var ogrenci = new Ogrenci
            {
                Ad = "a",
                Soyad = "s",
                OkulAdi = "gazi",
                Yas = 55
            };

            ogrenci.BilgiYazdir();

            Console.WriteLine(ValidateTool.Validate(new RequiredRule(), ogrenci.OkulAdi));
            Console.WriteLine(ValidateTool.Validate(new LengthRule(4), ogrenci.OkulAdi));
            Console.WriteLine(ValidateTool.Validate(new RangeRule(10,50), ogrenci.Yas));

            Console.ReadLine();
           
        }
    }
}