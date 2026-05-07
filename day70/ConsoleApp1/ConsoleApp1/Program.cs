// class Program
// {
//     delegate void MyDelegate();
//     static void Main()
//     {
//         MyDelegate d = delegate()
//         {
//             Console.WriteLine("Anonymous method ishladi");
//         };
//         d();
//     }
// }

// class Program
// {
//     delegate void MyDelegate(int x);
//     static void Main()
//     {
//         MyDelegate d = delegate(int x)
//         {
//             Console.WriteLine(x * 2);
//         };
//         d(10);
//     }
// }

// class Program
// {
//     delegate void MyDelegate(int x);
//
//     static void Main()
//     {
//         MyDelegate d = delegate(int x) { Console.WriteLine("Anonymous method: " + x); };
//
//         d(10);
//     }
// }

// class Program
// {
//     delegate void MyDelegate(int x);
//     static void Main()
//     {
//         MyDelegate d = x => Console.WriteLine("Lambda: " + x);
//         d(10);
//     }
// }
//
// class Program
// {
//     // delegate void MyDelegate();
//     //
//     // static void Main()
//     // {
//     // MyDelegate d = delegate()
//     // {
//     //     Console.WriteLine("Hello");
//     // };
//     // d();
//     // }
//     
// }

// class Program
// {
//     delegate void MyDelegate(int x );
//     static void Main()
//     {
//         // int x = 10;
//         // Action a = delegate()
//         // {
//         //     Console.WriteLine(x);
//         // };
//         // a();
//
//         // List<int> numbers = new List<int>() { 1, 2, 3 };
//         // numbers.ForEach(delegate(int n)
//         // {
//         //     Console.WriteLine(n);
//         // });
//         MyDelegate d = delegate (int x)
//         {
//             Console.WriteLine(x);
//         };
//     }
// }

// class Program
// {
//     static IEnumerable<int> GetNumbers()
//     {
//         yield return 1;
//         yield return 2;
//     }
//     static void Main()
//     {
//         Console.WriteLine(GetNumbers().GetEnumerator());
//     }
// }

class Program
{
    delegate void MyDelegate();
    static void Main()
    {
        // MyDelegate d = delegate()
        // {
        //     Console.WriteLine("hello");
        // };
        // d();
        MyDelegate d = () => Console.WriteLine("Hello");
        d();
    }
}