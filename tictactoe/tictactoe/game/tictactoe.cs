using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.game
{
    class TicTacToe
    {
        private int column;
        private int row;
        String[] movement = new String[9];
        int flag = 0;


        public void setColumn(int column) {
            this.column = column;
        }

        public int getColumn() {
            return this.column;
}
        public void setRow(int row)
        {
            this.row = row;
        }

        public int getRow()
        {
            return this.row;
        }


        public void print()
        {
            for (int i = 0; i < 9; i++)
            {
                movement[i] = i.ToString();
            }
            for (int i = 0; i < 7; i+=3)
            {
                Console.WriteLine(movement[i] + "  |  " + movement[i+1] + "  |  " + movement[i + 2]);
                Console.ReadLine();

            }
            
        }
        public void game() {
            inputInformation player = new inputInformation();
            Console.WriteLine(player.getPlayerOne() + "start");
            Console.WriteLine("Type the number where you like to put the symbol:");
            int number = Convert.ToInt32(Console.ReadLine());
            movement[number] = player.getPlayerOne();

        }

        public void validation() {
            for (int i = 0; i < 7; i += 3)
            {
                if (true)
                {

                }
            }
        }

    }
}

         

    
