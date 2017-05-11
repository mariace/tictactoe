using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //data.inputData();
            //Console.Clear();
            game.print();
           
        }
    }
}
