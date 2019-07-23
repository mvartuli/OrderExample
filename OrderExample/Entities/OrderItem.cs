﻿using System.Globalization;
using System.Text;

namespace OrderExample.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product.Name);
            sb.Append(", $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal());

            return sb.ToString();
        }
    }
}
