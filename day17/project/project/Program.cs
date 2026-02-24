// class Program
// {
//     static AutoResetEvent autoResetEvent = new AutoResetEvent(false);   
//     
//     static void Main(string[] args)
//     {
//         Thread worker = new Thread(Work);
//         worker.Start();
//         
//         Console.WriteLine("Main 3 soniya kutadi...");
//         Thread.Sleep(3000);
//         
//         // Console.WriteLine("Signal berildi");
//         // autoResetEvent.Set();
//
//         worker.Join();
//         Console.WriteLine("Main tugadi");
//     }
//
//     static void Work()
//     {
//         Console.WriteLine("Worker signal kutmoqda");
//         autoResetEvent.WaitOne();
//         Console.WriteLine("Worker davom etadi..");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Thread worker = new Thread(Work);
//         worker.Start();
//         
//         Console.WriteLine("Main 3 soniya kutadi...");
//         Thread.Sleep(3000);
//         
//         Console.WriteLine("Main uyquda turadi (lekin worker allaqachon tugagan bo'lishi mumkin)");
//
//         worker.Join();
//         Console.WriteLine("Main tugadi");
//     }
//
//     static void Work()
//     {
//         Console.WriteLine("Worker darrov ishlayapti...");
//         Console.WriteLine("Worker tugadi");
//     }
// }

// class Program
// {
//     private static ManualResetEvent ev = new ManualResetEvent(false);
//     
//     static void Main()
//     {
//         new Thread(() => Work("A")).Start();
//         new Thread(() => Work("B")).Start();
//
//         Thread.Sleep(1000);
//         
//         Console.WriteLine("Set #1");
//         ev.Set();
//         
//         Thread.Sleep(1000);
//         
//         Console.WriteLine("Set #2");
//         ev.Set();
//     }
//
//     static void Work(string name)
//     {
//         Console.WriteLine($"{name} kutayapti...");
//         ev.WaitOne();
//         Console.WriteLine($"{name} o'tdi");
//     }
// }

// class Program
// {
//     private static int _sum = 0;
//     private static object _gate = new object();
//     static void Main()
//     {
//         Thread t1 = new Thread(Work);
//         Thread t2 = new Thread(Work);
//         
//         t1.Start();
//         t2.Start();
//         Thread.Sleep(100);
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine(_sum);
//     }
//
//     static void Work()
//     {
//         for (int i = 0; i < 100000; i++)
//         {
//              lock (_gate) _sum++;
//         }
//     }
// }
//
// class Program
// {
//     static async Task Main()
//     {
//         Console.WriteLine("Boshladik");
//
//         await Task.Delay(2000);
//         Console.WriteLine("2 soniyadan keyin davom etadi");
//         
//     }
// }

// class  Program
// {
//     static object _gate = new object();
//     
//     static async Task Main()
//     {
//         lock (_gate)
//         {
//             await Task.Delay(1000);
//             Console.WriteLine("Davom ");
//         }
//     }
// }

// class Program
// {
//     static object _gate = new object();
//     
//     static void Main(string[] args)
//     {
//         Thread t1 = new Thread(() =>
//         {
//             lock (_gate)
//             {
//                 Console.WriteLine("T1 lock oldi, 3 s ichida ushlab turadi...");
//                 Thread.Sleep(3000);
//                 Console.WriteLine("T1 lockni qo'yib yubordi");
//             }
//         });
//
//         Thread t2 = new Thread(() =>
//         {
//             Thread.Sleep(500);
//             Console.WriteLine("T2 lock olishga harakat qilayapti...");
//             lock(_gate) Console.WriteLine("T2 lock oldi");
//         });
//         
//         t1.Start();
//         t2.Start();
//         t1.Join();
//         t2.Join();
//     }
//
// }
//
// class Program
// {
//     static object _gate = new object();
//     private static int _value = 0;
//
//     static async Task Main(string[] args)
//     {
//         int snapshot;
//         
//         lock(_gate) snapshot = _value;
//         await Task.Delay(1000);
//         
//         lock (_gate) _value = snapshot + 1;
//         Console.WriteLine(snapshot);
//     }
// }

// class Program
// {
//     static SemaphoreSlim semaphore = new SemaphoreSlim(1,1);
//
//     static async Task Main(string[] args)
//     {
//         await semaphore.WaitAsync();
//         try
//         {
//             Console.WriteLine("Kirdim");
//             await Task.Delay(1000);
//             Console.WriteLine("Chiqayapman");
//         }
//         finally
//         {
//             semaphore.Release();
//         }
//     }
// }

