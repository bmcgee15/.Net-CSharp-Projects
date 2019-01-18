/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the Ellipse class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Created by Bret McGee - 9/27/2018
/// 
/// This program is design to take in one or more 2D or 3D shapes and output their
/// Type, Area, Volume, and Details.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab2A
{
    /// <summary>
    /// This is the Circle class, derived from the Ellipse class.
    /// </summary>
    class Circle : Ellipse
    {
        public double Radius { get; protected set; }

        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the area of the circle.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = Radius * Radius * PI;
            return Area;
        }

        /// <summary>
        /// This is the set data method which prompts the user for
        /// the details of the circle they would like to make. First
        /// it sets the shape type, then validates the input, and sets
        /// the radius of the circle if input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Circle";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Radius of the Circle:");

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Radius = double.Parse(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Radius:");
                }

            }
        }

        /// <summary>
        /// This is the Circle's ToString method that displays the details
        /// of the created Circle, formatted to match the main console output.
        /// </summary>
        /// <returns>output</returns>
        public override string ToString()
        {
            String output = String.Format("{0, -11} {1, 11} {2, 11} {3, -45}", Type, $"{Area:F2}", "", $"| {Radius:F2} r");
            return output;
        }
    }
}
