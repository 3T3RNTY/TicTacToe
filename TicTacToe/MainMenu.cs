using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        int turn = 1;
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
            if (turn % 2 == 0)
            {
                button.Text = "X";
                c = 'X';
            }
            else if(turn % 2 == 1) 
            {
                button.Text="O";
                c = 'O';
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
        
            
    }
}
