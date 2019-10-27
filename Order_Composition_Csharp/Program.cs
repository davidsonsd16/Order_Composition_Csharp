using System;
using Order_Composition_Csharp.Entities;

namespace Order_Composition_Csharp {
    class Program {
        static void Main(string[] args) {

            Client client = new Client("Davidson Dias", "davidsonsd16@gmail.com", DateTime.Parse("16/09/1995"));

            Console.WriteLine(client);

            Product product = new Product("TV", 1000.00);
            OrderItem orderItem = new OrderItem(product, 4);

            Console.WriteLine(orderItem);

            product.Price = 1200.00;

            Console.WriteLine(product);
            Console.WriteLine(orderItem);
        }
    }
}
