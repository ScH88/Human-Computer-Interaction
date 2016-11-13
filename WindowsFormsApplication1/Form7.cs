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
    public partial class Form7 : Form
    {
        //Variable for Form 1
        public Form1 f1;
        //Variable for Form 2
        public Form2 f2;
        //Variable for Form 3
        public Form3 f3;
        //Variable for Form 4
        public Form4 f4;
        //Variable for Form 11
        public Form11 f11;
        //Variable for Form 12
        public Form12 f12;
        //Variable for Form 13
        public Form13 f13;
        //Variable for Form 14
        public Form14 f14;
        //Variable for Form 15
        public Form15 f15;
        //Variable for Form 16
        public Form16 f16;
        //Variable for Form 17
        public Form17 f17;
        //Variable for Form 18
        public Form18 f18;
        //Variable for Form 19
        public Form19 f19;
        //Variable for Form 20
        public Form20 f20;
        //Variable for Form 21
        public Form21 f21;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If there is no Form 11 instance
            if (f11 == null)
            {
                //Instantiate Form 11
                f11 = new Form11();
            }
            //Show the new Form 11 instance
            f11.Show();
            //Set Form 11's Form 7 value as this instance
            f11.f7 = this;
            //Set Form 11's Form 6 value as null
            f11.f6 = null;
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
            //If there is no Form 12 instance
            if (f12 == null)
            {
                //Instantiate Form 12
                f12 = new Form12();
            }
            //Show the new Form 12 instance
            f12.Show();
            //Set Form 12's Form 7 value as this instance
            f12.f7 = this;
            //Set Form 11's Form 6 value as null
            f12.f6 = null;
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
            //If there is no Form 13 instance
            if (f13 == null)
            {
                //Instantiate Form 13
                f13 = new Form13();
            }
            //Show the new Form 13 instance
            f13.Show();
            //Set Form 13's Form 7 value as this instance
            f13.f7 = this;
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

        private void button8_Click(object sender, EventArgs e)
        {
            //If there is no Form 14 instance
            if (f14 == null)
            {
                //Instantiate Form 14
                f14 = new Form14();
            }
            //Show the new Form 14 instance
            f14.Show();
            //Set Form 14's Form 7 value as this instance
            f14.f7 = this;
            //Hide this form
            this.Hide();
        }

        private void button8_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button8.BackColor = Color.Yellow;
        }

        private void button8_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //If there is no Form 20 instance
            if (f20 == null)
            {
                //Instantiate Form 20
                f20 = new Form20();
            }
            //Show the new Form 20 instance
            f20.Show();
            //Set Form 20's Form 7 value as this instance
            f20.f7 = this;
            //Set Form 20's Form 6 value as null
            f20.f6 = null;
            //Hide this form
            this.Hide();
        }

        private void button9_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button9.BackColor = Color.Yellow;
        }

        private void button9_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //If there is no Form 15 instance
            if (f15 == null)
            {
                //Instantiate Form 15
                f15 = new Form15();
            }
            //Show the new Form 15 instance
            f15.Show();
            ////Set Form 15's Form 7 value as this instance
            f15.f7 = this;
            //Set Form 15's Form 6 value as null
            f15.f6 = null;
            //Hide this form
            this.Hide();
        }

        private void button4_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button4.BackColor = Color.Yellow;
        }

        private void button4_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //If there is no Form 16 instance
            if (f16 == null)
            {
                //Instantiate Form 16
                f16 = new Form16();
            }
            f16.Show();
            //Set Form 16's Form 7 value as this instance
            f16.f7 = this;
            //Set Form 16's Form 6 value as null
            f16.f6 = null;
            //Hide this form
            this.Hide();
        }

        private void button5_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button5.BackColor = Color.Yellow;
        }

        private void button5_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //If there is no Form 19 instance
            if (f19 == null)
            {
                //Instantiate Form 19
                f19 = new Form19();
            }
            //Show the new Form 19 instance
            f19.Show();
            //Set Form 19's Form 7 value as this instance
            f19.f7 = this;
            //Set Form 19's Form 6 value as null
            f19.f6 = null;
            //Hide this form
            this.Hide();
        }

        private void button10_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button10.BackColor = Color.Yellow;
        }

        private void button10_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //If there is no Form 17 instance
            if (f17 == null)
            {
                //Instantiate Form 17
                f17 = new Form17();
            }
            //Show the new Form 17 instance
            f17.Show();
            //Set Form 17's Form 7 value as this instance
            f17.f7 = this;
            //Set Form 17's Form 6 value as this instance
            f17.f6 = null;
            //Hide this form
            this.Hide();
        }

        private void button7_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button7.BackColor = Color.Yellow;
        }

        private void button7_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //If there is no Form 18 instance
            if (f18 == null)
            {
                //Instantiate Form 18
                f18 = new Form18();
            }
            //Show the new Form 18 instance
            f18.Show();
            //Set Form 18's Form 7 value as this instance
            f18.f7 = this;
            //Set Form 18's Form 6 value as null
            f18.f6 = null;
            this.Hide();
        }

        private void button6_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button6.BackColor = Color.Yellow;
        }

        private void button6_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //If there is no Form 21 instance
            if (f21 == null)
            {
                //Instantiate Form 21
                f21 = new Form21();
            }
            //Show the new Form 21 instance
            f21.Show();
            //Set Form 21's Form 7 value as this instance
            f21.f7 = this;
            //Set Form 21's Form 6 value as null
            f21.f6 = null;
            this.Hide();
        }

        private void button11_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button11.BackColor = Color.Yellow;
        }

        private void button11_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //If there is no Form 3 instance
            if (f3 == null)
            {
                //Instantiate Form 2
                f3 = new Form3();
            }
            //Show the new Form 3 instance
            f3.Show();
            //Set Form 3's Form 7 value as this instance
            f3.f7 = this;
            //Hide this form
            this.Hide();
        }

        private void button48_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button48.BackColor = Color.Yellow;
        }

        private void button48_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button48.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //If there is no Form 2 instance
            if (f2 == null)
            {
                //Instantiate Form 2
                f2 = new Form2();
            }
            //Show the new Form 2 instance
            f2.Show();
            //Hide this form
            this.Hide();
        }

        private void button49_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button49.BackColor = Color.Yellow;
        }

        private void button49_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button49.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
    } 
}
