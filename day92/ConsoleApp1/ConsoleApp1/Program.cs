class Program
{
    // static void Main()
    // {
    //     // Thread t = new Thread(() =>
    //     // {
    //     //     Console.WriteLine("Hello");
    //     // });
    //     //
    //     // t.Start();
    //
    //     // ThreadPool.QueueUserWorkItem(state =>
    //     // {
    //     //     Console.WriteLine($"THREAD ID: {Thread.CurrentThread.ManagedThreadId}");
    //     // });
    //
    //     // Task.Run(() =>
    //     // {
    //     //     Console.WriteLine("Hello");
    //     // });
    //
    //     // Task.Run(() =>
    //     // {
    //     //     long sum = 0;
    //     //     for (int i = 0; i < 1_000_000; i++)
    //     //     {
    //     //         sum += i;
    //     //     }
    //     //     
    //     //     Console.WriteLine(sum);
    //     // });
    //     // ThreadPool.GetMinThreads(
    //     //     out int worker,
    //     //     out int io);
    //     //
    //     // ThreadPool.SetMinThreads(
    //     //     workerThreads: 20,
    //     //     completionPortThreads: 20);
    //     //
    //     // Console.WriteLine(io);
    //     //
    // }

    static async Task Main()
    {
        
        string text = await File.ReadAllTextAsync("data.txt");
        Console.WriteLine(text);
        
        ThreadPool.GetAvailableThreads(
            out int worker,
            out int io);
        Console.WriteLine(io);
    }
}