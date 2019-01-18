/*  
  Author: Bret MJ McGee
  Date:   September 30th 2018

  Purpose: This is the main program sequence.

  *** Couldn't remember how to properly delete unused methods without 
  breaking the application so they were left in, would love to know how ***

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Created by Bret McGee - 9/27/2018
/// 
/// This program is designed to determine the pricing for a hair salon.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab2B
{
    /// <summary>
    /// This is the Form Control Class. 
    /// </summary>
    public partial class Form1 : System.Windows.Forms.Form
    {
        double basePrice = 0;
        double servicePrice = 0;
        double discount = 1;

        /// <summary>
        /// This is the main form method, that initializes the form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            janeSamleyRadio.Checked = true;
            adultRadio.Checked = true;
        }

        /// <summary>
        /// This is the form load method, currently unused
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the unused group box 1 enter method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the unused group box 3 enter method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the exit button method that closed the program window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This is the clear button method that clears all the fields,
        /// variables, and focus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            basePrice = 30;
            servicePrice = 0;
            discount = 1;
            clientNumberTextBox.Text = "";
            totalResultLabel.Text = "";
            janeSamleyRadio.Checked = true;
            patJohnsonRadio.Checked = false;
            ronChambersRadio.Checked = false;
            suePallonRadio.Checked = false;
            lauraRenkinsRadio.Checked = false;
            cutCheckBox.Checked = false;
            colourCheckBox.Checked = false;
            highlightsCheckBox.Checked = false;
            extensionsCheckBox.Checked = false;
            adultRadio.Checked = true;
            childRadio.Checked = false;
            studentRadio.Checked = false;
            seniorRadio.Checked = false;
            janeSamleyRadio.Focus();
        }

        /// <summary>
        /// This is the calculate button method that does
        /// all of the calculations to output the correct
        /// total cost of the events in the hair salon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            /*
             * First we test if the textbox input will parse to an integer, if it doesn't we give an error message,
             * if it does we then check what range the integer falls in, to determine one part of the discount.
             * We then check to make sure at least one of the service check boxes have been selected, giving an
             * error if not. Then depending on what services have been chosen the service price is calculated, 
             * and then the total result is calculated and displayed in the result label. Both discount and service
             * variables are reset to make sure changing options between hitting the calculate button does not accumulate
             * totals, resulting in incorrect totals.
             */
            String input = clientNumberTextBox.Text;
            if (int.TryParse(input, out int result))
            {
                if (int.Parse(clientNumberTextBox.Text) >= 4 && int.Parse(clientNumberTextBox.Text) <= 8)
                {
                    discount -= .05;
                    if (cutCheckBox.Checked == false && colourCheckBox.Checked == false && highlightsCheckBox.Checked == false && extensionsCheckBox.Checked == false)
                    {
                        servicesGroup.Focus();
                        totalResultLabel.Text = "Please select at least one Service";
                        discount += .05;
                    }
                    else
                    {
                        if (cutCheckBox.Checked == true)
                        {
                            servicePrice = 30;
                        }
                        if (colourCheckBox.Checked == true)
                        {
                            servicePrice += 40;
                        }
                        if (highlightsCheckBox.Checked == true)
                        {
                            servicePrice += 50;
                        }
                        if (extensionsCheckBox.Checked == true)
                        {
                            servicePrice += 200;
                        }
                        totalResultLabel.Text = $"${(basePrice + servicePrice) * discount}";
                        servicePrice = 0;
                        discount += .05;
                    }

                }
                else if (int.Parse(clientNumberTextBox.Text) >= 9 && int.Parse(clientNumberTextBox.Text) <= 13)
                {
                    discount -= .1;
                    if (cutCheckBox.Checked == false && colourCheckBox.Checked == false && highlightsCheckBox.Checked == false && extensionsCheckBox.Checked == false)
                    {
                        servicesGroup.Focus();
                        totalResultLabel.Text = "Please select at least one Service";
                        servicePrice = 0;
                        discount += .1;
                    }
                    else
                    {
                        if (cutCheckBox.Checked == true)
                        {
                            servicePrice = 30;
                        }
                        if (colourCheckBox.Checked == true)
                        {
                            servicePrice += 40;
                        }
                        if (highlightsCheckBox.Checked == true)
                        {
                            servicePrice += 50;
                        }
                        if (extensionsCheckBox.Checked == true)
                        {
                            servicePrice += 200;
                        }
                        totalResultLabel.Text = $"${(basePrice + servicePrice) * discount}";
                        servicePrice = 0;
                        discount += .1;
                    }
                }
                else if (int.Parse(clientNumberTextBox.Text) >= 14)
                {
                    discount -= .15;
                    if (cutCheckBox.Checked == false && colourCheckBox.Checked == false && highlightsCheckBox.Checked == false && extensionsCheckBox.Checked == false)
                    {
                        servicesGroup.Focus();
                        totalResultLabel.Text = "Please select at least one Service";
                        discount += .15;
                    }
                    else
                    {
                        if (cutCheckBox.Checked == true)
                        {
                            servicePrice = 30;
                        }
                        if (colourCheckBox.Checked == true)
                        {
                            servicePrice += 40;
                        }
                        if (highlightsCheckBox.Checked == true)
                        {
                            servicePrice += 50;
                        }
                        if (extensionsCheckBox.Checked == true)
                        {
                            servicePrice += 200;
                        }
                        totalResultLabel.Text = $"${(basePrice + servicePrice) * discount}";
                        servicePrice = 0;
                        discount += .15;
                    }
                }
                else if (int.Parse(clientNumberTextBox.Text) >= 1 && int.Parse(clientNumberTextBox.Text) <= 3)
                {

                    if (cutCheckBox.Checked == false && colourCheckBox.Checked == false && highlightsCheckBox.Checked == false && extensionsCheckBox.Checked == false)
                    {
                        servicesGroup.Focus();
                        totalResultLabel.Text = "Please select at least one Service";
                    }
                    else
                    {
                        if (cutCheckBox.Checked == true)
                        {
                            servicePrice = 30;
                        }
                        if (colourCheckBox.Checked == true)
                        {
                            servicePrice += 40;
                        }
                        if (highlightsCheckBox.Checked == true)
                        {
                            servicePrice += 50;
                        }
                        if (extensionsCheckBox.Checked == true)
                        {
                            servicePrice += 200;
                        }
                        totalResultLabel.Text = $"${(basePrice + servicePrice) * discount}";
                        servicePrice = 0;
                    }
                } else
                {
                    clientNumberTextBox.Focus();
                    totalResultLabel.Text = "Client Visit Must be a Positive Integer";
                }
            } else
            {
                clientNumberTextBox.Focus();
                totalResultLabel.Text = "Client Visit Must be a Positive Integer";
            }


        }

        /// <summary>
        /// This is the jane samley radio button check changed method that sets their correct base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void janeSamleyRadio_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 30;
        }

        /// <summary>
        /// This is the pat johnson radio button check changed method that sets their correct base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patJohnsonRadio_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 45;
        }

        /// <summary>
        /// This is the ron chambers radio button check changed method that sets their correct base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ronChambersRadio_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 40;
        }

        /// <summary>
        /// This is the sue pallon radio button check changed method that sets their correct base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suePallonRadio_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 50;
        }

        /// <summary>
        /// This is the laura renkins radio button check changed method that sets their correct base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lauraRenkinsRadio_CheckedChanged(object sender, EventArgs e)
        {
            basePrice = 55;
        }

        /// <summary>
        /// This is the unused cut check box check changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This is the unused colour check box check changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This is the unused highlights check box check changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highlightsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This is the unused extensions check box check changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void extensionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This is the adult discount radio button check changed method that sets the discount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adultRadio_CheckedChanged(object sender, EventArgs e)
        {
            discount = 1;
        }

        /// <summary>
        /// This is the child discount radio button check changed method that sets the discount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childRadio_CheckedChanged(object sender, EventArgs e)
        {
            discount = .9;
        }

        /// <summary>
        /// This is the student discount radio button check changed method that sets the discount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            discount = .95;
        }

        /// <summary>
        /// This is the senior discount radio button check changed method that sets the discount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seniorRadio_CheckedChanged(object sender, EventArgs e)
        {
            discount = .85;
        }

        /// <summary>
        /// This is the unused client number text box check changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
