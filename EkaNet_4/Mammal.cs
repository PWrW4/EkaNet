using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_4
{
    public class Mammal
    {
        public string Sex { get; set; }
        public int LegCount { get; set; }
        

        public Mammal(string sex, int legCount)  //ctor(p) + tab
        {
            Sex = sex;
            LegCount = legCount;
        }

    }
}
