// class PaymentService
// {
//     public void Pay(string type, int quantity)
//     {
//         if (type == "payme") Console.WriteLine("Payme orqali to'landi: " + quantity);
//         else if (type == "click" )Console.WriteLine("Click orqali to'landi: " + quantity);
//     }
// }
//
// class OrderService
// {
//     public void Checkout()
//     {
//         PaymentService paymentService = new PaymentService();
//         paymentService.Pay("click", 100);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         OrderService service = new OrderService();
//         service.Checkout();
//     }
// }

// interface IPayment
// {
//      void Pay(int amount);
// }
//
// class PaymePayment : IPayment
// {
//      public void Pay(int amount) => Console.WriteLine("Payme orqali: " + amount);
// }
//
// class ClickPayment : IPayment
// {
//      public void Pay(int amount) => Console.WriteLine("Click orqali: " + amount);
// }
//
// class OrderService
// {
//      private readonly IPayment _payment;
//      public OrderService(IPayment payment) => _payment = payment;
//
//      public void Checkout()
//      {
//           Console.WriteLine("Buyurtma yaratildi");
//           _payment.Pay(100);
//      }
// }
//
// class Program
// {
//      static void Main()
//      {
//           IPayment payment = new PaymePayment();
//           OrderService service = new OrderService(payment);
//           service.Checkout();
//      }
// }

//1.  Information Expert

// class Order
// {
//     public List<int> Prices = new();
//     public int GetTotal() => Prices.Sum();
// }

// class UniversityBank
// {
//     public List<int> Moneys = new();
//     public int GetTotal() => Moneys.Sum();
// }

// 2.  Creator

// YOMON USUL
// class Brick
// {
//     public string Type { get; set; }
//     public Brick(string type) => Type = type;
// }
//
// class Builder
// {
//     public void BuildWall()
//     {
//         Brick brick = new Brick("Qizil g'isht");
//         Console.WriteLine("Devor qurildi: " + brick.Type);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Builder builder = new Builder();
//         builder.BuildWall();
//     }
// }

// YAXSHI USUL
// class Brick
// {
//     public string Type { get; set; }
//     public Brick(string type) => Type = type;
// }
//
// class BrickFactory
// {
//     public Brick CreateBrick() => new Brick("Qizil g'isht");
// }
//
// class Builder
// {
//     private readonly BrickFactory _factory;
//     public Builder(BrickFactory factory) => _factory = factory;
//
//     public void BuildWall()
//     {
//         Brick brick = _factory.CreateBrick();
//         Console.WriteLine("Devor qurildi: " + brick.Type);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         BrickFactory factory = new BrickFactory();
//         Builder builder = new Builder(factory);
//         builder.BuildWall();
//     }
// }

// 3. Controller

// YOMON
// class Receptionist
// {
//     public void ReceivePatient(string name)
//     {
//         Console.WriteLine($"{name} qabul qilindi");
//         Console.WriteLine($"{name} ga dori yozildi");
//     }
// }
//

// YAXSHI
// class Doctor
// {
//     public void Treat(string patientName)
//     {
//         Console.WriteLine($"{patientName} tekshirildi");
//         Console.WriteLine($"{patientName} ga dori yozildi");
//     }
// }
//
// class Receptionist
// {
//     private readonly Doctor _doctor;
//     public Receptionist(Doctor doctor) => _doctor = doctor;
//
//     public void ReceivePatient(string name)
//     {
//         Console.WriteLine($"{name} qabul qilindi");
//         
//         _doctor.Treat(name);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Doctor doctor = new Doctor();
//         Receptionist receptionist = new Receptionist(doctor);
//         
//         receptionist.ReceivePatient("Ali");
//     }
// }

// 4. Low Coupling

// YOMON
// class Socket
// {
//     public void ProvideElectricity() => Console.WriteLine("220V elektr uzatildi");
// }
//
// class Lamp
// {
//     private readonly Socket _socket = new Socket();
//
//     public void TurnOn()
//     {
//         _socket.ProvideElectricity();
//         Console.WriteLine("Chiroq yoqildi");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Lamp lamp = new Lamp();
//         lamp.TurnOn();
//     }
// }

// YAXSHI

// interface IPowerSource
// {
//     void ProvideElectricity();
// }
//
// class Socket : IPowerSource
// {
//     public void ProvideElectricity() => Console.WriteLine("220 V ta'minlayapti");
// }
//
// class Lamp
// {
//     private readonly Socket _socket;
//     public Lamp(Socket socket) => _socket = socket;
//
//     public void TurnOn()
//     {
//         _socket.ProvideElectricity();
//         Console.WriteLine("Yondi");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Lamp lamp = new Lamp(new Socket());
//         lamp.TurnOn();
//     }
// }


