// // abstract class Animal
// // {
// //     // public Animal()
// //     // {
// //     //     Console.WriteLine("Ctor");
// //     // }
// //     // public abstract void Speak();
// //     public void Sleep() => Console.WriteLine("Sleeping...");
// // }
// //
// // // class Dog : Animal
// // // {
// // //     public override void Speak()
// // //     {
// // //         Console.WriteLine("Dog Barks");
// // //     }
// // // }
// //
// // class Program
// // {
// //     static void Main()
// //     {
// //         // Dog d = new Dog();
// //         // d.Speak();
// //         // d.Sleep();
// //
// //         Animal a = new Animal();
// //     }
// // }
// //
// // interface IPrinter
// // {
// //     void Print();
// // }
// //
// // interface IScanner
// // {
// //     void Print() {}
// // }
// //
// // class Document : IPrinter
// // {
// //     public void Print()
// //     {
// //         Console.WriteLine("Printing document...");
// //     }
// // }
// //
// // class Machine : IPrinter, IScanner
// // {
// //     void IPrinter.Print() => Console.WriteLine("Printer printing...");
// //     void IScanner.Print() => Console.WriteLine("Scanner scanning...");
// // }   
// //
// // class Program
// // {
// //     static void Main()
// //     {
// //         Machine m = new Machine();
// //         ((IPrinter)m).Print();
// //         ((IScanner)m).Print();
// //     }
// // }
//
// interface ILogger
// {
//     void Log(string message);
// }
//
// interface IFileLogger
// {
//     void Log(string message);
// }
//
// class Logger : ILogger, IFileLogger
// {
//     void ILogger.Log(string message) => Console.WriteLine("Console log: " + message);
//     void IFileLogger.Log(string message) => Console.WriteLine("File log: " + message);
// }
//
// class Program
// {
//     static void Main()
//     {
//         
//         ILogger consoleLogger = new Logger();
//         consoleLogger.Log("Hello");
//
//         IFileLogger fileLogger = new Logger();
//         fileLogger.Log("Hello");
//     }
// }

interface IPrinter
{
    void Print();
}

interface IScanner
{
    void Print();
}

class Document : IPrinter, IScanner
{
    // public void Print() => Console.WriteLine("Printing document");
    void IPrinter.Print() => Console.WriteLine("Printer printing...");
    void IScanner.Print() => Console.WriteLine("Scanner printing...");
}

class Program
{
    static void Main()
    {
        Document d = new Document();
        ((IPrinter)d).Print();
        ((IScanner)d).Print();
    }
}