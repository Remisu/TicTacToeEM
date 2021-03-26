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
        bool OPlayerTurn = false;

        public FrmTicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MetodoSeparado()
        {
           // Functions.CheckWinner(XPlayerTurn);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (XPlayerTurn == true)
                {
                    button1.Text = "X"; 
                    if (CheckWinner((XPlayerTurn) ? "X": "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1,button2,button3,button4,button5,button6,button7,button8,button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button1.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button2.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button3.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button4.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button5.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button6.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button7.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button8.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
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
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("X is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = false;
                }
                else
                {
                    button9.Text = "O";
                    if (CheckWinner((XPlayerTurn) ? "X" : "O"))
                    {
                        MessageBox.Show("O is the Winner !!!");
                        Functions.CleanFields(ref button1, button2, button3, button4, button5, button6, button7, button8, button9);
                    }
                    XPlayerTurn = true;
                }
            }
        }
        public bool CheckWinner(string player)
        {
            if ((button1.Text == player) && (button2.Text == player) && (button3.Text == player))
            {
                return true;
            }

            if ((button4.Text == player) && (button5.Text == player) && (button6.Text == player))
            {
                return true;
            }

            if ((button7.Text == player) && (button8.Text == player) && (button9.Text == player))
            {
                return true;
            }

            if ((button1.Text == player) && (button4.Text == player) && (button7.Text == player))
            {
                return true;
            }

            if ((button2.Text == player) && (button5.Text == player) && (button8.Text == player))
            {
                return true;
            }

            if ((button3.Text == player) && (button6.Text == player) && (button9.Text == player))
            {
                return true;
            }

            if ((button1.Text == player) && (button5.Text == player) && (button9.Text == player))
            {
                return true;
            }

            if ((button3.Text == player) && (button5.Text == player) && (button7.Text == player))
            {
                return true;
            }
            return false;
        }
    }
}
