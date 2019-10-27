using System;
using System.Collections.Generic;
using System.Text;

namespace Order_Composition_Csharp.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }

        public Client() {
        }

        public Client(string name, string email, DateTime bithDate) {
            Name = name;
            Email = email;
            BithDate = bithDate;
        }

        public override string ToString() {
            return "Client: " + Name + " (" + BithDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
