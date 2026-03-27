// // class Singleton
// // {
// //     private static Singleton _instance;
// //     private Singleton() {}
// //
// //     public static Singleton Instance()
// //     {
// //         if (_instance == null) _instance = new Singleton();
// //         return _instance;
// //     }
// // }
//
// class Singleton
// {
//     private static readonly Singleton instance = new Singleton();
//     private Singleton() {}
//
//     public static Singleton Instance => instance;
// }
//
// public class Program
// {
//     static void Main()
//     {
//         Singleton s1 = Singleton.Instance;
//         Console.WriteLine(s1);
//     }
// }

// public class Person
// {
//     public string Name;
//     public int Age;
//
//     public Person() => Console.WriteLine("Default Constructor");
//
//     public Person(string name) : this()
//     {
//         Name = name;
//         Console.WriteLine("Constructor with name");
//     }
//
//     public Person(string name, int age) : this(name)
//     {
//         Age = age;
//         Console.WriteLine("Constructor with name and age");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var p = new Person("Ali", 25);
//     }
// }
//
// public class Animal
// {
//     public Animal() => Console.WriteLine("Animal constructor");
// }
//
// public class Dog : Animal
// {
//     // public Dog() : base() => Console.WriteLine("Dog constructor");
//     public Dog() => Console.WriteLine("Dog constructor");
// }
//
// class Program
// {
//     static void Main()
//     {
//         var d = new Dog();
//     }
// }

// public class A
// {
//     public A() => Console.WriteLine("A");
// }
//
// public class B : A
// {
//     public B() : base() => Console.WriteLine("B");
// }
//
// public class C : B
// {
//     public C() : base() => Console.WriteLine("C");
// }
//
// class Program
// {
//     static void Main()
//     {
//         var obj = new C();
//     }
// }

// public class Test
// {
//     public Test() => Console.WriteLine("1");
//
//     public Test(int x) : this() => Console.WriteLine("2");
//
//     public Test(int x, int y) : this(x) => Console.WriteLine("3");
// }

// public class A
// {
//     public A(string msg) => Console.WriteLine(msg);
// }
//
// public class B : A
// {
//     public B() : this("hello") => Console.WriteLine("B default");
//
//     public B(string msg) : base(msg) => Console.WriteLine("B param");
// }


// class Test
// {
//     public Test() {Console.WriteLine("1 ");}
//     public Test(int x) : this() {Console.WriteLine("2 ");}
//
// }

// class Test
// {
//     public Test() {Console.WriteLine("1 ");}
//     public Test(int x) : this() {Console.WriteLine("2 ");}
//     public Test(int x, int y) : this(x) {Console.WriteLine("3 ");}
// }

// class A
// {
//     public A() { Console.Write("A "); }
// }
//
// class B : A
// {
//     public B() : base() { Console.Write("B "); }
// }
//
// class C : B
// {
//     public C() : base() { Console.Write("C "); }
// }

// class A
// {
//     public A(string msg) { Console.Write(msg + " "); }
// }
//
// class B : A
// {
//     public B() : base("Hello") { Console.Write("B "); }
// }
//

// class Test
// {
//     public Test() { Console.Write("1 "); }
//     public Test(int x) : this() { Console.Write("2 "); }
//     public Test(int x, int y) : this(x) {Console.WriteLine("3 ");}
// }

// class A
// {
//     public A() { Console.Write("A "); }
// }
//
// class B : A
// {
//     public B(string msg) { Console.Write(msg); }
// }

// class A
// {
//     public A() { Console.Write("A "); }
// }
//
// class B : A
// {
//     public B() : this(5) { Console.Write("B "); }
//     public B(int x) { Console.Write("C "); }
// }
//
//

// class A
// {
//     public A() { Console.Write("A "); }
// }
//
// class B : A
// {
//     public B() { Console.Write("B "); }
//     public B(int x) : this() { Console.Write("C "); }
// }


// class A
// {
//     public A() { Console.Write("A "); }
// }
//
// class B : A
// {
//     public B() : base() { Console.Write("B "); }
// }
//
// class C : B
// {
//     public C() { Console.Write("C "); }
// }


class A
{
    public A() { Console.Write("A "); }
}

// class B : A
// {
//     public B() : this(5) { Console.Write("B "); }
//     public B(int x) : base() { Console.Write("C "); }
// }

class Test
{
    public Test() { Console.Write("1 "); }
    public Test(int x) : this() { Console.Write("2 "); }
}






class Program
{
    static void Main()
    {
        new Test(0);

    }       
}