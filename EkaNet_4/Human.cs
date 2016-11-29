using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_4
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        protected void Sleep()
        {
            Console.WriteLine("sleeping");
        }

        public abstract void IntroduceYourself();
    }
}
