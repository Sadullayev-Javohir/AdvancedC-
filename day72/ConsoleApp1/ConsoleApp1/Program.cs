// class Program
// {
//     static void Main()
//     {
//         string name = "Javohir";
//
//         Action show = () =>
//         {
//             Console.WriteLine(name);
//         };
//         show();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // int x = 10;
//         // Func<int> get = () => x;
//         //
//         // Console.WriteLine(get());
//
//         // int number = 10;
//         // Action test = () =>
//         // {
//         //     Console.WriteLine(number);
//         // };
//         // number = 20;
//         // test();
//         // number = 30;
//
//         var c1 = Counter();
//         var c2 = Counter();
//         
//         
//         Console.WriteLine(c1());
//         Console.WriteLine(c1());
//         
//         Console.WriteLine(c2());
//     }
//     static Func<int> Counter()
//     {
//         int count = 0;
//         return () =>
//         {
//             count++;
//             return count;
//         };
//     } 
// }

// class Program
// {
//     static void Main()
//     {
//         int a = 10;
//
//         Func<int> test = () => a;
//         Console.WriteLine(test());
//     }
// }

// class Program
// {
//     delegate void MyDelegate();
//     
//     static void Main()
//     {
//         int x = 5;
//         
//         MyDelegate d = () =>
//         {
//             Console.WriteLine(x);
//         };
//         d();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int counter = 0;
//
//         void Increment()
//         {
//             counter++;
//             Console.WriteLine(counter);
//         }
//
//         Increment();
//         Increment();
//         Increment();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int limit = 10;
//         var numbers = new List<int>() { 5, 15, 20 };
//         var result = numbers.Where(x => x > limit);
//         foreach (var i in result) Console.WriteLine(i);
//         
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var actions = new List<Action>();
//
//         for (int i = 0; i < 3; i++)
//         {
//            // actions.Add(() => Console.WriteLine(i));
//            int copy = i;
//            actions.Add(() => Console.WriteLine(copy));
//         }
//
//         foreach (var action in actions) action();
//     }
// }

// class Program
// {
//     static async Task Main()
//     {
//         string message = "Finished";
//
//         await Task.Run(() =>
//         {
//             Console.WriteLine(message);
//         });
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Func<int> Test()
//         {
//             int x = 5;
//             return () => x;
//         }
//         Console.WriteLine(Test()());
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Action test = delegate()
//         // {
//         //     Console.WriteLine("Hello");
//         // };
//         // test();
//
//         Func<int> Create(int start = 5)
//         {
//             int count = start;
//             return () => ++count;
//         }
//         Console.WriteLine(Create()());
//         Console.WriteLine(Create()());
//         Console.WriteLine(Create()());
//     }
// }

class DisplayClass
{
    public int x { get; set; }
}

class Program
{
    static void Main()
    {
        DisplayClass c = new DisplayClass();
        c.x = 5;

        c.x = 20;

        Func<int> test = () => c.x;
        Console.WriteLine(test());
    }
}
