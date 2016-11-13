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
    public partial class Form9 : Form
    {
        //This form's Form 1 (start) value
        public Form1 f1;
        //This form's Form 2 (main menu) value
        public Form2 f2;
        //This form's Form 10 (workshop times) value
        public Form10 f10;

        public Form9()
        {
            InitializeComponent();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //If there is no Form 2 instance
            if (f2 == null)
            {
                //Instantiate Form 2
                f2 = new Form2();
            }
            //Show the new Form 2 instance
            f2.Show();
            //Set Form 2's Form 9 value as this instance
            f2.f9 = this;
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
            //If there is no Form 10 instance
            if (f10 == null)
            {
                //Instantiate Form 10
                f10 = new Form10();
            }
            //Show the new Form 10 instance
            f10.Show();
            //Set Form 10's Form 9 value as this instance
            f10.f9 = this;
            //Hide all the necessary labels in the Form 10 instance
            f10.label13.Hide();
            f10.label14.Hide();
            f10.label15.Hide();
            f10.label16.Hide();
            f10.label17.Hide();
            f10.label18.Hide();
            f10.label19.Hide();
            f10.label20.Hide();
            f10.label21.Hide();
            f10.label22.Hide();
            f10.label23.Hide();
            f10.label24.Hide();
            f10.label25.Hide();
            f10.label26.Hide();
            f10.label27.Hide();
            f10.label28.Hide();
            f10.label29.Hide();
            f10.label30.Hide();
            f10.label31.Hide();
            f10.label32.Hide();
            f10.label33.Hide();
            f10.label34.Hide();
            f10.label35.Hide();
            f10.label36.Hide();
            f10.label37.Show();
            f10.label38.Show();
            f10.label39.Show();
            f10.label40.Show();
            //Set the Form 10's workShopSession string value as label 2's text value
            f10.workshopSession = label2.Text;
            //Hide this form
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
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //If there is no Form 10 instance
            if (f10 == null)
            {
                //Instantiate Form 10
                f10 = new Form10();
            }
            //Show the new Form 10 instance
            f10.Show();
            //Set Form 10's Form 9 value as this instance
            f10.f9 = this;
            //Hide all the necessary labels in the Form 10 instance
            f10.label13.Hide();
            f10.label14.Hide();
            f10.label15.Hide();
            f10.label16.Hide();
            f10.label17.Hide();
            f10.label18.Hide();
            f10.label23.Hide();
            f10.label24.Hide();
            f10.label25.Hide();
            f10.label26.Hide();
            f10.label28.Hide();
            f10.label29.Hide();
            f10.label31.Hide();
            f10.label32.Hide();
            f10.label33.Hide();
            f10.label34.Hide();
            f10.label35.Hide();
            f10.label36.Hide();
            f10.label37.Show();
            f10.label38.Show();
            f10.label39.Show();
            f10.label40.Show();
            f10.label19.Show();
            f10.label20.Show();
            f10.label21.Show();
            f10.label22.Show();
            f10.label27.Show();
            f10.label30.Show();
            //Set Form 10's workShopSession string as label 3's text
            f10.workshopSession = label3.Text;
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
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //If there is no Form 10 instance
            if (f10 == null)
            {
                //Instantiate Form 10
                f10 = new Form10();
            }
            //Show the new Form 10 instance
            f10.Show();
            //Set Form 10's Form 9 value as this instance
            f10.f9 = this;
            //Hide all the necessary labels in the Form 10 instance
            f10.label19.Hide();
            f10.label20.Hide();
            f10.label21.Hide();
            f10.label22.Hide();
            f10.label23.Hide();
            f10.label24.Hide();
            f10.label25.Hide();
            f10.label26.Hide();
            f10.label27.Hide();
            f10.label28.Hide();
            f10.label29.Hide();
            f10.label30.Hide();
            f10.label31.Hide();
            f10.label32.Hide();
            f10.label33.Hide();
            f10.label34.Hide();
            f10.label35.Hide();
            f10.label36.Hide();
            f10.label37.Hide();
            f10.label38.Hide();
            f10.label39.Hide();
            f10.label40.Hide();
            f10.label13.Show();
            f10.label14.Show();
            f10.label15.Show();
            f10.label16.Show();
            f10.label17.Show();
            f10.label18.Show();
            //Set Form 10's workShopSession string as label 4's text
            f10.workshopSession = label4.Text;
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
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //If there is no Form 10 instance
            if (f10 == null)
            {
                //Instantiate Form 10
                f10 = new Form10();
            }
            //Show the new Form 10 instance
            f10.Show();
            //Set Form 10's Form 9 value as this instance
            f10.f9 = this;
            //Hide all the necessary labels in the Form 10 instance
            f10.label13.Hide();
            f10.label14.Hide();
            f10.label15.Hide();
            f10.label16.Hide();
            f10.label17.Hide();
            f10.label18.Hide();
            f10.label19.Hide();
            f10.label20.Hide();
            f10.label21.Hide();
            f10.label22.Hide();
            f10.label27.Hide();
            f10.label30.Hide();
            f10.label31.Hide();
            f10.label32.Hide();
            f10.label33.Hide();
            f10.label34.Hide();
            f10.label35.Hide();
            f10.label36.Hide();
            f10.label37.Hide();
            f10.label38.Hide();
            f10.label39.Hide();
            f10.label40.Hide();
            f10.label23.Show();
            f10.label24.Show();
            f10.label25.Show();
            f10.label26.Show();
            f10.label28.Show();
            f10.label29.Show();
            //Set Form 10's workShopSession string as label 5's text
            f10.workshopSession = label5.Text;
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
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //If there is no Form 10 instance
            if (f10 == null)
            {
                //Instantiate Form 10
                f10 = new Form10();
            }
            //Show the new Form 10 instance
            f10.Show();
            //Set Form 10's Form 9 value as this instance
            f10.f9 = this;
            //Hide all the necessary labels in the Form 10 instance
            f10.label13.Hide();
            f10.label14.Hide();
            f10.label15.Hide();
            f10.label16.Hide();
            f10.label17.Hide();
            f10.label18.Hide();
            f10.label19.Hide();
            f10.label20.Hide();
            f10.label21.Hide();
            f10.label22.Hide();
            f10.label23.Hide();
            f10.label24.Hide();
            f10.label25.Hide();
            f10.label26.Hide();
            f10.label27.Hide();
            f10.label28.Hide();
            f10.label29.Hide();
            f10.label30.Hide();
            f10.label37.Hide();
            f10.label38.Hide();
            f10.label39.Hide();
            f10.label40.Hide();
            f10.label31.Show();
            f10.label32.Show();
            f10.label33.Show();
            f10.label34.Show();
            f10.label35.Show();
            f10.label36.Show();
            //Set Form 10's workShopSession string as label 11's text
            f10.workshopSession = label11.Text;
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
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
        }
    }
}
