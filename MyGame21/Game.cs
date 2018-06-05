using System;

namespace MyGame21
{
     public class Game
    {
        Random rnd = new Random();
        Player player = new Player();
        Bank bank = new Bank();
        Computer computer = new Computer();
        public int player_Score = 0,  computer_score = 0;
        int bet = 1; // later you can change it 
        bool firstTwoCard = true, compDontStop = true;


        public int GetPlayerMoney()
        {
            return bank.player_Money;
        }

        public int GetComputerMoney()
        {
            return bank.computer_Money;
        }

        public int Play(int _bet) // сделать инт, если 0 то не победа, 1 победа игрока, 2 победа пк, 3 для анблока ставки
        {
            if (CheckBank())
            {

                bet = _bet;

                if (firstTwoCard)
                {
                    MethodForFirstTwoCard();
                    firstTwoCard = false;
                }

                player.Take_Card(rnd);
                player_Score += player.score_card;

                int tmp = computer.Take_Card(rnd, computer_score);
                if (tmp == 0) compDontStop = false;

                if (player.IsItWin()) // метод на проверку 2х тузов
                {
                    PlayerGatMoney();
                    NewPartForNumbers(); 
                    return 3 ;
                }

                if (computer.IsItWin()) // метод на проверку 2х тузов
                {
                    ComputerGetMoney();
                    NewPartForNumbers();
                    return 3;
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
                    return 3;
                }
                return 0;
            }
            else
            {
                if (Winner()) //player win 
                {
                    return 1;
                }
                else // comp win
                {
                    return 2;
                }
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

        private bool PlayerWin()
        {
            if (player_Score > computer_score) return true;
            else  return false;
        }

        private void PlayerGatMoney()
        {
            bank.player_Money += bet;
            bank.computer_Money -= bet;
        }

        private void ComputerGetMoney()
        {
            bank.player_Money -= bet;
            bank.computer_Money += bet;
        }

        private bool CheckBank()
        {
            if ((bank.player_Money > 0) && (bank.computer_Money > 0))
            {
                return true;
            }
            else return false;
        }

        public bool Winner() // true  - player; false - computer
        {
            if (bank.player_Money < 0)
            {
                return false;
            }
            else return true;
        }
      
    }
}
