// public class EmailSender
// {
//     public void Send(string message) => Console.WriteLine($"Email: {message}");
// }
//
// public class NotificationService
// {
//     private readonly EmailSender _emailSender;
//     public NotificationService() => _emailSender = new EmailSender();
//     public void Notify(string message) => _emailSender.Send(message);
// }
//
// class Program
// {
//     static void Main()
//     {
//         NotificationService service = new NotificationService();
//         service.Notify("Hello");
//     }
// }

// public interface IMessageSender
// {
//     void Send(string message);
// }
//
// public class EmailSender : IMessageSender
// {
//     public void Send(string message) => Console.WriteLine($"Email: {message}");
// }
//
// public class NotificationService
// {
//     private readonly IMessageSender _sender;
//     public NotificationService() => _sender = new EmailSender();
//     public void Notify(string message) => _sender.Send(message);
// }
//
// class Program
// {
//     static void Main()
//     {
//         NotificationService service = new NotificationService();
//         service.Notify("Hello");
//         
//     }
// }

// interface IMessageSender
// {
//     void Send(string message);
// }
//
// class Email : IMessageSender
// {
//     public void Send(string message) => Console.WriteLine(message);
// }
// class NotificationService
// {
//     private readonly IMessageSender _sender;
//     // public NotificationService() => _sender = new Email();
//     // public void Notify(string message) => _sender.Send(message);
//     public NotificationService(IMessageSender sender) => this._sender = sender;
//     public void Notify(string message) => _sender.Send(message);
// }
//
// class Program
// {
//     static void Main()
//     {
//         NotificationService service = new NotificationService(new Email());
//         service.Notify("Salom");
//     }
// }

using Microsoft.Extensions.DependencyInjection;

public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"Email: {message}");
}

class Program
{
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IMessageSender, EmailSender>();
        var provider = services.BuildServiceProvider();
        var a = provider.GetService<IMessageSender>();
        var b = provider.GetService<IMessageSender>();
        Console.WriteLine(a == b);
        // var sender = provider.GetRequiredService<IMessageSender>();
        // sender.Send("Salom");
    }
}