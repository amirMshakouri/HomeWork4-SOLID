using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task7.Classes
{
    public class Product
    {
        public string Name { get; }

        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
