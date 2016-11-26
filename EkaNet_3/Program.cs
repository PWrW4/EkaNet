using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduceCollection();
            CitizenFormater Formater = new CitizenFormater();

            var citizen = new Citizen("Przemo",0.10,2000);
            //citizen.Income = 10;
            //citizen.TaxRate = 2;
            //citizen.Name = "Paweł";
            Console.WriteLine(citizen.ToString());
            Console.WriteLine(citizen.CalculateTax());
            Console.WriteLine();

            Console.WriteLine(CitizenFormater.Format(citizen));
            //Formater.Format(citizen);
            var citizens = new List<Citizen>()
            {
                new Citizen("zdzisiek", 0.2, 1800),
                new Citizen("michał", 0.2, 1800)
            };

            foreach (var cit in citizens)
            {
                Console.WriteLine(CitizenFormater.Format(cit));
            }
            
            Console.ReadKey();
        }


        
        public static void introduceCollection()
        {
            //Tablica
            int[] tablica = new int[5];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
                Console.WriteLine(tablica[i]);
            }
            Console.WriteLine();


            var names = new List<string> { "Przemo", "Marian" };

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
