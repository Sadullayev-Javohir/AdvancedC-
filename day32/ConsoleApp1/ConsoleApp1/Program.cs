class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal sound");
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof");
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        // a.Speak();
        // Console.WriteLine(a.GetType());
        // Console.WriteLine(a is Animal);
        Dog d = a as Dog;
        Console.WriteLine(d);
    }
}