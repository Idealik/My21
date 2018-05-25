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

        public int Take_Card(Random rnd)
        {
            score_card = 5;
            while (score_card == 5)
            {
                score_card = rnd.Next(1, 11);
            }

            return score_card;
        }
    }
}
