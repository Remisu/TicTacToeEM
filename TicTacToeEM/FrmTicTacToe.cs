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
                    button1.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1,button2,button3,button4,button5,button6,button7,button8,button9,player);
                        ScoreX++;
                        lblScoreX.Text = ScoreX.ToString();
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button1.Text = "O";
                    button1.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player, ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button2.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button2.Text = "O";
                    button2.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button3.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button3.Text = "O";
                    button3.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button4.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button4.Text = "O";
                    button4.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button5.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button5.Text = "O";
                    button5.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button6.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button6.Text = "O";
                    button6.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button7.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button7.Text = "O";
                    button7.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button8.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button8.Text = "O";
                    button8.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
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
                    button9.ForeColor = System.Drawing.Color.FromArgb(255, 97, 95);
                    player = "X";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreX++;
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button9.Text = "O";
                    button9.ForeColor = System.Drawing.Color.FromArgb(62, 197, 243);
                    player = "O";
                    if (Functions.CheckWinner(ref player,ref button1, button2, button3, button4, button5, button6, button7, button8, button9))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9,player);
                        ScoreO++;
                    }
                    XPlayerTurn = true;
                }
            }
        }
    }
}
