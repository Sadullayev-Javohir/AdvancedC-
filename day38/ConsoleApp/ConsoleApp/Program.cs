// class Animal
// {
//     public string Name = InitName();
//
//     public Animal() => Console.WriteLine("Animal constructor");
//
//
//     static string InitName()
//     {
//         Console.WriteLine("Static/Field Init for Animal");
//         return "Animal";
//     }
//
// }
//
// class Dog : Animal
// {
//     public string Breed = InitBreed();
//
//     public Dog() => Console.WriteLine("Dog constructor");
//
//     static string InitBreed()
//     {
//         Console.WriteLine("Static/Field Init for Dog");
//         return "Bulldog";
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Dog d = new Dog();
//         
//     }
// }

// class Base
// {
//     public int x = InitX();
//
//     public Base() => Console.WriteLine("Base Ctor");
//
//     static int InitX()
//     {
//         Console.WriteLine("Base Field");
//         return 1;
//     }
// }
//
// class Derived : Base
// {
//     public int y = InitY();
//     public Derived() => Console.WriteLine("Derived ctor");
//
//     static int InitY()
//     {
//         Console.WriteLine("Derived field");
//         return 2;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Derived b = new Derived();
//     }
// }


using System;
//
// class Parent
// {
//     public Parent()
//     {
//         Print(); // ⚠️ virtual method chaqirilmoqda
//     }
//
//     public virtual void Print()
//     {
//         Console.WriteLine("Parent Print");
//     }
// }
//
// class Child : Parent
// {
//     int x = 5;
//
//     public override void Print()
//     {
//         Console.WriteLine("Child Print: x = " + x);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Child c = new Child();
//     }
// }

// class Test
// {
//     public static int x = InitX();
//
//     static Test() => Console.WriteLine("Static ctor");
//
//     static int InitX()
//     {
//         Console.WriteLine("Static field init");
//         return 10;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Main");
//         var t1 = new Test();
//         var t2 = new Test();
//     }
// }

// class Test
// {
//     public int x = InitX();
//
//     public Test() => Console.WriteLine("Ctor");
//
//     static int InitX()
//     {
//         Console.WriteLine("Field init");
//         return 5;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var t = new Test();
//     }
// }

// class Base
// {
//     public Base() => Console.WriteLine("Base ctor");
// }
//
// class Derived : Base
// {
//     public int y = InitY();
//     public Derived() => Console.WriteLine("Derived ctor");
//
//     static int InitY()
//     {
//         Console.WriteLine("Derived field init");
//         return 10;
//     }
// }

using System;

// public class BaseClass
// {
//     public static int baseStaticField = Init("Ota klass: Statik Field");
//     public int baseField = Init("Ota klass: Oddiy Field");
//
//     static BaseClass() => Console.WriteLine("Ota klass: Statik Konstruktor");
//     public BaseClass() => Console.WriteLine("Ota klass: Oddiy Konstruktor");
//
//     public static int Init(string message)
//     {
//         Console.WriteLine(message);
//         return 0;
//     }
// }
//
// public class ChildClass : BaseClass
// {
//     public static int childStaticField = Init("Voris klass: Statik Field");
//     public int childField = Init("Voris klass: Oddiy Field");
//
//     static ChildClass() => Console.WriteLine("Voris klass: Statik Konstruktor");
//     public ChildClass() => Console.WriteLine("Voris klass: Oddiy Konstruktor");
// }
//
// class Program
// {
//     static void Main()
//     {
//         var obj = new ChildClass();
//     }
// }

class A
{
    public A() => Console.WriteLine("A Instance");
    static A() => Console.WriteLine("A static");
}

class B : A
{
    public B() => Console.WriteLine("B Instance");
    static B() => Console.WriteLine("B static");
}

class Program
{
    static void Main()
    {
        B b = new B();
    }
}