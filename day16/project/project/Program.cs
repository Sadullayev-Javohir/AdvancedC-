//enum OrderStatus
//{
//    Pending, Approved, Shipped, Cancelled
//}

//class Order
//{
//    public int Id;
//    public OrderStatus Status;

//    public void Print()
//    {
//        Console.WriteLine($"Order Id: {Id}");
//        Console.WriteLine($"Status: {(int)Status}");
//    }
//}

//class  Program
//{
//    static void Main()
//    {
//        Order order = new Order();
//        order.Id = 1;
//        order.Status = OrderStatus.Pending;

//        order.Print();

//        order.Status = OrderStatus.Shipped;
//        order.Print();

//        Console.ReadLine();
//    }

//}

//enum PaymentMethod
//{
//    Cash, Card, Transfer
//}

//class Payment
//{
//    public int Amount;
//    public PaymentMethod Method;
//}

//class Program
//{
//    static void Main()
//    {
//        Payment p = new Payment();
//        p.Amount = 5;
//        p.Method = PaymentMethod.Card;

//        Console.WriteLine($"Amount: {p.Amount},\n Method: {p.Method}");
//    }
//}

//struct Position
//{
//    public int X, Y;
//}

//class Player
//{
//    public string Name;
//    public Position Pos;

//    public void Print()
//    {
//        Console.WriteLine($"{Name} position: X={Pos.X}, Y={Pos.Y}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Player p = new Player();
//        p.Name = "Hero";

//        p.Pos.X = 10;
//        p.Pos.Y = 20;

//        p.Print();
//    }

//}




//struct Size
//{
//    public int Width, Height;
//}

//class Window
//{
//    public string? Title;
//    public Size WindowSize;

//    public void Print()
//    {
//        Console.WriteLine($"Window name: {Title}, Window width: {WindowSize.Width}, Window height: {WindowSize.Height}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Window w = new Window();
//        w.Title = "Redmi Monitor";
//        w.WindowSize.Width = 2500;
//        w.WindowSize.Height = 900;
//        w.Print();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello");
//        Console.WriteLine("Hello");
//        Console.WriteLine("Hello");
//        Console.WriteLine("Hello");
//        Console.WriteLine("Hello");
//        Console.WriteLine("Hello");
//        Console.WriteLine("Hello");

//    }
//}
using System;
using System.Threading;

//class Program
//{
//    static void Main()
//    {
//        Thread t = new Thread(Work);
//        Console.WriteLine("Main tugadi");
//    }

//    static void Work ( ) => Console.WriteLine("Work ishladi");
//}

//class Program
//{ 
//    static void Main()
//    {
//        static void Main()
//        {
//            Thread t = new Thread(Print);
//            Thread t2 = new Thread(Sum);
//            Console.WriteLine("Tugadi");
//        }
//        static void Print ( ) => Console.WriteLine("Hi");
//        static void Sum ( ) => Console.WriteLine(2 + 3);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Thread t = new Thread(Work);
//        t.Start();

//        Console.WriteLine("Main davom etayapti");
//    }

//    static void Work ( ) => Console.WriteLine("Work thread ishlayapti");
//}

//class Program
//{
//    static void Main()
//    {
//        Thread a = new Thread(A);
//        Thread b = new Thread(B);
//        a.Start(); b.Start(); 
//        Console.WriteLine("Main davom etayapti");
//    }

//    static void A ( ) => Console.WriteLine("A");
//    static void B ( ) => Console.WriteLine("B");
//}

//class Program
//{
//    static void Main()
//    {
//        Thread t = new Thread(( ) =>
//        {
//            Thread.Sleep(5000);
//            Console.WriteLine("Thread tugadi");
//        });
//        t.Start();
//        t.Join();

//        Console.WriteLine("Main tugadi...");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Thread t = new Thread(( ) =>
//        {
//            Thread.Sleep(1000);
//            Console.WriteLine("Done");
//        });
//        t.Start();
//        Console.WriteLine("Main kutayapti");
//        t.Join();

//        Console.WriteLine("Main tugadi");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Thread t1 = new Thread(( ) =>
//        {
//            Thread.Sleep(200);
//            Console.WriteLine("200 ms");
//        });
//        Thread t2 = new Thread(( ) =>
//        {
//            Thread.Sleep(800);
//            Console.WriteLine("800 ms");
//        });
//        Console.WriteLine("Main boshlandi");
//        t1.Start();
//        t2.Start();
//        t2.Join();
//        t1.Join();

//        Console.WriteLine("Main tugadi");
//    }

//}
//class Program
//{
//    static void Main()
//    {
//        Thread t1 = new Thread(( ) =>
//        {
//            for (int i = 0; i < 5; i++) Console.WriteLine("T1: " + i);
//            Thread.Sleep(0);
//            //Thread.Yield();
//        });

//        Thread t2 = new Thread(( ) =>
//        {
//            for (int i = 0; i < 5; i++) Console.WriteLine("T2: " + i);
//            Thread.Sleep(0);
//            //Thread.Yield();
//        });

