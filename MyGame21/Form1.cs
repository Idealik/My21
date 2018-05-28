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

        private void BT_TakeMore_Click(object sender, EventArgs e)
        {
            game.Play();
            myInterface();
        }

        private void BT_StopGame_Click(object sender, EventArgs e)
        {
            game.StopGame();
            myInterface();
        }

        private void BT_CreateGame_Click(object sender, EventArgs e)
        {
            game = new Game();
            myInterface();
            timer1.Enabled = true;
        }

        public void myInterface()
        {
            LB_ComputerMoney.Text = "Money = " + game.GetComputerMoney().ToString();
            LB_YourMoney.Text = "Money = " + game.GetPlayerMoney().ToString();
            LB_MyScore.Text = "My score = " + game.player_Score;
            LB_ComputerScore.Text = "Comp score = " + game.computer_score;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }
    }
}
