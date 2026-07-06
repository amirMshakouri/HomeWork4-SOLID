using HomeWork4.Task7.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task7.Classes
{
        public class Order
        {
            private readonly IDiscount discount;
            private readonly IEmailService emailService;

            public Order(IDiscount discount, IEmailService emailService)
            {
                this.discount = discount;
                this.emailService = emailService;
            }

            public void Buy(Product product, string customerName)
            {
                decimal initialPrice = product.Price;

                decimal finalPrice = discount.ApplyDiscount(initialPrice);

                decimal discountAmount = initialPrice - finalPrice;

                decimal discountPercent = 0;

                if (initialPrice != 0)
                {
                    discountPercent = (discountAmount / initialPrice) * 100;
                }

                Console.WriteLine("========== Receipt ==========");
                Console.WriteLine("Product Name : " + product.Name);
                Console.WriteLine("Initial Price: " + initialPrice);
                Console.WriteLine("Discount Percentage: " + discountPercent + "%");
                Console.WriteLine("Discount Amount: " + discountAmount);
                Console.WriteLine("Final Price: " + finalPrice);
                Console.WriteLine("=============================");

                emailService.SendEmail(customerName);
            }
        }
    }



