// class UI
// {
//     void OnClick()
//     {
//         Order order = new Order();
//         order.AddItem("Phone", 1);
//         order.CalculateTotal();
//         order.Save();
//     }
// }

// class OrderController
// {
//     public void CreateOrder(string product, int q)
//     {
//         Order order = new Order();
//         order.AddItem(product, q);
//         order.CalculateTotal();
//         order.Save();
//     }
// }
//
// class UI
// {
//     void OnBuyClick()
//     {
//         var controller = new OrderController();
//         controller.CreateOrder("Phone", 1);
//     }
// }

// class Kitchen
// {
//     public void Cook(string food)
//     {
//         Console.WriteLine($"{food} tayyorlanmoqda...");
//     }
// }
//
// class CustomUI
// {
//     public void OrderFood()
//     {
//         Kitchen kitchen = new Kitchen();
//         kitchen.Cook("Burger");
//     }
// }

// class Kitchen
// {
//     public void Cook(string food)
//     {
//         Console.WriteLine($"{food} tayyorlanmoqda...");
//     }
// }
//
// class WaiterController
// {
//     public void TakeOrder(string food)
//     {
//         Kitchen kitchen = new Kitchen();
//         
//         Console.WriteLine("Buyurtma qabul qilindi");
//         kitchen.Cook(food);
//     }
// }
//
// class CustomerUI
// {
//     public void OrderFood()
//     {
//         WaiterController waiter = new WaiterController();
//         waiter.TakeOrder("Burger");
//     }
// }

// class UI
// {
//     void OnBuyClick()
//     {
//         Order order = new Order();
//         order.AddItem("Phone", 1);
//         order.CalculateTotal();
//         order.Save();
//     }
//
// }

class OrderController
{
    public void CreateOrder(string product, int quantity)
    {
        Order order = new Order();
        order.AddItem(product, quantity);
        order.CalculateTotal();
        order.Save();
    }
}

class UI
{
    void OnBuyClick()
    {
        var controller = new OrderController();
        controller.CreateOrder("Phone", 1);
    }
}