using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class Product
    {
        private string productName;
        private double price;
        private double quantity;

        public Product(string productName, double price, double quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }
        public string? ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public double SetPrice(double newPrice)
        {

            this.Price = newPrice;
            return newPrice;
        }
        public double ProductValue()
        {
            double totalvalue = price * quantity;
            return totalvalue;
        }


    }
}
