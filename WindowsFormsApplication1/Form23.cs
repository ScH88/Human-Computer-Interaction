using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form23 : Form
    {
        //This form's Form 5 (mobile number and name) value
        public Form5 f5;
        
        //CONSTRUCTOR
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If there is no Form 5
            if (f5 == null)
            {
                //Instantiate form 5
                f5 = new Form5();
            }
            //Enable all buttons in form 5
            f5.button1.Enabled = true;
            f5.button2.Enabled = true;
            f5.button3.Enabled = true;
            f5.button4.Enabled = true;
            f5.button5.Enabled = true;
            f5.button6.Enabled = true;
            f5.button7.Enabled = true;
            f5.button8.Enabled = true;
            f5.button9.Enabled = true;
            f5.button10.Enabled = true;
            f5.button11.Enabled = true;
            f5.button12.Enabled = true;
            f5.button13.Enabled = true;
            f5.button14.Enabled = true;
            f5.button15.Enabled = true;
            f5.button16.Enabled = true;
            f5.button17.Enabled = true;
            f5.button18.Enabled = true;
            f5.button19.Enabled = true;
            f5.button20.Enabled = true;
            f5.button21.Enabled = true;
            f5.button22.Enabled = true;
            f5.button23.Enabled = true;
            f5.button24.Enabled = true;
            f5.button25.Enabled = true;
            f5.button26.Enabled = true;
            f5.button29.Enabled = true;
            f5.button30.Enabled = true;
            f5.button31.Enabled = true;
            f5.button32.Enabled = true;
            f5.button33.Enabled = true;
            f5.button34.Enabled = true;
            f5.button35.Enabled = true;
            f5.button36.Enabled = true;
            f5.button37.Enabled = true;
            f5.button38.Enabled = true;
            f5.button39.Enabled = true;
            f5.button40.Enabled = true;
            f5.button41.Enabled = true;
            f5.button42.Enabled = true;
            f5.button43.Enabled = true;
            f5.button44.Enabled = true;
            f5.button45.Enabled = true;
            f5.button46.Enabled = true;
            f5.button47.Enabled = true;
            f5.button48.Enabled = true;
            f5.button49.Enabled = true;
            f5.button50.Enabled = true;
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
