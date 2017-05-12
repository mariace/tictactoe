using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tictactoe.game;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            game.inputInformation data = new game.inputInformation();
            game.TicTacToe game = new game.TicTacToe();
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
