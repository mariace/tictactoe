using System;



namespace tictactoe
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
        //fill the array 0-8
        public void fill() {
            for (int i = 0; i < 9; i++)
            {
                movement[i] = i.ToString();
            }
        }
        //this is the "board" 
        // 0|1|2
        // 3|4|5
        // 6|7|8
        public void print()
        {

            for (int i = 0; i < 7; i += 3)
            {
                Console.WriteLine(movement[i] + "  |  " + movement[i + 1] + "  |  " + movement[i + 2]);


            }

        }

        //this method draw the 'X' or 'O' in the board
        //and valid if the type number is valid or no and if the case is already taken
        public void game(String play) {
            Console.Clear();
            Console.WriteLine(play + " start");
            Console.WriteLine("Type the number where you like to put the symbol:");
            print();
            int number = Convert.ToInt32(Console.ReadLine());
            int flag=0;
            while (number < 0 || number > 8)
            {
                flag = 1;
                Console.WriteLine("Invalid number, try again");
                print();
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0 && number <= 8)
                {
                    while (movement[number].Equals("X") || movement[number].Equals("O"))
                    {
                        Console.WriteLine("This case is taken, choose another");
                        number = Convert.ToInt32(Console.ReadLine());
                       
                    }
                         movement[number] = play;
                }
               
            }
            if (flag != 1)
            {
                while (movement[number].Equals("X") || movement[number].Equals("O"))
                {
                    flag = 1;
                    if (flag==1)
                    {
                        
                        Console.WriteLine("This case is taken, choose another");
                        number = Convert.ToInt32(Console.ReadLine());
                        
                    }
                   
                }
                movement[number] = play;
            }
        }

        //this method say if the person who play first use th 'X' or 'O'
        public void symbol(int x) {
            if (x == 1 && player.getO()==0)
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

        //this method is tha validation of each space in the boad
        //tells who player winner
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

         

    
