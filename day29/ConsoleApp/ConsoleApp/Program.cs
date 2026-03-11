// // public interface IDisposable
// // {
// //     void Dispose();
// // }
// //
// // class FileManager : IDisposable
// // {
// //     private FileStream file;
// //
// //     public FileManager()
// //     {
// //         file = new FileStream("data.txt", FileMode.OpenOrCreate);
// //     }
// //
// //     public void Dispose()
// //     {
// //         file.Close();
// //         file.Dispose();
// //         Console.WriteLine("Resurs yopildi");
// //     }
// // }
// //
// // class Program
// // {
// //     static void Main()
// //     {
// //         
// //         var manager = new FileManager();
// //         manager.Dispose();
// //     }
// // }
//
// // FileStream file = new FileStream("data.txt", FileMode.OpenOrCreate);
// //
// // try { }
// // finally
// // {
// //     if (file != null) file.Dispose();
// // }
//
// class ResourceHolder : IDisposable
// {
//     private bool disposed = false;
//
//     public void Dispose()
//     {
//         Dispose(true);
//         GC.SuppressFinalize(this);
//     }
//
//     protected virtual void Dispose(bool disposing)
//     {
//         if (disposed) return;
//         if (disposing)
//         {
//             // manage resource
//         }
//         // unmanaged resource
//         disposed = true;
//     }
//
//     ~ResourceHolder() => Dispose(false);
//     private IntPtr handle;
// }

using System.Runtime.InteropServices;

interface IDisposable
{
    void Dispose();
}

class MyResource : IDisposable
{
    private SafeHandle handle;

    public MyResource(SafeHandle handle) => this.handle = handle;
    public void Dispose()
    {
        handle?.Dispose();
    }
}