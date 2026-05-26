// using System;
// using System.Reflection;
//
// class User
// {
//     public string Name { get; set; }
//     public void Sayhello() => Console.WriteLine("Hello");
// }
//
// class Program
// {
//     static void Main()
//     {
//         Type type = typeof(User);
//         
//         Console.WriteLine(type.Name);
//
//         PropertyInfo[] properties = type.GetProperties();
//         foreach (var p in properties)
//         {
//             Console.WriteLine(p.Name);
//         }
//
//         MethodInfo[] methods = type.GetMethods();
//         foreach (var m in methods)
//         {
//             Console.WriteLine(m.Name);
//         }
//     }
// }

// Type type = typeof(ProductService);
//
// AuthorizeAttribute attr = (AuthorizeAttribute)Attribute.GetCustomAttribute(
//     type,
//     typeof(AuthorizeAttribute));
// Console.WriteLine(attr.Name);
//
// class AuthorizeAttribute : Attribute
// {
//     public string Name { get; set; }
//     public AuthorizeAttribute(string name) => Name = name;
// }
//
// [Authorize("Javohir")]
// [AttributeUsage(AttributeTargets.Method)]
// public class LogAttribute : Attribute
// {
//     
// }
// class ProductService{}


// [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
// public class TagAttribute : Attribute
// {
//     public string Name { get; set; }
//     public TagAttribute(string name) => Name = name;
// }
//
// [Tag("Backend")]
// [Tag("Api")]
// class UserService {}
//

//
// using System.ComponentModel.DataAnnotations;
//
// public class GmailAttribute : ValidationAttribute
// {
//     public override bool IsValid(object? value)
//     {
//         string email = value.ToString();
//         return email.EndsWith("@gmail.com");
//     }
// }
//
// public class UserDto
// {
//     [Gmail]
//     public string Email { get; set; }
// }

using System.ComponentModel.DataAnnotations;

public class GmailAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        string email = value.ToString();
        return email.EndsWith("@gmail.com");
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name} must be gmail";
    }
}
class Program
{
    [Log]
    public static void CreateOrder()
    {
    
    }}
[AttributeUsage(AttributeTargets.Method)]
public class LogAttribute : Attribute {}

