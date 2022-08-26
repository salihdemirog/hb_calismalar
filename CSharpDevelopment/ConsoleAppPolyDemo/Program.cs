using InheritancePolyDemo;

namespace ConsoleAppPolyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var polis = new Polis()
            {
                Ad = "a",
                Soyad = "b",
                GorevYeri = "c",
                Yas = 35
            };
            polis.BilgiYazdir();

            //InheritancePolyDemo.Program.MainBilgiYazdir(polis);
            Console.ReadLine();

        }
    }
}