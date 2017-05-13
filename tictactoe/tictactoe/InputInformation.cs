using System;


//in this class are the input information that put the gamers
// Name and the rol they want to choose X or O
namespace tictactoe
{
    class inputInformation
    {
        private String playerOne;
        private String playerTwo;
        private int x;
        private int o;

        //default constructor 
        public inputInformation()
        {
        }
        public void setPlayerOne(String _playerOne)
        {
            this.playerOne = _playerOne;
        }
        public String getPlayerOne()
        {
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

        public void setX(int _x) {
            this.x = _x;
        }

        public int getX() {
            return this.x;
        }

        public void setO(int _o) {
            this.o = _o;
        }

        public int getO() {
            return this.o;
        }


        //this method is just for input the necesary data
        public void inputData() {
            Console.WriteLine("Type the name of the Player One: ");
            setPlayerOne(Console.ReadLine());
            Console.WriteLine("Type the name of the Player Two: ");
            setPlayerTwo(Console.ReadLine());
            Console.WriteLine(getPlayerOne() + " If want to be the 'X' type 1 or if " + getPlayerOne() + " want to be the 'O' type 2");
            String answer = Console.ReadLine();
            while (answer!="1" || answer!="2")
            {
                if (answer.Equals("1") || answer.Equals("2"))
                {
                    break;
                }
                Console.WriteLine("Invalid option, try again");
                answer = Console.ReadLine();

            }



            if (answer.Equals("1"))
                {
                    setX(1);
                    setO(0);
                    Console.WriteLine(getPlayerOne() + " You be the 'X'");
                    Console.WriteLine(getPlayerTwo() + " You have to be the 'O'");
                    Console.ReadLine();
                }
                else
                {
                    setX(0);
                    setO(1);
                    Console.WriteLine(getPlayerOne() + " You be the 'O'");
                    Console.WriteLine(getPlayerTwo() + " You have to be the 'X'");
                    Console.ReadLine();

                }

            

            Console.WriteLine("Good Luck!! " + getPlayerTwo() + " and " + getPlayerOne());
            Console.ReadLine();

        }

    }
}
