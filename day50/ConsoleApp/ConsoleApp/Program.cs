// class BankAccount
// {
//     public string Name { get; set; }
//     public decimal Balance { get; private set; } 
//
//     public bool Canwithdraw(decimal amount) => Balance >= amount;
//
//     public bool Withdraw(decimal amount)
//     {
//         if (!Canwithdraw(amount)) return false;
//         Balance -= amount;
//         return true;
//     }
// }
//
// class Bank
// {
//     public void ProcessWithdraw(BankAccount account, decimal amount)
//     {
//         if (account.Withdraw(amount)) Console.WriteLine("Pul yechildi");
//         else Console.WriteLine("Balans yetarli emas");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Bank b = new Bank();
//         BankAccount a = new BankAccount();
//         b.ProcessWithdraw(a, 1999);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Order order = new Order();
//         OrderItem item = new OrderItem();
//         order.AddItem(item);
//     }
// }

// class Order
// {
//     private List<OrderItem> items = new List<OrderItem>();
//
//     public void AddItem(string name, int quantity)
//     {
//         OrderItem item = new OrderItem(name, quantity);
//         items.Add(item);
//     }
// }
//

// class UI
// {
//     void OnClick()
//     {
//         Order order = new Order();
//         order.AddItem("Phone", 1);
//         order.CalculateTotal();
//         order.Save();
//     }
// }

// class OrderController
// {
//     public void CreateOrder(string product, int quantity)
//     {
//         Order order = new Order();
//         order.AddItem(product, quantity);
//         order.CalculateTotal();
//         order.Save();
//     }   
// }
// class UI
// {
//     void OnClick()
//     {
//         OrderController controller = new();
//         controller.CreateOrder("Phone", 1);
//     }
// }
//

// class UserManager
// {
//     public void CreateUser() {}
//     public void SendEmail() {}
//     public void GenerateReport() {}
//     public void SaveToDatabase(){}
// }
//

class UserService
{
    public void CreateUser() {}
}

class EmailService
{
    public void SendEmail() {}
}

class ReportService
{
    public void GenerateReport(){}
}

class UserRepository
{
    public void Save() {}
}

