using System;
using Order_Composition_Csharp.Entities;

namespace Order_Composition_Csharp {
    class Program {
        static void Main(string[] args) {

            Client client = new Client("Davidson Dias", "davidsonsd16@gmail", DateTime.Parse("16/09/1995"));

            Console.WriteLine(client);
        }
    }
}
