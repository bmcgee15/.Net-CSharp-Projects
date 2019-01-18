/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This abstract class is derived from the Shape class,
           and is the base of many other three-dimensional shapes.

           As it is an abstract class, there can be no instances of it.
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
    /// This is the 3D Shape abstract class which house
    /// some extra 3D specific instance variables. 
    /// </summary>
    public abstract class ThreeDShapes : Shape
    {
        public double Area { get; protected set; }
        public double Volume { get; protected set; }
    }
}
