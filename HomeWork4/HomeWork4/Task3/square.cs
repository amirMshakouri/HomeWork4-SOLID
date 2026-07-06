using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task3
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public override int GetArea()
        {
            return Side * Side;
        }
    }



    //public class Square : Rectangle
    //{
    //    public override int Width
    //    {
    //        set
    //        {
    //            base.Width = value;
    //            base.Height = value;
    //        }
    //    }
                                         
    //    public override int Height
    //    {
    //        set
    //        {
    //            base.Width = value;
    //            base.Height = value;
    //        }
    //    }
    //}
}
