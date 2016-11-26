using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_3_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework();
        }

        public static void Homework()
        {
            bool continuum = true;
            var NewCitizens = new List<Citizen>();

            do
            {
                if (NewCitizens.Count != 0)
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

                if (Console.ReadLine() == "t")
                {
                    NewCitizens.Add(new Citizen(Console.ReadLine(), 0.23, 1800));
                }


                Console.WriteLine("jeśli chcesz zakonczyc program wpisz 'q'");
                if ((Console.ReadLine()) == "q")
                {
                    continuum = false;
                }
            } while (continuum);
        }
    }
}
