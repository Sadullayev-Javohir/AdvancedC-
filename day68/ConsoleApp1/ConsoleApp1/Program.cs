// class Program
// {
//     public delegate void MyDelegate();
//
//     static void Hello() => Console.WriteLine("Hello");
//     static void Main()
//     {
//         MyDelegate del = Hello;
//         del();
//     }
// }

// class Test
// {
//     public void Show() => Console.WriteLine("Show");
// }
//
// class Program
// {
//     public delegate void MyDelegate();
//     static void Main()
//     {
//         Test t = new Test();
//         MyDelegate del = t.Show;
//
//         del.DynamicInvoke();
//     }
// }
//
// class Program
// {
//     public delegate void MyDelegate();
//
//     static void A() => Console.WriteLine("A");
//     static void B() => Console.WriteLine("B");
//     
//     static void Main()
//     {
//         MyDelegate del = A;
//         del += B;
//         
//         del.Invoke(); 
//     }
// }

// class Person
// {
//     public void Speak() => Console.WriteLine("Speaking");
// }
//
// class Program
// {
//     public delegate void MyDelegate();
//     static void Main()
//     {
//         Person p = new Person();
//         Action a = p.Speak;
//         a();
//     }
// }

// class Program
// {
//     static void Hello() => Console.WriteLine("Hello");
//
//     static void Main()
//     {
//         Action a = Hello;
//         a();
//     }
// }

// class Program
// {
//     static void A() => Console.WriteLine("A");
//     static void B() => Console.WriteLine("B");
//     static void C() => Console.WriteLine("C");
//
//     static void Main()
//     {
//         Action a = A;
//         a += B;
//         a += C;
//
//         a();
//     }
// }

// class Program
// {
//     public delegate void MyDelegate();
//     static void Main()
//     {
//         MyDelegate del = Hello;
//         del();
//     }
//
//     static void Hello() => Console.WriteLine("Hello");
// }

// class Test
// {
//     public void Show() => Console.WriteLine("Show");
// }
//
// class Program
// {
//     // public delegate void MyDelegate();
//     // static void Main()
//     // {
//     //     Test t = new Test();
//     //     MyDelegate del = t.Show;
//     //     del();
//     // }
//     
//     static void Add() => Console.WriteLine("Add");
//     public delegate void Operation();
//
//     static void Main()
//     {
//         Operation op = Add;
//         op();
//     }
// }

