using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            _windowsHeight = windowHight-2;
            _windowsWidth = windowsWidth;

            CreateCreatureList();
        }

        private void CreateCreatureList()
        {
            _creatureList = new List<Creature>();
            int amountofCreatures = _windowsHeight * _windowsWidth * 15 / 100;

            for (int i = 0; i < amountofCreatures / 3; i++)
            {
                _creatureList.Add(new Thief(_windowsHeight, _windowsWidth));
                _creatureList.Add(new Warrior(_windowsHeight, _windowsWidth));
                _creatureList.Add(new Wizzard(_windowsHeight, _windowsWidth));

            }

            foreach (var creature in _creatureList)
            {
                RandAndSetCoord(creature);
            }
            WriteWorldToConsole();
        }

        private void RandAndSetCoord(Creature creature)
        {
            int coordX, coordY;

            do
            {
                coordX = _rnd.Next(0, _windowsWidth);
                coordY = _rnd.Next(0, _windowsHeight);
            } while (_creatureList.Exists(x => x.XCoordinate == coordX && x.YCoordinate == coordY));

            creature.XCoordinate = coordX;
            creature.YCoordinate = coordY;
        }

        public void RunWorld()
        {
            WriteWorldToConsole();

            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                EditWorld();
            }

        }

        private void EditWorld()
        {
            foreach (var creature in _creatureList)
            {
                creature.Move();
                FightifConflict(creature);
            }

            RemoveDeadCreatures();
            WriteWorldToConsole();
            WriteStatsToConsole();

        }

        private void RemoveDeadCreatures()
        {
            var deadCollection = _creatureList.Where(x => x.IsAlive() == false).ToList();

            foreach (var deadCreature in deadCollection)
            {
                _creatureList.Remove(deadCreature);
            }

        }

        private void FightifConflict(Creature creature)
        {
            var CreatureToFight =
                _creatureList.FirstOrDefault(
                    x =>
                        creature.XCoordinate == x.XCoordinate && creature.YCoordinate == x.YCoordinate &&
                        x.GetType() != creature.GetType() && x.IsAlive());
            if (CreatureToFight != null)
            {
                Fight(creature,CreatureToFight);
            }

        }
        
        private void Fight(Creature creature, Creature creatureToFight)
        {
            while (creature.IsAlive() && creatureToFight.IsAlive())
            {
                creatureToFight.GetDamage(creature.Attack());
                creature.GetDamage(creatureToFight.Attack());
            }
        }

        private void WriteWorldToConsole()
        {
            foreach (var creature in _creatureList)
            {
                WriteCreatureToConsole(creature);
            }

            WriteStatsToConsole();

        }

        private void WriteStatsToConsole()
        {
            Console.CursorTop = Console.WindowHeight;
            Console.CursorLeft = 1;
            Console.ForegroundColor = ConsoleColor.White;
            int wizzardCount = _creatureList.Count(w => w.Symbol == 'W');
            int warriorCount = _creatureList.Count(r => r.Symbol == 'R');
            int thiefCount = _creatureList.Count(t => t.Symbol == 'T');
            Console.Write(
                $"W:  {wizzardCount}, R: {warriorCount}, T: {thiefCount}");
        }

        private void WriteCreatureToConsole(Creature creature)
        {
            Console.CursorTop = creature.YCoordinate;
            Console.CursorLeft = creature.XCoordinate;
            Console.ForegroundColor = creature.Color;
            Console.Write(creature.Symbol);
        }
    }
}