// 5. High Cohesion

// YOMON
// class Cashier
// {
//     public void TakePayment(decimal amount) => Console.WriteLine($"To'lov olindi: {amount}");
//     public void CookFood() => Console.WriteLine("Ovqat tayyorlandi");
//     public void CleanShop() => Console.WriteLine("Dokon tozalandi");
// }


// YAXSHI
// class Cashier
// {
//     public void TakePayment(decimal amount)
//     {
//         Console.WriteLine($"To'lov olindi: {amount}");
//     }
//
//     public void GiveReceipt() => Console.WriteLine("Check chiqarildi");
// }

// 6. Polymorphism

// class Elevator
// {
//     public void Go(string type)
//     {
//         if (type == "Office") Console.WriteLine("3-qavatga chiqdi");
//         else if (type == "Hotel") Console.WriteLine("10-qavatga tushdi");
//         else if (type == "parking") Console.WriteLine("Parkinga tushdi");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Elevator elevator = new Elevator();
//         elevator.Go("Office");
//     }
// }

// YAXSHI

// interface IElevator
// {
//     void Go();
// }
//
// class OfficeElevator : IElevator
// {
//     public void Go() => Console.WriteLine("3-qavatga tushdi");
// }
//
// class HotelElevator : IElevator
// {
//     public void Go() => Console.WriteLine("10-qavatga tushdi");
// }
//
// class ParkingElevator : IElevator
// {
//     public void Go() => Console.WriteLine("Parkinga tushdi");
// }
//
// class Program
// {
//     static void Main()
//     {
//         IElevator elevator1 = new OfficeElevator();
//         elevator1.Go();
//     }
// }

// class Order
// {
//     public void Save() => Console.WriteLine("Bazaga saqlandi");
//     public void SendEmail() => Console.WriteLine("Email yuborildi");
//     public void Deliver() => Console.WriteLine("Yetkazib berildi");
// }

// class Order
// {
//     public int Id { get; set; }
//     public Order(int id) => Id = id;
// }
//
// class LogisticService
// {
//     public void Deliver(Order order) => Console.WriteLine($"Order #{order.Id} yetkazib berildi");
// }
//
// class EmailService
// {
//     public void Send(Order order) => Console.WriteLine($"Order #{order.Id} uchun email yuborildi");
// }
//
// class OrderRepository
// {
//     public void Save(Order order) => Console.WriteLine($"Order #{order.Id} bazaga saqlandi");
// }
//

// 8. Indirection
// YOMON
// class Friend
// {
//     public void Talk() => Console.WriteLine("Do'st bilan gaplashildi");
// }
//
// class Person
// {
//     public Friend _friend = new Friend();
//     public void Call() => _friend.Talk();
// }
//
// class Program
// {
//     static void Main()
//     {
//         Person p = new Person();
//         p.Call();
//     }
// }

// class Friend
// {
//     public void Talk() => Console.WriteLine("Do'st bilan gaplashildi");
// }
//
// class Operator
// {
//     private readonly Friend _friend;
//     public Operator(Friend friend) => _friend = friend;
//     public void ConnectCall()
//     {
//         Console.WriteLine("Operator qong'iroqni uladi");
//         _friend.Talk();
//     }
// }
//
// class Person
// {
//     private readonly Operator _operator;
//     public Person(Operator op) => _operator = op;
//
//     public void Call()
//     {
//         Console.WriteLine("Qo'ng'iroq qilinmoqda...");
//         _operator.ConnectCall();
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Person person = new Person(new Operator(new Friend()));
//         person.Call();
//     }
// }
//
// class Payme
// {
//     public void Pay(int amount) => Console.WriteLine("Payme orqali to'landi: " + amount);
// }
//
// class OrderService
// {
//     private Payme _payme = new Payme();
//     public void Checkout() => _payme.Pay(100);
// }
//


interface IPayment
{
    void Pay(int amount);
}

class Payme : IPayment
{
    public void Pay(int amount) => Console.WriteLine("Payme orqali: " + amount);
}

class Click : IPayment
{
    public void Pay(int amount) => Console.WriteLine("Click orqali: " + amount);
}

class OrderService
{
    private readonly IPayment _payment;
    public OrderService(IPayment payment) => _payment = payment;

    public void Checkout()
    {
        _payment.Pay(100);
    }
}

class Program
{
    static void Main()
    {
        // IPayment click = new Click();
        // OrderService orderService = new OrderService(click);
        // orderService.Checkout();
    }
}