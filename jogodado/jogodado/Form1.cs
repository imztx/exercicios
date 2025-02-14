namespace jogodado
{
    public partial class Form1 : Form
    {

        int player1 = 0;
        int player2 = 0;

        int ponto1 = 0;
        int ponto2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rmd = new Random();
            int dado1 = rmd.Next(1,7);
            label4.Text = Convert.ToString(dado1);
            player1 = dado1;
            textBox1.Text += dado1.ToString() + " | ";

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rmd = new Random();
            int dado2 = rmd.Next(1, 7);
            label6.Text = Convert.ToString(dado2);
            player2 = dado2;
            textBox2.Text += dado2.ToString() + " | ";
            
            button1.Enabled = true;
            button2.Enabled = false;


            if (player1 > player2) {
                MessageBox.Show("Player 1 ganhou a rodada!!");
                ponto1++;

                if (ponto1 == 2 && ponto2 == 0)
                {
                    MessageBox.Show("Player 1 ganhou o jogo!");
                }
                else if (ponto1 == 3 && ponto2 == 2 || ponto1 == 3 && ponto2 == 1)
                {
                    MessageBox.Show("Player 1 ganhou o jogo!");
                }

            }
            else if (player2 > player1)
            {
                MessageBox.Show("Player 2 ganhou a rodada!!");
                ponto2++;

                if (ponto2 == 2 && ponto1 == 0)
                {
                    MessageBox.Show("Player 2 ganhou o jogo!");
                }

                else if (ponto2 == 3 && ponto1 == 2 || ponto2 == 3 && ponto1 == 1)
                {
                    MessageBox.Show("Player 2 ganhou o jogo!");
                }
            }
            else
            {
                MessageBox.Show("Tivemos um empatee!!");
            }
        }
    }
}
