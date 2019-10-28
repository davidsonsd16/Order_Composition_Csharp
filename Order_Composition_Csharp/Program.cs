using System;
using System.Globalization;
using Order_Composition_Csharp.Entities;
using Order_Composition_Csharp.Entities.Enums;

namespace Order_Composition_Csharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(client, status);

            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numItems; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(product, quantity);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}
