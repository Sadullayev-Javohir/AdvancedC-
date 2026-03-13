// class Program
// {
//     static void Main()
//     {
//         object a = new object();
//         Console.WriteLine(GC.GetGeneration(a));
//         
//         GC.Collect(0);
//         a = null;
//         Console.WriteLine(GC.GetGeneration(a));
//         
//         GC.Collect();
//         Console.WriteLine(GC.GetGeneration(a));
//     }
//     
//     
// }

// class A
// {
//     public B Bref;
// }
//
// class B
// {
//     public C CRef;
// }
//
// class C{}
//
// class Program
// {
//     static void Main()
//     {
//         A a = new A();
//         a.Bref = new B();
//         a.Bref.CRef = new C();
//
//         a = null;
//     }
// }

// using System.Runtime;
//
// class Program
// {
//     static void Main()
//     {
//         // object obj = new object();
//         // WeakReference weak = new WeakReference(obj);
//         //
//         // Console.WriteLine(weak.IsAlive);
//         //
//         // obj = null;
//         // GC.Collect();
//         // GC.WaitForPendingFinalizers();
//         //
//         // Console.WriteLine(weak.IsAlive);
//
//         // byte[] small = new byte[1000];
//         // byte[] large = new byte[100_000];
//         //
//         // Console.WriteLine(GC.GetGeneration(small));
//         // Console.WriteLine(GC.GetGeneration(large));
//         
//         Console.WriteLine(GCSettings.IsServerGC);
//         Console.WriteLine(GCSettings.LatencyMode);
//     }
// }
//
// class Demo
// {
//     public Demo() => Console.WriteLine("Obyekt yaratildi");
//
//     ~Demo()
//     {
//         Console.WriteLine("Finalizer ishladi");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         CreateObject();
//         
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//         
//         Console.WriteLine("Main tugadi");
//     }
//
//     static void CreateObject()
//     {
//         Demo d = new Demo();
//     }
// }

// class Demo
// {
//     protected override void Finalize()
//     {
//         try
//         {
//             Console.WriteLine("Finalize ishladi");
//         }
//         finally
//         {
//             base.Finalize();
//         }
//     }
// }
//
// class MyResource : IDisposable
// {
//     private bool _disposed;
//
//     public void Use()
//     {
//         if (_disposed) throw new ObjectDisposedException(nameof(MyResource));
//         Console.WriteLine("Resource ishlatilmoqda");
//     }
//
//     public void Dispose()
//     {
//         if (_disposed) return;
//         Console.WriteLine("Resource tozalanmoqda");
//         _disposed = true;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         MyResource r = new MyResource();
//         r.Use();
//         r.Dispose();
//     }
// }

// class MyResourceHolder : IDisposable
// {
//     private bool _disposed;
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
//
//     protected virtual void Dispose(bool disposing)
//     {
//         if (_disposed) return;
//         if (disposing) Console.WriteLine("Managed resource tozalandi");
//         
//         Console.WriteLine("Unmanaged resource tozalandi");
//         _disposed = true;
//     }
//
//     ~MyResourceHolder()
//     {
//         Dispose(false);
//     }
// }

class Test
{
    ~Test()
    {
        Console.WriteLine("Finalizer ishladi");
    }
}

class  Program
{
    static void Main()
    {
        // Create();
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        // Console.WriteLine("Tugadi
        // ");

        byte[] arr = new byte[100_000];
        Console.WriteLine("Generation: " + GC.GetGeneration(arr));
    }

    static void Create()
    {
        Test t = new Test();
    }
}