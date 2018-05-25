using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame21
{
     public class Player
    {
        Random rnd;

        public int Take_Card()
        {
            int score_card=6;
            while (score_card == 6)
            {
                score_card = rnd.Next(1, 11);
            }
            return score_card;
        }



    }
}
