using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeAndLadder{

    public class Board{

        public void StartGame(Player player){
            while (player.position <100){
                Play(player);
            }
            Console.WriteLine("Player Win the game");
            Console.WriteLine("Player Position: " + player.position);
            player.position =0;
        }


        public  int Options(){
            Random rand = new Random();
            int option = rand.Next(0,3);
            return option;
        }
        public void Play(Player player){
            int option = Options();
            int diceNum = player.RoolDice();
            if(option == 0){
                if(player.position + diceNum > 100){
                    Console.WriteLine("No move possible moves");
                }else{
                Console.WriteLine("Using the ladder to move");
                player.position = player.position + diceNum;
                }
            }else if(option == 1){
                Console.WriteLine("Oops Snakes!");
                player.position = player.position - diceNum;
            }else{
                Console.WriteLine("No moves");
            }
        }

    }

}