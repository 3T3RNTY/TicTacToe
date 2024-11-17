using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        int turn = 1;
        int player1Score;
        int player2Score;

        Button button;
        char[,] list;
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            char c ='-';
            var button = (Button)sender;
            // First Player
            if (turn % 2 == 1)
            {
                button.Text = "O";
                c = 'O';
            }
            // Second Player
            else if(turn % 2 == 0) 
            {
                button.Text="X";
                c = 'X';
            }

            button.Enabled = false;

            string name = button.Name.ToString();
            string x = name.Substring(6,1);
            string y = name.Substring(7,1);
            int i = int.Parse(x);
            int j = int.Parse(y);
            list[i, j] = c;
            


            Check(i,j,c);

            turn++;
        }
        private void button3x3_Click(object sender, EventArgs e)
        {
            Create(3);

        }

        private void button5x5_Click(object sender, EventArgs e)
        {
            Create(5);

        }

        private void button7x7_Click(object sender, EventArgs e)
        {
            Create(7);
        }
        public void Check(int i, int j, char c)
        {
            // Orta kontrol
            if (i > 0 && i < list.GetLength(1) - 1)
            {
                // Ortadan üst alt kontrol
                if (list[i - 1, j] == c && list[i + 1, j] == c)
                {
                    list[i - 1, j] = '*';
                    list[i, j] = '*';
                    list[i + 1, j] = '*';

                    Score(c);
                }
            }

            if (j > 0 && j < list.GetLength(1) - 1)
            {
                // Ortadan sað sol kontrol
                if (list[i, j - 1] == c && list[i, j + 1] == c)
                {
                    list[i, j - 1] = '*';
                    list[i, j] = '*';
                    list[i, j + 1] = '*';

                    Score(c);
                }
            }
            //Uç alt üst kontrol
            if (i > 1)
            {
                // Üstten Alt kontrol
                if (list[i - 2, j] == c && list[i - 1, j] == c)
                {
                    list[i - 2, j] = '*';
                    list[i - 1, j] = '*';
                    list[i, j] = '*';

                    Score(c);
                }
            }
            if (i < list.GetLength(0) - 2)
            {
                // Alttan üst kontrol
                if (list[i + 2, j] == c && list[i + 1, j] == c)
                {
                    list[i + 2, j] = '*';
                    list[i + 1, j] = '*';
                    list[i, j] = '*';

                    Score(c);
                }
            }
            // Uç sað sol kontrol
            if (j > 1)
            {
                // Üstten Alt kontrol
                if (list[i, j - 2] == c && list[i, j - 1] == c)
                {
                    list[i, j - 2] = '*';
                    list[i, j - 1] = '*';
                    list[i, j] = '*';

                    Score(c);
                }
            }
            if (j < list.GetLength(1) - 2)
            {
                // Alttan üst kontrol
                if (list[i, j + 2] == c && list[i, j + 1] == c)
                {
                    list[i, j + 2] = '*';
                    list[i, j + 1] = '*';
                    list[i, j] = '*';

                    Score(c);
                }
            }

            EndGame();
        }

        public void Score(char c)
        {
            if (c == 'O')
                player1Score++;
            else
                player2Score++;

            playerScore1.Text = "Score: " + player1Score;          
            playerScore2.Text = "Score: " + player2Score;

            playerScore1.Show();
            playerScore2.Show();
        }
        public void Create(int size)
        {

            button3x3.Hide();
            button5x5.Hide();
            button7x7.Hide();
            player1.Show();
            player2.Show();
            playerScore1.Show();
            playerScore2.Show();

            list = new char[size,size];

            int x = 400;
            int y = 60;
            string name = "";

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    button = new Button();
                    button.Name = "button" + i + j;
                    button.BackColor = Color.FromArgb(192, 192, 255);
                    button.Font = new Font("Unispace", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
                    button.Location = new Point(x, y);
                    button.Size = new Size(50, 50);
                    button.Click += button_Click;
                    Controls.Add(button);
                    list[i, j] = '-' ;
                    x += 65;
                }
                x = 400;
                y += 65;
            }
        }
        public void EndGame()
        {
            for (int i= 0; i < list.GetLength(0); i++)
            {
                for(int j= 0; j < list.GetLength(1); j++)
                {
                    if ( list[i,j] == '-')
                    {
                        return;
                    }
                    
                }
            }
            if (player1Score > player2Score)
            {
                MessageBox.Show(" Player 1 Wins!");
            }
            else if (player1Score < player2Score)
            {
                MessageBox.Show(" Player 2 Wins!");
            }
            else
            {
                MessageBox.Show(" It's a Draw!");
            }
        }
    }
}
