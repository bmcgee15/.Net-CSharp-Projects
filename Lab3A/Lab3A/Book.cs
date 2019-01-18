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
    /// <summary>
    /// This is the book class which inherits from base class Media and implements interface IEncryptable
    /// </summary>
    class Book : Media , IEncryptable
    {
        public string Type { get; set; } // initialize type property
        public string Author { get; set; } // initialize author property
        public string Summary { get; set; } // initialize summary property

        /// <summary>
        /// This is the book constructor that initializes type, title, year, author and summary
        /// calling the base constructor with the title and year arguments
        /// </summary>
        /// <param name="Type">The type of object used polymorphically in media arrays</param>
        /// <param name="Title">The title of the book</param>
        /// <param name="Year">the year the book was published</param>
        /// <param name="Author">the author of the book</param>
        /// <param name="Summary">the summary of the book</param>
        public Book(string Type, string Title, int Year, string Author, string Summary) : base(Title, Year)
        {
            this.Type = Type;
            this.Author = Author;
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
            return new string(array); // return the new decrypted string
        }

        /// <summary>
        /// Overridden ToString method
        /// </summary>
        /// <returns>the to string</returns>
        public override string ToString()
        {
            return $"Book Title:\t{Title}  ({Year})\nAuthor:\t\t{Author}";
        }
    }
}
