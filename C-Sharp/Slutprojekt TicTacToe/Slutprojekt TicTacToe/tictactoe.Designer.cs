namespace Slutprojekt_Poker
{
    partial class tictactoe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.A1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(89, 7);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(79, 68);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(259, 155);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(79, 68);
            this.C3.TabIndex = 1;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(174, 155);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(79, 68);
            this.C2.TabIndex = 2;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(89, 155);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(79, 68);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(174, 81);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(79, 68);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(89, 81);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(79, 68);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(174, 7);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(79, 68);
            this.A2.TabIndex = 6;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(259, 81);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(79, 68);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(259, 7);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(79, 68);
            this.A3.TabIndex = 8;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(4, 7);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(79, 28);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.OnRestart);
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(4, 47);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(79, 28);
            this.Switch.TabIndex = 10;
            this.Switch.Text = "Switch";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.OnSwitch);
            // 
            // tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 233);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.A1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "tictactoe";
            this.ShowIcon = false;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.tictactoe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Switch;
    }
}

