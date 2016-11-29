using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_4
{
    public interface IFigure
    {
        string Name { get; set; }
        int CalculateArea();
        void DisplayAreaInConsole();

    }
}
