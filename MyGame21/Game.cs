using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame21
{
     public class Game
    {
        Random rnd = new Random();
        Player player = new Player();
        Bank bank = new Bank();
        Computer computer = new Computer();
        public int player_Score = 0,  comuter_score = 0;
        int bet = 10; // later you can change it 

        public int GetPlayerMoney()
        {
            return bank.player_Money;
        }

        public int GetComputerMoney()
        {
            return bank.computer_Money;
        }

        public void Play()
        {
            player.Take_Card(rnd);
            computer.Take_Card(rnd);

            if (!CheckScore())
            {    // if score > 21
                if (Loser())
                {
                    bank.player_Money -= 10;
                    bank.computer_Money += 10;
                }
                else
                {
                    bank.player_Money += 10;
                    bank.computer_Money -= 10;
                }

                comuter_score = 0; player_Score = 0;
            }
            else
            {

            }
        }

        public bool CheckScore()
        {

            player_Score += player.score_card;
            comuter_score += computer.score_card;

            if((player_Score>21) || (comuter_score > 21))
            {
                return false;
            }

            return true;
        }

        public bool Loser() // true =  player is loser, false  = comuter is loser
        {
            if (player_Score > 21) return true;
            else return false;
        }


        //When push Stop Game
        public void StopGame()
        {
            if (PlayerWin())
            {
                bank.player_Money += 10;
                bank.computer_Money -= 10;
            }
            else
            {
                bank.player_Money -= 10;
                bank.computer_Money += 10;
            }
            comuter_score = 0; player_Score = 0;
        }


        public bool PlayerWin()
        {
            if (player_Score > comuter_score) return true;
            else  return false;

        }
      
    }
}
