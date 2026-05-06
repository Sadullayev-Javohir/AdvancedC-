// class Program
// {
//     static void A() => Console.WriteLine("Method A");
//     static void B() => Console.WriteLine("Method B");
//
//     delegate void MyDelegate();
//     static void Main()
//     {
//         MyDelegate d = A;
//         // d += B;
//         d = (MyDelegate)Delegate.Combine(d, new MyDelegate(B));
//         // d -= B;
//         d = (MyDelegate)Delegate.Remove(d, new MyDelegate(B));
//         d();
//     }
// }

// class Program
// {
//     delegate int Calc();
//
//     static int A()
//     {
//         return 10;
//     }
//
//     static int B()
//     {
//         return 20;
//     }
//
//     static void Main()
//     {
//         Calc d = A;
//         d += B;
//
//         Console.WriteLine(d());
//     }
// }

// class Program
// {
//     static void A() => Console.WriteLine("Method A");
//     static void B() => Console.WriteLine("Method B");
//
//     delegate void MyDelegate();
//     static void Main()
//     {
//         MyDelegate d = A;
//         // d += B;
//         d = (MyDelegate)Delegate.Combine(d, new MyDelegate(B));
//         // d -= B;
//         // d = (MyDelegate)Delegate.Remove(d, new MyDelegate(B));
//         d += B;
//         foreach (var item in d.GetInvocationList())
//         {
//             Console.WriteLine(item.Method.Name);
//         }
//         d();
//     }
// }


class Program
{
    static void Main()
    {
        Action log = null;
        log += () => Console.WriteLine("DB log");
        log += () => Console.WriteLine("File log");
        log += () => Console.WriteLine("Email log");

        log();
    }
}