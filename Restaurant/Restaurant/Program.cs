namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order() { OrderId = 1, FoodName = "lasagna" };
            Server server = new Server() { EmployeeId = 1, EmployeeName = "Eunsaem" };
            Chef chef = new Chef() { EmployeeId = 2, EmployeeName = "Kurt"};
            Counter counter = new Counter();

            server.ReceiveOrder(order1);
            counter.order = server.PlaceOrder();
            chef.ReceiveOrder(counter.order);
            counter.food = chef.Cook();
            server.ServeFood(counter.food);
        }
    }
}
