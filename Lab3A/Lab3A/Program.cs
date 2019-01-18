/*  
  Author: Bret MJ McGee
  Date:   November 6th 2018

  Purpose: This is the main program sequence.
*/
using System;
using System.Collections.Generic;
using System.IO;
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
    /// This is the main Class that runs the program 
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the method that runs the main block of
        /// program execution.
        /// </summary>
        /// <param name="args">The main program arguments</param>
        static void Main(string[] args)
        {
            // Create a Media List named media, returned from the readData method.
            List<Media> media = ReadData();
            // Execute the method that runs the looped user interaction, with media list used as an argument.
            Run(media);
        }

        /// <summary>
        /// This method runs the looped user interaction process that the user chooses what to sort and search for.
        /// </summary>
        /// <param name="media">The list of media objects pulled from the datafile</param>
        private static void Run(List<Media> media)
        {

            int userInput = 0; // initialize the user input variable to zero 
            int counter = 0; // initialize the counter to zero used trigger the display initializer when app starts
            bool running = true; // boolean flag for the main program running loop

            // the main app running loop
            while (running)
            {

                // Initializer
                if (counter == 0)
                {
                    displayTitle(); // displays the main title
                    displayChoices(); // displays the users options
                }

                // Loop the user input until a number is entered
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    displayTitle(); // displays the main title
                    displayChoices(); // displays the users options
                }
                if (userInput == 6) // end main loop if user inputs 6
                {
                    running = false; // trigger the boolean flag to exit the main program loop
                }
                else
                {
                    displayTitle(); // displays the main title

                    // switch class that displays different media types or the search field depending on user input
                    switch (userInput)
                    {
                        // info is displayed for all books in the file
                        case 1:
                            sortTitle("Book Search"); // executes the sort title method

                            // runs through the media list and displays any book data without summary in the file
                            foreach (Media item in media)
                            {
                                if (item is Book) // if the item is a book display the book info w/o summary
                                {
                                    itemSearch(item); // call the itemsearch method and pass item as argument
                                }
                            }
                            break; // break out of the switch case

                        // info is displayed for all movies in the file
                        case 2:
                            sortTitle("Movie Search"); // executes the sort title method

                            // runs through the media list and displays any movie data without summary in the file
                            foreach (Media item in media)
                            {
                                if (item is Movie) // if the item is a movie display the movie info w/o summary
                                {
                                    itemSearch(item); // call the itemsearch method and pass item as argument
                                }
                            }
                            break; // break out of the switch case

                        // info is displayed for all songs in the file
                        case 3:
                            sortTitle("Song Search"); // executes the sort title method

                            // runs through the media list and displays any song data in the file
                            foreach (Media item in media)
                            {
                                if (item is Song) // if the item is a song display the song info
                                {
                                    itemSearch(item); // call the itemsearch method and pass item as argument
                                }
                            }
                            break; // break out of the switch case

                        // info is displayed for all media types in the file
                        case 4:
                            sortTitle("Media Search"); // executes the sort title method

                            foreach (Media item in media) // loop all items in the Media List
                            {
                                if (item != null) // tue if the item is not empty
                                {
                                    if (item is Book) // if the item is a book display the book info w/o summary
                                    {
                                        itemSearch(item); // call the itemsearch method and pass item as argument
                                    }
                                    if (item is Movie) // if the item is a movie display the movie info w/o summary
                                    {
                                        itemSearch(item); // call the itemsearch method and pass item as argument
                                    }
                                    if (item is Song) // if the item is a song display the song info
                                    {
                                        itemSearch(item); // call the itemsearch method and pass item as argument
                                    }
                                }
                            }
                            break; // break out of the switch case

                        // info is displayed for all items that have the user inputed string in the title
                        case 5:
                            sortTitle("Search all media by title"); // executes the sort title method
                            foreach (Media item in media) // loop all items in the Media List
                            {
                                // prompt user
                                Console.WriteLine("Please enter a search term:\n ");
                                string query = Console.ReadLine(); // store user input
                                Console.WriteLine(""); // create extra space
                                if (query == "0" || query == "") // true if user input is not empty or 0
                                {
                                    break;  // break out of the switch case
                                }
                                foreach (Media m in media) // loop all items in the Media List
                                {
                                    if (m.Search(query)) // true if the query is in the title of an item in the Media List
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green; // make console text green
                                        Console.WriteLine(m); // display the item info not including summary for movie/book
                                        Console.ForegroundColor = ConsoleColor.White; // make console text white

                                        if (m is Book) // if item is book displays the decrypted summary of the book
                                        {
                                            Book temp = m as Book;
                                            Console.WriteLine("");
                                            Console.WriteLine(temp.Decrypt());
                                            Console.WriteLine("--------------------");
                                        }
                                        if (m is Movie) // if item is movie displays the decrypted summary of the movie
                                        {
                                            Movie temp = m as Movie;
                                            Console.WriteLine("");
                                            Console.WriteLine(temp.Decrypt());
                                            Console.WriteLine("--------------------");
                                        }

                                    }
                                }
                                break;
                            }
                            break;
                    }

                    displayChoices(); // displays the users options

                    // change output to remind user 1 - 6 are only valid numbers
                    if (userInput != 1 && userInput != 2 && userInput != 3 && userInput != 4 && userInput != 5)
                    {
                        Console.Write("Please Enter a number from 1 - 6: ");
                    }
                    else
                    {
                        Console.Write("Enter choice:");
                    }
                    counter++; // increase the counter used to initialize the first output
                }


            }
        }

        /// <summary>
        /// This method is used to display the appropriate item title
        /// </summary>
        /// <param name="type">the parameter to decide what type of item title is being displayed</param>
        private static void sortTitle(string type)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; // make console text red
            Console.WriteLine($"{type}");
            Console.WriteLine("-----------");
            Console.ForegroundColor = ConsoleColor.White; // make console text white
        }

        /// <summary>
        /// This method is used to display the appropriate item info
        /// </summary>
        /// <param name="item">takes in an object from the Media List</param>
        private static void itemSearch(Media item)
        {
            Console.ForegroundColor = ConsoleColor.Green; // make console text green
            Console.WriteLine(item);
            Console.ForegroundColor = ConsoleColor.White; // make console text white
            //Movie temp = item as Movie;
            //Console.WriteLine(temp.Decrypt());
            Console.WriteLine("--------------------");
        }

        /// <summary>
        /// This method displays the main display title
        /// </summary>
        private static void displayTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; // make console text red
            Console.WriteLine("{0, -20}", "Bret's Media Collection");
            Console.WriteLine("{0, -20}", "=======================");
            Console.ForegroundColor = ConsoleColor.White; // make console text white
        }

        /// <summary>
        /// This method displays the main user choices
        /// </summary>
        private static void displayChoices()
        {
            Console.WriteLine("\n1. List All Books");
            Console.WriteLine("2. List All Movies");
            Console.WriteLine("3. List All Songs");
            Console.WriteLine("4. List All Media");
            Console.WriteLine("5. Search All Media by Title\n");
            Console.WriteLine("6. Exit\n");
            Console.Write("Enter choice: ");
        }

        /// <summary>
        /// This method reads a data file, splits and organizes the pieces into a Media Object list
        /// used to search and display the information in the run method.
        /// </summary>
        /// <returns>a Media Object List of books, movies and songs</returns>
        private static List<Media> ReadData()
        {
            try // exception handling for the file IO
            {
                StreamReader data = new StreamReader("data.txt"); // read data from file
                string line; // initialize line string
                List<Media> media = new List<Media>(); // initialize the Media List named media
                while ((line = data.ReadLine()) != null) // true while the line read is not empty
                {
                    string[] exploded = line.Split('|'); // split the line read by the | character and save into array


                    string summary = ""; // initialize the summary string

                    do
                    {
                        line = data.ReadLine(); // readline and save the data in the line variable
                        if (line != "-----") // returns true if line is not -----
                            summary += line; // add the line to the summary string
                        else
                            summary += "";

                    } while (line != "-----"); // loop runs util line is -----

                    if (exploded[0] == "BOOK") // if the first index is book, create book object and add it to the Media List
                    {
                        Book temp = new Book(exploded[0], exploded[1], int.Parse(exploded[2]), exploded[3], summary);
                        media.Add(temp);
                    }
                    if (exploded[0] == "MOVIE") // if the first index is movie, create movie object and add it to the Media List
                    {
                        Movie temp = new Movie(exploded[0], exploded[1], int.Parse(exploded[2]), exploded[3], summary);
                        media.Add(temp);
                    }
                    if (exploded[0] == "SONG") // if the first index is song, create song object and add it to the Media List
                    {
                        Song temp = new Song(exploded[0], exploded[1], int.Parse(exploded[2]), exploded[3], exploded[4]);
                        media.Add(temp);
                    }

                }
                data.Close(); // close the IO
                return media; // return the Media Array 
            }
            catch (Exception) // catch the exception if the file was not read properly
            {
                Console.WriteLine("the file was either not found or could not be read."); // exception error message
                throw; // throw the exception
            }
        }
    }
}


