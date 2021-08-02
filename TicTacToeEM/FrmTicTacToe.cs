using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeEM;

namespace TicTacToeEM
{
    public partial class FrmTicTacToe : Form
    {
        bool XPlayerTurn = true;
        string player;
        int ScoreX;
        int ScoreO;

        public FrmTicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button1.Text = "X";
                    CheckXWinner(button1);
                }
                else
                {
                    button1.Text = "O";
                    CheckOwinner(button1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button2.Text = "X";
                    CheckXWinner(button2);
                }
                else
                {
                    button2.Text = "O";
                    CheckOwinner(button2);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button3.Text = "X";
                    CheckXWinner(button3);
                }
                else
                {
                    button3.Text = "O";
                    CheckOwinner(button3);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button4.Text = "X";
                    CheckXWinner(button4);
                }
                else
                {
                    button4.Text = "O";
                    CheckOwinner(button4);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button5.Text = "X";
                    CheckXWinner(button5);
                }
                else
                {
                    button5.Text = "O";
                    CheckOwinner(button5);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button6.Text = "X";
                    CheckXWinner(button6);
                }
                else
                {
                    button6.Text = "O";
                    CheckOwinner(button6);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button7.Text = "X";
                    CheckXWinner(button7);
                }
                else
                {
                    button7.Text = "O";
                    CheckOwinner(button7);
                }
            }
        }
     
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button8.Text = "X";
                    CheckXWinner(button8);
                }
                else
                {
                    button8.Text = "O";
                    CheckOwinner(button8);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button9.Text = "X";
                    CheckXWinner(button9);
                }
                else
                {
                    button9.Text = "O";
                    CheckOwinner(button9);
                }
            }
        }

        private void CheckXWinner(Button button)
        {
            button.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
            player = "X";
            if (Functions.CheckWinner(ref player, ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
            {
                MessageBox.Show("X is the Winner !!!");
                Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9, player);
                ScoreX++;
                lblScoreX.Text = ScoreX.ToString();
            }
            XPlayerTurn = false;
        }

        private void CheckOwinner(Button button)
        {
            button.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
            player = "O";
            if (Functions.CheckWinner(ref player, ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
            {
                MessageBox.Show("O is the Winner !!!");
                Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9, player);
                ScoreO++;
                lblScoreO.Text = ScoreO.ToString();
            }
            XPlayerTurn = true;
        }
    }
}
