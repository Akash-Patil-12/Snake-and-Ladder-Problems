using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class Play
    {
        //variables
        int position = 0;
        //constants
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        /// <summary>
        /// Roll the dies and add value according the option to position 
        /// </summary>
        public void Start()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    position += dice;
                    break;
                case SNAKE:
                    position -= dice;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Postion :" + position);
        }
    }
}
