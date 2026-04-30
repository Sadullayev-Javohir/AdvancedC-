// object value = 10;
// int number = (int)value;
// Console.WriteLine(number);

// object value = "Hello";
// int number = (int)value;
// Console.WriteLine(number);

// List<object> items = new List<object>();
//
// items.Add(10);
// items.Add("Hello");
// items.Add(true);
//
// int number = (int)items[1];

// Box<int> box = new Box<int>();
// box.Value = 10;
// Console.WriteLine(box.Value);
//
// public class Box<T>
// {
//     public T Value { get; set; }
// }

public class Repository<T>
{
    public void Add(T entity) {}
}
class User{}
class Product{}


class Program
{
    private Repository<User> users = new Repository<User>();
    private Repository<Product> products = new Repository<Product>();
    
    
    // public static T GetValue<T>(T value) => value;
    //
    // static void Main()
    // {
    //     int x = GetValue(10);
    //     string y = GetValue("Hello");
    // }
}