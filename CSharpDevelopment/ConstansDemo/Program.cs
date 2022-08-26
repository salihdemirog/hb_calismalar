namespace ConstansDemo;

internal class Program
{
    static void Main(string[] args)
    {
        var matematik = new Matematik();
        //matematik.UgurluSayi = 6;
        //Matematik.PI_SAYISI = 6;

        Console.WriteLine(matematik.UgurluSayi);
        Console.WriteLine(Matematik.PI_SAYISI);
    }
}