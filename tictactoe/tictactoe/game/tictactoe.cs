using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.game
{
    class TicTacToe
    {
        private String column;
        private String row;
        int[,] movement = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int flag = 0;


        public void setColumn(String column) {
            this.column = column;
        }

        public String getColumn() {
            return this.column;
        }
        public void setRow(String row)
        {
            this.row = row;
        }

        public String getRow()
        {
            return this.row;
        }


        public void print()
        {

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
        public void game() {
            inputInformation player = new inputInformation();
            Console.WriteLine(player.getPlayerOne() + "start");
            Console.WriteLine("Type the row where you like to put the symbol:");
            setRow(Console.ReadLine());
            Console.WriteLine("Type the column where you like to put the symbol:");
            setColumn(Console.ReadLine());
            int answerOne = Convert.ToInt32(getRow());
            int answerTwo = Convert.ToInt32(getColumn());
            movement[answerOne,answerTwo];


        }
    }
}

         

    
