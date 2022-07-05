using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter
{
    internal class Creature
    {
        private int health = GetRandomHealth();
        public string creatureName;
        private bool isAlive = true;

        public Creature(string name)
        {
            this.creatureName = name;
        }

        public static void AttackCreature(string name, List<Creature> creatures)
        {
            Creature attackedCreature;
            int attackDamage = GetRandomAttack();
            foreach (Creature creature in creatures)
            {
                if(creature.creatureName == name && creature.isAlive != false)
                {
                    creature.health -= attackDamage;
                    Console.WriteLine($"You successfully dealt { attackDamage }.");
                    if (creature.health <= 0)
                    {
                        creature.isAlive = false;
                        Console.WriteLine($"Congrats! You killed {name}!");
                    }
                    return;
                }
            }
            Console.WriteLine($"{name} was not found.");
        }

        public static void ListAllCreatures(List<Creature> creatures)
        {
            creatures.ForEach(x => Console.WriteLine(x.creatureName));
        }

        public static void ListAliveCreatures(List<Creature> creatures)
        {
            List<Creature> aliveCreatures = new List<Creature>();
            foreach (Creature c in creatures)
            {
                if (c.isAlive != false)
                {
                    aliveCreatures.Add(c);
                }
            }
            aliveCreatures.ForEach(x => Console.WriteLine(x.creatureName));
        }

        private static int GetRandomAttack()
        {
            Random random = new Random();
            int randomAttack = random.Next(0, 50);

            return randomAttack;
        }

        private static int GetRandomHealth()
        {
            Random rollNumber = new Random();
            int randomNumber = rollNumber.Next(1, 10) * 10;

            return randomNumber;
        }
    }

    
}
