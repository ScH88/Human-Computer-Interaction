using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        //Form 1 variable
        public Form1 f1;
        //Form 2 variable
        public Form2 f2;
        //Form 4 variable
        public Form4 f4;
        //Form 7 variable
        public Form7 f7;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If there is no Form 4 instance
            if (f4 == null)
            {
                //Instantiate Form 4
                f4 = new Form4();
            }
            //Show the new Form 4 instance
            f4.Show();
            //Hide this form
            this.Hide();
        }

        private void button1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button1.BackColor = Color.Yellow;
        }

        private void button1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //If there is no Form 7 instance
            if (f7 == null)
            {
                //Instantiate Form 7
                f7 = new Form7();
            }
            //Show the new Form 7 instance
            f7.Show();
            //Set Form 7's Form 3 variable as this instance
            f7.f3 = this;
            //Hide this form
            this.Hide();
        }

        private void button2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button2.BackColor = Color.Yellow;
        }

        private void button2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //If there is no Form 2 instance
            if (f2 == null)
            {
                //Instantiate Form 2
                f2 = new Form2();
            }
            //Show the new Form 2 instance
            f2.Show();
            //Set Form 2's Form 3 value as this instance
            f2.f3 = this;
            //Hide this form
            this.Hide();
        }

        private void button3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button3.BackColor = Color.Yellow;
        }

        private void button3_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
    }
}
