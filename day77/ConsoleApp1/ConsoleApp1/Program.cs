// class Publisher
// {
//     public event EventHandler ProcessCompleted;
//
//     public void Start()
//     {
//         Console.WriteLine("Jarayon ishladi");
//         ProcessCompleted?.Invoke(this, EventArgs.Empty);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Publisher p = new Publisher();
//         p.ProcessCompleted += OnProcessCompleted;
//         p.Start();
//     }
//
//     static void OnProcessCompleted(object sender, EventArgs e)
//     {
//         Console.WriteLine("Event ishladi");
//     }
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
//         MessageSent?.Invoke(this, new MessageEventArgs
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
//
//         // p.MessageSent += OnMessageSent;
//         p.Send();
//     }
//
//     static void OnMessageSent(object sender, MessageEventArgs e)
//     {
//         Console.WriteLine(e.Message);
//     }
// }

// class UserService
// {
//     public void Register()
//     {
//     }
//
//     public void SaveToDatabase() {}
//     public void  SendWelcomeEmail() {}
// }

class UserService
{
    public void Register(){}
}

class DatabaseService
{
    public void SaveToDatabase() {}
}

class EmailService
{
    public void SendEmailService() {}
}


