using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        int counter = 0;
        int undo_counter = 0;
        string result = "";
        Button button = new Button();
        string playerName;
        int playerTurn;
        public TicTacToe()
        {
            InitializeComponent();

        }


        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

    

        private void button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;

            if (button.Text.Equals("X") || button.Text.Equals("O"))
                MessageBox.Show("You checked this box before");
            else
           
            {
                if (counter % 2 == 0)
                {
                    ((Button)sender).Text = "X";

                    ((Button)sender).ForeColor = System.Drawing.Color.Red;
                    playerName = "Player 1";
                    playerTurn = 2; // Player 2
                    


                }
                else
                {
                    ((Button)sender).Text = "O";
                    ((Button)sender).ForeColor = System.Drawing.Color.Blue;
                    playerTurn = 1; // Player 1
                    
                }
                counter++;
                undo_counter = 0;
                PlayerTurn.Text = "Player " + playerTurn.ToString();
                if (Sprawdz_wynik().Equals("win"))
                {
                    PlayerTurn.Visible = false;
                    MessageBox.Show(playerName + " wins");
                    DialogResult dialogResult = MessageBox.Show("New Game?","", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        New_Game();
                    }
                    else { Close(); }
                }
                
                if (Sprawdz_wynik().Equals("remis"))
                {
                    PlayerTurn.Visible = false;
                    MessageBox.Show("Remis");
                    DialogResult dialogResult = MessageBox.Show("New Game?","", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        New_Game();
                    }
                    else { Close(); }


                }
                    
               

            }
        }
        private string Sprawdz_wynik()
        {



            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                Koloruj(1);

            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
            {
                Koloruj(2);

            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
            {
                Koloruj(3);
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
            { Koloruj(4); }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
            { Koloruj(5); }
            else if (button7.Text == button5.Text && button5.Text == button3.Text && button3.Text != "")
            { Koloruj(6); }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
            { Koloruj(7); }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
            { Koloruj(8); }
            else if (counter == 9)
            { result = "remis"; }
            
               
             
           
            
            
            return result;
        }

        private string Koloruj(int i)
        {
            if (i == 1)
            {
                button1.FlatStyle = FlatStyle.Flat;
                button2.FlatStyle = FlatStyle.Flat;
                button3.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = Color.Red;
                button2.FlatAppearance.BorderColor = Color.Red;
                button3.FlatAppearance.BorderColor = Color.Red;
            }
            if (i == 2)
            {
                button1.FlatStyle = FlatStyle.Flat;
                button4.FlatStyle = FlatStyle.Flat;
                button7.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = Color.Red;
                button4.FlatAppearance.BorderColor = Color.Red;
                button7.FlatAppearance.BorderColor = Color.Red;

            }

            if (i == 3) 
            {
                button1.FlatStyle = FlatStyle.Flat;
                button5.FlatStyle = FlatStyle.Flat;
                button9.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.BorderColor = Color.Red;
                button5.FlatAppearance.BorderColor = Color.Red;
                button9.FlatAppearance.BorderColor = Color.Red;

            }
            if (i == 4)
            {
                button4.FlatStyle = FlatStyle.Flat;
                button5.FlatStyle = FlatStyle.Flat;
                button6.FlatStyle = FlatStyle.Flat;
                button4.FlatAppearance.BorderColor = Color.Red;
                button5.FlatAppearance.BorderColor = Color.Red;
                button6.FlatAppearance.BorderColor = Color.Red;

            }
            if (i == 5)
            {
                button7.FlatStyle = FlatStyle.Flat;
                button8.FlatStyle = FlatStyle.Flat;
                button9.FlatStyle = FlatStyle.Flat;
                button7.FlatAppearance.BorderColor = Color.Red;
                button8.FlatAppearance.BorderColor = Color.Red;
                button9.FlatAppearance.BorderColor = Color.Red;

            }
            if (i == 6)
            {
                button7.FlatStyle = FlatStyle.Flat;
                button5.FlatStyle = FlatStyle.Flat;
                button3.FlatStyle = FlatStyle.Flat;
                button7.FlatAppearance.BorderColor = Color.Red;
                button5.FlatAppearance.BorderColor = Color.Red;
                button3.FlatAppearance.BorderColor = Color.Red;

            }

            if (i == 7)
            {
                button2.FlatStyle = FlatStyle.Flat;
                button5.FlatStyle = FlatStyle.Flat;
                button8.FlatStyle = FlatStyle.Flat;
                button2.FlatAppearance.BorderColor = Color.Red;
                button5.FlatAppearance.BorderColor = Color.Red;
                button8.FlatAppearance.BorderColor = Color.Red;

            }

            if (i == 8)
            {
                button3.FlatStyle = FlatStyle.Flat;
                button6.FlatStyle = FlatStyle.Flat;
                button9.FlatStyle = FlatStyle.Flat;
                button3.FlatAppearance.BorderColor = Color.Red;
                button6.FlatAppearance.BorderColor = Color.Red;
                button9.FlatAppearance.BorderColor = Color.Red;

            }



            return result = "win";

        }
        private void New_Game()
        {
            PlayerTurn.Visible = true;
            PlayerTurn.Text = "Player 1";
            counter = 0;
            result = "";
            button1.Text = "";
            button1.FlatStyle = FlatStyle.Standard;
            button2.Text = "";
            button2.FlatStyle = FlatStyle.Standard;
            button3.Text = "";
            button3.FlatStyle = FlatStyle.Standard;
            button4.Text = "";
            button4.FlatStyle = FlatStyle.Standard;
            button5.Text = "";
            button5.FlatStyle = FlatStyle.Standard;
            button6.Text = "";
            button6.FlatStyle = FlatStyle.Standard;
            button7.Text = ""; 
            button7.FlatStyle = FlatStyle.Standard;
            button8.Text = "";
            button8.FlatStyle = FlatStyle.Standard;
            button9.Text = "";
            button9.FlatStyle = FlatStyle.Standard;

}

    private void button11_Click(object sender, EventArgs e)
        {
            New_Game();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (undo_counter == 0) 
            { 
            button.Text = "";
            counter -= 1;
            undo_counter -= 1;
                if (playerTurn == 1)
                {
                    playerTurn = 2;
                }
                else
                    playerTurn = 1;
                PlayerTurn.Text = "Player " + playerTurn.ToString();
            }
        }
    
    }
}
