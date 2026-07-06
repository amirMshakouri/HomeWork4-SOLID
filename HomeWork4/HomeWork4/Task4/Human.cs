using HomeWork4.Task4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task4
{
    public class Human : IWork , IEat
    {
        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }
    }
}
