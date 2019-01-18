/*  
  Author: Bret MJ McGee
  Date:   December 5th 2018

  Purpose: This is the main program sequence.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Created by Bret McGee - 12/5/2018
/// 
/// This program is design to read a data file, extract/organize the data,
/// and create an interface for displaying the relevant searchable data.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab5B
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
            InitializeComponent(); // Initialize the form
        }

        List<Doctor> d = new List<Doctor>(); // initializes the doctor list
        List<Companion> c = new List<Companion>(); // initializes the companion list
        List<Episode> p = new List<Episode>(); // initializes the episode list
        List<Chosen> ch = new List<Chosen>(); // Initialize the chosen list
        List<string> ts1 = new List<string>(); // initialize the temp string 1 list
        List<string> ts2 = new List<string>(); // initialize the temp string 2 list
        string fileName = string.Empty; // initializes the file name variable
        int val = 0; // initializes the doctor picked value

        /// <summary>
        /// This method loads the txt file the user chooses, reads the information and sets up the lists
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event Parameter</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath; // initializes the fileContent and filePath variable

            // Starts the open file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // initializes the initial directory
                openFileDialog.Filter = "txt files (*.txt)|*.txt"; // initializes the file filter
                openFileDialog.FilterIndex = 2; // initializes the index filter
                openFileDialog.RestoreDirectory = true; // initializes the restore directory to true

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    filePath = openFileDialog.FileName;

                    // Get the name of the file
                    fileName = Path.GetFileName(filePath);

                    ////Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    // create the stream reader
                    try // exception handling for the file IO
                    {
                        StreamReader data = new StreamReader(filePath); // read data from file
                        string line; // initialize line string
                        while ((line = data.ReadLine()) != null) // true while the line read is not empty
                        {
                            string[] exploded = line.Split('|'); // split the line read by the | character and save into array

                            if (exploded[0].Trim() == "E")
                            {   // create new episode object
                                Episode temp = new Episode(exploded[1].Trim(), int.Parse(exploded[2].Trim()), int.Parse(exploded[3].Trim()), exploded[4].Trim());
                                p.Add(temp); // add to episode list
                            }
                            if (exploded[0].Trim() == "C")
                            {   // create new companion object
                                Companion temp = new Companion(exploded[1].Trim(), exploded[2].Trim(), int.Parse(exploded[3].Trim()), exploded[4].Trim());
                                c.Add(temp); // add to companion list
                            }
                            if (exploded[0].Trim() == "D")
                            {
                                // create doctor object
                                Doctor temp = new Doctor(int.Parse(exploded[1].Trim()), exploded[2].Trim(), int.Parse(exploded[3].Trim()), int.Parse(exploded[4].Trim()), exploded[5].Trim());
                                d.Add(temp); // add to doctor list
                                // create chosen object
                                Chosen chosen = new Chosen(int.Parse(exploded[1].Trim()), exploded[2].Trim(), int.Parse(exploded[3].Trim()), int.Parse(exploded[4].Trim()), exploded[5].Trim());
                                ch.Add(chosen); // add to chosen list
                            }
                        }
                        data.Close(); // close the IO
                        d.Sort((x, y) => x.Ordinal.CompareTo(y.Ordinal)); // sort doctor list
                        ch.Sort((x, y) => x.Ordinal.CompareTo(y.Ordinal)); // sort chosen list
                        foreach (Chosen chosen in ch)
                        {
                            // use linq to get matching title
                            var joinedItem = d.Join(p.Where(_ => _.Story == chosen.Debut),
                                                               D => D.Debut, // "Outer" key expression
                                                               P => P.Story,       // "Inner" key expression 
                                                               (D, P) => String.Format(P.Title));
                            // set property value with item
                            foreach (string item in joinedItem)
                            {
                                chosen.Episode = item;
                            }
                            // use linq to get matching year
                            var joinedItem2 = d.Join(p.Where(_ => _.Story == chosen.Debut),
                                                               D => D.Debut, // "Outer" key expression
                                                               P => P.Story,       // "Inner" key expression
                                                               (D, P) => String.Format((P.Year).ToString()));
                            // set property value with item
                            foreach (string item in joinedItem2)
                            {
                                chosen.Year = int.Parse(item);
                            }
                            // use linq to get matching year
                            var joinedItem6 = p.Join(c.Where(_ => _.Doctor == chosen.Ordinal),
                                                               P => P.Story, // "Outer" key expression
                                                               C => C.Debut,       // "Inner" key expression 
                                                               (P, C) => String.Format(P.Year.ToString()));
                            // set property with value of item
                            foreach (string item in joinedItem6)
                            {
                                foreach (Companion ck in c)
                                {
                                    if (chosen.Ordinal == ck.Doctor)
                                    {
                                        ck.Year = int.Parse(item);
                                    }

                                }
                            }
                            // use linq to get matching title
                            var joinedItem5 = p.Join(c.Where(_ => _.Doctor == chosen.Ordinal),
                                                               P => P.Story, // "Outer" key expression
                                                               C => C.Debut,       // "Inner" key expression 
                                                               (P, C) => String.Format(P.Title));

                            // set property with value of item
                            foreach (string item in joinedItem5)
                            {
                                foreach (Companion ck in c)
                                {
                                    if (chosen.Ordinal == ck.Doctor)
                                    {
                                        ck.Episode = item;
                                    }
                                }
                            }
                            // use linq to get matching actor
                            var joinedItem3 = d.Join(c.Where(_ => _.Debut == chosen.Debut && _.Doctor == chosen.Ordinal),
                                                               D => D.Debut, // "Outer" key expression
                                                               C => C.Debut,       // "Inner" key expression
                                                               (D, C) => String.Format((C.Actor).ToString()));
                            // set property with value of item
                            foreach (string item in joinedItem3)
                            {
                                foreach (Companion co in c)
                                {
                                    if (co.Actor == item)
                                    {
                                        ts1.Add(co.Actor);
                                    }
                                }
                            }
                            // use linq to get matching name
                            var joinedItem4 = d.Join(c.Where(_ => _.Debut == chosen.Debut && _.Doctor == chosen.Ordinal),
                                                               D => D.Debut, // "Outer" key expression
                                                               C => C.Debut,       // "Inner" key expression
                                                               (D, C) => String.Format((C.Name).ToString()));
                            // set property to value of item
                            foreach (string item in joinedItem3)
                            {
                                foreach (Companion co in c)
                                {
                                    if (co.Actor == item)
                                    {
                                        ts2.Add(co.Name);
                                    }
                                }
                            }
                            chosen.CompanionName = ts1; // set temp string 1
                            chosen.CompanionActor = ts2; // set temp string 2
                            doctorComboBox.Items.Add(NumberToWords(chosen.Ordinal)); // display the word ordinal values
                        }

                        // initialize the starting info
                        doctorComboBox.SelectedIndex = 0;
                        yearTextBox.Text = "1963";
                        actorTextBox.Text = d[0].Actor;
                        seriesTextBox.Text = (d[0].Series).ToString();
                        ageTextBox.Text = (d[0].Age).ToString();
                        episodeTextBox.Text = "An Unearthly Child";

                    }
                    catch (Exception) // catch the exception if the file was not read properly
                    {
                        Console.WriteLine("the file was either not found or could not be read."); // exception error message
                    }
                }
            }
        }

        /// <summary>
        /// This method takes in an integer and spits out the word spelling of that number
        /// </summary>
        /// <param name="number">The number passed through</param>
        /// <returns>The string version of the number given in words</returns>
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth", "Eleventh", "Twelfth", "Thirteenth" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        /// <summary>
        /// Quits the program
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">the event parameter</param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method chooses what information to show depending on which doctor the user chooses
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            companionsListBox.Items.Clear(); // clear the list box when chooseing a new option
            string selected = doctorComboBox.SelectedItem.ToString(); // get the chosen value
            // switch using the chosen value to convert the words back into int
            switch (selected)
            {
                case "First":
                    val = 1;
                    break;
                case "Second":
                    val = 2;
                    break;
                case "Third":
                    val = 3;
                    break;
                case "Fourth":
                    val = 4;
                    break;
                case "Fifth":
                    val = 5;
                    break;
                case "Sixth":
                    val = 6;
                    break;
                case "Seventh":
                    val = 7;
                    break;
                case "Eighth":
                    val = 8;
                    break;
                case "Ninth":
                    val = 9;
                    break;
                case "Tenth":
                    val = 10;
                    break;
                case "Eleventh":
                    val = 11;
                    break;
                case "Twelfth":
                    val = 12;
                    break;
                default:
                    break;

            }
            // loop through the chosen doctors list
            foreach (Chosen w in ch)
            {
                // stop on the chosen doctor and fill out the appropriate data
                if (w.Ordinal == val)
                {
                    yearTextBox.Text = w.Year.ToString(); // set year
                    actorTextBox.Text = w.Actor; // set actor
                    seriesTextBox.Text = w.Series.ToString(); // set series
                    ageTextBox.Text = w.Age.ToString(); // set age
                    episodeTextBox.Text = w.Episode; // set episode
                    // search through the companions and display infor appropriately
                    foreach (Companion ck in c)
                    {
                        if (w.Ordinal == ck.Doctor)
                        {
                            companionsListBox.Items.Add(ck.Name + "  (" + ck.Actor + ")"); // display companions name and the actor
                            companionsListBox.Items.Add('"' + ck.Episode + '"' + "  (" + ck.Year + ")"); // display the episode and year
                            companionsListBox.Items.Add(""); // create a space between entries
                        }
                    }
                }
            }
        }
    }
}
