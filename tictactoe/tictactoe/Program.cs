using System;


namespace tictactoe
{
    class Program : TicTacToe
    {
        static void Main(string[] args)
        {
            inputInformation data = new inputInformation();
            TicTacToe game = new TicTacToe();
            Console.Title = ("Tic Tac Toe"); 
            Console.WriteLine("Tic Tac Toe Game");
            data.inputData();
            game.print();
            while (game.validation() == false)
            {
                game.game(game.getPlayerOne());// is the symbol
                if (game.validation()==true)
                {
                    break;
                    game.game(game.getPlayerTwo());
                }

            }
            Console.Clear();
            game.print();
           
        }
    }
}
