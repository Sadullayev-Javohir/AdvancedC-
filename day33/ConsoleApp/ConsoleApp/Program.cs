class Person
{
    public int Age;
    public bool IsMarried;
    public string Name;

    public Person()
    {
        Console.WriteLine($"Age: {Age}, IsMarried: {IsMarried}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
    }
}