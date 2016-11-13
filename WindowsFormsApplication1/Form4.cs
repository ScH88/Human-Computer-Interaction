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
    public partial class Form4 : Form
    {
        //The Form 2 (search or apply) value of this form
        public Form2 f2;
        //The Form 3 (how would you like to search) value of this form
        public Form3 f3;
        //The Form 4 (keyboard) value
        public Form4 f4;
        //The Form 6 (search results) value of this form
        public Form6 f6;
        //The Form 1 (main page) value of this form
        public Form1 f1;

        public Form4()
        {
            InitializeComponent();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //If there is no Form 3 instance
            if (f3 == null)
            {
                //Instantiate Form 3
                f3 = new Form3();
            }
            //Show the new Form 3 instance
            f3.Show();
            //Set Form 3's Form 4 variable as this instance
            f3.f4 = this;
            //Delete all contents of this text box
            this.textBox1.Text = "";
            this.Hide();
        }

        private void button35_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button35.BackColor = Color.Yellow;
        }

        private void button35_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button35.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            //If there is no Form 2 instance
            if (f2 == null)
            {
                //Instantiate Form 2
                f2 = new Form2();
            }
            //Show the new Form 2 instance
            f2.Show();
            //Delete all contents of this text box
            this.textBox1.Text = "";
            //Hide this form
            this.Hide();
        }

        private void button36_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button36.BackColor = Color.Yellow;
        }

        private void button36_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button36.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE ENTER BUTTON
        private void button29_Click(object sender, EventArgs e)
        {
            //If there is no Form 6 instance
            if (f6 == null)
            {
                //Instantiate Form 6
                f6 = new Form6();
            }
            //Show the new Form 6 instance
            f6.Show();
            //Set form 6's Form 4 variable as this instance
            f6.f4 = this;
            //Pass the text box's contents to Form 6's resultText variable
            f6.resultText.Text = textBox1.Text;
            //Hide all labels in Form 6 in order to be processed
            f6.label2.Hide();
            f6.label3.Hide();
            f6.label4.Hide();
            f6.label5.Hide();
            f6.label6.Hide();
            f6.label7.Hide();
            f6.label8.Hide();
            f6.label9.Hide();
            f6.label10.Hide();
            f6.label11.Hide();
            f6.label12.Hide();
            f6.label13.Hide();

            //Boolean for if a result is found
            bool resultFound = false;

            //If the value of the text box contains the words "air", "space", "gallery", "helicopter", "shuttle", "jet" or "container"
            if (this.textBox1.Text.Contains("air") || this.textBox1.Text.Contains("space") || this.textBox1.Text.Contains("gallery") || this.textBox1.Text.Contains("helicopter") || this.textBox1.Text.Contains("shuttle") || this.textBox1.Text.Contains("jet") || this.textBox1.Text.Contains("propeller"))
            {
                //Show label 2 of Form 6
                f6.label2.Show();
                //Show label 12 of Form 6
                f6.label12.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "ancient" or "egyptians"
            if (this.textBox1.Text.Contains("ancient") || this.textBox1.Text.Contains("egyptians") || this.textBox1.Text.Contains("pharaoh"))
            {
                //Show label 3 of Form 6 
                f6.label3.Show();
                //Show label 7 of Form 6 
                f6.label7.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "communication", "communications", "telephone", "morse", "internet", "mobile" or "email"
            if (this.textBox1.Text.Contains("communication") || this.textBox1.Text.Contains("communications") || this.textBox1.Text.Contains("telephone") || this.textBox1.Text.Contains("morse") || this.textBox1.Text.Contains("internet") || this.textBox1.Text.Contains("mobile") || this.textBox1.Text.Contains("email"))
            {
                //Show label 4 of Form 6 
                f6.label4.Show();
                //Show label 8 of Form 6 
                f6.label8.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "energy", "power", "fuel", "electric", "gas" or "steam"
            if (this.textBox1.Text.Contains("energy") || this.textBox1.Text.Contains("power") || this.textBox1.Text.Contains("fuel") || this.textBox1.Text.Contains("electric") || this.textBox1.Text.Contains("gas") || this.textBox1.Text.Contains("steam"))
            {
                //Show label 5 of Form 6 
                f6.label5.Show();
                //Show label 6 of Form 6 
                f6.label6.Show();
                //Show label 12 of Form 6 
                f6.label12.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "history" or "timeline
            if (this.textBox1.Text.Contains("history") || this.textBox1.Text.Contains("timeline"))
            {
                //Show label 2 of Form 6
                f6.label2.Show();
                //Show label 3 of Form 6
                f6.label3.Show();
                //Show label 6 of Form 6
                f6.label6.Show();
                //Show label 7 of Form 6
                f6.label7.Show();
                //Show label 8 of Form 6
                f6.label8.Show();
                //Show label 9 of Form 6
                f6.label9.Show();
                //Show label 11 of Form 6
                f6.label11.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "technology", "innovation", "industry" or "revolution"
            if (this.textBox1.Text.Contains("technology") || this.textBox1.Text.Contains("innovation") || this.textBox1.Text.Contains("industry") || this.textBox1.Text.Contains("Revolution"))
            {
                //Show label 4 of Form 6
                f6.label4.Show();
                //Show label 6 of Form 6
                f6.label6.Show();
                //Show label 10 of Form 6
                f6.label10.Show();
                //Show label 12 of Form 6
                f6.label12.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "famous", "people", "king", "queen", "leader", "entertainer", "poet" or "playwright"
            if (this.textBox1.Text.Contains("famous") || this.textBox1.Text.Contains("people") || this.textBox1.Text.Contains("king") || this.textBox1.Text.Contains("Queen") || this.textBox1.Text.Contains("leader") || this.textBox1.Text.Contains("entertainer") || this.textBox1.Text.Contains("poet") || this.textBox1.Text.Contains("playwright"))
            {
                //Show label 8 of Form 6
                f6.label8.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "roman", "romans", "emperor", "caesar" or "gladiator"
            if (this.textBox1.Text.Contains("roman") || this.textBox1.Text.Contains("romans") || this.textBox1.Text.Contains("emperor") || this.textBox1.Text.Contains("caesar") || this.textBox1.Text.Contains("gladiator"))
            {
                //Show label 7 of Form 6
                f6.label7.Show();
                //Show label 9 of Form 6
                f6.label9.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "science", "nature", "animal" or "dinosaur"
            if (this.textBox1.Text.Contains("science") || this.textBox1.Text.Contains("nature") || this.textBox1.Text.Contains("animal") || this.textBox1.Text.Contains("dinosaur"))
            {
                //Show label 10 of Form 6
                f6.label10.Show();
                //Show label 2 of Form 6
                f6.label2.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "transport", "car", "train", "aircraft"
            if (this.textBox1.Text.Contains("transport") || this.textBox1.Text.Contains("car") || this.textBox1.Text.Contains("train") || this.textBox1.Text.Contains("aircraft"))
            {
                //Show label 6 of Form 6
                f6.label6.Show();
                //Show label 12 of Form 6
                f6.label12.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the value of the text box contains the words "war", "world war", "crimean" or "cold war"
            if (this.textBox1.Text.Contains("war") || this.textBox1.Text.Contains("world war") || this.textBox1.Text.Contains("crimean") || this.textBox1.Text.Contains("cold war"))
            {
                //Show label 11 of Form 6
                f6.label11.Show();
                //Set the resultFound boolean to true
                resultFound = true;
            }
            //If the resultFound boolean is still false
            if (!resultFound)
            {
                //Show the form 6's label 13 ("Result not found") label
                f6.label13.Show();
            } else 
            {
                //Call form 6's order method to rearrange the visible labels
                f6.order();
            }

            //Erase all the contents of the text box
            this.textBox1.Text = "";  
            //Hide this form
            this.Hide();
        }

        private void button29_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button29.BackColor = Color.Yellow;
        }

        private void button29_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button29.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void typeKey(String key)
        {
            //String for storing the contents of the text box before the change
            String beforeText = null;
            //String for storing the contents of the text box after the change
            String afterText = null;

            //If the current selector index is the same as the text length (i.e. right at the end of the text)
            if (textBox1.SelectionStart == textBox1.Text.Length)
            {
                //Add the text of this button onto and after the existing text 
                textBox1.Text = textBox1.Text + key;
                //Set the current selector index as the new length (i.e. after the recently added character)
                textBox1.SelectionStart = textBox1.Text.Length;
                //Set focus on the text bar so that the selector index is blinking
                textBox1.Focus();
            }
            //If the current selector index is less than the length of the text (i.e. in the middle the text)
            else if (textBox1.SelectionStart < textBox1.Text.Length)
            {
                //Set the beforeText as a substring of all characters from the beginning of the text to the selector
                beforeText = textBox1.Text.Substring(0, textBox1.SelectionStart);
                //Set the afterText as a substring of the length of the beforeText
                afterText = textBox1.Text.Substring(beforeText.Length);
                //Set the text box contents as a concatenation of the beforeText substring, this button's character in the middle and the afterText substring)
                textBox1.Text = string.Concat(beforeText, key, afterText);
                //Set the current selector index just after the recently added character
                textBox1.SelectionStart = beforeText.Length + 1;
                //Set focus on the text bar so that the selector index is blinking
                textBox1.Focus();
            }
            //If the length of the text is more than 0, but the starting character index is 0 (i.e. before the text)
            else if (textBox1.Text.Length > 0 && textBox1.SelectionStart == 0)
            {
                //Set the afterText as a substring of all characters between the selector and the end of the text
                afterText = textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length);
                //Add this button's character at the beginning of the text
                textBox1.Text = key + textBox1.Text;
                //Set focus on the text bar so that the selector index is blinking
                textBox1.Focus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button10.Text);
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

        private void button11_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button11.Text);
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

        private void button12_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button12.Text);
        }

        private void button12_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button12.BackColor = Color.Yellow;
        }

        private void button12_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button13.Text);
        }

        private void button13_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button13.BackColor = Color.Yellow;
        }

        private void button13_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button14.Text);
        }

        private void button14_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button14.BackColor = Color.Yellow;
        }

        private void button14_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button15.Text);
        }

        private void button15_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button15.BackColor = Color.Yellow;
        }

        private void button15_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button15.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button16.Text);
        }

        private void button16_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button16.BackColor = Color.Yellow;
        }

        private void button16_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button17.Text);
        }

        private void button17_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button17.BackColor = Color.Yellow;
        }

        private void button17_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button18.Text);
        }

        private void button18_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button18.BackColor = Color.Yellow;
        }

        private void button18_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button18.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button19.Text);
        }

        private void button19_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button19.BackColor = Color.Yellow;
        }

        private void button19_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button19.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button1.Text);
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
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button2.Text);
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
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button3.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button4.Text);
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
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button5.Text);
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

        private void button6_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button6.Text);
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

        private void button7_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button7.Text);
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

        private void button8_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button8.Text);
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
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button9.Text);
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

        private void button20_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button20.Text);
        }

        private void button20_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button20.BackColor = Color.Yellow;
        }

        private void button20_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button20.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button21.Text);
        }

        private void button21_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button21.BackColor = Color.Yellow;
        }

        private void button21_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button21.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button22.Text);
        }

        private void button22_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button22.BackColor = Color.Yellow;
        }

        private void button22_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button22.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button23.Text);
        }

        private void button23_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button23.BackColor = Color.Yellow;
        }

        private void button23_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button23.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button24.Text);
        }

        private void button24_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button24.BackColor = Color.Yellow;
        }

        private void button24_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button24.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button25.Text);
        }

        private void button25_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button25.BackColor = Color.Yellow;
        }

        private void button25_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button25.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it this button's respective text value
            typeKey(button26.Text);
        }

        private void button26_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button26.BackColor = Color.Yellow;
        }

        private void button26_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button26.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE SPACE KEY
        private void button30_Click(object sender, EventArgs e)
        {
            //Call the typeKey method, passing it a blank space as a String
            typeKey(" ");
        }

        private void button30_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button30.BackColor = Color.Yellow;
        }

        private void button30_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button30.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE BACKSPACE KEY
        private void button31_Click(object sender, EventArgs e)
        {
            //String for the text before the selector index
            String beforeText = null;
            //String for the text after the selector index
            String afterText = null;

            //If the selector index is more than 0 (if there are characters before the backspace)
            if (textBox1.SelectionStart > 0)
            {
                //If the current selector index is the same as the text length (i.e. right at the end of the text)
                if (textBox1.SelectionStart == textBox1.Text.Length)
                {
                    //Set the text in the box as a substring of characters between the start and the character before the end
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    //Set the current selector index as the end of the text box value
                    textBox1.SelectionStart = textBox1.Text.Length;
                    //Set focus on the text bar so that the selector index is blinking
                    textBox1.Focus();
                }
                //If the current selector index is less than the length of the text (i.e. in the middle the text)
                else if (textBox1.SelectionStart < textBox1.Text.Length)
                {
                    //Set the beforeText as a substring of characters between the start and the character before the selector index
                    beforeText = textBox1.Text.Substring(0, textBox1.SelectionStart - 1);
                    //Set hte afterText as a substring of characters after the selector index
                    afterText = textBox1.Text.Substring(textBox1.SelectionStart);

                    //Set the text box's text contnets as a concatenation of the beforeText and afterText
                    textBox1.Text = string.Concat(beforeText, afterText);
                    //Set the new selector index as the beforeText's length
                    textBox1.SelectionStart = beforeText.Length;
                    //Set focus on the text bar so that the selector index is blinking
                    textBox1.Focus();
                }
            }
        }

        private void button31_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button31.BackColor = Color.Yellow;
        }

        private void button31_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button31.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE LEFT KEY
        private void button32_Click(object sender, EventArgs e)
        {
            //If the text box's selector is greater than 0
            if (textBox1.SelectionStart > 0)
            {
                //Shift the selector index one character left
                textBox1.SelectionStart--;
                //Set focus on the text bar so that the selector index is blinking
                textBox1.Focus();
            }
        }

        private void button32_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button32.BackColor = Color.Yellow;
        }

        private void button32_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button32.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE RIGHT KEY
        private void button33_Click(object sender, EventArgs e)
        {
            //If the selector is less than the length of the text
            if (textBox1.SelectionStart < textBox1.Text.Length)
            {
                //Shift the selector one character right
                textBox1.SelectionStart++;
                //Set focus on the text bar so that the selector index is blinking
                textBox1.Focus();
            }
        }

        private void button33_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button33.BackColor = Color.Yellow;
        }

        private void button33_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button33.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //FUNCTION FOR DELETE BUTTON
        private void button34_Click(object sender, EventArgs e)
        {
            //String for getting the text before the selector index
            String beforeText;
            //String for getting the text after the selector index
            String afterText;
            //If the current selector is less than the length of the text (if there are  any characters after the selector index)
            if (textBox1.SelectionStart < textBox1.Text.Length)
            {
                //Set the beforeText as a substring of characters between the start and the selector index
                beforeText = textBox1.Text.Substring(0, textBox1.SelectionStart);
                //Set the afterText as a substring of characters after the character after the selection index
                afterText = textBox1.Text.Substring(textBox1.SelectionStart + 1);
                //Define the text value in the box as a concatenation of the beforeText and afterText
                textBox1.Text = string.Concat(beforeText, afterText);
                //Set the current selector index as the same as the current position
                textBox1.SelectionStart = beforeText.Length;
                //Set focus on the text bar so that the selector index is blinking
                textBox1.Focus();
            }
        }

        private void button34_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button34.BackColor = Color.Yellow;
        }

        private void button34_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button34.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
    }
}
