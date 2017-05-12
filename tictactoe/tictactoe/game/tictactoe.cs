using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tictactoe.game
{
    class TicTacToe
    { 

        private String playerOne;
        private String playerTwo; 
        String[] movement = new String[9];
        inputInformation player = new inputInformation();

    
        public TicTacToe()
        {
        }

        public void setPlayerOne(String _playerOne) {
            this.playerOne = _playerOne;
        }
        public String getPlayerOne() {
            return this.playerOne;
        }
        public void setPlayerTwo(String _playerTwo)
        {
            this.playerTwo = _playerTwo;
        }
        public String getPlayerTwo()
        {
            return this.playerTwo;
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
        public void game(String play) {

            Console.WriteLine(player.getPlayerOne() + " start");
            Console.WriteLine("Type the number where you like to put the symbol:" );
            print();
            int number = Convert.ToInt32(Console.ReadLine());
            movement[number] = play;
            print();
        }
        public void symbol() {
            if (player.getX() == 1 && player.getO()==0)
            {
                setPlayerOne("X");
                setPlayerTwo("O");
            }
            else
            {
                setPlayerOne("O");
                setPlayerTwo("X");
            }
        }
        public Boolean validation() {
            for (int i = 0; i < 7; i += 3)
            {
                if (movement[i].Equals(movement[i+1]) && movement[i+1].Equals(movement[i+2]))
                {
                     return true;
                }
            }
            if (movement[0].Equals(movement[4]) && movement[4].Equals(movement[8]))
            {
                return true;
            }
            if (movement[0].Equals(movement[3]) && movement[3].Equals(movement[6]))
            {
                return true;
            }
            if (movement[1].Equals(movement[4]) && movement[4].Equals(movement[7]))
            {
                return true;
            }
            if (movement[2].Equals(movement[5]) && movement[5].Equals(movement[8]))
            {
                return true;
            }
            if (movement[2].Equals(movement[4]) && movement[4].Equals(movement[6]))
            {
                return true;
            }
            return false;
        }

    }
}

         

    
