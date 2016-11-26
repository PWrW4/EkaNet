using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_3_Homework_2
{
    class Point
    {

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Move(double z, double przesuniecie)
        {
            return (z + przesuniecie);
        }

        public void Show(double x, double y)
        {
            Console.WriteLine(Cords(x, y));
        }

        public string Cords(double x, double y)
        {
            string cordy = "polozenie punktu po przesunieciu: " + x + " " + y;

            return cordy;
        }
    }
}
