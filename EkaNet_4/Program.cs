using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle("red", 3, 4);
            rectangle.DisplayFillCollor();

            

            //var Kotek = new Kot("męskiej",4,"Czarek");
            //Kotek.ShowKota();

            Console.ReadKey();
        }
    }
}
