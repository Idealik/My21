﻿using System;

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
        bool firstTwoCard = true, compDontStop = true;

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
            player_Score += player.score_card;

            int tmp = computer.Take_Card(rnd, computer_score);
            if (tmp == 0) compDontStop = false;

            if (player.IsItWin())
            {
                PlayerGatMoney();
                NewPartForNumbers();
                return;
            }

            if (computer.IsItWin())
            {
                ComputerGetMoney();
                NewPartForNumbers();
                return;
            }

            if (compDontStop)
            {
                computer_score += tmp;
            }

            if (!CheckScore())
            {    // if score > 21
                if (Loser())
                {
                    ComputerGetMoney();
                }
                else
                {
                    PlayerGatMoney();
                }

                NewPartForNumbers();
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
        public bool StopGame()
        {
            firstTwoCard = true;

            if(computer_score == player_Score)
            {
                //ничья
                NewPartForNumbers();
                return false;
            }

            if (PlayerWin() )
            {
                PlayerGatMoney();
            }
            else
            {
                ComputerGetMoney();
            }

            NewPartForNumbers();
            return true;
        }

        public void NewPartForNumbers()
        {
            player.CreateNewColoda();
            computer.CreateNewColoda();
            compDontStop = true;
            computer_score = 0; player_Score = 0;
        }

        public bool PlayerWin()
        {
            if (player_Score > computer_score) return true;
            else  return false;
        }

        public void PlayerGatMoney()
        {
            bank.player_Money += bet;
            bank.computer_Money -= bet;
        }

        public void ComputerGetMoney()
        {
            bank.player_Money -= bet;
            bank.computer_Money += bet;
        }

      
    }
}
