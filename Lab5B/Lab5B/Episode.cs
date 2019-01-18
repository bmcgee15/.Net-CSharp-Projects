/*  
  Author: Bret MJ McGee
  Date:   December 5th 2018

  Purpose: This is the episode class
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
    /// This is the episode class
    /// </summary>
    class Episode
    {
        public string Story { get; set; } // initialize story property
        public int Season { get; set; } // initialize season property
        public int Year { get; set; } // initialize year property
        public string Title { get; set; } // initialize title property

        /// <summary>
        /// This is the episode constructor
        /// </summary>
        /// <param name="Story">The episode number</param>
        /// <param name="Season">The season of the episode</param>
        /// <param name="Year">The year of the episode</param>
        /// <param name="Title">The tile of the episode</param>
        public Episode(string Story, int Season, int Year, string Title)
        {
            this.Story = Story;
            this.Season = Season;
            this.Year = Year;
            this.Title = Title;
        }

    }
}
