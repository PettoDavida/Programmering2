using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class kalkylator : Form
    {
        private List<char> numeriska = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '+', '.', '%', '/', '*', '(', ')'}; 

        Timer timer;
        public kalkylator()
        {
            InitializeComponent();

            timer = new Timer();

            timer.Tick += Timer_Tick;
            timer.Interval = 500;

           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.outputText.Text = "";
        }

        private void Operatorer(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            this.outputText.Text += button.Text;

        }

        private void Clear(object sender, EventArgs e)
        {
            this.outputText.Text = "";
        }

        private void Equals(object sender, EventArgs e)
        {
            string ekvation = this.outputText.Text;
            try {
                string equals = new DataTable().Compute(ekvation, null).ToString();
                Console.WriteLine(equals);
                this.outputText.Text = equals;
            } catch {
                this.outputText.Text = "ERROR";
                timer.Start();
            }
        }

        private void OutputText_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Equals(null, null);
                e.Handled = true;
            }
            
        }

        private void Del(object sender, EventArgs e)
        {
            if (this.outputText.Text.Length <= 0)
                return;

            string text = this.outputText.Text;
            text = text.Substring(0, text.Length - 1);
            this.outputText.Text = text;
        }

        private void OutputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine();
            bool bokstav = false;
            for (int i = 0; i < numeriska.Count; i++)
            {
                if(e.KeyChar == numeriska[i] || e.KeyChar == 8)
                {
                    bokstav = false;
                    break;
                }
                else
                {
                    bokstav = true;
                }
                
            }

            if (bokstav)
            {
                e.Handled = true;
            }
            
        }
    }
}