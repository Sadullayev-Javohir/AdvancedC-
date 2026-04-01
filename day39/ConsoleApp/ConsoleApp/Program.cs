// class Program
// {
//     static void Main()
//     {
//         Print(5);
//     }
//
//     static void Print(double x) => Console.WriteLine($"Double: {x}");
// }
//
// class Animal
// {
//     public virtual void Speak() => Console.WriteLine("Animal make sound");
// }
//
// class Dog : Animal
// {
//     public new void Speak() => Console.WriteLine("Dog barks");
// }
//
// class Program
// {
//     static void Main()
//     {
//         Animal a = new Dog();
//         a.Speak();
//     }
// }

// class A
// {
//     public void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public new void Show() => Console.WriteLine("B");
// }
//
// class Program
// {
//     static void Main()
//     {
//         A obj = new B();
//         obj.Show();
//     }
// }


// class Animal
//
// {
//     public virtual void Speak() => Console.WriteLine("Animal make sound");
// }
//
// class Dog : Animal
// {
//     public override void Speak() => Console.WriteLine("Dog barks");
// }
//
// class Program
// {
//     static void Main()
//     {
//         List<Animal> animals = new List<Animal>()
//         {
//             new Dog(),
//             new Animal()
//         };
//
//         foreach (var a in animals)
//         {
//             a.Speak();
//         }
//     }
// }
//


// class A
// {
//     public void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public new void Show() => Console.WriteLine("B");
// }


// class Test
// {
//     public void Print(int x) => Console.WriteLine("int");
//     public void Print(double x) => Console.WriteLine("double");
// }



//
// class  Program
// {
//     // static void Print(byte x) { Console.WriteLine("double"); }
//     //
//     
//     static void Show(double x) { }
//     // void Show(double x, int y) { }
//
//     
//     static void Main()
//     {
//         Show(5);
//     }
// }

// class A
// {
//     public virtual void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public override void Show()
//     {
//         base.Show();
//         Console.WriteLine("B");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         B b = new B();
//         b.Show();
//     }
// }

// class A
// {
//     public virtual void Show() { }
// }
//
// class B : A
// {
//     public sealed override void Show() { }
// }
//
// class C : B
// {
//     public override void Show() { } // ❓
// }

// class A
// {
//     public virtual void Show(int x)
//     {
//         Console.WriteLine("A int");
//     }
// }
//
// class B : A
// {
//     public void Show(double x)
//     {
//         Console.WriteLine("B double");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new B();
//         obj.Show(5);
//     }
// }
// class A
// {
//     public void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public void Show() => Console.WriteLine("B");
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new B();
//         obj.Show();
//     }
// }


// class A
// {
//     public virtual void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public override void Show() => Console.WriteLine("B");
// }
//
// class C : B
// {
//     public override void Show() => Console.WriteLine("C");
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new B();
//         obj.Show();
//     }
// }

// class A
// {
//     public A()
//     {
//         Show();
//     }
//
//     public virtual void Show()
//     {
//         Console.WriteLine("A");
//     }
// }
//
// class B : A
// {
//     private int x = 10;
//
//     public override void Show()
//     {
//         Console.WriteLine(x);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var obj = new B();
//     }
// }
// class A
// {
//     public virtual void Foo() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public override void Foo() => Console.WriteLine("B");
// }
//
// class C : B
// {
//     public new void Foo() => Console.WriteLine("C");
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new C();
//         obj.Foo();
//     }
// }


// class Parent
// {
//     public void Greet()
//     {
//         Console.WriteLine("Hello from Parent");
//     }
// }
//
// class Child : Parent
// {
//     public new void Greet()
//     {
//         Console.WriteLine("Hello from Child");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Parent p = new Child();
//         p.Greet();  // Hello from Parent ❌ (parent qaraladi)
//
//         Child c = new Child();
//         c.Greet();  // Hello from Child ✅   
//     }
// }

// class Base
// {
//     public virtual void Print() => Console.WriteLine("Base");
// }
//
// class Derived : Base
// {
//     public override void Print() => Console.WriteLine("Derived");
// }
//
// class Program
// {
//     static void Main()
//     {
//         Base b = new Derived();
//         Derived d = (Derived)b;
//         d.Print();  
//     }
// }

// class BankAccount
// {
//     private double balance = 1000;
//
//     public void Withdraw(double amount)
//     {
//         if (amount <= balance)
//             balance -= amount;
//     }
//
//     public double GetBalance() => balance;
// }
//
// class  Program
// {
//     static void Main()
//     {
//         
//         BankAccount acc = new BankAccount();
//         acc.Withdraw(200);
//         Console.WriteLine(acc.balance); // ❓
//     }
// }

