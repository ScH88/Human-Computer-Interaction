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

    //Partial class = Allows code to be added without recreating the source file; Result of spreading a class across multiple seperate files
    //Form1 : Form = Form1 extends the Form class
    public partial class Form1 : Form
    {
        //Form2 variable
        public Form2 f2;

        //Form1 constructor
        public Form1()
        {
            //Call the InitializeComponent method
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //If the f2 variable is null
            if (f2 == null)
            {
                //Instantiate the f2 as a new Form2 object
                f2 = new Form2();
            }
            //Show the Form 2 window
            f2.Show();
            //Set the Form2 object's f1 value as this form instance
            f2.f1 = this;
            //hide this instance
            this.Hide();
            }
        }
    }
