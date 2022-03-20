using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;

            //validate the milesTextBox control
            if(double.TryParse(milesTextBox.Text, out miles))
            {
                //validate the gallonsTextBox control
                if(double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    //calculate MPG
                    mpg = miles / gallons;

                    //display the MPG in the mpgLabel control
                    mpgLabel.Text = mpg.ToString("n1");
                }
                else
                {
                    // Display an error message for gallonsTextBox.
                    MessageBox.Show("Invalid input for gallons");
                    
                }
            }
            else
            {
                // Display an error message for milesTextBox.
                MessageBox.Show("Invalid input for miles");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
