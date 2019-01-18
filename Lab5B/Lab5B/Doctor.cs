/*  
  Author: Bret MJ McGee
  Date:   December 5th 2018

  Purpose: This is the doctor class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Created by Bret McGee - 12/5/2018
/// 
/// This program is design to read a data file, extract/organize the data,
/// and create an interface for displaying the relevant searchable data.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab5B
{
    /// <summary>
    /// This is the doctor class
    /// </summary>
    class Doctor
    {
        public int Ordinal { get; set; } // initialize ordinal property
        public string Actor { get; set; } // initialize actor property
        public int Series { get; set; } // initialize series property
        public int Age { get; set; } // initialize age property
        public string Debut { get; set; } // initialize debut property

        /// <summary>
        /// This is the doctor constructor
        /// </summary>
        /// <param name="Ordinal">The doctors number</param>
        /// <param name="Actor">The actors name</param>
        /// <param name="Series">The length of series they played as the character</param>
        /// <param name="Age">Their age when they started</param>
        /// <param name="Debut">Their debut</param>
        public Doctor(int Ordinal, string Actor, int Series, int Age, string Debut)
        {
            this.Ordinal = Ordinal;
            this.Actor = Actor;
            this.Series = Series;
            this.Age = Age;
            this.Debut = Debut;
        }
    }
}