// class A
// {
//     protected int x = 10;
// }
//
// class B : A
// {
//     public void PrintX() => Console.WriteLine(x);
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         B obj = new B();
//         obj.PrintX();
//     }
// }

// interface IShape
// {
//     void Draw();
// }
//
// abstract class Shape : IShape
// {
//     public abstract void Draw();
//     public void Move() => Console.WriteLine("Moving shape");
// }
//
// class Circle : Shape
// {
//     public override void Draw() => Console.WriteLine("Drawing circle");
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         Shape s = new Circle();
//         s.Draw();
//         s.Move();
//     }
// }

// interface IA { void Foo(); }
// interface IB { void Foo(); }
//
// class C : IA, IB
// {
//     public void Foo() => Console.WriteLine("C Foo");
// }
//
// class Program
// {
//     static void Main()
//     {
//         C obj = new C();
//         ((IA)obj).Foo();
//         ((IB)obj).Foo();
//     }
// }

// class A
// {
//     public virtual void Show(int x) => Console.WriteLine("A int");
//     public void Show(double x) => Console.WriteLine("A double");
// }
//
// class B : A
// {
//     public override void Show(int x) => Console.WriteLine("B int");
//     public void Show(float x) => Console.WriteLine("B float");
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new B();
//         obj.Show(5); // ❓
//     }
// }


// class Base
// {
//     public virtual void Print() => Console.WriteLine("Base");
// }
//
// class Derived : Base
// {
//     public new void Print() => Console.WriteLine("Derived");
// }
//
// class Program
// {
//     static void Main()
//     {
//         Base b = new Derived();
//         b.Print(); // ❓
//     }
// }
//
// class A
// {
//     public virtual void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public override void Show() => Console.WriteLine("B");
// }
//
// class C : B
// {
//     public override void Show() => Console.WriteLine("C");
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new C();
//         obj.Show(); // ❓
//     }
// }

// class A
// {
//     public A() { Print(); }
//     public virtual void Print() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     private int x = 10;
//     public override void Print() => Console.WriteLine(x);
// }
//
// class Program
// {
//     static void Main()
//     {
//         B obj = new B();
//     }
// }

// class A
// {
//     public virtual void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public override void Show() => Console.WriteLine("B");
// }
//
// class C : B
// {
//     public new void Show() => Console.WriteLine("C");
// }
//
// class Program
// {
//     static void Show(object x) => Console.WriteLine("object");
//     static void Show(int x) => Console.WriteLine("int");
//
//    
//     
//     static void Main()
//     {
//         int a = 5;
//         Show(a);
//     }
// }

// interface ITest
// {
//     void Show();
// }
//
// class A
// {
//     public void Show() => Console.WriteLine("A");
// }
//
// class B : A, ITest
// {
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         B obj = new B();
//         obj.Show();
//     }
// }

// interface ITest
// {
//     void Show();
// }
//
// class A : ITest
// {
//     void ITest.Show()
//     {
//         Console.WriteLine("Interface");
//     }
//
//     public void Show()
//     {
//         Console.WriteLine("Public");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         A obj = new A();
//         obj.Show();
//         ((ITest)obj).Show();
//     }
// }

// class A
// {
//     public A()
//     {
//         Print();
//     }
//
//     public virtual void Print()
//     {
//         Console.WriteLine("A");
//     }
// }
//
// class B : A
// {
//     private string message = "Hello";
//
//     public override void Print()
//     {
//         Console.WriteLine(message.Length);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         new B();
//     }
// }

// class A
// {
//     public virtual void Show() => Console.WriteLine("A");
// }
//
// class B : A
// {
//     public override void Show() => Console.WriteLine("B");
// }
//
// class Program
// {
//     static void Main()
//     {
//         A obj1 = new B();
//         B obj2 = new B();
//
//         obj1.Show();
//         obj2.Show();
//     }
// }

// interface IA { void Show(); }
// interface IB { void Show(); }
//
// class C : IA, IB
// {
//     public void Show()
//     {
//         Console.WriteLine("C");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         IA c = new C();
//         c.Show();
//     }
// }

// class Person
// {
//     private int age;
//
//     public void SetAge(int value)
//     {
//         if (value > 0) age = value;
//     }
// }

// class Animal
// {
//     public void Eat() => Console.WriteLine("Eating...");
// }
//
// class Dog : Animal
// {
//     public void Bark() => Console.WriteLine("Barking");
// }

class Engine
{
    public void Start() => Console.WriteLine("Engine started");
}

class Car
{
    private Engine _engine = new Engine();

    public void StartCar()
    {
        _engine.Start();
        Console.WriteLine("Car is running");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.StartCar();
    }
}