using System;

namespace Restaurant
{
    public class Server : Employee
    {
        private Order Order { get; set; }

        public void ReceiveOrder(Order order)
        {
            Order = order;
            Console.WriteLine("The server takes the order for OrderID: {0}, FoodName: {1}", order.OrderId, order.FoodName);
        }

        public Order PlaceOrder()
        {
            Console.WriteLine("The server places the order.");
            return Order;
        }

        public void ServeFood(Food food)
        {
            Console.WriteLine("The server has served the food: {0}", food.FoodName);
        }
    }
}
