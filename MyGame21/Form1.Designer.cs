﻿namespace MyGame21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BT_TakeMore = new System.Windows.Forms.Button();
            this.LB_MyScore = new System.Windows.Forms.Label();
            this.LB_ComputerScore = new System.Windows.Forms.Label();
            this.PK = new System.Windows.Forms.Label();
            this.BT_StopGame = new System.Windows.Forms.Button();
            this.LB_YourMoney = new System.Windows.Forms.Label();
            this.LB_ComputerMoney = new System.Windows.Forms.Label();
            this.BT_CreateGame = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TB_Bet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_TakeMore
            // 
            this.BT_TakeMore.BackColor = System.Drawing.Color.Aquamarine;
            this.BT_TakeMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_TakeMore.Location = new System.Drawing.Point(335, 315);
            this.BT_TakeMore.Name = "BT_TakeMore";
            this.BT_TakeMore.Size = new System.Drawing.Size(212, 23);
            this.BT_TakeMore.TabIndex = 0;
            this.BT_TakeMore.Text = "Take more";
            this.BT_TakeMore.UseVisualStyleBackColor = false;
            this.BT_TakeMore.Click += new System.EventHandler(this.BT_TakeMore_Click);
            // 
            // LB_MyScore
            // 
            this.LB_MyScore.AutoSize = true;
            this.LB_MyScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_MyScore.Location = new System.Drawing.Point(340, 370);
            this.LB_MyScore.Name = "LB_MyScore";
            this.LB_MyScore.Size = new System.Drawing.Size(61, 24);
            this.LB_MyScore.TabIndex = 1;
            this.LB_MyScore.Text = "Score";
            // 
            // LB_ComputerScore
            // 
            this.LB_ComputerScore.AutoSize = true;
            this.LB_ComputerScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_ComputerScore.Location = new System.Drawing.Point(340, 86);
            this.LB_ComputerScore.Name = "LB_ComputerScore";
            this.LB_ComputerScore.Size = new System.Drawing.Size(61, 24);
            this.LB_ComputerScore.TabIndex = 2;
            this.LB_ComputerScore.Text = "Score";
            // 
            // PK
            // 
            this.PK.AutoSize = true;
            this.PK.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PK.Location = new System.Drawing.Point(374, 110);
            this.PK.Name = "PK";
            this.PK.Size = new System.Drawing.Size(157, 30);
            this.PK.TabIndex = 3;
            this.PK.Text = "Computer";
            // 
            // BT_StopGame
            // 
            this.BT_StopGame.BackColor = System.Drawing.Color.Aquamarine;
            this.BT_StopGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_StopGame.Location = new System.Drawing.Point(335, 344);
            this.BT_StopGame.Name = "BT_StopGame";
            this.BT_StopGame.Size = new System.Drawing.Size(212, 23);
            this.BT_StopGame.TabIndex = 4;
            this.BT_StopGame.Text = "Stop";
            this.BT_StopGame.UseVisualStyleBackColor = false;
            this.BT_StopGame.Click += new System.EventHandler(this.BT_StopGame_Click);
            // 
            // LB_YourMoney
            // 
            this.LB_YourMoney.AutoSize = true;
            this.LB_YourMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_YourMoney.Location = new System.Drawing.Point(650, 450);
            this.LB_YourMoney.Name = "LB_YourMoney";
            this.LB_YourMoney.Size = new System.Drawing.Size(83, 24);
            this.LB_YourMoney.TabIndex = 5;
            this.LB_YourMoney.Text = "Money=";
            // 
            // LB_ComputerMoney
            // 
            this.LB_ComputerMoney.AutoSize = true;
            this.LB_ComputerMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_ComputerMoney.Location = new System.Drawing.Point(650, 50);
            this.LB_ComputerMoney.Name = "LB_ComputerMoney";
            this.LB_ComputerMoney.Size = new System.Drawing.Size(83, 24);
            this.LB_ComputerMoney.TabIndex = 6;
            this.LB_ComputerMoney.Text = "Money=";
            // 
            // BT_CreateGame
            // 
            this.BT_CreateGame.BackColor = System.Drawing.Color.Chocolate;
            this.BT_CreateGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_CreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CreateGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_CreateGame.Location = new System.Drawing.Point(335, 499);
            this.BT_CreateGame.Name = "BT_CreateGame";
            this.BT_CreateGame.Size = new System.Drawing.Size(212, 50);
            this.BT_CreateGame.TabIndex = 7;
            this.BT_CreateGame.Text = "New Game";
            this.BT_CreateGame.UseVisualStyleBackColor = false;
            this.BT_CreateGame.Click += new System.EventHandler(this.BT_CreateGame_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TB_Bet
            // 
            this.TB_Bet.Location = new System.Drawing.Point(398, 289);
            this.TB_Bet.Name = "TB_Bet";
            this.TB_Bet.Size = new System.Drawing.Size(100, 20);
            this.TB_Bet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SetBet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Bet);
            this.Controls.Add(this.BT_CreateGame);
            this.Controls.Add(this.LB_ComputerMoney);
            this.Controls.Add(this.LB_YourMoney);
            this.Controls.Add(this.BT_StopGame);
            this.Controls.Add(this.PK);
            this.Controls.Add(this.LB_ComputerScore);
            this.Controls.Add(this.LB_MyScore);
            this.Controls.Add(this.BT_TakeMore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_TakeMore;
        private System.Windows.Forms.Label LB_MyScore;
        private System.Windows.Forms.Label LB_ComputerScore;
        private System.Windows.Forms.Label PK;
        private System.Windows.Forms.Button BT_StopGame;
        private System.Windows.Forms.Label LB_YourMoney;
        private System.Windows.Forms.Label LB_ComputerMoney;
        private System.Windows.Forms.Button BT_CreateGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TB_Bet;
        private System.Windows.Forms.Label label1;
    }
}

