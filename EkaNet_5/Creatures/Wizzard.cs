using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_5.Creatures
{
    public class Wizzard : Creature
    {
        public Wizzard(int xLimit, int ylimit) : base(xLimit, ylimit, 'W', ConsoleColor.Cyan)
        {
        }

        public override int Attack()
        {
            MagicRegeneration();
            return _power;
        }

        private void MagicRegeneration()
        {
            _health++;
        }

        public override void GetDamage(int damage)
        {
            double immortalProbability = 0.5;

            if (_rnd.NextDouble() < immortalProbability)
            {
                ActivateMagicBarrier();
            }
            else
            {
                base.GetDamage(damage);
            }
        }

        private void ActivateMagicBarrier()
        {
        }
    }
}
