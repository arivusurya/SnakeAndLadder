using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeAndLadder{

    public class Board{
        
        public Player player1;
        public Player player2;
        public Board(){
            player1 = new Player();
            player1.name ="Player1";
            player2 = new Player();
            player2.name="Player2";
        }

        public void StartGame(Player player1 , Player player2){
            while (player1.position <100 && player2.position< 100){
                Console.WriteLine("No of Dice played : "+ player1.NoofDiceplayed);
                Console.WriteLine($"{player1.name} Position  : "+ player1.position);
                Console.WriteLine("No of Dice played : "+ player2.NoofDiceplayed);
                Console.WriteLine($"{player2.name} Position  : "+ player2.position);
                
                Play(player1);
                Play(player2);

                if(player1.position == 100){
                    Console.WriteLine($"{player1.name} win the Game");
                    break;
                }else if(player2.position == 100){
                    Console.WriteLine($"{player2.name} win the Game");
                    break;
                }else{
                    continue;
                }
                
            }
          
        }


        public  int Options(){
            Random rand = new Random();
            int option = rand.Next(0,3);
            return option;
        }
        public void Play(Player player){
            int option = Options();
            int diceNum = player.RoolDice();
            Console.WriteLine("Dice Num : "+ diceNum);
            if(option == 0){
                if(player.position + diceNum > 100){
                    Console.WriteLine("No possible moves");
                }else{
                Console.WriteLine("Using the ladder to move");
                player.position = player.position + diceNum;
                }
            }else if(option == 1){
                if(player.position - diceNum < 0){
                    Console.WriteLine("No Possible Moves");
                }else{
                Console.WriteLine("Oops Snakes!");
                player.position = player.position - diceNum;
                }
            }else{
                Console.WriteLine("No moves");
            }
        }

    }

}