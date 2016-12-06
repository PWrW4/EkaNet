using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_5.Creatures
{
    public class Thief : Creature
    {
        public Thief(int xLimit, int ylimit) : base(xLimit, ylimit, 'T', ConsoleColor.Yellow)
        {
            _power /= 2;
        }

        public override int Attack()
        {
            double probabilityForImmidiateKill = 0.2;

            if (_rnd.NextDouble()<probabilityForImmidiateKill)
            {
                return StabInTheBack();
            }
            else
            {
                return _power;
            }
        }

        private int StabInTheBack()
        {
            return Int32.MaxValue;
        }
    }
}
