using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNet_5.Creatures
{
    public abstract class Creature
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public readonly char Symbol;
        public readonly ConsoleColor Color;
        protected int _health;
        public int _power;
        protected static Random _rnd = new Random();
        private int _xLimit;
        private int _yLimit;

        protected Creature(int xLimit, int ylimit, char symbol, ConsoleColor color)
        {
            _healyh = 100;
            _power = 10;
            _xLimit = xLimit;
            _yLimit = ylimit;
            Symbol = symbol;
            Color = color;
        }

        public void Move()
        {
            MoveX();
            MoveY();
        }

        private void MoveY()
        {
            var rnd = _rnd.NextDouble();
            if (rnd < 0.50)
            {
                if (YCoordinate < _xLimit)
                {
                    YCoordinate++;
                }
            }
            else
            {
                if (YCoordinate > 1)
                {
                    YCoordinate--;
                }
            }
        }

        private void MoveX()
        {
            var rnd = _rnd.NextDouble();
            if (rnd<0.50)
            {
                if (XCoordinate < _xLimit)
                {
                    XCoordinate++;
                }
            }
            else
            {
                if (XCoordinate>1)
                {
                    XCoordinate--;
                }
            }
        }

        public abstract int Attack();

        public virtual void GetDamage(int damage)
        {
            _healyh -= damage;
        }

        public bool IsAlive()
        {
            if (_healyh<=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
