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
    class Movie : Media, IEncryptable
    {
        public string Type { get; set; } // initialize type property
        public string Director { get; set; } // initialize director property
        public string Summary { get; set; } // initialize summary property

        /// <summary>
        /// This is the movie constructor that initializes type, title, year, director and summary
        /// calling the base constructor with the title and year arguments
        /// </summary>
        /// <param name="Type">The type of object used polymorphically in media arrays</param>
        /// <param name="Title">The title of the book</param>
        /// <param name="Year">the year the book was published</param>
        /// <param name="Director">the director of the book</param>
        /// <param name="Summary">the summary of the book</param>
        public Movie(string Type, string Title, int Year, string Director, string Summary) : base(Title, Year)
        {
            this.Type = Type;
            this.Director = Director;
            this.Summary = Summary;
        }

        /// <summary>
        /// This is the encrypted method, that just calls the decrypted method because its rot13
        /// and there are 26 characters in the alphabet
        /// </summary>
        /// <returns>the encrypted string</returns>
        public string Encrypt()
        {
            string encrypt = Decrypt();
            return encrypt;
        }

        /// <summary>
        /// This is the decrypt method used to decrypt the media files summaries
        /// </summary>
        /// <returns>the decrypted summary string</returns>
        public string Decrypt()
        {
            char[] array = Summary.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        /// <summary>
        /// Overridden ToString method
        /// </summary>
        /// <returns>the to string</returns>
        public override string ToString()
        {
            return $"Movie Title:\t{Title}  ({Year})\nDirector:\t{Director}";
        }
    }
}
