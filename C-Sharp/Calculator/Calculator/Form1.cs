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
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            this.outputText.Text += button.Text;

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            this.outputText.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
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
                Button2_Click(null, null);
                e.Handled = true;
            }
        }

        
    }
}