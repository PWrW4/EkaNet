using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_3_Homework_1
{
    public class Citizen
    {
        public string Name { get; set; } //prop + tab
        private double _taxRate;
        public double Income { get; set; }

        public Citizen(string name, double taxrate, double income)
        {
            Name = name;
            _taxRate = taxrate;
            Income = income;
        }

        public Citizen()
        {
            
        }

        public double CalculateTax()
        {
            return _taxRate*Income+10;
        }
    }
}
