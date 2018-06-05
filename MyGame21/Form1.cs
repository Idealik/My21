using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game;

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            myInterface();
        }
        int party = 0;
        private void BT_TakeMore_Click(object sender, EventArgs e)
        {

            try
            {               
                party = game.Play(int.Parse(TB_Bet.Text));
                TB_Bet.Enabled = false;
                if (party == 1)
                {
                    MessageBox.Show("Игрок выиграл");
                    BlockGame();
                }
                if (party == 2)
                {
                    MessageBox.Show("Компьютер выиграл");
                    BlockGame();
                }           
                myInterface();
            
            }
            catch
            {
                MessageBox.Show("Проверь ставку");
            }

            if (party == 3)
            {
                TB_Bet.Enabled = true;
            }

        }

        private void BlockGame()
        {
            BT_TakeMore.Enabled = false;
            BT_StopGame.Enabled = false;
        }
        private void UnBlockGame()
        {
            BT_TakeMore.Enabled = true;
            BT_StopGame.Enabled = true;
        }

        private void BT_StopGame_Click(object sender, EventArgs e)
        {
            if (!game.StopGame())
            {
                MessageBox.Show("Ничья");
            }
            TB_Bet.Enabled = true;
            myInterface();
        }

        private void BT_CreateGame_Click(object sender, EventArgs e)
        {
            game = new Game();
            UnBlockGame();
            myInterface();

        }

        public void myInterface()
        {
            LB_ComputerMoney.Text = "Money = " + game.GetComputerMoney().ToString();
            LB_YourMoney.Text = "Money = " + game.GetPlayerMoney().ToString();
            LB_MyScore.Text = "My score = " + game.player_Score;
            LB_ComputerScore.Text = "His score = " + game.computer_score;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {}
    }
}
