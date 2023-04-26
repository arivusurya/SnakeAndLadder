using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeAndLadder{
    public class Program{
        public static void Main(string[] args)
        {
            Board board = new Board();
            board.StartGame(board.player1,board.player2);
            
           
           
        }
    }
}