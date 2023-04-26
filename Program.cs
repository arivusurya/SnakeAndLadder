using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeAndLadder{
    public class Program{
        public static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine(player.position);
        }
    }
}