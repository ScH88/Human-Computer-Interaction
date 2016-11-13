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
    public partial class Form8 : Form
    {
        //Variable for Form 1 (Main Page)
        public Form1 f1;
        //Variable for Form 2
        public Form2 f2;
        //Variable for Form 5
        public Form5 f5;
        //String for storing the workshop session
        public String workshopSession;
        //String for storing the workshop time
        public String workshopTime;
        //String for storing the first return text 
        public System.Windows.Forms.Label returnText1;
        //String for storing the second return text
        public System.Windows.Forms.Label returnText2;
  
        //CONSTRUCTOR
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If there is no Form 2 instance
            if (f2 == null)
            {
                //Instantiate Form 2
                f2 = new Form2();
            }
            //Show the new Form 2 instance
            f2.Show();
            //Set Form 2's Form 8 variable as this instance
            f2.f8 = this;
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
