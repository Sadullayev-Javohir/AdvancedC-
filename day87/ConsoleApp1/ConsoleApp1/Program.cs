using System.Reflection;

// class User
// {
//     public void SayHello() => Console.WriteLine("Hello");
// }
//
// class Program
// {
//     static void Main()
//     {
//         User user = new User();
//         Type type = typeof(User);
//         MethodInfo method = type.GetMethod("SayHello");
//         method.Invoke(user, null);
//     }
// }

// class Calculator
// {
//     public int Add(int a, int b) => a + b;
// }
//
// class Program
// {
//     static void Main()
//     {
//         Calculator calc = new Calculator();
//         Type type = typeof(Calculator);
//
//         MethodInfo method = type.GetMethod("Add");
//         object result = method.Invoke(calc, new object[] { 5, 3 });
//         Console.WriteLine(result);
//     }
// }

using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

// class Test
// {
//     public void Work()
//     {
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Test obj = new Test();
//
//         Stopwatch sw = new Stopwatch();
//
//         sw.Start();
//
//         for (int i = 0; i < 1000000; i++)
//         {
//             obj.Work();
//         }
//
//         sw.Stop();
//
//         Console.WriteLine($"Direct: {sw.ElapsedMilliseconds}");
//
//         Type type = typeof(Test);
//
//         MethodInfo method = type.GetMethod("Work");
//
//         sw.Restart();
//
//         for (int i = 0; i < 1000000; i++)
//         {
//             method.Invoke(obj, null);
//         }
//
//         sw.Stop();
//
//         Console.WriteLine($"Reflection: {sw.ElapsedMilliseconds}");
//     }
// }
//

//
// class Program
// {
//     static void Main()
//     {
//         AssemblyName assemblyName = new AssemblyName("MyAssembly");
//
//         AssemblyBuilder assemblyBuilder =
//             AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
//         ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
//
//         TypeBuilder typeBuilder = moduleBuilder.DefineType("MyClass", TypeAttributes.Public);
//
//         Type dynamicType = typeBuilder.CreateType();
//         Console.WriteLine(dynamicType.Name);
//     }
// }

using System;
using System.Reflection;
using System.Reflection.Emit;

// class Program
// {
//     static void Main()
//     {
//         AssemblyName assemblyName = new("DynamicAssembly");
//
//         AssemblyBuilder assemblyBuilder =
//             AssemblyBuilder.DefineDynamicAssembly(
//                 assemblyName,
//                 AssemblyBuilderAccess.Run);
//
//         ModuleBuilder moduleBuilder =
//             assemblyBuilder.DefineDynamicModule("MainModule");
//
//         TypeBuilder typeBuilder =
//             moduleBuilder.DefineType(
//                 "MyDynamicClass",
//                 TypeAttributes.Public);
//
//         MethodBuilder methodBuilder =
//             typeBuilder.DefineMethod(
//                 "Hello",
//                 MethodAttributes.Public,
//                 typeof(void),
//                 Type.EmptyTypes);
//
//         ILGenerator il = methodBuilder.GetILGenerator();
//
//         il.Emit(OpCodes.Ldstr, "Hello World");
//
//         il.Emit(OpCodes.Call,
//             typeof(Console).GetMethod(
//                 "WriteLine",
//                 new[] { typeof(string) }));
//
//         il.Emit(OpCodes.Ret);
//
//         Type type = typeBuilder.CreateType();
//
//         object obj = Activator.CreateInstance(type);
//
//         MethodInfo method = type.GetMethod("Hello");
//
//         method.Invoke(obj, null);
//     }
// }

using System;
using System.Reflection.Emit;

class Program
{
    static void Main()
    {
        DynamicMethod dm =
            new DynamicMethod(
                "Hello",
                null,
                Type.EmptyTypes);

        ILGenerator il = dm.GetILGenerator();

        il.Emit(OpCodes.Ldstr, "Dynamic Method");

        il.Emit(OpCodes.Call,
            typeof(Console).GetMethod(
                "WriteLine",
                new[] { typeof(string) }));

        il.Emit(OpCodes.Ret);

        var action =
            (Action)dm.CreateDelegate(typeof(Action));

        action();
    }
}