// class Program
// {
//     public static int LengthOfLastWord(string s)
//     {
//         var count = 0;
//         string letters = null;
//         int i = s.Length - 1;
//         while (i >= 0 && s[i] == ' ') i--;
//         for (int j = i; j >= 0; j--) 
//         {
//             if (s[j] == ' ') break;
//             count++;
//         }
//
//         return count;
//     }
//     static void Main()
//     {
//         string s = "hELLO world  ";
//         Console.WriteLine(LengthOfLastWord(s));
//     }
// }

// class Test
// {
//     private Action Notify;
//
//     public void Add()
//     {
//         Notify += () => Console.WriteLine("Hello");
//     }
//
//     public void Run() => Notify.Invoke();
// }

// class Alarm
// {
//     private Action _notify;
//     public event Action Notify
//     {
//         add
//         {
//             Console.WriteLine("Subscriber qo'shildi");
//             _notify += value;
//         }
//         remove
//         {
//             Console.WriteLine("Subscriber o'chirildi");
//             _notify -= value;
//         }
//     }
//     public void Start() {
//         Console.WriteLine("Alarm ishladi");
//         _notify.Invoke();
//     }
//     
// }
//
// class Program
// {
//     static void Main()
//     {
//         Alarm alarm = new Alarm();
//         alarm.Notify += Message1;
//         alarm.Notify += Message2;
//         
//         alarm.Start();
//         alarm.Notify -= Message1;
//     }
//
//     static void Message1() => Console.WriteLine("Xabar 1");
//     static void Message2() => Console.WriteLine("Xabar 2");
// }

// class Publisher
// {
//     public event EventHandler ProcessCompleted;
//
//     public void Start()
//     {
//         Console.WriteLine("Jarayon ishladi");
//         ProcessCompleted.Invoke(this, EventArgs.Empty);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//         // p.ProcessCompleted +=
//
//         p.ProcessCompleted += OnProcessCompleted;
//         p.Start();
//     }
//
//     static void OnProcessCompleted(object sender, EventArgs e) => Console.WriteLine("Event ishladi");
// }

// class MessageEventArgs : EventArgs
// {
//     public string Message { get; set; }
// }
//
// class Publisher
// {
//     public event EventHandler<MessageEventArgs> MessageSent;
//
//     public void Send()
//     {
//         MessageSent.Invoke(this, new MessageEventArgs
//         {
//             Message = "Salom"
//         });
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//         p.MessageSent += OnMessageSent;
//         p.Send();
//     }
//
//     static void OnMessageSent(object sender, MessageEventArgs e)
//     {
//         Console.WriteLine(e.Message);
//     }
// }

// class Publisher
// {
//     public event EventHandler ProcessCompleted;
//
//     public void Start()
//     {
//         Console.WriteLine("Jarayon boshlandi");
//         ProcessCompleted?.Invoke(this, EventArgs.Empty);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//         p.ProcessCompleted += Method1;
//         
//         p.Start();
//     }
//
//     static void Method1(object sender, EventArgs e) => Console.WriteLine("Salom");
// }
//
// class MessageEventArgs : EventArgs
// {
//     public string Message { get; set; }
// }
//
// class Publisher : EventArgs
// {
//     public event EventHandler<MessageEventArgs> MessageSent;
//
//     public void Send()
//     {
//         MessageSent?.Invoke(this,
//             new MessageEventArgs{Message = "Salom"});
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//         p.MessageSent += Method;
//         p.Send();
//     }
//
//     static void Method(object sender, MessageEventArgs e) => Console.WriteLine(e.Message);
// }

// class Publisher
// {
//     public event EventHandler MyEvent;
//
//     public void RaiseEvent()
//     {
//         Console.WriteLine("Publisher ichida event chaqirildi");
//         var handler = MyEvent;
//         handler?.Invoke(this, EventArgs.Empty);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//
//         p.MyEvent += (sender, e) =>
//         {
//             Console.WriteLine("Event ishladi");
//         };
//         
//         p.RaiseEvent();
//     }
// }

class OrderEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public string Status { get; set; }
}

class OrderService
{
    public event EventHandler<OrderEventArgs> OrderCreated;

    public void CreateOrder(int orderId)
    {
        Console.WriteLine("Order yaratilmoqda...");
        OrderCreated?.Invoke(this, new OrderEventArgs
        {
            OrderId = orderId,
            Status = "Created"
        });
    }
}

class Program
{
    static void Main()
    {
        OrderService service = new OrderService();
        service.OrderCreated += LogOrder;
        service.OrderCreated += SendEmail;
        service.OrderCreated += ProcessPayment;
        service.CreateOrder(101);
    }

    static void LogOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"[LOG] Order {e.OrderId} created");
    }

    static void SendEmail(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"[Email] Order {e.OrderId} email yuborildi");
    }

    static void ProcessPayment(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"[PAYMENT] Order {e.OrderId} payment boshlandi");
    }
}