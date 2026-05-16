// class Publisher
// {
//     public event Action Notify;
//
//     public void Start()
//     {
//         Console.WriteLine("Process started");
//         Notify.Invoke();
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//         p.Notify += Message;
//         
//         p.Start();
//     }
//
//     static void Message() => Console.WriteLine("Event ishladi");
// }

// class Test
// {
//     private Action handlers;
//     public event Action Notify
//     {
//         add
//         {
//             Console.WriteLine("Subscriber qo'shildi");
//             handlers += value;
//         }
//         remove
//         {
//             Console.WriteLine("Subscriber olib tashlandi");
//             handlers -= value;
//         }
//     }
//
//     public void Raise() => handlers.Invoke();
// }
//
// class Program
// {
//     static void Hello() => Console.WriteLine("Hello");
//     static void Main()
//     {
//         Test t = new Test();
//         t.Notify += Hello;
//         t.Raise();
//     }
// }

class BankAccount
{
    private Action lowBalanceHandlers;
    public event Action LowBalance
    {
        add
        {
            Console.WriteLine("Subcriber qo'shildi");
            lowBalanceHandlers += value;
        }
        remove
        {
            Console.WriteLine("Subscriber removed");
            lowBalanceHandlers -= value;
        }
    }

    private decimal balance = 1000;

    public void Withdraw(decimal amount)
    {
        balance -= amount;
        Console.WriteLine($"Balance: {balance}");
        
        if (balance < 200) lowBalanceHandlers.Invoke();
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.LowBalance += Warning;
        acc.Withdraw(801);
    }

    static void Warning() => Console.WriteLine("Low Balance");
}