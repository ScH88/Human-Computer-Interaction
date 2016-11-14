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
    public partial class Form18 : Form
    {
        //Form 1 (menu) variable
        public Form1 f1;
        //Form 2 (exhibit) variable
        public Form2 f2;
        //Form 6 (search results) variable
        public Form6 f6;
        //Form 7 (exhibit listing) variable
        public Form7 f7;
        //Form 22 (museum map) variable
        public Form22 f22;

        public Form18()
        {
            InitializeComponent();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //If there is no Form 7 instance
            if (this.f7 == null)
            {
                //Show Form 6
                f6.Show();
            }
            //If there is no Form 6 instance
            else if (this.f6 == null)
            {
                //Show Form 7
                f7.Show();
            }
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

        private void label2_Click(object sender, EventArgs e)
        {
            //If there is no Form 22 instance
            if (f22 == null)
            {
                //Instantiate Form 22
                f22 = new Form22();
            }
            //Show the new Form 22 instance
            f22.Show();
            //Set Form 22's marker's x position
            f22.markerXPos = 80;
            //Set Form 22's marker's y position
            f22.markerYPos = 115;
            //Set Form 22's marker's width
            f22.markerWidth = 150;
            //Set Form 22's marker's height
            f22.markerHeight = 50;
            //Call the Form 22's drawCircle method to draw the circular marker over the transport exhibit part of the map
            f22.drawCircle();
            //Set the directions String of Form 22
            f22.directions = "Go through the entrance, then turn left and go through the Air and Space gallery. It should be immediately to your right";
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

        private void button49_Click(object sender, EventArgs e)
        {
            //If there is not Form 2 instance active
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
