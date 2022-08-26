namespace InheritanceDemo2;

class A
{
    public A()
    {
        Console.WriteLine("A 0 Ctor Çalıştı");
    }

    public A(object obj)
    {
        Console.WriteLine("A 1 Ctor Çalıştı");
    }
}

class B : A
{
    public B() : base()
    {
        Console.WriteLine("B 0 Ctor Çalıştı");
    }

    public B(object obj) : base(obj)
    {
        Console.WriteLine("B 1 Ctor Çalıştı");
    }
}


class C : Object
{
    public C() : base()
    {

    }
}


