// class User
// {
//     public void SaveToDatabase() {}
//     
//     public void SendEmail() {}
// }
//

// class User
// {
//     public string Name;
// }
//
// class UserRepository
// {
//     public void Save(User user) => Console.WriteLine($"{user.Name} saved to database");
// }
//
// class UserService
// {
//     private UserRepository repo;
//     public UserService(UserRepository repo) => this.repo = repo;
//
//     public void RegisterUser(User user)
//     {
//         Console.WriteLine("Validating user...");
//         repo.Save(user);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         User user = new User() { Name = "Javohir" };
//         UserService service = new UserService(new UserRepository());
//         service.RegisterUser(user);
//     }
// }

// class User
// {
//     public void Pay()
//     {
//         var payment = new PaymentSystem();
//         payment.ProcessPayment();
//     }
// }

// interface IPaymentGateway
// {
//     void ProcessPayment();
// }
//
// class PaymentService
// {
//     private readonly IPaymentGateway _gateway;
//     public PaymentService(IPaymentGateway gateway) => _gateway = gateway;
//     public void Pay() => _gateway.ProcessPayment();
// }
//
// class User
// {
//     private readonly PaymentService _paymentService;
//     public User(PaymentService paymentService) => _paymentService = paymentService;
//
//     public void Pay() => _paymentService.Pay();
// }

// class OrderRepository {}
// class OrderService
// {
//     private readonly OrderRepository _repo;
//     public OrderService(OrderRepository repo) => _repo = repo;
//
//     public void CreateOrder(string product, int quantity)
//     {
//         if (quantity <= 0) throw new Exception("Quantity noto'g'ri");
//
//         var totalPrice = quantity * 100;
//         Console.WriteLine($"Order yaratildi: {product}, {totalPrice}");
//         _repo.Save(product, quantity);
//     }
// }
//
//










// INDIRECTION
// 1. Service 

// Controller ->  Service -> Repository
//Repository
// class OrderRepository
// {
//     public void Save(string order) => Console.WriteLine("Saved to DB: " + order);
// }
//
// // Service
// class OrderService
// {
//     private readonly OrderRepository _repo;
//     public OrderService(OrderRepository _repo) => this._repo = _repo;
//
//     public void CreateOrder(string order)
//     {
//         Console.WriteLine("Business logic ishladi");
//         _repo.Save(order);
//     }
// }
//
// //Controller
// class OrderController
// {
//     private readonly OrderService _orderService;
//     public OrderController(OrderService _orderService) => this._orderService = _orderService;
//
//     public void Create()
//     {
//         _orderService.CreateOrder("Book");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         var orderRepo = new OrderRepository();
//         var orderServ = new OrderService(orderRepo);
//         var controller = new OrderController(orderServ);
//         controller.Create();
//     }
// }

// 2.Repository - Service va Database orasidagi vositachi
// Serivce -> Repository -> DB

// class UserRepository
// {
//     public string GetUser() => "User from DB";
// }
//
// class UserService
// {
//     private readonly UserRepository _repo;
//     public UserService(UserRepository repo) => this._repo = repo;
//
//     public void PrintUser() => Console.WriteLine(_repo.GetUser());
// }
//
// class Program
// {
//     static void Main()
//     {
//         UserRepository repo = new UserRepository();
//         UserService service = new UserService(repo);
//         service.PrintUser();
//         
//     }
// }

// 3.Mediator  - ko'p classlar o'rniga bitta markaz
// A, B, C -> Mediator

// class Mediator
// {
//     public void Send(string message, Colleague sender)
//     {
//         if (sender is UserA) Console.WriteLine("UserB ga yuborildi: " + message);
//         else Console.WriteLine("UserA ga yuborildi: " + message);
//     }
// }
//
// class Colleague
// {
//     protected Mediator mediator;
//     public Colleague(Mediator mediator) => this.mediator = mediator;
// }
//
// class UserA : Colleague
// {
//     public UserA(Mediator m): base(m){}
//     public void Send(string msg) => mediator.Send(msg, this);
//     
// }
//
// class UserB : Colleague
// {
//     public UserB(Mediator m) : base(m) {}
//     public void Send(string msg) => mediator.Send(msg, this);
// }
//
// class Program
// {
//     static void Main()
//     {
//         UserA userA = new UserA(new Mediator());
//         userA.Send("Laptop");
//         
//     }
// }

interface INewPayment
{
    void Pay();
}

class OldPaymentSystem
{
    public void MakePayment() => Console.WriteLine("Old System Payment");
}

class PaymentAdapter : INewPayment
{
    private OldPaymentSystem _old;
    public PaymentAdapter(OldPaymentSystem old) => _old = old;

    public void Pay() => _old.MakePayment();
}

class Program
{
    static void Main()
    {
        INewPayment payment = new PaymentAdapter(new OldPaymentSystem());
        payment.Pay();
    }
}