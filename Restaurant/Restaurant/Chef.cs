using System;

namespace Restaurant
{
    public class Chef : Employee
    {
        private Order Order { get; set; }

        public void ReceiveOrder(Order order)
        {
            Order = order;
            Console.WriteLine("The chef is cooking Food: {0}", order.FoodName);
        }

        public Food Cook()
        {
            Console.WriteLine("The chef has cooked the food: {0}", Order.FoodName);
            Food food = new Food() { FoodName = Order.FoodName };
            return food;
        }
    }
}
