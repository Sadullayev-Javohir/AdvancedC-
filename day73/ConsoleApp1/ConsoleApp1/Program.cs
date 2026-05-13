// class Program
// {
//     static void Main()
//     {
//         Func<int> test()
//         {
//             int x = 10;
//
//             return () => x;
//         };
//         
//         Console.WriteLine(test()());
//     }
// }

// class DisplayClass
// {
//     public int x;
//     public int LambdaMethod() => x;
// }
//
// class Program
// {
//     static void Main()
//     {
//         Func<int> Test()
//         {
//             DisplayClass dc = new DisplayClass();
//             dc.x = 10;
//             return dc.LambdaMethod;
//         };
//         Console.WriteLine(Test()());
//     }
// }

// class DisplayClass
// {
//     public int x;
//     public void Lambda() => Console.WriteLine(x);
// }
//
// class Program
// {
//     static void Main()
//     {
//         int x = 5;
//         Action a = () =>
//         {
//             DisplayClass dc = new DisplayClass();
//             dc.x = x;
//             dc.Lambda();
//         };
//         a();
//     }
// }

// class DisplayClass
// {
//     public int a;
//     public int b;
//     public int Lambda() => a + b;
// }
// class Program
// {
//     static void Main()
//     {
//         int a = 1, b = 2;
//         Func<int> f = () =>
//         {
//             DisplayClass dc = new DisplayClass();
//             dc.a = a;
//             dc.b = b;
//             return dc.Lambda();
//         };
//         Console.WriteLine(f());
//     }
// }

// class DisplayClass
// {
//     public int x;
//     public void Lambda1() => Console.WriteLine(x);
//     public void Lambda2() => Console.WriteLine(x * 2);
// }
//
// class Program
// {
//     static void Main()
//     {
//         int x = 10;
//         Action a = () =>
//         {
//             DisplayClass dc = new DisplayClass();
//             dc.x = x;
//             dc.Lambda1();
//         };
//         Action b = () =>
//         {
//             DisplayClass dc = new DisplayClass();
//             dc.x = x;
//             dc.Lambda2();
//         };
//         a();
//         b();
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         // int x = 0;
//         // Action a = () => x++;
//         // Action b = () => Console.WriteLine(x);
//         // a();
//         // b();
//
//         var actions = new List<Action>();
//
//         for (int i = 0; i < 3; i++)
//         {
//             int copy = i;
//             actions.Add(() => Console.WriteLine(copy));
//         }
//
//         foreach (var a in actions) a();
//     }
//     
// }
//
// class Test
// {
//     public int x = 10;
//
//     public Action Get()
//     {
//         return () => Console.WriteLine(x);
//     }
// }
//
// class DisplayClass
// {
//     public Test @this;
//     public void Lambda() => Console.WriteLine(@this.x);
// }
// class Program
// {
//     static void Main()
//     {
//         int x = 10;
//         Action a = static () => Console.WriteLine("hey");
//         a();
//         // Test t = new Test();
//         // t.Get()();
//
//
//     }
// }


class Program
{
    delegate void MyDelegate();
    static void Main()
    {
        MyDelegate d = delegate() { Console.WriteLine("Hello"); };
        d();
    }
}