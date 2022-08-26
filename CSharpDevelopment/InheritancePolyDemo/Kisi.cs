global using System;
global using System.Collections.Generic; //C# 10
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo; //C# 10

public class Kisi : Object
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yas { get; set; }

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Ad:{Ad}");
        Console.WriteLine($"Soyad:{Soyad}");
        Console.WriteLine($"Yaş:{Yas}");
    }
}