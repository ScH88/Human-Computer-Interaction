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
    public partial class Form10 : Form
    {
        //Variable for storing Form 1
        public Form1 f1;
        //Variable for storing Form 2
        public Form2 f2;
        //Variable for storing Form 5
        public Form5 f5;
        //Variable for storing Form 9
        public Form9 f9;
        //String for storing the type of workshop session
        public String workshopSession;

        public Form10()
        {
            InitializeComponent();
        }

        private void nextForm(String wsTime)
        {
            //If there is no Form 5 instance
            if (f5 == null)
            {
                //Instantiate Form 5
                f5 = new Form5();
            }
            //Show the new Form 5
            f5.Show();
            //Set Form 5's workshop session string as the same as this form's
            f5.workshopSession = this.workshopSession;
            //Set Form 5's workshop time string as the String passed to the parameter
            f5.workshopTime = wsTime;
            //Hide this form
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Thursday 4:00pm");
        }

        private void label22_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label22.BackColor = Color.Yellow;
        }

        private void label22_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label22.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Wednesday 3:00pm");
        }

        private void label33_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label33.BackColor = Color.Yellow;
        }

        private void label33_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label33.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Friday 11:00am");
        }

        private void label39_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label39.BackColor = Color.Yellow;
        }

        private void label39_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label39.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Wednesday 11:00am");
        }

        private void label38_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label38.BackColor = Color.Yellow;
        }

        private void label38_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label38.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label37_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Monday 1:00pm");
        }

        private void label37_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label37.BackColor = Color.Yellow;
        }

        private void label37_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label37.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Saturday 2:00pm");
        }

        private void label36_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label36.BackColor = Color.Yellow;
        }

        private void label36_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label36.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Friday 2:00pm");
        }

        private void label35_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label35.BackColor = Color.Yellow;
        }

        private void label35_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label35.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Thursday 2:00pm");
        }

        private void label34_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label34.BackColor = Color.Yellow;
        }

        private void label34_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label34.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Saturday 11:00am");
        }

        private void label40_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label40.BackColor = Color.Yellow;
        }

        private void label40_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label40.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Tuesday 2:00pm");
        }

        private void label32_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label32.BackColor = Color.Yellow;
        }

        private void label32_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label32.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Monday 2:00pm");
        }

        private void label31_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label31.BackColor = Color.Yellow;
        }

        private void label31_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label31.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label30_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Saturday 4:00pm");
        }

        private void label30_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label30.BackColor = Color.Yellow;
        }

        private void label30_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label30.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Saturday 5:00pm");
        }

        private void label29_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label29.BackColor = Color.Yellow;
        }

        private void label29_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label29.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Friday 5:00pm");
        }

        private void label28_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label28.BackColor = Color.Yellow;
        }

        private void label28_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label28.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Friday 4:00pm");
        }

        private void label27_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label27.BackColor = Color.Yellow;
        }

        private void label27_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label27.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Thursday 5:00pm");
        }

        private void label26_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label26.BackColor = Color.Yellow;
        }

        private void label26_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label26.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Wednesday 5:00pm");
        }

        private void label25_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label25.BackColor = Color.Yellow;
        }

        private void label25_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label25.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Tuesday 6:00pm");
        }

        private void label24_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label24.BackColor = Color.Yellow;
        }

        private void label24_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label24.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Monday 5:00pm");
        }

        private void label23_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label23.BackColor = Color.Yellow;
        }

        private void label23_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label23.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Wednesday 4:00pm");
        }

        private void label21_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label21.BackColor = Color.Yellow;
        }

        private void label21_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label21.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Tuesday 4:00pm");
        }

        private void label20_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label20.BackColor = Color.Yellow;
        }

        private void label20_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label20.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Monday 4:00pm");
        }

        private void label19_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label19.BackColor = Color.Yellow;
        }

        private void label19_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label19.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Saturday 11:00am");
        }

        private void label18_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label18.BackColor = Color.Yellow;
        }

        private void label18_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label18.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Friday 11:00am");
        }

        private void label17_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label17.BackColor = Color.Yellow;
        }

        private void label17_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label17.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Thursday 11:00am");
        }

        private void label16_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label16.BackColor = Color.Yellow;
        }

        private void label16_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label16.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Wednesday 11:00am");
        }

        private void label15_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label15.BackColor = Color.Yellow;
        }

        private void label15_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label15.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Tuesday 11:00am");
        }

        private void label14_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label14.BackColor = Color.Yellow;
        }

        private void label14_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label14.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //Call the nextForm method and pass it the following String
            nextForm("Monday 11:00am");
        }

        private void label13_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour to yellow
            this.label13.BackColor = Color.Yellow;
        }

        private void label13_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this label's background colour back to it's default
            this.label13.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //If there is no Form 2 instance
            if (f2 == null)
            {
                //Instantiate Form 2
                f2 = new Form2();
            }
            //Show the new Form 2
            f2.Show();
            //Set the workshop session string to null
            this.workshopSession = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            //If there is no Form 9 instance
            if (f9 == null)
            {
                //Instantiate Form 9
                f9 = new Form9();
            }
            //Show the new Form 9
            f9.Show();
            //Set the workshop session string to null
            this.workshopSession = "";
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
    }
}
