// using System;
// using System.Diagnostics;
//
// class Program
// {
//     static void Main()
//     {
//         const int N = 10_000_000;
//
//         Measure("No boxing", () =>
//         {
//             int sum = 0;
//             for (int i = 0; i < N; i++)
//             {
//                 sum += i;
//             }
//         });
//
//         Measure("With boxing", () =>
//         {
//             int sum = 0;
//             for (int i = 0; i < N; i++)
//             {
//                 object o = i;        // boxing
//                 sum += (int)o;       // unboxing
//             }
//         });
//     }
//
//     static void Measure(string name, Action action)
//     {
//         var sw = Stopwatch.StartNew();
//         action();
//         sw.Stop();
//         Console.WriteLine($"{name}: {sw.ElapsedMilliseconds} ms");
//     }
// }

// object o = new Big(); // 🔥 katta copy + allocation
//
// struct Big
// {
//     public long A, B, C, D;
// }


// struct S
// {
//     public int X;
//
//     public override string ToString()
//     {
//         return X.ToString();
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         S s = new S { X = 5 };
//         Console.WriteLine(s);
//     }
// }


using System.Collections;

interface ITest
{
    void Run();
}

struct S : ITest
{
    public void Run() => Console.WriteLine("Run");
}

class Program
{
    static void Main()
    {
        // S s = new S();
        // ITest t = s; // hidden boxing
        // t.Run();

        ArrayList arr = new ArrayList() {1, 2, 3};
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}