/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the TwoDShape class,
           and is the base for the circle class.
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
    /// This is the Ellipse class, derived from the TwoDShapes class.
    /// </summary>
    class Ellipse : TwoDShapes
    {

        public double MajorAxis { get; protected set; }
        public double MinorAxis { get; protected set; }

        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the area of the ellipse.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = MajorAxis * MinorAxis * PI;
            return Area;
        }

        /// <summary>
        /// Ellipses do not have a volume, so this method throws
        /// an exception if used.
        /// </summary>
        /// <returns>Exception</returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is the set data method which prompts the user
        /// for the details of the ellipse they would like to make.
        /// First it sets the shape type, then validates the input,
        /// and sets the major axis, and minor axis of the ellipse if
        /// input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Ellipse";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Major Axis of the Ellipse:");

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    MajorAxis = double.Parse(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Major Axis:");
                }

            }

            Console.Write("Please Enter the Minor Axis of the Ellipse:");

            flag = true;

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    MinorAxis = Convert.ToInt32(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Minor Axis:");
                }

            }
        }

        /// <summary>
        /// This is the Ellipse's ToString method that displays the details
        /// of the created ellipse, formatted to match the main console output.
        /// </summary>
        /// <returns>output</returns>
        public override string ToString()
        {
            String output = String.Format("{0, -11} {1, 11} {2, 11} {3, -45}", Type, $"{Area:F2}", "", $"| {MajorAxis:F2} M : {MinorAxis:F2} m");
            return output;
        }
    }
}
