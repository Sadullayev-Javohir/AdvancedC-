// // class Program
// // {
// //     static void ProcessOrder()
// //     {
// //         Console.WriteLine("Order started");
// //         
// //         // low-level detail
// //         var total = 0;
// //         foreach (var item in new int[] { 1, 2, 3 }) total += item;
// //         
// //         Console.WriteLine($"Total: {total}");
// //         Console.WriteLine("Order finished");
// //     }
// //     static void Main()
// //     {
// //         ProcessOrder();
// //     }
// // }
//
// class Program
// {
//     static void ProcessOrder()
//     {
//         PrintStart();
//         var total = CalculateTotal();
//         PrintTotal(total);
//         PrintEnd();
//     }
//
//     private static void PrintStart() => Console.WriteLine("Order started");
//     private static int  CalculateTotal()
//     {
//         int total = 0;
//         int[] items = { 1, 2, 3 };
//         foreach (var item in items)
//         {
//             total += item;
//         }
//
//         return total;
//     }
//
//     private static void PrintTotal(int total) => Console.WriteLine($"Total: {total}");
//     private static void PrintEnd() => Console.WriteLine("Order started");
//     static void Main()
//     {
//         ProcessOrder();
//     }
// }

class Program
{
    static void Main()
    {
        RegisterUser("Javohir", "javohir@");
    }
    // static void RegisterUser(string name, string email)
    // {
    //     if (string.IsNullOrEmpty(name)) throw new Exception("Name required");
    //     if (!email.Contains("@")) throw new Exception("Invalid email");
    //     Console.WriteLine("Saving user...");
    //     Console.WriteLine($"User {name} saved with email {email}");
    // }

    static void RegisterUser(string name, string email)
    {
        ValidateUser(name, email);
        SaveUser(name, email);
        NotifyUser(name);
    }

    private static void ValidateUser(string name, string email)
    {
        if (string.IsNullOrEmpty(name)) throw new Exception("Name required");
        if (!email.Contains("@")) throw new Exception("Invalid email");
    }

    private static void SaveUser(string name, string email)
    {
        Console.WriteLine("Saving user...");
        Console.WriteLine($"User {name} saved");
    }

    private static void NotifyUser(string name) => Console.WriteLine($"Notification sent to {name}");
}