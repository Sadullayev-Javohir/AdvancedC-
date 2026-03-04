class Program
{
    static void Main()
    {
        CreateObjects();
        GC.Collect();
    }

    static void CreateObjects()
    {
        for (int i = 0; i < 1000; i++)
        {
            Person p = new Person();
        }
    }
}

class Person {}