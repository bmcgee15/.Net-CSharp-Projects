/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the ThreeDShape class.
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
    /// This is the Tetrahedron class, derived from the ThreeDShapes class.
    /// </summary>
    class Tetrahedron : ThreeDShapes
    {
        public double Length { get; protected set; }

        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the surface area of the Tetrahedron.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = Math.Sqrt(3) * (Length * Length);
            return Area;
        }

        /// <summary>
        /// This is the calculate volume method which as it states
        /// calculates the volume of the Tetrahedron.
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            Volume = (Length * Length * Length) / (Math.Sqrt(2) * 6);
            return Volume;
        }

        /// <summary>
        /// This is the set data method which prompts the user for the
        /// details of the box they would like to make. First it
        /// sets the shape type, then validates the input, and sets the
        /// length of the tetrahedron if input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Tetrahedron";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Length of the Tetrahedron:");

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

        }

        /// <summary>
        /// This is the Tetrahedron's ToString method that displays the details
        /// of the created tetrahedron, formatted to match the main console output.
        /// </summary>
        /// <returns>output</returns>
        public override string ToString()
        {
            String output = String.Format("{0, -11} {1, 11} {2, 11} {3, -45}", Type, $"{Area:F2}", $"{Volume:F2}", $"| {Length:F2} l");
            return output;
        }
    }
}
