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
    public partial class Form6 : Form
    {
        //Form variables for forms related to this form or any of it's functions
        public Form1 f1;
        public Form2 f2;
        public Form4 f4;
        public Form11 f11;
        public Form12 f12;
        public Form13 f13;
        public Form14 f14;
        public Form15 f15;
        public Form16 f16;
        public Form17 f17;
        public Form18 f18;
        public Form19 f19;
        public Form20 f20;
        public Form21 f21;

        public System.Windows.Forms.Label resultText;

        public Form6()
        {
            //Initialise all labels and buttons and set their attributes by calling the InitializeComponent method in the .Designer.cs version of this form
            InitializeComponent();
        }

        public void order()
        {
            //Integer for current Y position, with default value of 110
            int currentY = 110;

            //If label 13 ("results not found" text) is hidden
            if (!label13.Visible)
            {
                //If label 2 is visible
                if (label2.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label2.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 3 is visible
                if (label3.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label3.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 4 is visible
                if (label4.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label4.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 5 is visible
                if (label5.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label5.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 6 is visible
                if (label6.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label6.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 7 is visible
                if (label7.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label7.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 8 is visible
                if (label8.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label8.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 9 is visible
                if (label9.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label9.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 10 is visible
                if (label10.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label10.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 11 is visible
                if (label11.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label11.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
                //If label 12 is visible
                if (label12.Visible)
                {
                    //Set the new location of the label, passing the currentY value for the new Y position 
                    label12.Location = new Point(106, currentY);
                    //Increase the current Y integer by 45
                    currentY += 45;
                }
            }
        }
        
        private void button48_Click(object sender, EventArgs e)
        {
            //If there is no Form 4 instance
            if (f4 == null)
            {
                //Instantiate Form 4
                f4 = new Form4();
            }
            //Show the new Form 4 instance
            f4.Show();
            //Set Form 4's Form 6 variable as this instance
            f4.f6 = this;
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

        private void label2_Click(object sender, EventArgs e)
        {
            //If there is no Form 11 instance
            if (f11 == null)
            {
                //Instantiate Form 11
                f11 = new Form11();
            }
            //Show the new Form 11 instance
            f11.Show();
            //Set Form 11's Form 6 variable as this instance
            f11.f6 = this;
            //Set Form 11's Form 7 variable as null
            f11.f7 = null;
            this.Hide();
        }

        private void label2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label2.BackColor = Color.Yellow;
        }

        private void label2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //If there is no Form 20 instance
            if (f20 == null)
            {
                //Instantiate Form 20
                f20 = new Form20();
            }
            //Show the new Form 20 instance
            f20.Show();
            //Set Form 20's Form 6 variable as this instance
            f20.f6 = this;
            //Set Form 20's Form 7 variable as null
            f20.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label3.BackColor = Color.Yellow;
        }

        private void label3_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //If there is no Form 12 instance
            if (f12 == null)
            {
                //Instantiate Form 12
                f12 = new Form12();
            }
            //Show the new Form 12 instance
            f12.Show();
            //Set Form 12's Form 6 variable as this instance
            f12.f6 = this;
            //Set Form 12's Form 7 variable as null
            f12.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label4_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label4.BackColor = Color.Yellow;
        }

        private void label4_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //If there is no Form 13 instance
            if (f13 == null)
            {
                //Instantiate Form 13
                f13 = new Form13();
            }
            //Show the new Form 13 instance
            f13.Show();
            //Set Form 13's Form 6 variable as this instance
            f13.f6 = this;
            //Set Form 13's Form 7 variable as null
            f13.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label5_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label5.BackColor = Color.Yellow;
        }

        private void label5_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //If there is no Form 14 instance
            if (f14 == null)
            {
                //Instantiate Form 14
                f14 = new Form14();
            }
            //Show the new Form 14 instance
            f14.Show();
            //Set Form 14's Form 6 variable as this instance
            f14.f6 = this;
            //Set Form 14's Form 7 variable as null
            f14.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label7_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label7.BackColor = Color.Yellow;
        }

        private void label7_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //If there is no Form 15 instance
            if (f15 == null)
            {
                //Instantiate Form 15
                f15 = new Form15();
            }
            //Show the new Form 15 instance
            f15.Show();
            //Set Form 15's Form 6 variable as this instance
            f15.f6 = this;
            //Set Form 15's Form 7 variable as null
            f15.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label6_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label6.BackColor = Color.Yellow;
        }

        private void label6_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //If there is no Form 16 instance
            if (f16 == null)
            {
                //Instantiate Form 16
                f16 = new Form16();
            }
            //Show the new Form 16 instance
            f16.Show();
            //Set Form 16's Form 6 variable as this instance
            f16.f6 = this;
            //Set Form 16's Form 7 variable as null
            f16.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label8_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label8.BackColor = Color.Yellow;
        }

        private void label8_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //If there is no Form 19 instance
            if (f19 == null)
            {
                //Instantiate Form 19
                f19 = new Form19();
            }
            //Show the new Form 19 instance
            f19.Show();
            //Set Form 19's Form 6 variable as this instance
            f19.f6 = this;
            //Set Form 19's Form 7 variable as null
            f19.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label9_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label9.BackColor = Color.Yellow;
        }

        private void label9_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //If there is no Form 17 instance
            if (f17 == null)
            {
                //Instantiate Form 17
                f17 = new Form17();
            }
            //Show the new Form 17 instance
            f17.Show();
            //Set Form 17's Form 6 variable as this instance
            f17.f6 = this;
            //Set Form 17's Form 7 variable as null
            f17.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label10_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label10.BackColor = Color.Yellow;
        }

        private void label10_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //If there is no Form 18 instance
            if (f18 == null)
            {
                //Instantiate Form 18
                f18 = new Form18();
            }
            //Show the new Form 18 instance
            f18.Show();
            //Set Form 18's Form 6 variable as this instance
            f18.f6 = this;
            //Set Form 18's Form 7 variable as null
            f18.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label12_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label12.BackColor = Color.Yellow;
        }

        private void label12_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //If there is no Form 21 instance
            if (f21 == null)
            {
                //Instantiate Form 21
                f21 = new Form21();
            }
            //Show the new Form 21 instance
            f21.Show();
            //Set Form 21's Form 6 variable as this instance
            f21.f6 = this;
            //Set Form 21's Form 7 variable as null
            f21.f7 = null;
            //Hide this form
            this.Hide();
        }

        private void label11_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label11.BackColor = Color.Yellow;
        }

        private void label11_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

    }
}
       
    

       
    

