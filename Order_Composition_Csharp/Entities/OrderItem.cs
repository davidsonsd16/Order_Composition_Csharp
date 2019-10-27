﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Order_Composition_Csharp.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        //public OrderItem() { }

        public OrderItem(Product product, int quantity) {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal() {
            return Price * Quantity;
        }
        public override string ToString() {
            return Product.Name
                + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity
                + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
