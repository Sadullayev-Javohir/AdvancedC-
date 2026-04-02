class Animal
{
    public virtual void Speak() {}
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Apcherka : Dog
{
    public override void Speak()
    {
        Console.WriteLine("Apcherka barks");
    }
}

class Program
{
    static void Main()
    {
        Animal apcherka = new Dog();
        apcherka.Speak();
    }
}