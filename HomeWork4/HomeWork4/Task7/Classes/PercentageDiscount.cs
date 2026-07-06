using HomeWork4.Task7.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task7.Classes
{
    public class PercentageDiscount : IDiscount
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal ApplyDiscount(decimal price)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid discount percentage.");
                return price;
            }

            return price - (price * percentage / 100);
        }
    }
}