// interface IAnimal
// {
//     void Speak();
// }
//
// class Dog : IAnimal
// {
//     public void Speak()
//     {
//         Console.WriteLine("Woof");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Dog d = new Dog();
//         d.Speak();
//     }
// }

// public class BankAccount
// {
//     private decimal _balance;
//
//     public decimal Balance => _balance;
//
//     public void Deposit(decimal amount)
//     {
//         if (amount <= 0) throw new ArgumentException("Amount must be positive");
//         _balance += amount;
//     }
//
//     public void Withdraw(decimal amount)
//     {
//         if (amount <= 0) throw new ArgumentException("Invalid amount");
//         if (amount > _balance) throw new InvalidOperationException("Not enough balance");
//
//         _balance -= amount;
//     }
// }

// class Person
// {
//     private string _name;
//
//     public string Name
//     {
//         get => _name;
//         set => _name = value ?? throw new ArgumentNullException(nameof(value));
//     }
// }

// class Base
// {
//     int x = InitX();
//
//     static int InitStatic() { Console.WriteLine("Static Base"); return 0; }
//     static int s = InitStatic();
//
//     public Base()
//     {
//         Console.WriteLine("Base ctor");
//     }
//
//     static int InitX()
//     {
//         Console.WriteLine("Instance Base");
//         return 1;
//     }
// }
//
// class Derived : Base
// {
//     int y = InitY();
//
//     public Derived()
//     {
//         Console.WriteLine("Derived ctor");
//     }
//
//     static int InitY()
//     {
//         Console.WriteLine("Instance Derived");
//         return 2;
//     }
// }

class Base
{
    public Base()
    {
        Console.WriteLine("Base ctor");
    }
}

class Derived : Base
{
    int x = Init();

    static int Init()
    {
        Console.WriteLine("Field init");
        return 1;
    }

    public Derived()
    {
        Console.WriteLine("Derived ctor");
    }
}

class Program
{
    static void Main()
    {
        Base d = new Derived();
    }
}