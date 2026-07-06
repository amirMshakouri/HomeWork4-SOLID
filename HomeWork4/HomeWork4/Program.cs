using HomeWork4.Task7.Classes;
using HomeWork4.Task7.Interfaces;
using HomeWork4.Task7.Services;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product("Laptop", 10000000);

            IDiscount discount = new PercentageDiscount(15);

            
            // IDiscount discount = new FixedDiscount(5000000);  FOR FIXED DISCOUNT WITH NUMBER NOT PERCENTAGE 

            IEmailService emailService = new EmailService();

            Order order = new Order(discount, emailService);

            order.Buy(laptop, "Amir");
        }
    }
}
