/* AUTHOR: Kyle Huber
 * DATE: 10/05/2020
 * DESCRIPTION: This application will display the distance traveled per hour based upon the total number
 * of hours entered by the user at a specified speed. The program also incorporates StreamWriter
 * and instantiates a new instance of SaveFileDialog which auto populates the .txt filter and loops through
 * all listbox items, allowing the user to choose a location to save the contents as a document.
*/

using System;
//Init StreamWriter & Reader
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            InitializeComponent();
        }
        
        private void calcBtn_Click(object sender, EventArgs e)
        {
           
            // Init count 
            int count;
            int distance;

            /* Get the inital information from user
            & Define vars for try-parse conversion */
            if (int.TryParse(mphTxtBox.Text, out int number_mph))
            {
                // Get the number of hours
                if (int.TryParse(hours_traveledTxtBox.Text, out int total_number_hours))
                {
                    if (total_number_hours != 0 && number_mph != 0)
                    {


                        /*Loop until the stopping point is reached (specified num of hours,
                         * Output the value at each iteration

                        ...Distance = Speed * Time (in this case, we're going to perform the calculation by multiplying speed by the counter since the counter
                        is going to be a clone of "total num hours" for each iteration) */

                        //Make component visible and active
                        outputListBox.Visible = true;
                        outputListBox.Enabled = true;

                        for (count = 1; count <= total_number_hours; count++)
                        {

                            distance = number_mph * count;
                            outputListBox.Items.Add("After hour " + count + " the vehicle traveled " + distance.ToString("n") + " miles.");
                        }

                        // Enable saving
                        saveButton.Enabled = true;
                        saveButton.BackColor = Color.Snow;
                        

                    }
                    else
                    {
                        // Invalid input message
                        MessageBox.Show("Please ensure that number of hours and MPH are greater than zero.");
                    }
                }
                else
                {
                    // Invalid input message
                    MessageBox.Show("Please enter a valid whole number for hours traveled.");

                }
            }
                else
                {
                // Invalid input message
                MessageBox.Show("Please enter a valid whole number for MPH.");
                }

          
            }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear fields and return focus
            mphTxtBox.Text = "";
            hours_traveledTxtBox.Text = "";
            outputListBox.Items.Clear();
            outputListBox.Visible = false;
            outputListBox.Enabled = false;
            saveButton.Enabled = false;
            saveButton.BackColor = Color.Gray;
            mphTxtBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Close program or ALT + X
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Using Stream Writer
           
                // Create a file & write to it
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "Text (*.txt) |*.txt";
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                        using (var sw = new StreamWriter(saveFile.FileName, false))

                            foreach (var item in outputListBox.Items)
                                sw.Write(item.ToString() + Environment.NewLine);
                    MessageBox.Show("Data successfully stored in: " + saveFile.FileName +
                        " you may view the contents in your preffered text editor.");
                    // Complimentary end of the program to eliminate confusion
                    this.Close();
                }
            else
            {
                MessageBox.Show("You canceled the operation.");
            }
        }
    }
    }

