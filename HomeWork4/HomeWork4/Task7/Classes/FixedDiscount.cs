using HomeWork4.Task7.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task7.Classes
{
    public class FixedDiscount : IDiscount
    {
        private decimal amount;

        public FixedDiscount(decimal amount)
        {
            this.amount = amount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            if (amount > price)
            {
                Console.WriteLine("Discount amount is greater than product price.");
                return price;
            }

            return price - amount;
        }
    }

}
