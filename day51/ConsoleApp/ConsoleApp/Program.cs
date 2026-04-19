// class PaymentService
// {
//     public void Pay(string type)
//     {
//         if (type == "Card") Console.WriteLine("Card payment");
//         else if (type == "Cash") Console.WriteLine("Cash payment");
//     }
// }

// interface IPayment
// {
//     void Pay();
// }
//
// class CashPayment : IPayment
// {
//     public void Pay() => Console.WriteLine("Naqd to'landi");
// }
//
// class CardPayment : IPayment
// {
//     public void Pay() => Console.WriteLine("Card orqali to'landi");
// }
//
// class PaymentService
// {
//     public void Process(IPayment payment) => payment.Pay();
// }
//
// class Program
// {
//     static void Main()
//     {
//         PaymentService service = new PaymentService();
//         service.Process(new CardPayment());
//         service.Process(new CashPayment());
//     }
// }

// interface IPrinter
// {
//     void Print();
// }
//
// class Document : IPrinter
// {
//     void IPrinter.Print() => Console.WriteLine("Printing...");
// }
//
// class Program
// {
//     static void Main()
//     {
//         IPrinter doc = new Document();
//         doc.Print();
//     }
// }

// class Order
// {
//     public List<OrderItem> Items;
//
//     public decimal GetTotal() => Items.Sum(i => i.Price * i.Quantity);
// }


// class Me
// {
//     public List<int> coins = new List<int>();
//     public double GetAverage() => coins.Average();
// }

// class Order
// {
//     public List<OrderItem> Items = new();
//
//     public void AddItem(string name, int qty, decimal price)
//     {
//         OrderItem item = new OrderItem(name, qty, price);
//         Items.Add(item);
//     }
// }
//
// class OrderItem
// {
//     public string Name;
//     public int Quantity;
//     public decimal Price;
//
//     public OrderItem(string name, int quantity, decimal price)
//     {
//         Name = name;
//         Quantity = quantity;
//         Price = price;
//     }
// }

// class BankController
// {
//     private BankService service = new BankService();
//     public void Withdraw(decimal amount) => service.Withdraw(amount);
// }
//
// class BankService
// {
//     public void Withdraw(decimal amount) => Console.WriteLine("Pul yechildi " + amount);
// }
//
// class Program
// {
//     static void Main()
//     {
//         BankController controller = new BankController();
//         controller.Withdraw(200); 
//     }
// }
//
// class GameController
// {
//     private Player _player = new Player();
//     public void Attack() => _player.Attack();
// }
//
// class Player
// {
//     public void Attack() => Console.WriteLine("Hujum qilindi");
// }

class B {}
//
// class A
// {
//     private B b = new();
// }

// interface INofitication
// {
//     void Send(string message);
// }
//
// class EmailNotification : INofitication
// {
//     public void Send(string msg) => Console.WriteLine("Email " + msg);
// }
//
// class SmsNotification : INofitication
// {
//     public void Send(string msg) => Console.WriteLine("Sms " + msg);
// }
//
// class UserService
// {
//     public void Register(string name, INofitication notification)
//     {
//         Console.WriteLine("user yaratildi " + name);
//         notification.Send("Xush kelibsiz: " + name);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         UserService userserv = new UserService();
//         userserv.Register("Javohir", new EmailNotification());
//     }
// }


interface INotification
{
    void Send(string msg);
}

class EmailNotification : INotification
{
    public void Send(string msg) => Console.WriteLine("Email " + msg);
}

class SmsNotification : INotification
{
    public void Send(string msg) => Console.WriteLine("SMS " + msg);
}

class UserService
{
    private readonly INotification _notification;
    public UserService(INotification _notification) => this._notification = _notification;

    public void Register(string name)
    {
        Console.WriteLine("User yaratildi: " + name);
        _notification.Send("Xush kelibsiz: " + name);
    }
}

class Program
{
    static void Main()
    {
        UserService usserv = new UserService(new EmailNotification());
        usserv.Register("Javohir");
        
    }
}