// class A
// {
//     public A(int x) { }
// }
//
// class B : A
// {
//     public B() : base(10)
//     {
//         
//     }
// }

// class A
// {
//     public int x = 5;
// }

// class A
// {
//     public int x = 5;
//     public int y;
//
//     public A()
//     {
//         x = 10;
//         y = 20;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var a = new A();
//         Console.WriteLine(a.x);
//         Console.WriteLine(a.y);
//     }
// }

// class A
// {
//     public A(int x) { Console.WriteLine(x); }
// }
//
// class B : A
// {
//     public B(int x) : base(x) { Console.WriteLine("B ctor"); }
// }
// class A
// {
//     private A() {Console.WriteLine("Private ctor");}
//     public static A Create() => new A();
// }

class A
{
    public int x = 5;

    public A()
    {
        x = 10;
    }
}

class B : A
{
    public B()
    {
        x = 20;
    }
}

class Program
{
    static void Main()
    {
        // var obj = A.Create();
        // var obj2 = new A();
        var b = new B();
        Console.WriteLine(b.x);
    }
} 
