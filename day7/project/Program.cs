// class ManagedOnly
// {
//   public string Name {get;set;} = "Shalola";
// }

// class Program
// {
//   static void Main()
//   {
//     ManagedOnly obj = new ManagedOnly();
//     Console.WriteLine(obj.Name);
//   }
// }

using System;
using System.IO;

// class Program
// {
//   static void Main()
//   {
//     var fs = new FileStream("a.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

//     fs.Dispose();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     using (var fs = new FileStream("a.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
//     using (var writer = new StreamWriter(fs))
//     {
//       writer.WriteLine("Watch");
//     }
//   }
// }

using System;
using System.Net.Sockets;
using System.Text;

class Program
{
  static void Main()
  {
    using (var client = new TcpClient("example.com", 80))
    using (NetworkStream stream = client.GetStream())
    {
      string req = "Get / HTTP/1.1\r\nHost: example.com\r\nConnection: close\r\n\r\n";
      byte[] data = Encoding.ASCII.GetBytes(req);

      stream.Write(data, 0, data.Length);
    }
  }
}
