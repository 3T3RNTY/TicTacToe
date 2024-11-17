using TicTacToe.Properties;

namespace TicTacToe
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            button3x3 = new Button();
            button5x5 = new Button();
            button7x7 = new Button();
            player1 = new Label();
            player2 = new Label();
            playerScore1 = new Label();
            playerScore2 = new Label();
            SuspendLayout();
            // 
            // button3x3
            // 
            button3x3.BackColor = Color.DarkSeaGreen;
            button3x3.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button3x3.Location = new Point(150, 200);
            button3x3.Name = "button3x3";
            button3x3.Size = new Size(150, 75);
            button3x3.TabIndex = 2;
            button3x3.Text = "3X3";
            button3x3.UseVisualStyleBackColor = false;
            button3x3.Click += button3x3_Click;
            // 
            // button5x5
            // 
            button5x5.BackColor = Color.DarkSeaGreen;
            button5x5.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button5x5.Location = new Point(350, 200);
            button5x5.Name = "button5x5";
            button5x5.Size = new Size(150, 75);
            button5x5.TabIndex = 3;
            button5x5.Text = "5X5";
            button5x5.UseVisualStyleBackColor = false;
            button5x5.Click += button5x5_Click;
            // 
            // button7x7
            // 
            button7x7.BackColor = Color.DarkSeaGreen;
            button7x7.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button7x7.Location = new Point(550, 200);
            button7x7.Name = "button7x7";
            button7x7.Size = new Size(150, 75);
            button7x7.TabIndex = 4;
            button7x7.Text = "7X7";
            button7x7.UseVisualStyleBackColor = false;
            button7x7.Click += button7x7_Click;
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            player1.Location = new Point(80, 100);
            player1.Name = "player1";
            player1.Size = new Size(124, 28);
            player1.TabIndex = 5;
            player1.Text = "Player 1";
            player1.Visible = false;
            // 
            // player2
            // 
            player2.AutoSize = true;
            player2.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            player2.Location = new Point(80, 250);
            player2.Name = "player2";
            player2.Size = new Size(124, 28);
            player2.TabIndex = 6;
            player2.Text = "Player 2";
            player2.Visible = false;
            // 
            // playerScore1
            // 
            playerScore1.AutoSize = true;
            playerScore1.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            playerScore1.Location = new Point(80, 150);
            playerScore1.Name = "playerScore1";
            playerScore1.Size = new Size(124, 28);
            playerScore1.TabIndex = 7;
            playerScore1.Text = "Score: 0";
            playerScore1.Visible = false;
            // 
            // playerScore2
            // 
            playerScore2.AutoSize = true;
            playerScore2.Font = new Font("Unispace", 13.7999992F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            playerScore2.Location = new Point(80, 300);
            playerScore2.Name = "playerScore2";
            playerScore2.Size = new Size(124, 28);
            playerScore2.TabIndex = 8;
            playerScore2.Text = "Score: 0";
            playerScore2.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(882, 553);
            Controls.Add(playerScore2);
            Controls.Add(button3x3);
            Controls.Add(playerScore1);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(button7x7);
            Controls.Add(button5x5);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3x3;
        private Button button5x5;
        private Button button7x7;
        private Label player1;
        private Label player2;
        private Label playerScore1;
        private Label playerScore2;
    }
}
