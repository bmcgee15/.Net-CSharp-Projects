/*  
  Author: Bret MJ McGee
  Date:   November 6th 2018

  Purpose: This is the main program sequence.
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
/// Created by Bret McGee - 11/6/2018
/// 
/// This program is design to let the user choose a hair dresser, add services and get a
/// total cost for the service. The main functionality allow to select and add hairdresser
/// & services, calculate total, reset the input, and exit the program.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab3B
{
    /// <summary>
    /// This is the main form class
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is the main form initialization method
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // initialize the form
        }

        int count = 0; // initialize the user process count to 0
        double jane = 30.00;  // initialize the jane base price to 30
        double pat = 45.00;  // initialize the pat base price to 45
        double ron = 40.00;  // initialize the ron base price to 40
        double sue = 50.00;  // initialize the sue base price to 50
        double laura = 55.00;  // initialize the base laura price to 55
        double cut = 30.00;  // initialize the cut service price to 30
        double wash = 20.00;  // initialize the wash service price to 20
        double colour = 40.00;  // initialize the colour service price to 40
        double highlights = 50.00;  // initialize the highlights service price to 50
        double extensions = 200.00;  // initialize the extentions service price to 200
        double upDo = 60.00;  // initialize the up do service price to 60
        double total = 00.00;  // initialize the total price to 0

        /// <summary>
        /// This method calculates the total price by adding up the hairdresser base price
        /// with all of the services added. 
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            TotalPriceTextBox.Text = $"{total:C}";
        }

        /// <summary>
        /// This method adds the selected hair dresser and service item the first time, and adds
        /// the selected service item going forward.
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            // making sure that there is at least one item selected, and that there are not more items than in the item list
            if (ServiceListBox.SelectedIndex != -1 && count < 6)
            {
                if (count == 0) // to check for the first time running the program or after reset
                {
                    // add the selected item to the charged items listbox
                    ChargedListBox.Items.Add(HairDresserComboBox.SelectedItem);

                    // if selected item is jane samley, add the appropriate price to the price list box and total variable.
                    if (HairDresserComboBox.SelectedItem.Equals("Jane Samley"))
                    {
                        PriceListBox.Items.Add($"{jane:C}");
                        total += jane;
                    }

                    // if selected item is pat johnson, add the appropriate price to the price list box and total variable.
                    if (HairDresserComboBox.SelectedItem.Equals("Pat Johnson"))
                    {
                        PriceListBox.Items.Add($"{pat:C}");
                        total += pat;
                    }

                    // if selected item is ron chambers, add the appropriate price to the price list box and total variable.
                    if (HairDresserComboBox.SelectedItem.Equals("Ron Chambers"))
                    {
                        PriceListBox.Items.Add($"{ron:C}");
                        total += ron;
                    }

                    // if selected item is sue pallon, add the appropriate price to the price list box and total variable.
                    if (HairDresserComboBox.SelectedItem.Equals("Sue Pallon"))
                    {
                        PriceListBox.Items.Add($"{sue:C}");
                        total += sue;
                    }

                    // if selected item is laura renkins, add the appropriate price to the price list box and total variable.
                    if (HairDresserComboBox.SelectedItem.Equals("Laura Renkins"))
                    {
                        PriceListBox.Items.Add($"{laura:C}");
                        total += laura;
                    }

                    HairDresserComboBox.Enabled = false; // disable hair dresser combo box after add service button clicked until reset
                    ResetButton.Enabled = true; // enable the reset button
                    CalculateButton.Enabled = true; // enable the calculate button

                    // add the selected service item to the charged list box
                    ChargedListBox.Items.Add(ServiceListBox.SelectedItem);

                    // if selected item is cut, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Cut"))
                    {
                        PriceListBox.Items.Add($"{cut:C}");
                        total += cut;
                    }

                    // if selected item is wash, blow-dry, and style, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Wash, blow-dry, and style"))
                    {
                        PriceListBox.Items.Add($"{wash:C}");
                        total += wash;
                    }

                    // if selected item is colour, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Colour"))
                    {
                        PriceListBox.Items.Add($"{colour:C}");
                        total += colour;
                    }

                    // if selected item is highlights, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Highlights"))
                    {
                        PriceListBox.Items.Add($"{highlights:C}");
                        total += highlights;
                    }

                    // if selected item is extensions, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Extensions"))
                    {
                        PriceListBox.Items.Add($"{extensions:C}");
                        total += extensions;
                    }

                    // if selected item is up do, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Up-do"))
                    {
                        PriceListBox.Items.Add($"{upDo:C}");
                        total += upDo;
                    }

                    ServiceListBox.Items.Remove(ServiceListBox.SelectedItem); // removes the service from service list box to prevent duplicate adds
                    count++; // increment count
                }
                else
                {
                    // adds the list item to the charged list box (but not the hair dresser because this is count 1+)
                    ChargedListBox.Items.Add(ServiceListBox.SelectedItem);

                    // if selected item is cut, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Cut"))
                    {
                        PriceListBox.Items.Add($"{cut:C}");
                        total += cut;
                    }

                    // if selected item is ron chambers, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Wash, blow-dry, and style"))
                    {
                        PriceListBox.Items.Add($"{wash:C}");
                        total += wash;
                    }

                    // if selected item is colour, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Colour"))
                    {
                        PriceListBox.Items.Add($"{colour:C}");
                        total += colour;
                    }

                    // if selected item is highlights, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Highlights"))
                    {
                        PriceListBox.Items.Add($"{highlights:C}");
                        total += highlights;
                    }

                    // if selected item is extensions, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Extensions"))
                    {
                        PriceListBox.Items.Add($"{extensions:C}");
                        total += extensions;
                    }

                    // if selected item is up do, add the appropriate price to the price list box and total variable.
                    if (ServiceListBox.SelectedItem.Equals("Up-do"))
                    {
                        PriceListBox.Items.Add($"{upDo:C}");
                        total += upDo;
                    }

                    ServiceListBox.Items.Remove(ServiceListBox.SelectedItem); // removes the service from service list box to prevent duplicate adds
                }

                //if you wanted multiple items selected and added. Had it working, found single item add was cleaner
                //var items = ServiceListBox.SelectedItems;
                //foreach (string item in items)
                //{
                //    ChargedListBox.Items.Add(item);
                //}

            } else
            {
                MessageLabel.Text = "Please Choose One or More Services"; // display error message
            }
            
            
    
        }

        /// <summary>
        /// This method resets the form back to original state
        /// </summary>
        /// <param name="sender">the sender parameter</param>
        /// <param name="e">the event parameter</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            total = 00.00; // set total to 0
            count = 0; // set count to 0
            PriceListBox.Items.Clear(); // clear the items in the price list box
            TotalPriceTextBox.Text = ""; // set total price text to empty string
            ChargedListBox.Items.Clear(); // clear the items in the charged list box
            ServiceListBox.Items.Clear(); // clear the items in the service list box
            ServiceListBox.Items.Add("Cut"); // add cut back into service list box
            ServiceListBox.Items.Add("Wash, blow-dry, and style"); // add wash, blow-dry, and style back into service list box
            ServiceListBox.Items.Add("Colour"); // add colour back into service list box
            ServiceListBox.Items.Add("Highlights"); // add highlights back into service list box
            ServiceListBox.Items.Add("Extensions"); // add extensions back into service list box
            ServiceListBox.Items.Add("Up-do"); // add up do back into service list box
            HairDresserComboBox.Enabled = true; // enable hair dresser combo box
            HairDresserComboBox.Focus(); // bring the focus to the har dresser combo box

            ResetButton.Enabled = false; // disable the reset button
            CalculateButton.Enabled = false; // disable the calculate button

        }

        /// <summary>
        /// This Method closes the program
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Unused method, couldn't find the line to delete in the form designer section
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
