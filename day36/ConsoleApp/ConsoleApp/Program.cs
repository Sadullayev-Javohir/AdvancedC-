using System.Security.Cryptography.X509Certificates;

//
// class Singleton
// {
//     private static Singleton _instance;
//     private Singleton() {}
//
//     public static Singleton GetInstance()
//     {
//         if (_instance == null) _instance = new Singleton();
//         return _instance;
//     }
// }
// class Singleton
// {
//     private static Singleton _instance;
//     private static object _lock = new object();
//     
//     private Singleton() {}
//
//     public static Singleton GetInstance()
//     {
//         lock (_lock)
//         {
//             if (_instance == null) _instance = new Singleton();
//             return _instance;
//         }
//     }
// }

// class Singleton
// {
//     private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
//     
//     private Singleton() {}
//
//     public static Singleton Instance => _instance.Value;
// }

// class MyClass
// {
//     private MyClass(){}
// }

// class Singleton
// {
//     private static Singleton _instance;
//     private Singleton(){}
//
//     public static Singleton GetInstance()
//     {
//         if (_instance == null)
//         {
//             Thread.Sleep(100);
//             _instance = new Singleton();
//         }
//         return _instance;
//     }
// }

// class Logger
// {
//     private static Logger instance;
//     private Logger() {}
//
//     public static Logger GetInstance()
//     {
//         if (instance == null) instance = new Logger();
//         return instance;
//     }
//
//     public void Log(string message) => Console.WriteLine($"LOG: {message}");
// }

// class Singleton
// {
//     private static Singleton instance;
//     private static object lockObj = new object();
//
//     private Singleton()
//     {
//     }
//
//     public static Singleton GetInstance()
//     {
//         lock (lockObj)
//         {
//             if (instance == null) instance = new Singleton();
//         }
//
//         return instance;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Singleton s1 = Singleton.GetInstance();
//         Singleton s2 = Singleton.GetInstance();
//         
//         // if (s1 == s2) Console.WriteLine("Ikkala instance bir xil");
//         // else Console.WriteLine("Turli instancelar");
//         Console.WriteLine(s1);
//
//         
//     }
// }

using System;
using System.Threading;

// class Singleton
// {
//     private static Singleton instance;
//     private static object _lock = new object();
//
//     private Singleton()
//     {
//         Console.WriteLine("Singleton constructor ishladi");
//     }
//
//     public static Singleton GetInstance()
//     {
//         if (instance == null)
//         {
//             lock (_lock)
//             {
//                 if (instance == null)
//                 {
//                     // Bu yerda thread collision ehtimolini oshirish uchun kutamiz
//                     Thread.Sleep(100);
//                     instance = new Singleton();
//                 }  
//             }
//         }
//         
//         
//         return instance;
//     }
// }
//
// class Singleton
// {
//     private static readonly Singleton instance = new Singleton();
//     private Singleton(){}
//
//     public static Singleton Instance => instance;
// }

//
// class Singleton
// {
//     private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
//     private Singleton() {}
//
//     public static Singleton Instance => instance.Value;
// }
//  
// class Program
// {
//     static void Main()
//     {
//         Singleton s1 = Singleton.Instance;
//         var obj = Activator.CreateInstance(typeof(Singleton), true);
//         Console.WriteLine(obj);
//     }
// }

// class Singleton
// {
//     private static Singleton instance;
//     private static object lockObj = new object();
//     private int counter = 0;
//     
//     private Singleton() {}
//
//     public static Singleton GetInstance()
//     {
//         if (instance == null)
//         {
//             lock (lockObj)
//             {
//                 if (instance == null) instance = new Singleton();
//             }
//         }
//
//         return instance;
//     }
//
//     public void Increment() => counter++;
//     public int Counter => counter;
// }
//
// class Singleton
// {
//     
//     private static readonly Singleton instance = new Singleton();
//     
//     private Singleton() => Console.WriteLine("Constructor called");
//
//     public static Singleton Instance => instance;
// }
//
// class Program
// {
//     static void Main()
//     {
//         var s1 = Singleton.Instance;
//         var s2 = (Singleton)Activator.CreateInstance(typeof(Singleton), true);
//         
//         Console.WriteLine(object.Equals(s1, s2));
//     }
// }

class BaseSingleton
{
    private static BaseSingleton instance = new BaseSingleton();
    
    protected BaseSingleton() {}
    public static BaseSingleton Instance => instance;
}

class DerivedSingleton : BaseSingleton
{
    private static DerivedSingleton _derivedSingleton = new DerivedSingleton();
    private DerivedSingleton() {}

    public static DerivedSingleton Instance => _derivedSingleton;
}