using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame21
{
     public class Player
    {
        public int score_card;
        int[] myColoda = new int[22] ; // решить проблему с переполнением
        int positionOnColoda = 0;

        public int Take_Card(Random rnd)
        {
            score_card = 5;
            while (score_card == 5)
            {
                score_card = rnd.Next(1, 11);
            }

            AddInColoda(score_card);
            return score_card;
        }

        public int[] AddInColoda(int scoreOfCard)
        {
            myColoda[positionOnColoda] = scoreOfCard;
            positionOnColoda++;

            return myColoda;
        }

        public bool IsItWin()
        {
            if ((myColoda[0] == myColoda[1]) &&(myColoda[0]==1)) return true;
            else return false;
        }

        public void CreateNewColoda()
        {
            positionOnColoda = 0;
        }

    }
}
