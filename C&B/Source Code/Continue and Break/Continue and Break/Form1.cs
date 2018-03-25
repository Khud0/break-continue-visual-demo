using System;
using System.Linq;
using System.Windows.Forms;

namespace Continue_and_Break
{
    public partial class Form1 : Form
    {
        #region Functions n' stuff

        public int minNumber, maxNumber, breakPoint;
        public int toShow = 20;
        public int outShown = 0; // Whether the #3 out of range messagebox was shown or not;

        public Form1()
        {
            InitializeComponent();
            SetDefaultValues();
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            Count(textBoxNormal, minNumber, maxNumber, "normal", breakPoint);
        }

        private void btn_break_Click(object sender, EventArgs e)
        {
            Count(textBoxBreak, minNumber, maxNumber, "break", breakPoint);
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            Count(textBoxContinue, minNumber, maxNumber, "continue", breakPoint);
        }

        private void set1_Click(object sender, EventArgs e)
        {
            ChangeValues(textBoxFrom);
        }

        private void set2_Click(object sender, EventArgs e)
        {
            ChangeValues(textBoxTo);
        }

        private void set3_Click(object sender, EventArgs e)
        {
            ChangeValues(textBoxAction);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Khud0"); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Pexgcu7EBg0"); 
        }

        #endregion

        #region Methods

         /// <summary>
        /// Counts from minNumber till maxNumber in a box and performs a breakType at breakPoint;
        /// </summary>
        /// <param name="box">The box in which to write the numbers</param>
        /// <param name="minNumber">The number to start counting from (inclusive)</param>
        /// <param name="maxNumber">The number at which to stop counting (inclusive)</param>
        /// <param name="breakType">The type of a break you want to use, allows "normal", "break", "continue" as parameters</param>
        /// <param name="breakPoint">The number at which to perform the breakType</param>
        void Count(TextBox box, int minNumber, int maxNumber, string breakType, int breakPoint) 
        {
            box.Text = ""; // Reset
            int amount = 0;

            if (minNumber <= maxNumber) {

            #region If the progression is ascending

                for(int i=minNumber; i<=maxNumber; i++) 
                {
                    if (i==breakPoint) 
                    {
                        if (breakType == "normal") 
                        {
                            // Do nothing
                        } else if (breakType == "break") 
                        {
                            break;
                        } else if (breakType == "continue") 
                        {
                            continue;
                        }
                    }

                    box.Text += i + " "; // Adds a space between the numbers;
                    amount++;

                    if (amount >= toShow) break;
                
                }
            }

            #endregion 

            else

            #region If the progression is descending

            {
                for (int i=minNumber; i>=maxNumber; i--) 
                {
                    if (i==breakPoint) 
                    {
                        if (breakType == "normal") 
                        {
                            // Do nothing
                        } else if (breakType == "break") 
                        {
                            break;
                        } else if (breakType == "continue") 
                        {
                            continue;
                        }
                    }

                    box.Text += i + " "; // Adds a space between the numbers;
                    amount++;

                    if (amount >= toShow) break;
                
                }
            }
            #endregion
        }

        void ChangeValues(TextBox textBox) 
        {

            if(int.TryParse(textBox.Text, out int result)) // Checks if the text is a number, not a text;
            {
                int newValue = int.Parse(textBox.Text); // Converts a text from the TextBox into an integer;

                if ((newValue >= 0) && (newValue <= 100)) // Checks if the number is within the range;
                {
                    #region Apply the Changes (Everything is correct in the TextBoxes);
                        if (textBox.Name == "textBoxFrom")
                                minNumber = int.Parse(textBoxFrom.Text);

                        else if (textBox.Name == "textBoxTo")
                            maxNumber = int.Parse(textBoxTo.Text);

                        else if (textBox.Name == "textBoxAction")
                            breakPoint = int.Parse(textBoxAction.Text);
                     #endregion

                    #region Change the breakPoint if necessary
                        
                        Random r = new Random();
                        if (minNumber < maxNumber) // Basically, if the progression is ascending;
                        {
                            //if (!Enumerable.Range(minNumber, maxNumber).Contains(breakPoint) ) // Checks if the breakPoint is not within the range between the min number and max number;
                            if (!(breakPoint >= minNumber) || !(breakPoint <= maxNumber)) // The above ^ version used to not work in A LOT of cases
                                {
                                    breakPoint = minNumber + r.Next(0, maxNumber - minNumber); // Changes the breakPoint to fit the task;

                                    if (outShown == 0)
                                    {
                                        MessageBox.Show("Even though it's not necessary to have a break/continue condition within the range between " +
                                                        "#1 and #2, this program wouldn't show anything this way. \n\nSo I changed the #3 value for you.", "#3 out of range between #1 and #2");  
                                        outShown = 1;
                                    }
                                }
                        }
                        else // If the progression is descending;
                        {
                            //if (!Enumerable.Range(maxNumber, minNumber).Contains(breakPoint) ) // Checks if the breakPoint is not within the range between the min number and max number;
                            if (!(breakPoint <= minNumber) || !(breakPoint >= maxNumber)) // The above ^ version used to not work in A LOT of cases
                                {
                                    breakPoint = minNumber - r.Next(0, minNumber - maxNumber); // Changes the breakPoint to fit the task;

                                    if (outShown == 0)
                                    {
                                        MessageBox.Show("Even though it's not necessary to have a break/continue condition within the range between " +
                                                        "#1 and #2, this program wouldn't show anything this way. \n\nSo I changed the #3 value for you.", "#3 out of range between #1 and #2");  
                                        outShown = 1;
                                    }
                                }
                        }

                    #endregion
                        
                } else 
                {
                    MessageBox.Show("The number should be between 0 (inclusive) and 100 (inclusive)", "The value is not within allowed range!");
                }
                
            } else 
            {
                MessageBox.Show("An integer number from 0 to 100 is expected, not a piece of text!", "Not an integer value inserted!");
            }

            ChangeTextBoxText();
        }

        void SetDefaultValues() 
        {
            minNumber = 1;
            maxNumber = 10;
            breakPoint = 2;

            TextBox[] boxes3 = {textBoxAction, textBoxFrom, textBoxTo};
            foreach(TextBox tb in boxes3) 
            {
                tb.MaxLength = 3;
            }

            TextBox[] boxes10 = {textBoxBreak, textBoxContinue, textBoxNormal};
            foreach (TextBox tb in boxes10) 
            {
                tb.MaxLength = 20;
            }

            ChangeTextBoxText();
        }

        void ChangeTextBoxText() 
        {
            textBoxFrom.Text = minNumber.ToString();
            textBoxTo.Text = maxNumber.ToString();
            textBoxAction.Text = breakPoint.ToString();

            textBoxBreak.Text = "";
            textBoxContinue.Text = "";
            textBoxNormal.Text = "";

            btn_break.Text = "Break at " + breakPoint;
            btn_continue.Text = "Continue at " + breakPoint;
        }

        #endregion
    }
}
