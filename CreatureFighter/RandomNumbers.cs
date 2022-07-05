using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter
{
    public class RandomNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetRandomHealth()
        {
            Random rollNumber = new Random();
            int randomNumber = rollNumber.Next(1, 10) * 10;

            return randomNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetRandomAttack()
        {
            Random random = new Random();
            int randomAttack = random.Next(0, 50);

            return randomAttack;
        }
    }

    
}
