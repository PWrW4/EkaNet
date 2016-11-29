using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_4
{
    public class Rectangle : Figure
    {
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        

        public Rectangle(string fillColor, int firstSide, int secondSide) : base(fillColor)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;

        }

        public override void DisplayFillCollor()
        {
            Console.WriteLine("fillcolor of rectangle is: " + FillCollor);

        }
    }
}
