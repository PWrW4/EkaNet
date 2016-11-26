using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EkaNet_3_Homework
{
    class CitizenFormater
    {
        public static string Format(Citizen cit)
        {
            return "Citizen name: " + cit.Name + " Citizen Income: " + cit.Income + " Citizen Tax: " + cit.CalculateTax();
        }

        public static Citizen AddCitizen()
        {
            double taxrate = Double.Parse(Console.ReadLine());
            double income = Double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            
            return new Citizen(name,taxrate,income);
        }
    }
}
