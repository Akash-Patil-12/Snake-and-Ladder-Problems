using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class Play
    {
        //variables
        int position = 0, dice, option;
        //constants
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, RESTART = 0, WIN = 100;
        /// <summary>
        /// Roll the dies till it reach 100 and add value according the option to position 
        /// </summary>
        public void Start()
        {
            while (position <= WIN)
            {
                Random random = new Random();
                dice = random.Next(1, 7);
                option = random.Next(0, 3);
                if (position < RESTART)
                    position = 0;
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
            }
            Console.WriteLine("Postion :" + position);
        }
    }
}
