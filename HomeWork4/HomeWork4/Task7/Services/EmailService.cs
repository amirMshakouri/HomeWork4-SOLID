using HomeWork4.Task7.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace HomeWork4.Task7.Services
    {
        public class EmailService : IEmailService
        {
            public void SendEmail(string customerName)
            {
                Console.WriteLine($"Verification email sent to {customerName}.");
            }
        }
    }

