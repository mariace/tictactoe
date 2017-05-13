using System;


namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            inputInformation data = new inputInformation();
            TicTacToe game = new TicTacToe();
            Console.Title = ("Tic Tac Toe"); 
            Console.WriteLine("Tic Tac Toe Game");
            data.inputData();
            game.fill();
            game.symbol(data.getX());
            String playOne = game.getPlayerOne();
            String playTwo = game.getPlayerTwo();
             while (game.validation() == false)
                {
                    game.game(playOne);// is the symbol
                    if (game.validation() == false)
                    {
                        game.game(playTwo);
                    }
                    else
                    {
                    Console.WriteLine("You Win, Congrats!!");
                    Console.ReadLine()
                        break;
                        
                    }
                }
            }  
        }
    }

