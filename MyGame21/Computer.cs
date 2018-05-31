using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame21
{
    class Computer
    {
        public int score_card;
        int[] myColoda = new int[22];
        int positionOnColoda = 0;

        public int Take_Card(Random rnd, int computer_score)
        {
            if (ThinkAboutResult(computer_score, rnd))
            {
                score_card = 5;
                while (score_card == 5)
                {
                    score_card = rnd.Next(1, 11);
                }
            }
            else score_card = 0;

            AddInColoda(score_card);
            return score_card;
        }

        public bool IsItWin()
        {
            if ((myColoda[0] == myColoda[1]) && (myColoda[0] == 1)) return true;
            else return false;
        }

        private bool ThinkAboutResult(int computer_score, Random rnd)
        {
            if (computer_score <= 11) { return true; }
            if (computer_score == 21) { return false; }

            if ((computer_score > 11)&& (computer_score < 21)){
                if (TrueCheckChance(computer_score, rnd))
                {
                    return true;
                }
                else { return false; }              
            }

            return true;
        }

        private bool TrueCheckChance(int score, Random rnd)
        {
            int myFor = 0;
            int myAgainst = 0;
            int count = 0;
            double chance;

            while (count != 10)
            {
                count++;
                double CheckNumber = rnd.Next(1000);
                if (score == 12)
                {
                    //  шасн что 8 карт будет норм, 1 не очень
                     chance =  889;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 13)
                {
                     chance = 778;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 14)
                {
                     chance = 667;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 15)
                {
                     chance = 556;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 16)
                {
                     chance = 555;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 17)
                {
                     chance = 443;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 18)
                {
                     chance = 332;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 19)
                {
                     chance = 221;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }

                if (score == 20)
                {
                     chance =  110;

                    if (CheckNumber > chance)
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }
            }

            if (myAgainst > myFor)  return false; 
            else return true;
        }

        public int[] AddInColoda(int scoreOfCard)
        {
            myColoda[positionOnColoda] = scoreOfCard;
            positionOnColoda++;

            return myColoda;
        }

        public void CreateNewColoda()
        {
            positionOnColoda = 0;
        }

    }
}
