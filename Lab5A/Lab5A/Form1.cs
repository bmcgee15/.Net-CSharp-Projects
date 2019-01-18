/*
  Program: Lab5A.cs
  Author:  Bret McGee
  Date:    November 28th 2018
 
  Purpose: This program uses a timer controlled by a trackbar to change the speed of the 
           colour pouring out of the faucet to fill the box.
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
/// Created by Bret McGee - 12/04/2018
/// 
/// This program is designed to allow the user to choose a value to increment the tap
/// stream that fills the bucket using the slider.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab5A
{
    /// <summary>
    /// This is the main form class
    /// </summary>
    public partial class Form1 : Form
    {
        private Graphics g;                         // Initialize graphics
        private Pen p;                              // Initialize pen
        private SolidBrush b;                       // Initialize brush1
        private SolidBrush v;                       // Initialize brush2 used to turn tap off
        private Color c = Color.White;              // Initialize the main water colour
        private Color t = Color.Black;              // Initialize the colour used to turn tap off
        private int fillIncrement = 0;              // Initialize fill increment value
        int deHeight = 245;                         // Initialize the height of the tap stream
        int height = 0;                             // Initialize the height of the water fill rectangle
        int width = 549;                            // Initialize the width of the water fill rectangle
        int y = 450;                                // Initialize the y axis of the water fill rectangle
        int x = 26;                                 // Initialize the x axis of the water fill rectangle
        int timeCounter = 0;                        // Initialize the time counter
        Rectangle tap = new Rectangle();            // Initialize the tap rectangle

        /// <summary>
        /// The constructor for the form registers the event handler that automatically repaints the screen
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);  //Registers the Paint event handler
        }

        /// <summary>
        /// Clicking the Set Colour button opens the Color Dialog box so the user can select a new colour to draw with
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void ColourButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog.Color; // Changes label 1 colour label colour
                c = colorDialog.Color; // set the c variable to the colour chosen from colour picker
            }
        }

        /// <summary>
        /// This is the form paint method that draws the bucket
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;                          //Get the Graphics object from the PaintEventArgs
            p = new Pen(c);                          //Create a new Pen using the current colour
            b = new SolidBrush(c);
            v = new SolidBrush(t);

            /* Write a title to the form */
            //g.DrawString("Graphics Sampler", f, b, 100, 50);
            this.g.DrawLine(p, 25, 250, 25, 450);        //Draw two intersecting lines using the current Pen
            this.g.DrawLine(p, 25, 450, 575, 450);
            this.g.DrawLine(p, 575, 250, 575, 450);
            //this.g.FillRectangle(b, x, y, width, height);


        }

        /// <summary>
        /// Clicking the Close button exits the application
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">the event parameter</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method sets the data for the trackbar and the speed chosen by the user
        /// </summary>
        /// <param name="sender">the sender parameter</param>
        /// <param name="e">the event parameter</param>
        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            // Set the minimum and maximum number of ticks.
            SpeedTrackBar.Minimum = 0;
            SpeedTrackBar.Maximum = 10;

            // Set the tick frequency to one tick every ten units.
            SpeedTrackBar.TickFrequency = 10;

            fillIncrement = SpeedTrackBar.Value;
            label3.Text = fillIncrement.ToString();

            if (fillIncrement != 0 && height < 195)
            {
                // Sets the timer interval to .25 second.
                timer1.Interval = 250;
                timer1.Start();
            } else
            {
                timer1.Stop();
                Invalidate(tap);
            }

        }

        /// <summary>
        /// This is the timer method that is called when the trackbar is not set to zero.
        /// This method paints the tap stream and fills the bucket with water
        /// </summary>
        /// <param name="sender">The sender parameter</param>
        /// <param name="e">The event parameter</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y > 260)
            {

                g = this.CreateGraphics(); // sets the graphics variable g
                b = new SolidBrush(c); // sets the solid brush b with color c
                v = new SolidBrush(t); // sets the solid brush v with color t
                height += fillIncrement; // sets the height of the water rectangle
                deHeight -= fillIncrement; // sets the height of the tap stream
                y -= fillIncrement; // ofsets the y coordinate as the bucket fills
                timeCounter++; // increments the time counter
                tap = new Rectangle(160, 205, 20, deHeight); // sets the new rectangle parameters
                label2.Text = $"TimeCounter:{timeCounter} | y coordinate:{y} | height:{height}"; // displays the debugging labels
                this.g.FillRectangle(b, tap); // draws the tap stream
                this.g.FillRectangle(b, x, y, width, height); // draws the bucket fill
            }

        }
    }
}
