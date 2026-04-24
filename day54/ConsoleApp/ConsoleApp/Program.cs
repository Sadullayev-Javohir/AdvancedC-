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
//     private Socket _socket = new Socket();
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

interface IPowerSource
{
    void ProvidePower();
}

class Socket : IPowerSource
{
    public void ProvidePower() => Console.WriteLine("220V elektr uzatildi");
}

class Lamp
{
    private readonly IPowerSource _power;
    public Lamp(IPowerSource power) => _power = power;

    public void TurnOn()
    {
        _power.ProvidePower();
        Console.WriteLine("Chiroq yoqildi");
    }
}

class Program
{
    static void Main()
    {
        Socket socket = new Socket();
        Lamp lamp = new Lamp(socket);
        lamp.TurnOn();
    }
}