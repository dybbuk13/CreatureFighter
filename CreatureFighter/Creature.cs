using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter
{
    public class Creature
    {
        /// <summary>
        /// 
        /// </summary>
        public string creatureName;
        /// <summary>
        /// 
        /// </summary>
        public int creatureHealth = RandomNumbers.GetRandomHealth();
        /// <summary>
        /// 
        /// </summary>
        public bool isAlive = true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Creature(string name)
        {
            this.creatureName = name;
        }
    }
}
