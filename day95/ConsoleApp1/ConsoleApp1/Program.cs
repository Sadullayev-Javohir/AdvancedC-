using System;
using System.Security.Cryptography;
using System.Threading;

class Program
{
    private static int counter = 0;

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        
        Console.WriteLine(counter);
    }

    static void Increment()
    {
        for (int i = 0; i < 100000; i++) Interlocked.Increment(ref counter);
    }
}