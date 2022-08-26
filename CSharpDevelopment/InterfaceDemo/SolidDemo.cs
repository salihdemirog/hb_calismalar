interface IWorkable
{
    void Work();
}

interface IEatable
{
    void Eat();
}

class Human : IWorkable, IEatable
{
    public void Eat()
    {
        //kod
    }

    public void Work()
    {
     //kod   
    }
}

class Robot : IWorkable
{
    public void Work()
    {
        //kod
    }
}