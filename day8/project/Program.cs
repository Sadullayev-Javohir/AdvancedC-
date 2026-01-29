// using System.Reflection;

// Type t = typeof(User);

// var methods = t.GetMethods();

// // foreach (var method in methods)
// // {
// //     Console.WriteLine(method.Name);
// // }

// MethodInfo mi = t.GetMethod("Hello");
// mi.Invoke(obj, null);

// // Type t = typeof(User);
// // object obj = Activator.CreateInstance(t);

// Console.WriteLine(obj.GetType().Name);
// class User
// {
//   public void Hello()
//   {
//       Console.WriteLine("Hello, User!");
//   }

//   public void Goodbye()
//   {
//       Console.WriteLine("Goodbye, User!");
//   }
// }



using System.Reflection;

Type t = typeof(User);

Console.WriteLine(t.Name);
Console.WriteLine(t.Assembly.FullName);
Console.ReadLine();
class User
{
    public string Name { get; set; }
    public void SayHello() => Console.WriteLine("Hello");
}

