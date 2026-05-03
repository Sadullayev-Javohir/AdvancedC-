class Program
{
    static void Print(int value) => Console.WriteLine(value);
    static T Echo<T>(T value) => value;

    static void Print<T1, T2>(T1 x, T2 y)
    {
        Console.WriteLine(y);
        Console.WriteLine(x);
    }
    static void Main()
    {
        Print(4);
        Print<string>("Hello");
        Print<string, int>("Somehow", 2);
    }

    static void Print<T>(T value)
    {
        Console.WriteLine(value);
    }
}