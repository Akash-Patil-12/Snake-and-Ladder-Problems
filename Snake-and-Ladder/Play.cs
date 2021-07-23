using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_and_Ladder
{
    class Play
    {
        //variables
        static int positionPlayer1 = 0;
        static int positionPlayer2 = 0;
        static int countDice = 0;
        //constants
        const int WIN = 100, NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        /// <summary>
        /// Randombly call Player 1 or 2 and display who won the game
        /// </summary>
        public void Start()
        {
            while (true)
            {
                Random random = new Random();
                int player = random.Next(1, 3);
                if (player == 1)
                    startPlayer1();
                else
                    startPlayer2();
                if (positionPlayer1 == WIN || positionPlayer2 == WIN)
                    break;
                
            }
            Console.WriteLine("position of player 1 :" + positionPlayer1);
            Console.WriteLine("position of player 2 :" + positionPlayer2);
            if (positionPlayer1 > positionPlayer2)
                Console.WriteLine("Player 1 is won");
            else
                Console.WriteLine("Player 2 is won");
        }
        /// <summary>
        /// Perform player 1 operation
        /// </summary>
        static void startPlayer1()
        {
            Random random = new Random();
            while (true)
            {
                int dice = random.Next(1, 7);
                countDice += 1;
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if ((positionPlayer1 + dice) <= 100)
                            positionPlayer1 += dice;
                        break;
                    case SNAKE:
                        positionPlayer1 -= dice;
                        break;
                    default:
                        break;
                }
                if (positionPlayer1 < 0)
                    positionPlayer1 = 0;
                Console.WriteLine("Dice 1 count to win the game is :" + countDice);
                Console.WriteLine("PostionPlayer1 :" + positionPlayer1);
                if(option!=1)
                break;
            }
        }
        /// <summary>
        /// perform player 2 operation
        /// </summary>
        static void startPlayer2()
        {
            Random random = new Random();
            while (true)
            {
                int dice = random.Next(1, 7);
                countDice += 1;
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if ((positionPlayer2 + dice) <= 100)
                            positionPlayer2 += dice;
                        break;
                    case SNAKE:
                        positionPlayer2 -= dice;
                        break;
                    default:
                        break;
                }
                if (positionPlayer2 < 0)
                    positionPlayer2 = 0;
                Console.WriteLine("Dice 2 count to win the game is :" + countDice);
                Console.WriteLine("PostionPlayer2 :" + positionPlayer2);
                if(option!=1)
                break;
            }
        }
    }
}