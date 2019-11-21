using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class kalkylator : Form
    {
        private List<char> numeriska = new List<char> { ',', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '+', '.', '%', '/', '*', '(', ')', '^'}; 
        // Alla karaktärer man ska kunna skriva in i miniräknaren
        Timer timer;
        public kalkylator()
        {
            InitializeComponent();

            timer = new Timer();

            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            // Timern gjordes så att man skulle hinna se ERROR om an fick det, innan gick den bara förbi så man han inte se ERROR
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Clearar fälten när timern tar slut när det blivit en error
            timer.Stop();
            this.outputText.Text = "";
            this.Ekvation.Text = "";
        }

        private void Operatorer(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            this.outputText.Text += button.Text;
            this.Ekvation.Text += button.Text;
        }

        private void Clear(object sender, EventArgs e)
        {
            this.outputText.Text = "";
            this.Ekvation.Text = "";
        }

        private void Equals(object sender, EventArgs e)
        {
            string ekvation = this.outputText.Text;
            try {
                string equals = new DataTable().Compute(ekvation, null).ToString();
                this.outputText.Text = equals;
            } catch {
                this.outputText.Text = "ERROR";
                timer.Start();
            }
        }

        private void OutputText_KeyUp(object sender, KeyEventArgs e) 
        {
            // gör bara så att man ska kunna klicka på enter istället för = på räknaren
            if (e.KeyCode == Keys.Enter)
            {
                Equals(null, null);
                e.Handled = true;
            }
            
        }

        private void Del(object sender, EventArgs e)
        {
            // Deletar bara en karaktär istället för att ta bort hela fältet
            if (this.outputText.Text.Length <= 0)
                return;

            string text = this.outputText.Text;
            text = text.Substring(0, text.Length - 1);
            this.outputText.Text = text;
            this.Ekvation.Text = text;
        }

        private void OutputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Gör så att när man klickar backspace knappen så tar den bort på båda outputsen istället för bara en av de
            if (e.KeyChar == 8)
            {
                if(this.Ekvation.Text.Length > 1)
                    this.Ekvation.Text = this.Ekvation.Text.Substring(0, this.Ekvation.Text.Length - 1);

                if(this.Ekvation.Text.Length == 1)
                    this.Ekvation.Text = this.Ekvation.Text.Substring(0, this.Ekvation.Text.Length - this.Ekvation.Text.Length);
                return;
            }
            // Jämnför tangenten du tryckte med listan av accepterade karaktärer för att se om den är samma annars så läggs den inte in
            bool bokstav = false;
            for (int i = 0; i < numeriska.Count; i++)
            {
                if(e.KeyChar == numeriska[i])
                {
                    bokstav = false;
                    this.Ekvation.Text += e.KeyChar;
                    break;
                } 
                else
                {
                    bokstav = true;
                }
                
            }
            //jag fick något fel när jag inte hade den så lämnar den för säkerhets skull
            if (bokstav)
            {
                e.Handled = true;
            }
            
        }
    }
}