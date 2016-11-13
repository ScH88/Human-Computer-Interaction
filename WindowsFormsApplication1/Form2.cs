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
    public partial class Form2 : Form
    {
        //Variable for Form 1
        public Form1 f1;
        //Variable for Form 2
        public Form2 f2;
        //Variable for Form 3
        public Form3 f3;
        //Variable for Form 8
        public Form8 f8;
        //Variable for Form 9
        public Form9 f9;

        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //If there is no Form 3 object
            if (f3 == null)
            {
                //Instantiate Form 3
                f3 = new Form3();
            }
            //Show the new Form 3 object
            f3.Show();
            //Set Form 3's Form 2 variable as this instance
            f3.f2 = this;
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
            //If there is no Form 9 instance
            if (f9 == null)
            {
                //Instantiate Form 9
                f9 = new Form9();
            }
            //Show the new Form 9 instance
            f9.Show();
            //Set Form 9's Form 2 variable as this instance
            f9.f2 = this;
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
    }
}
