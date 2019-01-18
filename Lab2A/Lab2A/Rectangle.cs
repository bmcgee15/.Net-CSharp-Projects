/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the TwoDShape class,
           and is the base for the square class.
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
    /// This is the Rectangle class, derived from the TwoDShapes class.
    /// </summary>
    class Rectangle : TwoDShapes
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the area of the rectangle.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = Length * Width;
            return Area;
        }

        /// <summary>
        /// Rectangles do not have a volume, so this method throws
        /// an exception if used.
        /// </summary>
        /// <returns>Exception</returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is the set data method which prompts the user
        /// for the details of the rectangle they would like to make.
        /// First it sets the shape type, then validates the input,
        /// and sets the length, width of the rectangle if
        /// input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Rectangle";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Length of the Rectangle:");

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Length = double.Parse(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Length:");
                }
                
            }

            Console.Write("Please Enter the Width of the Rectangle:");

            flag = true;

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Width = Convert.ToInt32(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Width:");
                }
                
            }

        }

        /// <summary>
        /// This is the Rectangle's ToString method that displays the details
        /// of the created rectangle, formatted to match the main console output.
        /// </summary>
        /// <returns>output</returns>
        public override string ToString()
        {
            String output = String.Format("{0, -11} {1, 11} {2, 11} {3, -45}", Type, $"{Area:F2}", "", $"| {Length:F2} l : {Width:F2} w");
            return output;
        }
    }
}
