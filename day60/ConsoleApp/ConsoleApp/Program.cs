// YAGNI VIOLATION
public class PaymentService
{
    public void Pay() => Console.WriteLine("Payment completed");
    public void Refund() => Console.WriteLine("Refund Completed");
    public void CryptoPayment() => Console.WriteLine("Crypto completed");
}


public class PaymentService2
{
    public void Pay() => Console.WriteLine("Payment completed");
}

// PREMATURE ABSTRACTION
public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine(message);
}

// Databaseda YAGNI
public class User
{
    public string Name { get; set; }
    public string FutureField1 { get; set; }
    public string FutureField2 { get; set; }
}

// Configlarda YAGNI
// {
//     "Reddis": {},
//     "RabbitMQ": {},
//     "Kafka": {}
// }

// {
//     "ConnectionString": ""
// }

// API designda YAGNI
// [HttpGet]
// [HttpPost]
// [HttpPut]
// [HttpDelete]


// Genericlarda YAGNI
// public class Repository<T>
// {
//     
// }

public class UserRepository
{}