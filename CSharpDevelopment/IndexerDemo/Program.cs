using System.Collections;

namespace IndexerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun day = new Gun();
            string ilkGun = day[1];

            for (byte i = 1; i <= 7; i++)
            {
                Console.WriteLine(day[i]);
            }

            Console.ReadLine();
        }
    }
}