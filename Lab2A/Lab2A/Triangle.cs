/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the TwoDShape class.
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
    /// This is the Triangle class, derived from the TwoDShapes class.
    /// </summary>
    class Triangle : TwoDShapes
    {
        public double Base { get; protected set; }
        public double Height { get; protected set; }

        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the surface area of the Triangle.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = (Base * Height) / 2;
            return Area;
        }

        /// <summary>
        /// Triangles do not have a volume, so this method throws
        /// an exception if used.
        /// </summary>
        /// <returns>Exception</returns>
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is the set data method which prompts the user for the
        /// details of the triangle they would like to make. First it sets 
        /// the shape type, then validates the input, and sets the base,
        /// and height of the triangle if input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Triangle";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Base of the Triangle:");

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Base = double.Parse(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Base:");
                }

            }

            Console.Write("Please Enter the Height of the Triangle:");

            flag = true;

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Height = Convert.ToInt32(input);
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Height:");
                }

            }

        
        }

        /// <summary>
        /// This is the Triangle's ToString method that displays the details
        /// of the created triangle, formatted to match the main console output.
        /// </summary>
        /// <returns>output</returns>
        public override string ToString()
        {
            String output = String.Format("{0, -11} {1, 11} {2, 11} {3, -45}", Type, $"{Area:F2}", "", $"| {Base:F2} b : {Height:F2} h");
            return output;
        }
    }
}
