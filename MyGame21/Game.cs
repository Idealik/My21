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
        public int player_Score = 0,  computer_score = 0;
        int bet = 10; // later you can change it 
        bool firstTwoCard = true;

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

            if (firstTwoCard)
            {
                MethodForFirstTwoCard();
                firstTwoCard = false;
            }

            player.Take_Card(rnd);
            computer.Take_Card(rnd, computer_score);

            player_Score += player.score_card;
            computer_score += computer.score_card;

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

                computer_score = 0; player_Score = 0;
            }
            else
            {

            }
        }


        public void MethodForFirstTwoCard()
        {
            player.Take_Card(rnd);
            computer.Take_Card(rnd, computer_score);

            player_Score += player.score_card;
            computer_score += computer.score_card;
        }

        public bool CheckScore()
        {           
            if((player_Score>21) || (computer_score > 21))
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
            firstTwoCard = true;

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

            computer_score = 0; player_Score = 0;
        }


        public bool PlayerWin()
        {
            if (player_Score > computer_score) return true;
            else  return false;

        }
      
    }
}
