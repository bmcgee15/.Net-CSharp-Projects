/*  
  Author: Bret MJ McGee
  Date:   November 6th 2018

  Purpose: This is the main program sequence.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Created by Bret McGee - 11/6/2018
/// 
/// This program is design to read a data file, extract/organize the data,
/// and create an interface for displaying the decrypted searchable data.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab3A
{
    class Song : Media
    {
        public string Type { get; set; } // initialize type property
        public string Album { get; set; } // initialize album property
        public string Artist { get; set; } // initialize artist property

        /// <summary>
        /// This is the song constructor that initializes type, title, year, album and artist
        /// calling the base constructor with the title and year arguments
        /// </summary>
        /// <param name="Type">The type of object used polymorphically in media arrays</param>
        /// <param name="Title">The title of the book</param>
        /// <param name="Year">the year the book was published</param>
        /// <param name="Album">the album of the book</param>
        /// <param name="Artist">the artist of the book</param>
        public Song(string Type, string Title, int Year, string Album, string Artist) : base(Title, Year)
        {
            this.Type = Type;
            this.Album = Album;
            this.Artist = Artist;
        }

        /// <summary>
        /// Overridden ToString method
        /// </summary>
        /// <returns>the to string</returns>
        public override string ToString()
        {
            return $"Song Title:\t{Title}  ({Year})\nAlbum:\t\t{Album}\nArtist:\t\t{Artist}";
        }
    }
}
