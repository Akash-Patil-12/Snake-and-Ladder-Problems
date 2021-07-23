using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class Play
    {
        //variables
        int position = 0;
        /// <summary>
        /// Roll the dies and add value to position 
        /// </summary>
        public void Start()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            position += dice;
            Console.WriteLine("Postion :" + position);
        }
    }
}
