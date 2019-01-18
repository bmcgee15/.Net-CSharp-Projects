/*  
  Author: Bret MJ McGee
  Date:   November 20th 2018

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
/// Created by Bret McGee - 11/20/2018
/// 
/// This program is designed to allow the user to load an html file of their choice
/// and then process that file to check if the html tags are balanced or not.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab4b
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

        List<string> tagList = new List<string>(); // initializes the tag list
        Stack<string> tagStack = new Stack<string>(); // initializes the tag stack
        List<string> selfClosing = new List<string>(); // initializes the self closing list
        string fileName = string.Empty; // initializes the file name variable
        string space = ""; // initializes the space variable

        /// <summary>
        /// This method loads the html file the user chooses, reads the information
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event Parameter</param>
        private void loadFileMenuItem_Click(object sender, EventArgs e)
        {
            string fileContent, filePath; // initializes the fileContent and filePath variables
            loadInitializer(out fileContent, out filePath); // initializes the load file method

            // Starts the open file dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // initializes the initial directory
                openFileDialog.Filter = "html files (*.html)|*.html"; // initializes the file filter
                openFileDialog.FilterIndex = 2; // initializes the index filter
                openFileDialog.RestoreDirectory = true; // initializes the restore directory to true

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Get the name of the file
                    fileName = Path.GetFileName(filePath);
                    messageLabel.Text = $"Loaded: {fileName}";

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    // create the stream reader
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd(); // store the whole file into file content
                        string pattern = @"([//]?)(?<=</?)([^ >/]+)"; // create the regex pattern
                        var matches = Regex.Matches(fileContent, pattern); // use the regex pattern to find matches
                        for (int i = 0; i < matches.Count; i++)
                        {
                            tagList.Add(matches[i].ToString()); // loop through the matches and add tags to list
                        }

                    }
                }
            }
        }
        /// <summary>
        /// This method initializes the loader with the variables needed, and
        /// clears items back to how they were when first running the program
        /// in order to properly work with another file right after.
        /// </summary>
        /// <param name="fileContent">The stored data from the file</param>
        /// <param name="filePath">The folder path of the file</param>
        private void loadInitializer(out string fileContent, out string filePath)
        {
            tagList.Clear(); // clear the tag list
            tagStack.Clear(); // clear the tag stack
            selfClosing.Clear(); // clear the self closing list
            fileName = string.Empty; // clear the file name
            space = ""; // clear the spacing string
            outputListBox.Items.Clear(); // clear the items in the list box
            fileContent = string.Empty; // clear the content of the file
            filePath = string.Empty; // clear the file path
        }

        /// <summary>
        /// This method goes through the tag list and creates a tag stack depending on
        /// opening and closing tags found. It then displays the appropriate found tags
        /// and checks wether the tags are balanced, and displays a message whether they
        /// are or not.
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void checkTagsMenuItem_Click(object sender, EventArgs e)
        {
            setSelfClosing(); // calls the self closing method
            int openCount = 0; // initializes the open tag count
            int closeCount = 0; // initializes the close tag count
            int selfCount = 0; // initializes the self closing tag count
            int tagCount = 0; // initializes the total tag count

            // this loop creates the tag stack, checks the balance, and displays the appropriate messages
            foreach (string s in tagList)
            {
                setSpacing(s); // set the spacing depending on the tag found
                if (tagCount == tagList.Count - 1) // check to see if the tag counts match to see if balanced
                    messageLabel.Text = $"{fileName} has balancing tags";
                if (openCount - closeCount > tagList.Count - tagCount) { // check to see if there are more open tags left in the stack then there are tags left meaning unbalanced
                    messageLabel.Text = $"{fileName} does not have balancing tags";
                    break;
                }
                if (s.StartsWith("/")) // checking if closing tag
                {
                    // pop a tag off of the stack when closing tag is found
                    outputListBox.Items.Add($"{space}Found Closing Tag: <{s}>");
                    tagStack.Pop();
                    closeCount++; // increment close count
                    tagCount++; // increment total tag count
                }
                else if (selfClosing.Contains(s)) // check if tag is self containing
                {
                    outputListBox.Items.Add($"{space}Found Non-Container Tag: <{s}>");
                    selfCount++; // increment self tag count
                    tagCount++; // increment total tag count
                }
                else
                {
                    // push tag to the stack when open tag is found
                    tagStack.Push(s);
                    outputListBox.Items.Add($"{space}Found Opening Tag: <{tagStack.Peek()}>");
                    openCount++; // increment open tag count
                    tagCount++; // increment total tag count
                }
            }
        }

        /// <summary>
        /// This method sets the appropriate spacing used for the output depending on which type of tag is passed through
        /// </summary>
        /// <param name="s">The tag that gets checked</param>
        private void setSpacing(string s)
        {
            if (s.StartsWith("html") || s.StartsWith("/html"))
                space = "";
            if (s.StartsWith("head") || s.StartsWith("body") || s.StartsWith("/head") || s.StartsWith("/body") || s.StartsWith("/BODY"))
                space = "   ";
            if (s.Contains("title") || s.StartsWith("h1") || s.StartsWith("p") || s.StartsWith("br") || s.StartsWith("/title") || s.StartsWith("/h1") || s.StartsWith("/p") || s.StartsWith("/br") || s.StartsWith("table") || s.StartsWith("/table"))
                space = "       ";
            if (s.StartsWith("a") || s.StartsWith("/a") || s == "b" || s == "/b")
                space = "           ";
            if (selfClosing.Contains(s) || s.Contains("tr"))
                space = "               ";
            if (s.Contains("td"))
                space = "                  ";
        }

        /// <summary>
        /// This is the method that builds the list of self closing tags
        /// </summary>
        private void setSelfClosing()
        {
            selfClosing.Add("area");
            selfClosing.Add("base");
            selfClosing.Add("br");
            selfClosing.Add("embed");
            selfClosing.Add("hr");
            selfClosing.Add("iframe");
            selfClosing.Add("img");
            selfClosing.Add("input");
            selfClosing.Add("link");
            selfClosing.Add("meta");
            selfClosing.Add("param");
            selfClosing.Add("source");
            selfClosing.Add("track");
        }

        /// <summary>
        /// This method closes the program
        /// </summary>
        /// <param name="sender">The sender parameters</param>
        /// <param name="e">the event parameters</param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // closes the app
        }

    }
}
