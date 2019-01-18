/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the Box class.
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
    /// This is the Cube class, derived from the Box class.
    /// </summary>
    class Cube : Box
    {
        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the surface area of the cube.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = (Length * Length) * 6;
            return Area;
        }

        /// <summary>
        /// This is the calculate volume method which as it states
        /// calculates the volume of the cube.
        /// </summary>
        /// <returns>Volume</returns>
        public override double CalculateVolume()
        {
            Volume = Length * Length * Length;
            return Volume;
        }

        /// <summary>
        /// This is the set data method which prompts the user
        /// for the details of the cube they would like to make.
        /// First it sets the shape type, then validates the input,
        /// and sets the length, width and height of the cube if
        /// input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Cube";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Length of the Cube:");

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Length = double.Parse(input);
                    Width = Length;
                    Height = Length;
                    flag = false;
                }
                else
                {
                    Console.Write("Please enter an integer for the Length:");
                }

            }
        }
    }
}
