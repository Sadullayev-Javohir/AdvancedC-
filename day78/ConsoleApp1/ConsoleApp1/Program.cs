// class DiscountCalculator
// {
//     public double GetDiscount(string type)
//     {
//         if (type == "student") return 10;
//         if (type == "vip") return 20;
//         return 0;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         DiscountCalculator dc = new DiscountCalculator();
//         Console.WriteLine(dc.GetDiscount("student"));
//     }
// }

// abstract class Discount
// {
//     public abstract double GetDiscount();
// }
//
// class StudentDiscount : Discount
// {
//     public override double GetDiscount()
//     {
//         return 10;
//     }
// }
//
// class VipDiscount : Discount
// {
//     public override double GetDiscount()
//     {
//         return 20;
//     }
// }
//
// class NewYearDiscount : Discount
// {
//     public override double GetDiscount()
//     {
//         return 30;
//     }
// }
//
// class DiscountService
// {
//     public double Calculate(Discount discount) => discount.GetDiscount();
// }
//
// class Program
// {
//     static void Main()
//     {
//         DiscountService dService = new DiscountService();
//         Console.WriteLine(dService.Calculate(new NewYearDiscount()));
//     }
// }

// abstract class Payment
// {
//     public abstract void Pay();
// }
//
// class ClickPayment : Payment
// {
//     public override void Pay() => Console.WriteLine("Click orqali to'lov");
// }
//
// class PaymePayment : Payment
// {
//     public override void Pay() => Console.WriteLine("Payme orqali to'lov");
// }
//
// class PaymentService
// {
//     public void Process(Payment payment) => payment.Pay();
// }
//
// class Program
// {
//     static void Main()
//     {
//         PaymentService ps = new PaymentService();
//         ps.Process(new ClickPayment());
//     }
// }

// abstract class Document
// {
//     abstract public void Report();
// }
//
// class PdfReport : Document
// {
//     public override void Report() => Console.WriteLine("Pdf report");
// }
//
// class ExcelReport : Document
// {
//     public override void Report() => Console.WriteLine("Excel report");
// }
//
// class ManageReport
// {
//     public void Execute(Document document) => document.Report();
// }
//
// class Program
// {
//     static void Main()
//     {
//         ManageReport mr = new ManageReport();
//         mr.Execute(new ExcelReport());
//     }
// }