//        t1.Start();
//        t2.Start();

//        t1.Join();
//        t2.Join();

//        Console.WriteLine("Hammasi tugadi");
//    }
//}

using System;
using System.Threading;

//class Program
//{
//    static void Main ( )
//    {
//        Thread t1 = new Thread(( ) =>
//        {
//            for (int i = 0; i < 20_000_00; i++)
//            {
//                // CPU band qilamiz
//                for (int k = 0; k < 20_000_00; k++) { }

//                Console.WriteLine("T1: " + i);
//            }
//        });

//        Thread t2 = new Thread(( ) =>
//        {
//            for (int i = 0; i < 20_000_00; i++)
//            {
//                for (int k = 0; k < 20_000_00; k++) { }

//                Console.WriteLine("T2: " + i);
//            }
//        });

//        t1.Start();
//        t2.Start();

//        t1.Join();
//        t2.Join();

//        Console.WriteLine("Hammasi tugadi");
//    }
//}


//class Program
//{
//    static void Main ( )
//    {
//        Thread t1 = new Thread(( ) =>
//        {
//           for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("T1 " + i + " ");
//                Thread.Sleep(0);
//            }
//        });
//        Thread t2 = new Thread(( ) =>
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("T2 " + i + " ");
//                Thread.Sleep(0);
//            }
//        });
//        t1.Start();
//        t2.Start();

//        t1.Join();
//        t2.Join();
//    }
//}

//class Program
//{
//    private static readonly object _gate = new object();
//    private static int _counter = 0;
//    static void Main()
//    {
//        Thread t1 = new Thread(( ) => Worker("T1"));
//        Thread t2 = new Thread(( ) => Worker("T2"));
//        Thread t3 = new Thread(( ) => Worker("T3"));

//        t1.Start();
//        t2.Start();
//        t3.Start();

//        t1.Join();
//        t2.Join();
//        t3.Join();

//        Console.WriteLine($"\nFinal counter = {_counter}");
//    }

//    static void Worker(string name)
//    {
//        for (int i = 0;  i < 5; i++)
//        {
//            lock(_gate)
//            {
//                int before = _counter;
//                Console.WriteLine($"{name} ENTER | counter = {before}");

//                Thread.Sleep(60);
//                _counter = before + 1;

//                Console.WriteLine($"{name} EXIT | counter = {_counter}");
//            }
//            Thread.Sleep(10);
//        }
//    }
//}
//class Program
//{
//    static int x = 0;
//    static object gate = new object();
//    static void Main()
//    {
//        Thread t1 = new Thread(Add);
//        Thread t2 = new Thread(Add);

//        t1.Start();
//        t2.Start();

//        t1.Join();
//        t2.Join();

//        Console.WriteLine(x);
//    }

//    static void Add()
//    {
//        for (int i = 0; i < 100000; i++)
//        {
//            lock (gate) { x++; }
//        }
//    }
//}

//class Program
//{
//    static int _sum = 0;
//    static object gate = new object();

//    static void Main()
//    {
//        for (int i = 0; i < 200; i++)
//        {
//            Thread t1 = new Thread(Sum);
//            Thread t2 = new Thread(Sum);
//            Thread t3 = new Thread(Sum);

//            t1.Start();
//            t2.Start();
//            t3.Start();

//            t1.Join();
//            t2.Join();
//            t3.Join();

//            Console.WriteLine(_sum);
//        }
//    }
//    static void Sum()
//    {
//        for (int i = 0; i < 10_000; i++)
//        {
//            lock(gate)
//            {
//                _sum++;
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;

//class Obj
//{
//    public string Name;
//    public bool Mark;
//    public Obj(string n) { Name = n; }
//}

//class Program
//{
//    static void Main()
//    {
//        var heap = new List<Obj> { new Obj("A"), new Obj("B"), new Obj("C") };
//        var roots = new List<Obj> { heap[0], heap[1] };

//        foreach (var r in roots) r.Mark = true;

//        heap.RemoveAll(o => o.Mark == false);

//        foreach (var o in heap) Console.WriteLine(o.Name);
//        Console.ReadLine();
//    }
//}


class Obj
{
    public string Name;
    public bool Mark;
    public Obj? Next;
    public Obj (string n) => Name = n; 
}

class Program
{
    static void Mark(Obj? o)
    {
        if (o == null || o.Mark) return;
        o.Mark = true;
        Mark(o.Next);
    }

    static void Main()
    {
        var A = new Obj("A");
        var B = new Obj("B");
        var C = new Obj("C");
        var D = new Obj("D");

        A.Next = B; B.Next = C;

        var heap = new List<Obj> { A, B, C, D };
        Mark(A);
        heap.RemoveAll(o => !o.Mark);

        foreach (var o in heap) Console.WriteLine(o.Name);
        Console.ReadLine();

    }
}
