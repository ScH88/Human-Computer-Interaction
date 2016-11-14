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
    public partial class Form24 : Form
    {
        //This form's Form 5 (mobile and name) value
        public Form5 f5;
        //This form's Form 8 (workshop booking completed) value
        public Form8 f8;

        public Form24()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            //If form 8 is null
            if (f8 == null)
            {
                //Instantiate form 8
                f8 = new Form8();
            }
            //Show the new Form 8 instance
            f8.Show();
            //Set Form 8's Form 5 variable as this instance
            f8.f5 = f5;
            //Pass the content of both text boxes as well as the workshop session and time to form 8's variables
            f8.returnText1.Text = f5.textBox1.Text;
            f8.returnText2.Text = f5.textBox2.Text;
            //Set Form 8's label 5 text value as the workshop session
            f8.label5.Text = this.f5.workshopSession;
            //Set Form 8's laben 7 text value as the workshop time
            f8.label7.Text = this.f5.workshopTime;
            //Clear both text boxes aof all content
            f5.textBox1.Text = "";
            f5.textBox2.Text = "";
            //Enable all buttons in form 5 again
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
            //Hide form 5
            f5.Hide();
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
