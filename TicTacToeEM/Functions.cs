using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TicTacToeEM;


namespace TicTacToeEM
{
    public static class Functions 
    {
        public static void CleanFields(ref Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public static bool CheckWinner(ref string player, ref Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9)
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
