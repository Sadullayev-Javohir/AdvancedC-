// class Database
// {
//     public void Save(string data) => Console.WriteLine("Saving data " + data);
// }
//
// class UserService
// {
//     private Database database = new Database();
//     public void Register(string name) => database.Save(name);
// }
//
// class Program
// {
//     static void Main()
//     {
//         UserService user = new UserService();
//         user.Register("Javohir");
//     }
// }

// interface IDataStorage
// {
//     void Save(string name);
// }
//
// class Database : IDataStorage
// {
//     public void Save(string name) => Console.WriteLine("Database " + name);
// }
//
// class ApiDatabase : IDataStorage
// {
//     public void Save(string name) => Console.WriteLine("Api " + name);
// }
//
// class UserService
// {
//     private IDataStorage storage;
//     public UserService(IDataStorage storage) => this.storage = storage;
//
//     public void Register(string name) => storage.Save(name);
// }
//
// class Program
// {
//     static void Main()
//     {
//         IDataStorage database = new Database();
//         UserService user1 = new UserService(database);
//         user1.Register("Javohir");
//
//         IDataStorage API = new ApiDatabase();
//         UserService user2 = new UserService(API);
//         user2.Register("Temur");
//     }
// }

// class A
// {
//     public int x = 10;
// }
//
// class B
// {
//     public void Test()
//     {
//         A a = new A();
//         a.x = 100;
//         Console.WriteLine(a.x);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         B b = new B();
//         b.Test();
//     }
// }

// static class Global
// {
//     public static int data;
// }
//
// class A
// {
//     public void Set() => Global.data = 10;
// }
//
// class B
// {
//     public void Print()
//     {
//         Console.WriteLine(Global.data);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         A a = new A();
//         a.Set();
//         B b = new B();
//         b.Print();
//     }
// }
//

// class Processor
// {
//     public void Process(int mode)
//     {
//         if (mode == 1) Console.WriteLine("Save to DB");
//         else if (mode == 2) Console.WriteLine("Save to file");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Processor pr = new Processor();
//         pr.Process(2);
//     }
// }

// class User
// {
//     public string Name;
//     public int Age;
//     public string Address;
// }
//
// class Service
// {
//     public void Save(User user) => Console.WriteLine("Name " + user.Name);
// }
//
// class Program
// {
//     static void Main()
//     {
//         Service service = new Service();
//         User user = new User();
//         service.Save(user);
//     }
// }


// 1. Content Coupling - Eng yomoni
// B class A ning ichki ma'lumotlarini to'g'ridan to'g'ri o'zgartirayapti. Bu encapsulationni buzadi.

// class A
// {
//     public int x = 10;
// }
//
// class B
// {
//     public void Test()
//     {
//         A a = new A();
//         a.x = 100;
//         Console.WriteLine(a.x);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         B b = new B();
//         b.Test();
//     }
// }

// 2. Common Coupling - Hamma class bitta global variable ishlatayapti
// static class Global
// {
//     public static int data;
// }
//
// class A
// {
//     public void SetData() => Global.data = 100;
// }
//
// class B
// {
//     public void Print() => Console.WriteLine(Global.data);
// }
//
// class Program
// {
//     static void Main()
//     {
//         A a = new A();
//         a.SetData();
//         B b = new B();
//         b.Print();
//     }
// }

// 3. Control Coupling. mode orqali boshqa classga nima qilishini buyuramiz. Yangi mode
// qo'shilsa - method o'zgaradi. Code kengayishga yopiq.

// class Processor
// {
//     public void Process(int mode)
//     {
//         if (mode == 1) Console.WriteLine("pdf yaratildi");
//         else Console.WriteLine("Excel yaratildi");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Processor pr = new Processor();
//         pr.Process(1);
//     }
// }

// 4. Stamp Coupling - Methodga keragidan ortiq katta object (butun class) uzatiladi
// lekin uning faqat bir qismi ishlatiladi.

// class User
// {
//     public string Name, Address;
//     public int Age;
// }
//
// class Service
// {
//     public void Save(User user)
//     {
//         Console.WriteLine(user.Name);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         User user = new();
//
//         user.Name = "Javohir";
//         user.Address = "Jizzakh";
//         user.Age = 20;
//
//         Service service = new Service();
//         service.Save(user);
//     }
// }
//

//5. Data Coupling - Class lar orasida faqat zarur bo'lgan
// oddiy ma'lumotlar uzatiladi
// class Service
// {
//     public void Save(string name) => Console.WriteLine(name);
// }
//
// class Program
// {
//     static void Main()
//     {
//         Service service = new Service();
//         service.Save("Javohir");
//     }
// }

// 6. Message Coupling
// Klasslar interface yoki abstraction orqali faqat xabar orqali aloqa qiladi.

interface ILogger
{
    void Log(string msg);
}

class File : ILogger
{
    public void Log(string msg) => Console.WriteLine("File " + msg);
}

class Db : ILogger
{
    public void Log(string msg) => Console.WriteLine("Db " + msg);
}

class Service
{
    private ILogger logger;
    public Service(ILogger logger) => this.logger = logger;

    public void Run() => logger.Log("Ishga tushdi");
}

class Program
{
    static void Main()
    {
        ILogger file = new File();
        Service servie = new Service(file);
        servie.Run();                                                                                                                                                                                                                                                                                                                                                                                                                                                          
    }
}                                                                                                                                                                                                                                                                     