// class Program
// {
//     // static void Change(int x)
//     // {
//     //     x = 100;
//     // }
//     // static void Main()
//     // {
//     //     int a = 5;
//     //     Change(a);
//     //     Console.WriteLine(a);
//     // }
//
//     static void Change(ref int x)
//     {
//         x = 100;
//     }
//
//     static void Main()
//     {
//         int a = 5;
//         Change(ref a);
//         Console.WriteLine(a);
//     }
// }

// struct  BigData
// {
//     public long A;
//     public long B;
//     public long C;
//     public long D;
// }

// class Program
// {
// static void Modify(BigData data)
// {
//     data.A = 999;
// }
//
// static void Main()
// {
//     BigData big = new BigData { A = 1, B = 2, C = 3, D = 4 };
//     
//     Modify(big);
//     Console.WriteLine(big.A);
// }

// static void Modify(ref BigData data) => data.A = 999;
//
// static void Main()
// {
//     BigData big = new BigData { A = 1, B = 2, C = 3, D = 4 };
//     Modify(ref big);
//     Console.WriteLine(big.A);
// }

//     static void GetValue(out int x) => x = 42;
//
//     static void Main()
//     {
//         int a;
//         GetValue(out a);
//         Console.WriteLine(a);
//
//         bool success = int.TryParse("123", out int result);
//         Console.WriteLine(success);
//         Console.WriteLine(result);
//     }
// }

// readonly struct BigData
// {
//     public readonly long A, B, C, D;
//
//     public BigData(long a, long b, long c, long d)
//     {
//         A = a;
//         B = b;
//         C = c;
//         D = d;
//     }
// }
//
// class Program
// {
//     static long Sum(BigData data)
//     {
//         return data.A + data.B;
//     }
//
//     static void Main()
//     {
//         BigData data = new BigData(2, 3, 4, 5);
//         Console.WriteLine(Sum(data));
//     }
// }
//

//
// class Program
// {
//     static void Print(in int x)
//     {
//         Console.WriteLine(x);
//     }
//     static void Main()
//     {
//         int a = 5;
//         Print(in a);
//     }
// }

// usi

// class Program
// {
//     private static int _started = 0;
//     static void Main()
//     {
//         int n = 10_000;
//         Console.WriteLine($"Creating {n} OS threads...");
//
//         try
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 new Thread(DoWork)
//                 {
//                     IsBackground = true
//                 }.Start();
//                 Console.WriteLine("All start() calls executed (if you got here).");
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("FAILED while creating threads: ");
//             Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
//         }
//         
//         Console.WriteLine("Press enter to exit..");
//         Console.ReadLine();
//     }
//
//     static void DoWork()
//     {
//         int x = Interlocked.Increment(ref _started);
//         
//         if (x % 500 == 0) Console.WriteLine($"Started threads: {x}");
//         Thread.Sleep(30_000);
//     }
// }

using System.Net.Http.Headers;

// class Program
// {
//     private static int _started = 0;
//     
//     static void Main()
//     {
//         int n = 10_000;
//         Console.WriteLine($"Queueing {n} work items to ThreadPool...");
//
//         using var done = new CountdownEvent(n);
//
//         for (int i = 0; i < n; i++)
//         {
//             ThreadPool.QueueUserWorkItem(_ =>
//             {
//                 DoWork();
//                 done.Signal();
//             });
//         }
//         
//         Console.WriteLine("Queued. Waiting all to finish...");
//         done.Wait();
//         
//         Console.WriteLine("All done. Press enter to exit...");
//         Console.ReadLine();
//     }
//
//     static void DoWork()
//     {
//         int x = Interlocked.Increment(ref _started);
//         if (x % 1000 == 0) Console.WriteLine($"Started work items: {x}");
//         Thread.SpinWait(200_000);
//     }
// }

// class Program
// {
//     static ref int GetRef(int[] arr, int index)
//     {
//         return ref arr[index];
//     }
//
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3 };
//         ref int element = ref GetRef(arr, 0);
//         element = 10;
//         ref int element2 = ref GetRef(arr, 1);
//         element2 = 20;
//         foreach (var i in arr)
//         {
//             Console.WriteLine(i);   
//         }
//
//     }
// }

class User
{
    public int Age;
}

class Program
{
    static void Main()
    {
        User user = new User();
        user.Age = 25;
        Console.WriteLine(user.Age);
        
        Test(ref user);
        Console.WriteLine(user.Age);

    }

    static void Test(ref User u)
    {
        u = new User();
        u.Age = 299;
    }
}
