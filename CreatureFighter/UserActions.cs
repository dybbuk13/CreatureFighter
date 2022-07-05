using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter
{
    public class UserActions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="creatures"></param>
        public static void AttackCreature(string name, List<Creature> creatures)
        {
            // TODO - Give creatures a chance to dodge, or users a chance to miss their attack.
            Creature attackedCreature;
            int attackDamage = RandomNumbers.GetRandomAttack();
            foreach (Creature creature in creatures)
            {
                if (creature.creatureName == name && creature.isAlive != false)
                {
                    creature.health -= attackDamage;
                    Console.WriteLine($"You successfully dealt {attackDamage}.");
                    if (creature.health <= 0)
                    {
                        creature.isAlive = false;
                        creatures.Remove(creature);
                        Console.WriteLine($"Congrats! You killed {name}!");
                    }
                    return;
                }
            }
            Console.WriteLine($"{name} was not found.");
        }

        // TODO - Add Swing Wildly action. User attacks a random creatures from the alive list.
        // (potential for higher crit chance and attack miss/creature dodge.)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creatures"></param>
        public static void ListAllCreatures(List<Creature> creatures)
        {
            creatures.ForEach(x => Console.WriteLine(x.creatureName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="creatures"></param>
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

    }
}
