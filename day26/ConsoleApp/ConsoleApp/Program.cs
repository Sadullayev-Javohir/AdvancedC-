using System.Buffers;
using System.Runtime;

class Program
{
    static void Main()
    {
        // GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
        // GC.Collect();
        
        // ArrayPool<int>
        byte[] buffer1 = new byte[100000];

        var pool = ArrayPool<byte>.Shared;
        byte[] buffer = pool.Rent(100000);
        
        pool.Return(buffer);

    }
}