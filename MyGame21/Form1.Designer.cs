namespace MyGame21
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
            this.BT_TakeMore = new System.Windows.Forms.Button();
            this.LB_MyScore = new System.Windows.Forms.Label();
            this.LB_ComputerScore = new System.Windows.Forms.Label();
            this.PK = new System.Windows.Forms.Label();
            this.BT_StopGame = new System.Windows.Forms.Button();
            this.LB_YourMoney = new System.Windows.Forms.Label();
            this.LB_ComputerMoney = new System.Windows.Forms.Label();
            this.BT_CreateGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_TakeMore
            // 
            this.BT_TakeMore.Location = new System.Drawing.Point(333, 315);
            this.BT_TakeMore.Name = "BT_TakeMore";
            this.BT_TakeMore.Size = new System.Drawing.Size(212, 23);
            this.BT_TakeMore.TabIndex = 0;
            this.BT_TakeMore.Text = "Take more";
            this.BT_TakeMore.UseVisualStyleBackColor = true;
            this.BT_TakeMore.Click += new System.EventHandler(this.BT_TakeMore_Click);
            // 
            // LB_MyScore
            // 
            this.LB_MyScore.AutoSize = true;
            this.LB_MyScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_MyScore.Location = new System.Drawing.Point(409, 288);
            this.LB_MyScore.Name = "LB_MyScore";
            this.LB_MyScore.Size = new System.Drawing.Size(63, 24);
            this.LB_MyScore.TabIndex = 1;
            this.LB_MyScore.Text = "label1";
            // 
            // LB_ComputerScore
            // 
            this.LB_ComputerScore.AutoSize = true;
            this.LB_ComputerScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_ComputerScore.Location = new System.Drawing.Point(409, 140);
            this.LB_ComputerScore.Name = "LB_ComputerScore";
            this.LB_ComputerScore.Size = new System.Drawing.Size(63, 24);
            this.LB_ComputerScore.TabIndex = 2;
            this.LB_ComputerScore.Text = "label1";
            // 
            // PK
            // 
            this.PK.AutoSize = true;
            this.PK.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PK.Location = new System.Drawing.Point(394, 116);
            this.PK.Name = "PK";
            this.PK.Size = new System.Drawing.Size(100, 24);
            this.PK.TabIndex = 3;
            this.PK.Text = "Computer";
            // 
            // BT_StopGame
            // 
            this.BT_StopGame.Location = new System.Drawing.Point(333, 344);
            this.BT_StopGame.Name = "BT_StopGame";
            this.BT_StopGame.Size = new System.Drawing.Size(212, 23);
            this.BT_StopGame.TabIndex = 4;
            this.BT_StopGame.Text = "Stop";
            this.BT_StopGame.UseVisualStyleBackColor = true;
            this.BT_StopGame.Click += new System.EventHandler(this.BT_StopGame_Click);
            // 
            // LB_YourMoney
            // 
            this.LB_YourMoney.AutoSize = true;
            this.LB_YourMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_YourMoney.Location = new System.Drawing.Point(703, 441);
            this.LB_YourMoney.Name = "LB_YourMoney";
            this.LB_YourMoney.Size = new System.Drawing.Size(83, 24);
            this.LB_YourMoney.TabIndex = 5;
            this.LB_YourMoney.Text = "Money=";
            // 
            // LB_ComputerMoney
            // 
            this.LB_ComputerMoney.AutoSize = true;
            this.LB_ComputerMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_ComputerMoney.Location = new System.Drawing.Point(703, 43);
            this.LB_ComputerMoney.Name = "LB_ComputerMoney";
            this.LB_ComputerMoney.Size = new System.Drawing.Size(83, 24);
            this.LB_ComputerMoney.TabIndex = 6;
            this.LB_ComputerMoney.Text = "Money=";
            // 
            // BT_CreateGame
            // 
            this.BT_CreateGame.Location = new System.Drawing.Point(12, 218);
            this.BT_CreateGame.Name = "BT_CreateGame";
            this.BT_CreateGame.Size = new System.Drawing.Size(212, 23);
            this.BT_CreateGame.TabIndex = 7;
            this.BT_CreateGame.Text = "New Game";
            this.BT_CreateGame.UseVisualStyleBackColor = true;
            this.BT_CreateGame.Click += new System.EventHandler(this.BT_CreateGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 493);
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
    }
}

