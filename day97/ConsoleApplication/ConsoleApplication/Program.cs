// class Program
// {
//     static volatile bool stop = false;
//
//     static void Worker()
//     {
//         while (!stop)
//         {
//         }
//
//         Console.WriteLine("Stopped");
//     }
//
//     static void Main()
//     {
//         Thread t = new Thread(Worker);
//         t.Start();
//
//         Thread.Sleep(2000);
//
//         stop = true;
//     }
// }

class Program
{
    private static int counter = 0;

    static void Writer()
    {
        for (int i = 0; i <= 5; i++)
        {
            Volatile.Write(ref counter, i);
            Console.WriteLine($"Write yozdi: {i}");
            Thread.Sleep(500);
        }
    }
    
    static void Reader()
    {
        int lastValue = 0;
        while (lastValue < 5)
        {
            int current = Volatile.Read(ref counter);
            if (current != lastValue)
            {

                lastValue = current;
                Console.WriteLine($"Reader o'qidi: {current}");
            }

        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Writer);
        Thread t2 = new Thread(Reader);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        Console.WriteLine("Tugadi");
    }
}