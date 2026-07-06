using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task2
{

    public class Animal
    {
        public virtual void MakeSound()
        {
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }


    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Moo");
        }
    }



















    //public class Animal
    //{
    //    public string Type { get; set; }

    //    public void MakeSound()
    //    {                                           OCP Problem
    //        if (Type == "Cat")
    //        {
    //            Console.WriteLine("Meow");
    //        }
    //        else if (Type == "Dog")
    //        {
    //            Console.WriteLine("Woof");
    //        }
    //    }
    //}
}
