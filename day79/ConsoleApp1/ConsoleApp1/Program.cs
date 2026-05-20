// public class Bird
// {
//     public virtual void Fly() => Console.WriteLine("Flying");
// }
//
// public class Penguin : Bird
// {
//     public override void Fly()
//     {
//         throw new Exception("Penguin can't fly");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Bird bird = new Penguin();
//         bird.Fly();
//     }
// }

// public abstract class Bird {}
//
// public interface IFlyingBird
// {
//     void Fly();
// }
//
// public class Sparrow : Bird, IFlyingBird
// {
//     public void Fly() => Console.WriteLine("Flying");
// }
//
// public class Penguin : Bird {}

// class Program
// {
//     static void Main()
//     {
//         Bird sparrow = new Sparrow();
//         // ((IFlyingBird)sparrow).Fly();
//         // if (sparrow is IFlyingBird flying) flying.Fly();
//
//         List<Bird> birds = new()
//         {
//             new Sparrow(),
//             new Penguin()
//         };
//     }
// }

// public class PaymentService
// {
//     public virtual void pay(decimal amount) => Console.WriteLine("Paying... ");
// }
//
// public class CryptoPayment : PaymentService
// {
//     public override void pay(decimal amount) => Console.WriteLine("Crypto Payment");
// }
//
// public class CashPayment : PaymentService
// {
//     public override void pay(decimal amount)
//     {
//         throw new NotSupportedException("Cash payment not supported online");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         PaymentService paymentService = new CashPayment();
//         paymentService.pay(200);
//     }
// }

public interface IPaymentMethod
{
    void Pay(decimal amount);
}

public class CardPayment : IPaymentMethod
{
    public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} via Card");
}

public class CryptoPayment : IPaymentMethod
{
    public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} via Crypto");
}

public class CashPayment : IPaymentMethod
{
    public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} via Cash");
}

public class CheckoutService
{
    private readonly IPaymentMethod _payment;
    public CheckoutService(IPaymentMethod payment) => _payment = payment;

    public void Checkout(decimal total)
    {
        _payment.Pay(total);
    }
}

class Program
{
    static void Main()
    {
        IPaymentMethod payment = new CardPayment();
        var checkout = new CheckoutService(payment);
        checkout.Checkout(299);
    }
}