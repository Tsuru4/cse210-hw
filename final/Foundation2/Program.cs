using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders= new List<Order>();
        orders.Add(new Order("Bruce Wayne", "1224 E 7th street", "Gothan", "Alaska", "United States of America"));
        orders.Add(new Order("Harry Potter", "123 E Diagon Alley", "London", "England", "Great Britain"));
        orders[0].AddProduct("Grappling Belt", "BWI3942", 4000, 3);
        orders[0].AddProduct("Mask", "BWI2820", 3000, 12);
        orders[0].AddProduct("Batmobile", "BWI4295", 1450000000, 2);
        orders[1].AddProduct("Yew Wand", "OW0023", 10000, 1);
        orders[1].AddProduct("Nimbus 3000","HQS7000", 90000, 2);
        orders[1].AddProduct("Jelly Beans (32 oz)","JB0034", 2, 30);

        foreach (Order order in orders)
        {
            Console.WriteLine("\n\tNew Order:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total cost: {order.CalculateCost()}");
        }
    }
}