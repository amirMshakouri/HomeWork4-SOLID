using HomeWork4.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task5
{
    public class Fan : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is ON");
        }
    }
}
