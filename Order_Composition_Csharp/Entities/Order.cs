using System;
using Order_Composition_Csharp.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Order_Composition_Csharp.Entities {
    class Order {
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order() { }

        public Order(Client client, OrderStatus status) {
            Client = client;
            Date = DateTime.Now;
            Status = status;
        }

        public void AddItem(OrderItem orderItem) {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem) {
            Items.Remove(orderItem);
        }

        public double Total() {
            double sum = 0;
            foreach(OrderItem item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Date);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
