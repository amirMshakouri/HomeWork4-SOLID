using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task3
{

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int GetArea()
        {
            return Width * Height;
        }
    }
}

