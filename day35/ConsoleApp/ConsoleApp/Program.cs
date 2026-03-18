// class A
// {
//     static A() => Console.WriteLine("Static constructor ishladi");
//     public A() => Console.WriteLine("Instance constructor");
// }

// class  A
// {
//     public static int x = Init();
//
//     static int Init()
//     {
//         Console.WriteLine("Field init");
//         return 10;
//     }
//
//     static A() => Console.WriteLine("Static ctor");
// }

// class  A
// {
//     public static int x = Init();
//
//     static int Init()
//     {
//         Console.WriteLine("Field init");
//         return 42;
//     }
// }

// class Config
// {
//     public static string ConnectionString = Load();
//
//     static string Load()
//     {
//         Console.WriteLine("Loading...");
//         return "DB";
//     }
// }

// class  A
// {
//     static A()
//     {
//         throw new Exception("Boom");
//     }
// }
// static class Utils
// {
//     static Utils() => Console.WriteLine("Init");
//     public static int a = 5;
// }
// class A
// {
//     static A() => Console.WriteLine("Static");
//     public static void M() {}
// }

// class A
// {
//     static A() => throw new Exception("Boom");
// }
// static class A
// {
//     static A() => Console.WriteLine("Static cons");
//     public static void SomeMethod() => Console.WriteLine("Another method");
// }
// class Program
// {
//     static void Main()
//     {
//         A.SomeMethod();
//         // Console.WriteLine("hello");
//         // var y = A.x;
//         // var /* = typeof(A);
//         // Console.WriteLine(x);
//         // A a = new A();
//         // */
//
//         // var A = new A();
//         // var A2 = new A(); 
//         // Console.WriteLine(A.x);
//         // Console.WriteLine("Main start");
//         // Console.WriteLine("Before accessing A.x");
//         // var A = new A();
//         // Config config = new Config();
//         // Console.WriteLine(Config.ConnectionString);
//
//         // Console.WriteLine(Utils.a);
//
//     }
// }

class A
{
    public static int X = Init();

    static int Init()
    {
        Console.WriteLine("Init A");
        return 10;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Main start");
    }
}