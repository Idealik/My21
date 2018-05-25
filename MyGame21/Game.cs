using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame21
{
     public class Game
    {

        Player player = new Player();
        Bank bank = new Bank();
        
        public int GetPlayerMoney()
        {
            return bank.player_Money;
        }

        public int GetComputerMoney()
        {
            return bank.computer_Money;
        }



    }
}
