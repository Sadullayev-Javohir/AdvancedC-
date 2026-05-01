public class Box<T> where T : notnull
{
    public T? Value { get; set; }
}

public class Program
{
    static void Main()
    {
        Box<int> e = new();
        
        // Box<int?> a = new();
        // Console.WriteLine(a.Create());
        // int? x = null;
        // Nullable<int> x2 = null;

    }
}