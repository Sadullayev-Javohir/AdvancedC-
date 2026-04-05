abstract class Animal
{
    // public Animal()
    // {
    //     Console.WriteLine("Ctor");
    // }
    // public abstract void Speak();
    public void Sleep() => Console.WriteLine("Sleeping...");
}

// class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Dog Barks");
//     }
// }

class Program
{
    static void Main()
    {
        // Dog d = new Dog();
        // d.Speak();
        // d.Sleep();

        Animal a = new Animal();
    }
}