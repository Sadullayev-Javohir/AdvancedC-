// var total = price - (price * 0.1);
// var final = price - (price * 0.1);


// 1. Method Extraction
// Yomon:
// var total = price - (price * 0.1);
// var final = amount - (amount * 0.1);
//
// // Yaxshi
// decimal ApplyDiscount(decimal price) => price - (price * 0.1m);
//
// var total = ApplyDiscount(price);
// var final = ApplyDiscount(amount); 

// 2. Constants chiqarish
// Yomon: 
// price * 0.1
// salary * 0.1

// Yaxshi
// const decimal DiscountRate = 0.1m;
// price * DiscountRate;
// salary * DiscountRate;

// 3. Class yoki Service yaratish
// Yomon: Har joyda validation logic
// if (password.Length < 8)

// public class PasswordValidator
// {
//     public bool IsValid(string password) => password.Length >= 8;
// }
// validator.IsValid(password);

// REAL MISOL
// yomon:
if (user.Age >= 18)
if (customer.Age >= 18)
if (employee.Age >= 18)

// yaxshi: 
bool IsAdult(int age) => age >= 18;
IsAdult(user.Age);
IsAdult(employee.Age);
IsAdult(customer.Age);