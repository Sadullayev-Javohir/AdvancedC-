// int counter = 0;
//
// Parallel.For(0, 10000, i =>
// {
//    counter++;
// });
// Console.WriteLine(counter);
//
// class Program
// {
//     private static int counter = 0;
//     private static readonly object _lock = new();
//
//     static void Increment()
//     {
//         for (int i = 0; i < 1_000_000; i++)
//         {
//             lock (_lock)
//             {
//                 counter++;
//             }
//         }
//     }
//     static void Main()
//     {
//         Thread t1 = new Thread(Increment);
//         Thread t2 = new Thread(Increment);
//
//         t1.Start();
//         t2.Start();
//
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine($"Counter: {counter}" +
//                           $"");
//     }
// }

using System.Diagnostics;
using System.Threading;

// class Program
// {
//     private static object _lock = new();
//     static void Main()
//     {
//         Monitor.Enter(_lock);
//
//         try
//         {
//             Console.WriteLine("Critical section");
//         }
//         finally
//         {
//             Monitor.Exit(_lock);
//         }
//     }
// }

// class Program
// {
//     private static SpinLock _spinLock = new SpinLock();
//     private static int counter = 0;
//
//     static void Increment()
//     {
//         for (int i = 0; i < 10000; i++)
//         {
//             bool lockTaken = false;
//             _spinLock.Enter(ref lockTaken);
//
//             try
//             {
//                 counter++;
//             }
//             finally
//             {
//                 if (lockTaken) _spinLock.Exit();
//             }
//         }
//     }
//     static void Main()
//     {
//         Thread t1 = new Thread(Increment);
//         Thread t2 = new Thread(Increment);
//
//         t1.Start();
//         t2.Start();
//
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine(counter);
//     }
// }

class Program
{
    private static object lockA = new object();
    private static object lockB = new object();

    static void Thread1()
    {
        lock (lockA)
        {
            Console.WriteLine("Thread1: lockA oldi");
            Thread.Sleep(100);
            
            lock (lockB)
            {
                Console.WriteLine("Thread1: lockB oldi");
            }
        }

        
    }

    static void Thread2()
    {
        lock (lockB)
        {
            Console.WriteLine("Thread2: lockB oldi");
            Thread.Sleep(100);

            lock (lockA)
            {
                Console.WriteLine("Thread2: lockA oldi");
            }
        }
        
    }
    static void Main()
    {
        new Thread(Thread1).Start();
        new Thread(Thread2).Start();
    }
}