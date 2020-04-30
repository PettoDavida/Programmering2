using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            
            turn_count += 1;
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            switch (b.Name[0])
            {
                case 'A': break;
                case 'B': break;
                case 'C': break;
            }

            switch (b.Name[1])
            {
                case '1': break;
                case '2': break;
                case '3': break;
            }
            
            turn = !turn;// switches turn
            b.Enabled = false;
            if (turn_count == 9)
            {
                MessageBox.Show("Draw!"); // When u click "ok" the application  restarts
                Application.Restart();
            }
        }



        private void OnSwitch(object sender, EventArgs e)
        {
            
            if (turn)
                turn = !turn; // Switches X to O
            else
                turn = !turn; // Switches O to X
        }

        private void OnRestart(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
