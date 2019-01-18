/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This class is derived from the Rectangle class.
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
    /// This is the Square class, derived from the Rectangle class.
    /// </summary>
    class Square : Rectangle
    {
        /// <summary>
        /// This is the calculate area method which as it states
        /// calculates the area of the Square.
        /// </summary>
        /// <returns>Area</returns>
        public override double CalculateArea()
        {
            Area = Length * Width;
            return Area;
        }

        /// <summary>
        /// This is the set data method which prompts the user
        /// for the details of the square they would like to make.
        /// First it sets the shape type, then validates the input,
        /// and sets the length and width of the box if input was properly validated.
        /// </summary>
        public override void SetData()
        {
            Type = "Square";

            double result;
            bool flag = true;

            Console.Write("Please Enter the Length of the Square:");

            while (flag)
            {
                String input = Console.ReadLine();
                if (double.TryParse(input, out result))
                {
                    Length = double.Parse(input);
                    Width = Length;
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
