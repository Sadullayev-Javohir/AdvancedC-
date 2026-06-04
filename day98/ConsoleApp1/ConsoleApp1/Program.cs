// Task task = new Task(() =>
// {
//     Console.WriteLine("Task ishlayapti");
// });
//
// task.Start();
//
// task.Wait();
// Console.WriteLine("Main tugadi");
//
// Task task = Task.Run(() =>
// {
//     Console.WriteLine("Ish bajarilmoqda...");
// });

// Task<int> task = Task.Run(() =>
// {
//     Task.Delay(2000).Wait();
//    return 19 + 20;
// });
//
// int result = task.Result;
// Console.WriteLine(result);

// Task t = Task.Run(() => {Console.WriteLine("salom");});

// int result = 0;
// Thread t = new Thread(() =>
// {
//     result = 10 + 20;
// });
// t.Start();
// Console.WriteLine(result);

// Task<int> task = Task.Run(() =>
// {
//    return 10 + 30;
// });
// int result = task.Result;
// Console.WriteLine(result);
//


// Task task = Task.Run(() =>
// {
//     Thread.Sleep(3000);
// });
// Console.WriteLine(task.IsCanceled);

// Task task = Task.Run(() =>
// {
//     throw new Exception("Xato");
// });
// class Program
// {
//     
//     static void Work1()
//     {
//         Thread.Sleep(3000);
//         Console.WriteLine("Work1 finished");
//     }
//
//     static void Work2()
//     {
//         Thread.Sleep(1000);
//         Console.WriteLine("Work2 finished");
//     }
//
//     static async Task Main()
//     {
//         Task t1 = Task.Run(() => Work1());
//         Task t2 = Task.Run(() => Work2());
//
//         await Task.WhenAll(t1, t2);
//
//         Console.WriteLine("All finished");
//     }
// }

// Task<int> t = Task.Run(() => 5);
// Console.WriteLine(t.Result);

async Task DoWorkAsync()
{
    await Task.Delay(2000);
    Console.WriteLine("Ish tugadi");
}

Task TASK = DoWorkAsync();
await TASK;