// class Program
// {
//     static object _gate = new  object();
//     private static int _count = 0;
//
//     static void Main()
//     {
//         Thread t1 = new Thread(Work);
//         
//         Thread t2 = new Thread(Work);
//         
//         t1.Start();
//         t2.Start();
//         
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine(_count);
//     }
//
//     static void Work()
//     {
//         for (int i = 0; i < 100_000; i++)
//         {
//             bool lockTokent = false;
//
//             try
//             {
//                 Monitor.Enter(_gate, ref lockTokent);
//                 _count++;
//             }
//             finally
//             {
//                 if (lockTokent)  Monitor.Exit(_gate);
//             }
//             
//         }
//     }
// }
//
// class Program
// {
//     static AutoResetEvent autoEvent = new  AutoResetEvent(false);
//
//     static void Main()
//     {
//         Thread worker = new Thread(Work);
//         worker.Start(); 
//         
//         Thread.Sleep(2000);
//         Console.WriteLine("Signal berildi");
//         autoEvent.Set();
//         
//         worker.Join();
//     }
//
//     static void Work()
//     {
//         Console.WriteLine("Worker kutayapti");
//         autoEvent.WaitOne();
//         Console.WriteLine("Worker davom etdi");
//         
//     }
// }

// class Program
// {
//     static object _gate = new object();
//
//     static void Main()
//     {
//         Thread t1 = new Thread(Work);
//         Thread t2 = new Thread(Work);
//         
//         t1.Start();
//         t2.Start();
//         
//         t1.Join();
//         t2.Join();
//
//         Console.WriteLine("Main tugadi");
//     }
//
//     static void Work()
//     {
//         Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} lock kutmoqda");
//         lock (_gate)
//         {
//             Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} kritik zonaga kirdi");
//             Thread.Sleep(2000);
//             Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} chiqdi");
//         }
//     }
// }

// class Program
// {
//     static Lock _lock = new  Lock();
//
//     static void Main()
//     {
//         Thread t1 = new Thread(Work);
//         Thread t2 = new Thread(Work);
//         
//         t1.Start();
//         t2.Start();
//
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine("Main tugadi");
//     }
//
//     static void Work()
//     {
//         using (_lock.EnterScope())
//         {
//             Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} kritik zonaga kirdi");
//             Thread.Sleep(2000);
//             Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} chiqdi");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // int x = 5;
//         //
//         // lock (x) Console.Write("Hello");
//         
//         string name = "test";
//
//         lock (name)
//         {
//             Console.WriteLine("Locked");
//         }
//     }
// }

// class Test
// {
//     public void Work()
//     {
//         lock (this)
//         {
//             Console.WriteLine("Work boshlandi");
//             Thread.Sleep(2000);
//             Console.WriteLine("Work tugadi");
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var t = new Test();
//
//         lock (t)
//         {
//             Console.WriteLine("Tashqi kod t ni lock qildi");
//             var worker = new Thread(() => t.Work());
//             
//             worker.Start();
//             
//             Thread.Sleep(3000);
//             Console.WriteLine("Tashqi kod lockni qo'yib yubordi");
//         }
//     }
// }
//
// class Program
// {
//     private static readonly object _lock = new object();
//     private static int _counter = 0;
//
//     static void Main()
//     {
//         Thread t1 = new Thread(Work);
//         Thread t2 = new Thread(Work);
//         
//         t1.Start();
//         t2.Start();
//
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine(_counter);
//     }
//
//     static void Work()
//     {
//         for (int i = 0; i < 100000; i++)
//         {
//             lock (_lock)
//             {
//                 _counter++;
//             }
//         }
//     }
// }

// class Program
// {
//     private static readonly Lock _lock = new Lock();
//     private static int _counter = 0;
//
//     static void Main()
//     {
//         Thread t1 = new Thread(Work);
//         Thread t2 = new Thread(Work);
//         
//         t1.Start();
//         t2.Start();
//
//         t1.Join();
//         t2.Join();
//         
//         Console.WriteLine("Final value: " + _counter);
//     }
//
//     static void Work()
//     {
//         for (int i = 0; i < 5; i++)
//         {
//             using (_lock.EnterScope())
//             {
//                 Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} entered");
//                 _counter++;
//                 Thread.Sleep(2000);
//                 Console.Write($"Thread {Thread.CurrentThread.ManagedThreadId} leaving");
//                 
//             }
//         }
//     }
// }
//



//
// using System;
// using System.Diagnostics;
// using System.Threading;
//
// class Program
// {
//     static void Main()
//     {
//         int jobs = 3000;            // 2000 dan boshlang, keyin 5000, 10000
//         int sleepMs = 2000;         // threadlar tirik tursin, o'sishni ko'rasiz
//
//         var proc = Process.GetCurrentProcess();
//         Console.WriteLine($"Before: Threads={proc.Threads.Count}, WS={proc.WorkingSet64 / (1024*1024)} MB");
//
//         var sw = Stopwatch.StartNew();
//
//         Thread[] threads = new Thread[jobs];
//
//         for (int i = 0; i < jobs; i++)
//         {
//             threads[i] = new Thread(() => Thread.Sleep(sleepMs));
//             threads[i].IsBackground = true;
//             threads[i].Start();
//         }
//
//         Console.WriteLine($"After start: Threads={proc.Threads.Count}, WS={proc.WorkingSet64 / (1024*1024)} MB");
//
//         for (int i = 0; i < jobs; i++)
//             threads[i].Join();
//
//         sw.Stop();
//         Console.WriteLine($"Done in {sw.ElapsedMilliseconds} ms");
//         Console.WriteLine($"After join: Threads={proc.Threads.Count}, WS={proc.WorkingSet64 / (1024*1024)} MB");
//     }
// }












































