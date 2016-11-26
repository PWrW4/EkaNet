using System;


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

        public void Move(double MoveX, double MoveY)
        {
            X += MoveX;
            Y += MoveY;
        }

        public void Show(double x, double y)
        {
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
        }

    }
}
