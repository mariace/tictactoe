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
            // data.inputData();
            game.print();
           
        }
    }
}
