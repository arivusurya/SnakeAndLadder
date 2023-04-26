using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeAndLadder{

    public class Board{


        public int Options(){
            Random rand = new Random();
            int option = rand.Next(0,3);
            return option;
        }

    }

}