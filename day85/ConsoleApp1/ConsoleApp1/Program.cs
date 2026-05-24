[AttributeUsage(AttributeTargets.Class)]
public class MyInfoAttribute : Attribute
{
    public string Author { get; }
    public MyInfoAttribute(string author) => Author = author;
}

[MyInfo("Javohir")]
class MyClass {}


// using System.Reflection;
//
// [Obsolete("Deprecated")]
// class Test { }
//
// class Program
// {
//     static void Main()
//     {
//         var type = typeof(Test);
//
//         var attributes = type.GetCustomAttributes();
//
//         foreach (var attr in attributes)
//         {
//             Console.WriteLine(attr);
//         }
//     }
// }

// class Program
// {
//     [Obsolete("Bu method eskirgan")]
//     public static void OldMethod() => Console.WriteLine("Salom");
//     static void Main()
//     {
//         OldMethod();
//     }
// }