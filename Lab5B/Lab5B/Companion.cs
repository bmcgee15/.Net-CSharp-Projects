/*  
  Author: Bret MJ McGee
  Date:   December 5th 2018

  Purpose: This is the companion class
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
    /// This is the companion class
    /// </summary>
    class Companion
    {
        public string Name { get; set; } // initialize name property
        public string Actor { get; set; } // initialize actor property
        public int Doctor { get; set; } // initialize doctor property
        public string Debut { get; set; } // initialize debut property
        public string Episode { get; set; } // initialize episode property
        public int Year { get; set; } // initialize year property

        /// <summary>
        /// The 4 param companion constructor
        /// </summary>
        /// <param name="Name">The name of the companion</param>
        /// <param name="Actor">The name of the actor</param>
        /// <param name="Doctor">The doctor they companioned</param>
        /// <param name="Debut">The first debut</param>
        public Companion(string Name, string Actor, int Doctor, string Debut)
        {
            this.Name = Name;
            this.Actor = Actor;
            this.Doctor = Doctor;
            this.Debut = Debut;
        }

        /// <summary>
        /// The 6 param companion constructor
        /// </summary>
        /// <param name="Name">The name of the companion</param>
        /// <param name="Actor">The name of the actor</param>
        /// <param name="Doctor">The doctor they companioned</param>
        /// <param name="Debut">The first debut</param>
        /// <param name="Episode">The episode of the first debut</param>
        /// <param name="Year">The year of the first debut</param>
        public Companion(string Name, string Actor, int Doctor, string Debut, string Episode, int Year)
        {
            this.Name = Name;
            this.Actor = Actor;
            this.Doctor = Doctor;
            this.Debut = Debut;
            this.Episode = Episode;
            this.Year = Year;
        }


    }



}
