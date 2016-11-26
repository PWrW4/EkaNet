using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_3_Homework_1
{
    class CitizenFormater
    {
        public static string ShowCitizen(Citizen cit)
        {
            return "Citizen name: "+ cit.Name+" Citizen income: "+cit.Income + " Citizen tax: "+cit.CalculateTax();
        }
    }
}
