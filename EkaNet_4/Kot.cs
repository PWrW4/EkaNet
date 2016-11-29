using System;

namespace EkaNet_4
{
    public class Kot : Mammal
    {
        public string Name { get; set; }

        public Kot(string sex, int legCount, string name) : base(sex, legCount) //ctor(p) + tab
        {
            Name = name;
        }

        public void ShowKota()
        {
            Console.WriteLine("kot ma na imie "+ Name + " ma " + LegCount + " nogi i jest plci "+Sex);
        }

    }
}
