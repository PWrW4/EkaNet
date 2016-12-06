using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkaNet_5.Creatures;

namespace EkaNet_5
{
    public class World
    {
        private Random _rnd;
        private int _windowsHeight;
        private int _windowsWidth;
        private List<Creature> _creatureList;

        public World(int windowHight = 20, int windowsWidth = 40)
        {
            _rnd = new Random();
            Console.WindowHeight = windowHight;
            Console.WindowWidth = windowsWidth;

            _windowsHeight -= 1;
            _windowsWidth = windowsWidth;

            CreateCreatureList();
        }

        private void CreateCreatureList()
        {
            _creatureList = new List<Creature>();
            int amountofCreatures = _windowsHeight*_windowsWidth*15/100;

            for (int i = 0; i < amountofCreatures/3; i++)
            {
                _creatureList.Add(new Thief(_windowsHeight,_windowsWidth));
                _creatureList.Add(new Warrior(_windowsHeight, _windowsWidth));
                _creatureList.Add(new Wizzard(_windowsHeight, _windowsWidth));

            }

            foreach (var creature in _creatureList)
            {
                RandAndSetCoord(creature);
            }
        }

        private void RandAndSetCoord(Creature creature)
        {
            int coordX, coordY;

            do
            {
                coordX = _rnd.Next(0, +_windowsWidth);
                coordY = _rnd.Next(0, _windowsHeight);
            } while (_creatureList.Exists(x => x.XCoordinate == coordX && x.YCoordinate == coordY));

            creature.XCoordinate = coordX;
            creature.YCoordinate = coordY;
        }
    }
}
