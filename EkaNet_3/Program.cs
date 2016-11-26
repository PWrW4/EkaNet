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
            //CitizenFormater Formater = new CitizenFormater();

            //var citizen = new Citizen("Przemo", 0.10, 2000);
            //citizen.Income = 10;
            //citizen.TaxRate = 2;
            //citizen.Name = "Paweł";
            //Console.WriteLine(citizen.ToString());
            //Console.WriteLine(citizen.CalculateTax());
            //Console.WriteLine();

            //Console.WriteLine(CitizenFormater.Format(citizen));
            //Formater.Format(citizen);
            //var citizens = new List<Citizen>()
            //{
            //    new Citizen("Zdzisiek", 0.2, 1800),
            //    new Citizen("Michał", 0.2, 1800)
            //};

            //foreach (var cit in citizens)
            //{
            //    Console.WriteLine(CitizenFormater.Format(cit));
            //}

            Homework();

            Console.ReadKey();
        }


        public static void Homework()
        {
           bool continuum = true;
           var NewCitizens = new List<Citizen>();

            do
            {
                if (NewCitizens.Count!=0)
                {
                    foreach (var cit in NewCitizens)
                    {
                        Console.WriteLine(CitizenFormater.ShowCitizen(cit));
                    }
                }
                else
                {
                    Console.WriteLine("lista jest pusta");
                }

                Console.WriteLine("Wpisz 't' jeśli chcesz dodac citizena");

                if (Console.ReadLine()=="t")
                {
                    NewCitizens.Add(new Citizen(Console.ReadLine(),0.23,1800));
                }


                Console.WriteLine("jeśli chcesz zakonczyc program wpisz 'q'");
                if ((Console.ReadLine()) == "q")
                {
                    continuum = false;
                }
            } while (continuum);
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
