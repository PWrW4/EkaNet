using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_4
{
    public class Figure : IFigure
    {
        public string FillCollor { get; set; }


        public Figure(string fillcolor)
        {
            FillCollor = fillcolor;
        }

        public virtual void DisplayFillCollor()
        {
            Console.WriteLine("fillcolor of figure is: "+FillCollor);
        }

        public string Name { get; set; }


        public int CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayAreaInConsole()
        {
            throw new NotImplementedException();
        }
    }
}
