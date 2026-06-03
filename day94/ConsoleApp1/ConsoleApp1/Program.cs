using System;
using System.Threading;

// class Program
// {
//     private static Mutex mutex = new Mutex();
//
//     static void Work()
//     {
//         mutex.WaitOne();
//         Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} started");
//         
//         Thread.Sleep(2000);
//         Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
//         
//         mutex.ReleaseMutex();
//     }
//
//     static void Main()
//     {
//         for (int i = 0; i < 3; i++) new Thread(Work).Start();
//     }
// }
//
// class Program
// {
//     private static Semaphore _semaphore = new Semaphore(3, 3);
//
//     static void Work()
//     {
//         _semaphore.WaitOne();
//         Console.WriteLine($"Start {Thread.CurrentThread.ManagedThreadId}");
//         
//         Thread.Sleep(3000);
//         
//         Console.WriteLine($"End {Thread.CurrentThread.ManagedThreadId}");
//
//         _semaphore.Release(3);
//     }
//     static void Main()
//     {
//         for (int i = 0; i < 10; i++) new Thread(Work).Start();
//     }
// }

using System.Threading;

class Program
{
    static void Main()
    {
        bool created;

        Mutex mutex =
            new Mutex(false,
                "MyApp",
                out created);

        if (!created)
        {
            Console.WriteLine(
                "Program already running");
            return;
        }
        
        Console.WriteLine("Program started");
        Console.ReadLine();
    }
}