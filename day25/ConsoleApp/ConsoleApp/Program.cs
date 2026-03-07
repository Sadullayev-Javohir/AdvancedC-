// class Person {}
//
// class  A
// {
//     public B b;
// }
//
// class B
// {
//     public C c;
// }
//
// class C {}
//
//     
//
// class Program
// {
//     static void Main()
//     {
//         Person p = new Person();
//
//         a = null;
//         A a = new A();
//         a.b = new B();
//         a.b.c = new C();
//     }
// }

// using System.Runtime.InteropServices;
//
// class Car{}
//
// class Program
// {
//     static void Main()
//     {
//         // Car car = new Car();
//         // GCHandle handle = GCHandle.Alloc(car);
//         byte[] buffer = new byte[100];
//         GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
//         WeakReference weak = new WeakReference(buffer);
//     }
//
//     static void Test()
//     {
//         Car car = new Car();
//     }
// }


class A
{
    public B b;
}

class B{}

class Program
{
    static A global = new A();

    static void Main()
    {
        B obj = new B();
        global.b = obj;
    }
}