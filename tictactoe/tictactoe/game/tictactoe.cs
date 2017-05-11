using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.game
{
    class TicTacToe
    {
        public void print()
        {
            
            int[,] movement = new int[3, 3] { {1,2,3 }, {4,5,6 }, {7,8,9} };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("    " + movement[i,j]);

                }
                Console.WriteLine();
                Console.Read();

            }



        }
    }
}

         

    
