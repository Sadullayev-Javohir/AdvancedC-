// class Program
// {
//     private static object lockA = new object();
//     private static object lockB = new object();
//
//     static void Thread1()
//     {
//         lock (lockA)
//         {
//             Console.WriteLine("Thread1: lockA olindi");
//             Thread.Sleep(1000);
//
//             lock (lockB)
//             {
//                 Console.WriteLine("Thread1: lockB olindi");
//             }
//         }
//     }
//
//     static void Thread2()
//     {
//         lock (lockA)
//         {
//             Console.WriteLine("Thread2: lockA olindi");
//             
//             lock (lockB)
//             {
//                 Console.WriteLine("Thread2: lockB olindi");
//                 Thread.Sleep(1000);
//            
//             }
//         }
//         
//     }
//     static void Main()
//     {
//         Thread t1 = new Thread(Thread1);
//         Thread t2 = new Thread(Thread2);
//
//         t1.Start();
//         t2.Start();
//
//         t1.Join();
//         t2.Join();
//         Console.WriteLine("Program tugadi");
//     }
// }

class Program
{
    private static readonly object myLock = new object();

    static void Thread1()
    {
        lock (myLock)
        {
            Console.WriteLine("Thread1: Lock olindi");
            Thread.Sleep(1000);
            Console.WriteLine("Thread1: Lock bo'shatildi");
        }
    }

    static void Thread2()
    {
        bool lockTaken = false;
        try
        {
            Monitor.TryEnter(myLock, TimeSpan.FromSeconds(2), ref lockTaken);
            if (lockTaken) Console.WriteLine("Thread2: Lock olindi");
            else Console.WriteLine("Thread2: Lock olinmadi: (timeout)");
        }
        finally
        {
            if (lockTaken) Monitor.Exit(myLock);
        }
    }
    static void Main()
    {
        Thread t1 = new Thread(Thread1);
        Thread t2 = new Thread(Thread2);
        
        t1.Start();
        Thread.Sleep(100);
        t2.Start();

        t1.Join();
        t2.Join();

    }
}