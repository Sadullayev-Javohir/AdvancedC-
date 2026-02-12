class Program
{
  static void Main()
  {
    int x = 10;
    Foo(x);
  }

  static void Foo(int a)
  {
    int y = a + 5;
    Bar(y);
  }

  static void Bar(int b)
  {
    int z = b * 2;
    Console.WriteLine(z);
  }
}
