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
    public partial class Form5 : Form
    {
        //Form 1 (main page) variable
        public Form1 f1;
        //Form 2 (what would you like to do?) variable
        public Form2 f2;
        //Form 8 (workshop booking confirmation) variable
        public Form8 f8;
        //Form 9 (workshop listing) variable
        public Form9 f9;
        //Form 23 (invalid input) variable
        public Form23 f23; 
        //Form 24 (confirmation) variable
        public Form24 f24;
        //String for storing the workshop session from previous forms
        public String workshopSession;
        //String for storing the workshop time from previous forms
        public String workshopTime;
        
        public Form5()
        {
            InitializeComponent();
        }



        private void button48_Click(object sender, EventArgs e)
        {
            //If there is not F9 instance
            if (f9 == null)
            {
                //Instantiate Form 9
                f9 = new Form9();
            }
            //Show the new Form 9 instance
            f9.Show();
            //Erase the contents of both text boxes
            textBox1.Text = "";
            textBox1.Text = "";
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
            //If there is not F2 instance
            if (f2 == null)
            {
                f2 = new Form2();
            }
            f2.Show();
            //Erase the contents of both text boxes
            textBox1.Text = "";
            textBox1.Text = "";
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

        private void button29_Click(object sender, EventArgs e)
        {
            //Disable all buttons in this form
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;
            button48.Enabled = false;
            button49.Enabled = false;
            button50.Enabled = false;
            //If both text boxes are empty, or if the first box's value length is less than 5 characters or the second less than 11
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox1.Text.Length < 5  || textBox2.Text.Length < 11)
            {
                //If there is no Form 23 instance
                if (f23 == null)
                {
                    //Instantiate Form 23
                    f23 = new Form23();
                }
                //Show the new Form 23 instance
                f23.Show();
                //Set form 23's Form 5 variable as this instance
                f23.f5 = this;
                //Return from this method
                return;
            }
            //Otherwise
            else
            {
                //If there is no Form 24 instance
                if (f24 == null)
                {
                    //Instantiate Form 24
                    f24 = new Form24();
                }
                //Show the new Form 24 instance
                f24.Show();
                //Set form 24's Form 5 variable as this instance
                f24.f5 = this;
            }
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

        private void typeKey1(String key)
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
            }
            //If the length of the text is more than 0, but the starting character index is 0 (i.e. before the text)
            else if (textBox1.Text.Length > 0 && textBox1.SelectionStart == 0)
            {
                //Set the afterText as a substring of all characters between the selector and the end of the text
                afterText = textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length);
                //Add this button's character at the beginning of the text
                textBox1.Text = key + textBox1.Text;
            }
        }

        private void typeKey2(String key)
        {
            //String for storing the contents of the text box before the change
            String beforeText = null;
            //String for storing the contents of the text box after the change
            String afterText = null;

            //If the current selector index is the same as the text length (i.e. right at the end of the text)
            if (textBox2.SelectionStart == textBox2.Text.Length)
            {
                //Add the text of this button onto and after the existing text 
                textBox2.Text = textBox2.Text + key;
                //Set the current selector index as the new length (i.e. after the recently added character)
                textBox2.SelectionStart = textBox2.Text.Length;
            }
            //If the current selector index is less than the length of the text (i.e. in the middle the text)
            else if (textBox2.SelectionStart < textBox2.Text.Length)
            {
                //Set the beforeText as a substring of all characters from the beginning of the text to the selector
                beforeText = textBox2.Text.Substring(0, textBox2.SelectionStart);
                //Set the afterText as a substring of the length of the beforeText
                afterText = textBox2.Text.Substring(beforeText.Length);
                //Set the text box contents as a concatenation of the beforeText substring, this button's character in the middle and the afterText substring)
                textBox2.Text = string.Concat(beforeText, key, afterText);
                //Set the current selector index just after the recently added character
                textBox2.SelectionStart = beforeText.Length + 1;
            }
            //If the length of the text is more than 0, but the starting character index is 0 (i.e. before the text)
            else if (textBox2.Text.Length > 0 && textBox2.SelectionStart == 0)
            {
                //Set the afterText as a substring of all characters between the selector and the end of the text
                afterText = textBox2.Text.Substring(textBox2.SelectionStart, textBox2.Text.Length);
                //Add this button's character at the beginning of the text
                textBox2.Text = key + textBox2.Text;
            }
        }

        private void deleteText(bool isTextBox1)
        {
            //String for getting the text before the selector index
            String beforeText;
            //String for getting the text after the selector index
            String afterText;
            //If the isTextBox1 value is true
            if (isTextBox1)
            {
                //If the current selector for the first text box is less than the length of the text (if there are  any characters after the selector index)
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
                    //Set focus on the first text bar so that the selector index is blinking
                    textBox1.Focus();
                }
                //If the isTextBox1 value is false
            }
            else if (!isTextBox1)
            {
                //If the current selector in the second text box is less than the length of the text (if there are  any characters after the selector index)
                if (textBox2.SelectionStart < textBox2.Text.Length)
                {
                    //Set the beforeText as a substring of characters between the start and the selector index
                    beforeText = textBox2.Text.Substring(0, textBox2.SelectionStart);
                    //Set the afterText as a substring of characters after the character after the selection index
                    afterText = textBox2.Text.Substring(textBox2.SelectionStart + 1);
                    //Define the text value in the box as a concatenation of the beforeText and afterText
                    textBox2.Text = string.Concat(beforeText, afterText);
                    //Set the current selector index as the same as the current position
                    textBox2.SelectionStart = beforeText.Length;
                    //Set focus on the second text bar so that the selector index is blinking
                    textBox2.Focus();
                }
            }
        }

        private void backspace(bool isTextBox1)
        {
            //String for the text before the selector index
            String beforeText = null;
            //String for the text after the selector index
            String afterText = null;
            //If the isTextBox1 is true
            if (isTextBox1)
            {
                //If the selector index in the first text box is more than 0 (if there are characters before the backspace)
                if (textBox1.SelectionStart > 0)
                {
                    //If the current selector index is the same as the text length (i.e. right at the end of the text)
                    if (textBox1.SelectionStart == textBox1.Text.Length)
                    {
                        //Set the text in the first box as a substring of characters between the start and the character before the end
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
                        //Set the afterText as a substring of characters after the selector index
                        afterText = textBox1.Text.Substring(textBox1.SelectionStart);

                        //Set the first text box's text contnets as a concatenation of the beforeText and afterText
                        textBox1.Text = string.Concat(beforeText, afterText);
                        //Set the new selector index as the beforeText's length
                        textBox1.SelectionStart = beforeText.Length;
                        //Set focus on the first text bar so that the selector index is blinking
                        textBox1.Focus();
                    }
                }
                //If the isTextBox1 value is false
            }
            else if (!isTextBox1)
            {
                //If the selector index in the second text box is more than 0 (if there are characters before the backspace)
                if (textBox2.SelectionStart > 0)
                {
                    //If the current selector index is the same as the text length (i.e. right at the end of the text)
                    if (textBox2.SelectionStart == textBox2.Text.Length)
                    {
                        //Set the text in the second box as a substring of characters between the start and the character before the end
                        textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                        //Set the current selector index as the end of the text box value
                        textBox2.SelectionStart = textBox2.Text.Length;
                        //Set focus on the second text bar so that the selector index is blinking
                        textBox2.Focus();
                    }
                    //If the current selector index in the second text box is less than the length of the text (i.e. in the middle the text)
                    else if (textBox2.SelectionStart < textBox2.Text.Length)
                    {
                        //Set the beforeText as a substring of characters between the start and the character before the selector index
                        beforeText = textBox2.Text.Substring(0, textBox2.SelectionStart - 1);
                        //Set hte afterText as a substring of characters after the selector index
                        afterText = textBox2.Text.Substring(textBox2.SelectionStart);

                        //Set the text box's text contnets as a concatenation of the beforeText and afterText
                        textBox2.Text = string.Concat(beforeText, afterText);
                        //Set the new selector index as the beforeText's length
                        textBox2.SelectionStart = beforeText.Length;
                        //Set focus on the second text bar so that the selector index is blinking
                        textBox2.Focus();
                    }
                }
            }
        }

        private void leftButton(bool isTextBox1)
        {
            // if the isTextBox1 value in the parameter is true
            if (isTextBox1)
            {
                //If the first text box's selector is greater than 0
                if (textBox1.SelectionStart > 0)
                {
                    //Shift the selector index of the first text box one character left
                    textBox1.SelectionStart--;
                    //Set focus on the first text bar so that the selector index is blinking
                    textBox1.Focus();
                }
            }
            //Otherwise, if the isTextBox1 value is false
            else if (!isTextBox1)
            {
                //If the second text box's selector is greater than 0
                if (textBox2.SelectionStart > 0)
                {
                    //Shift the second text box's selector index one character left
                    textBox2.SelectionStart--;
                    //Set focus on the second text bar so that the selector index is blinking
                    textBox2.Focus();
                }
            }
        }

        private void rightButton(bool isTextBox1)
        {
            //If the isTextBox1 value in the parameter is true
            if (isTextBox1)
            {
                //If the selector in the first text box is less than the length of the text
                if (textBox1.SelectionStart < textBox1.Text.Length)
                {
                    //Shift the first text box's selector one character right
                    textBox1.SelectionStart++;
                    //Set focus on the first text bar so that the selector index is blinking
                    textBox1.Focus();
                }
                //If the isTextBox1 value is false
            }
            else if (!isTextBox1)
            {
                //If the selector in the second text box is less than the length of the text
                if (textBox2.SelectionStart < textBox2.Text.Length)
                {
                    //Shift the selector in the second one character right
                    textBox2.SelectionStart++;
                    //Set focus on the second text bar so that the selector index is blinking
                    textBox2.Focus();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button10.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button11.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button12.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button13.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button14.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button15.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button16.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button17.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button18.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button19.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button1.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button2.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button3.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button4.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button5.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button6.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button7.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button8.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button9.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button20.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button21.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button22.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button23.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button24.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button25.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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
            //Call the first typeKey method, passing it this button's respective text value
            typeKey1(button26.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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

        //Method for the space bar
        private void button30_Click(object sender, EventArgs e)
        {
            //Call the first typeKey method, passing it a blank space for the string parameter
            typeKey1(" ");
            //Set focus on the text bar so that the selector index is blinking
            textBox1.Focus();
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

        //METHOD FOR BACKSPACE IN 2ND TEXT BOX
        private void button50_Click(object sender, EventArgs e)
        {
            //Call backspace method (passing false for the isTextBox1 value)
            backspace(false);
            
        }

        private void button50_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button50.BackColor = Color.Yellow;
        }

        private void button50_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button50.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR BACKSPACE IN 1ST TEXT BOX
        private void button31_Click(object sender, EventArgs e)
        {
            //Call backspace function (passing true for the isTextBox1 value)
            backspace(true);
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

        private void button35_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button35.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
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
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button36.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
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

        private void button37_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button37.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button37_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button37.BackColor = Color.Yellow;
        }

        private void button37_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button37.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button38.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button38_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button38.BackColor = Color.Yellow;
        }

        private void button38_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button38.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button39.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button39_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button39.BackColor = Color.Yellow;
        }

        private void button39_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button39.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button40.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button40_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button40.BackColor = Color.Yellow;
        }

        private void button40_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button40.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button41.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button41_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button41.BackColor = Color.Yellow;
        }

        private void button41_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button41.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button42.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button42_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button42.BackColor = Color.Yellow;
        }

        private void button42_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button42.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button43.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button43_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button43.BackColor = Color.Yellow;
        }

        private void button43_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button43.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            //Call the second typeKey method, passing it this button's respective text value
            typeKey2(button44.Text);
            //Set focus on the text bar so that the selector index is blinking
            textBox2.Focus();
        }

        private void button44_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button44.BackColor = Color.Yellow;
        }

        private void button44_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button44.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE LEFT KEY FOR 2ND TEXT BOX 
        private void button45_Click(object sender, EventArgs e)
        {
            //Call the leftButton method (passing false for the isTextBox1 value)
            leftButton(false);
        }

        private void button45_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button45.BackColor = Color.Yellow;
        }

        private void button45_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button45.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE RIGHT KEY FOR 2ND TEXT BOX
        private void button46_Click(object sender, EventArgs e)
        {
            //Call the rightButton function(passing it false for the isTextBox1 value)
            rightButton(false);
        }

        private void button46_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button46.BackColor = Color.Yellow;
        }

        private void button46_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button46.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR DELETING IN SECOND TEXT BOX
        private void button47_Click(object sender, EventArgs e)
        {
            //Call the deleteText function (passing false for the isTextBox1 method)
            deleteText(false);
        }

        private void button47_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour to yellow
            this.button47.BackColor = Color.Yellow;
        }

        private void button47_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //Change this button's background colour back to it's default
            this.button47.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //METHOD FOR THE LEFT KEY IN 1ST TEXT BOX
        private void button32_Click(object sender, EventArgs e)
        {
            //Call the leftButton function (passing it true for the istextBox1 value
            leftButton(true);
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

        //METHOD FOR THE RIGHT KEY IN 1ST TEXT BOX
        private void button33_Click(object sender, EventArgs e)
        {
            //Call the rightButton function (passing it true for the isTextBox1 value) 
            rightButton(true); 
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

        //METHOD FOR DELETING IN 1ST TEXT BOX
        private void button34_Click(object sender, EventArgs e)
        {
            //Call deleteText function (passing true for isTextBox1 value)
            deleteText(true);
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
