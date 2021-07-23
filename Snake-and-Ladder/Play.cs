using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class Play
    {
        //variables
        int position = 0, dice, option, countDice = 0;
        //constants
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, RESTART = 0, WIN = 100, START = 0;
        /// <summary>
        /// Roll the dies till it reach exact postion = 100 and it also show count dice roll 
        /// </summary>
        public void Start()
        {
            Random random = new Random();
            while (true)
            {
                if (position == WIN)
                    break;
                if (position < RESTART)
                    position = START;
                dice = random.Next(1, 7);
                countDice++;
                option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if ((position + dice) <= 100)
                            position += dice;
                        break;
                    case SNAKE:
                        position -= dice;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Count dice is :" + countDice);
                Console.WriteLine("Postion :" + position);
            }
        }
    }
}
