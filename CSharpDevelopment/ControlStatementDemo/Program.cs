namespace ControlStatementDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IfDemo();

            //TernaryOperatorDemo();

            //SwitchDemo();

            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"Merhaba Dünya : {i}");

            //for (int i = 10 ; i >= 1; i--)
            //{
            //    Console.WriteLine($"Merhaba Dünya : {i}");
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //        break;

            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //        return;

            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //        Console.WriteLine($"i:{i} , j:{j}");
            //}


            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Bitti");

            Console.ReadLine();
        }

        private static void SwitchDemo()
        {
            Console.Write("Kategori Giriniz:");
            string kategori = Console.ReadLine();


            switch (kategori)
            {
                case "Gida":
                    Console.WriteLine("Kdv % 8");
                    break;
                case "Mobilya":
                    Console.WriteLine("Kdv % 12");
                    break;
                case "Giyim":
                case "Elektronik":
                    Console.WriteLine("Kdv % 20");
                    break;
                default:
                    Console.WriteLine("Kdv % 18");
                    break;
            }
        }

        private static void TernaryOperatorDemo()
        {
            Console.Write("Not Giriniz:");
            var not = int.Parse(Console.ReadLine());

            string durum = not >= 50 ? "İyi" : "Kötü";

            Console.WriteLine(durum);
        }

        private static void IfDemo()
        {
            Console.Write("Not Giriniz:");
            var not = int.Parse(Console.ReadLine());

            if (not > 80)
            {
                //
                Console.WriteLine("Pekiyi");
            }
            else if (not > 60 && not <= 80)
                Console.WriteLine("İyi");
            else if (not > 40 && not <= 60)
                Console.WriteLine("Kötü");
            else
            {
                Console.WriteLine("Çok Kötü");

            }
        }
    }
}