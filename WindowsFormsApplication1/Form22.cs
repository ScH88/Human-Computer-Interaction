using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form22 : Form
    {
        //Form 1 (main page) variable
        public Form1 f1;
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
        //SpeechSynthesizer for text-to-speech functionality
        public SpeechSynthesizer speaker;
        //String variable for path directions
        public String directions;
        
        //Int variable for the x position of the exhibition marker
        public int markerXPos;
        //Int variable for the y position of the exhibition marker
        public int markerYPos;
        //Int variable for the width of the exhibition marker
        public int markerWidth;
        //Int variable for the height of the exhibition marker
        public int markerHeight;

        public Form22()
        {
            InitializeComponent();
        }

        public void drawCircle()
        {
            //refresh the map image
            pictureBox1.Refresh();
            //Createa a graphics object from the map image
            System.Drawing.Graphics graphics = pictureBox1.CreateGraphics();
            //declare a rectangle object and it's x, y. width and height
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(markerXPos, markerYPos, markerWidth, markerHeight);

            //Declare a pen object of colour red and width of 6
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Red, 6);
            //Draw an ellipse using the pen and rectangle variables
            graphics.DrawEllipse(pen, rectangle);
            //Dispose of the pen object to preserve processing
            pen.Dispose();
            //Dispose of the graphics object
            graphics.Dispose();
        }

        private void button48_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Initialize
            InitializeComponent();
            //Instantiate the SpeechSynthesizer variable
            speaker = new SpeechSynthesizer();
            //Set the speaker voice type to "Microsoft Sam"
            speaker.SelectVoice("Microsoft Sam");
            //Have the speaker speak the content of the "directions" string
            speaker.SpeakAsync(directions);
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
