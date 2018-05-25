using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGame21;

namespace GameTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Player_GetDefaulMoney_OneHundr()
        {
            var bank = new Bank();

            var money = bank.player_Money;

            Assert.AreEqual(100, money);

        }

        [TestMethod]
        public void Computer_GetDefaulMoney_OneHundr()
        {
            var bank = new Bank();

            var money = bank.computer_Money;

            Assert.AreEqual(100, money);
        }

        public void Player_TakeCard_ScoreFive()
        {

        }

    }
}
