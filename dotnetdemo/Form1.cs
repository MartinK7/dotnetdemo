using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dotnetdemo
{
    public partial class Form1 : Form
    {
        private Timer timer;
        int Value = 25;
        int Value2 = 0;

        public Form1()
        {
            InitializeComponent();

            // Set the form's start position to manual to specify the location
            this.StartPosition = FormStartPosition.Manual;

            // Set the form's location to the top-left corner (0, 0)
            this.Location = new System.Drawing.Point(0, 0);

            // Maximize the form
            this.WindowState = FormWindowState.Maximized;

            // Set up the timer
            this.timer = new Timer
            {
                Interval = 250
            };
            this.timer.Tick += new EventHandler(this.OnTimerTick);
            this.timer.Start();

            textBox1.Text = Value.ToString() + " C";
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            // Get the current mouse position
            var position = Cursor.Position;

            // Update the label text
            this.textBox2.Text = "Mouse Position: X = " + position.X.ToString() + ", Y = " + position.Y.ToString();

            Value2 = (Value2 + 5) % 100;
            progressBar1.Value = Value2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Value = Value + 1;
            textBox1.Text = Value.ToString() + " C";
        }
    }
}
