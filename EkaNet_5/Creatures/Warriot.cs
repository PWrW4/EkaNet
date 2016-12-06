using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_5.Creatures
{
    public class Warrior : Creature
    {
        public Warrior(int xLimit, int ylimit) : base(xLimit, ylimit, 'R', ConsoleColor.White)
        {
            _health += 20;
        }

        public override int Attack()
        {
            AdrenalineRush();
            return _power;
        }

        private void AdrenalineRush()
        {
            _power = +3;
        }
    }
}
