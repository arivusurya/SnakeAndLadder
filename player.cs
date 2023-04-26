using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeAndLadder{

    public class Player{
        
        public int position ;
        public int NoofDiceplayed;
        public string name ;

        public Player(){
            position = 0;
            NoofDiceplayed = 0;
        }

        public int RoolDice (){
            Random rand = new Random();
            NoofDiceplayed = NoofDiceplayed + 1;
            int DiceNUm = rand.Next(1,7);
            return DiceNUm;
        }
    }

}