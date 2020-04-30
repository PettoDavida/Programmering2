using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Slutprojekt_Poker
{
    public partial class tictactoe : Form
    {
        bool turn = true; // true = x Turn; false = o turn
        int turn_count = 0; // when turn_count = 9 game is a draw
        public tictactoe()
        {
            InitializeComponent();
        }

        private void tictactoe_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;// switches player
            b.Enabled = false;
        }



        private void OnSwitch(object sender, EventArgs e)
        {
            
            if (turn)
                turn = !turn;
            else
                turn = !turn;
        }

        private void OnRestart(object sender, EventArgs e)
        {

        }
    }
}
