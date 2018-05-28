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
            return score_card;
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
        }

        private bool TrueCheckChance(int score, Random rnd)
        {
            int myFor = 0;
            int myAgainst = 0;
            int count = 0;

            while (count != 10)
            {
                double CheckNumber = rnd.Next(1000);


                if (score == 12)
                {
                    //  шасн что 8 карт будет норм, 1 не очень
                    double chance = 8 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 7 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 6 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 5 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 4 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 4 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 3 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 2 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
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
                    double chance = 1 / 9 * 1000;

                    if (CheckNumber > Math.Round(chance))
                    {
                        myAgainst++;
                    }
                    else
                    {
                        myFor++;
                    }
                    continue;
                }
                count++;
            }

            if (myAgainst > myFor)  return false; 
            else return true;
        }

    }
}
