class Program
{
    static void Main()
    {
        object obj = new object();
        
        Console.WriteLine("Start: " + GC.GetGeneration(obj));
        
        GC.Collect(0, GCCollectionMode.Forced, blocking:true, compacting:true);
        
        Console.WriteLine("After Gen0 Collect: " + GC.GetGeneration(obj));
        
        GC.Collect(1, GCCollectionMode.Forced, blocking:true, compacting:true);
        Console.WriteLine("After Gen1 Collect: " + GC.GetGeneration(obj));
        
        GC.KeepAlive(obj);
        GC.Collect(2);
        
        Console.WriteLine(GC.CollectionCount(0));
        Console.WriteLine(GC.CollectionCount(1));
        Console.WriteLine(GC.CollectionCount(2));
        
        
        
    }
    
}