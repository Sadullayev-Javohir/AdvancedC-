class Program
{
  static void Main()
  {
    var a = Get();
    var b = Get();

    Console.WriteLine(object.ReferenceEquals(a, b));

    string Get() => "hello";  
  }


}
