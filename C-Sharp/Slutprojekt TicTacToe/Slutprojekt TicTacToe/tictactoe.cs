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
        Board board;
        public tictactoe()
        {
            InitializeComponent();
            board = new Board();
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

            int x = 0;
            int y = 0;

            switch (b.Name[0])
            {
                case 'A': y = 0; break;
                case 'B': y = 1; break;
                case 'C': y = 2; break;
            }

            switch (b.Name[1])
            {
                case '1': x = 0; break;
                case '2': x = 1; break;
                case '3': x = 2; break;
            }

            board.setValue(x, y, turn ? 1 : 2);

            bool winner = board.threeinarow(turn ? 1 : 2);

            if (winner)
            {
                string winningteam = turn ? "x" : "o";
                MessageBox.Show( winningteam + "    wins!"); // When u click "ok" the application  restarts
                Application.Restart();
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
