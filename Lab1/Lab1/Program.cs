using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Created by Bret McGee - 9/19/2018
/// 
/// This program is designed to read information from a file,
/// and sort/display that information to the liking of the user.
/// 
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// </summary>
namespace Lab1
    {

    /// <summary>
    /// This is the main Class that runs the program 
    /// </summary>
    class Program
    {   

        /// <summary>
        /// This is the Read Method that find the file,
        /// reads from the file, creates an array out
        /// of the files content and has exception handling.
        /// </summary>
        /// <returns>
        /// The employee array
        /// </returns>
        static Employee[] Read()
        {
            // Try/Catch block for exception handling of read issues
            try
            {
            // accesses file, reads file, counts lines, creates array based on number
            // of lines, loops to split file at commas & add to array, returns array.
            FileStream accessFile = new FileStream("employees.txt", FileMode.Open, FileAccess.Read);
            StreamReader readFile = new StreamReader(accessFile);
            int lineCount = File.ReadLines("employees.txt").Count();
            String line;
            Employee[] employees = new Employee[lineCount];
            int count = 0;

            while ((line = readFile.ReadLine()) != null)
            {
                String[] splitter = line.Split(',');
                Employee employee = new Employee(splitter[0], int.Parse(splitter[1]), Decimal.Parse(splitter[2]), Double.Parse(splitter[3]));
                employees[count] = employee;
                count++;
            }

            readFile.Close();

            return employees;

            }
            catch (Exception)
            {
                Console.WriteLine("The file was either not found or could not be read.");
                throw;
            }

        }


        // Used Insertion Sort from https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-6.php
        /// <summary>
        /// This is the sort method that takes in an array,
        /// and a user input for which sorting branch wanted
        /// the array is then sorted.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="userInput"></param>
        /// <returns>
        /// The sorted employee aray
        /// </returns>
        static Employee[] Sort(Employee[] inputArray, int userInput)
        {
            switch (userInput)
            {
                // The switch case for the name ascending sort
                case 1:
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            int stringCompare = inputArray[j - 1].GetName().CompareTo(inputArray[j].GetName());
                            if (stringCompare > 0)
                            {
                                Employee temp = inputArray[j - 1];
                                inputArray[j - 1] = inputArray[j];
                                inputArray[j] = temp;
                            }
                        }
                    }
                    break;
                // The switch case for the number ascending sort
                case 2:
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            if (inputArray[j - 1].GetNumber() > inputArray[j].GetNumber())
                            {
                                Employee temp = inputArray[j - 1];
                                inputArray[j - 1] = inputArray[j];
                                inputArray[j] = temp;
                            }
                        }
                    }
                    break;
                // The switch case for the rate descending sort
                case 3:
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            if (inputArray[j - 1].GetRate() < inputArray[j].GetRate())
                            {
                                Employee temp = inputArray[j - 1];
                                inputArray[j - 1] = inputArray[j];
                                inputArray[j] = temp;
                            }
                        }
                    }
                    break;
                // The switch case for the hours descending sort
                case 4:
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            if (inputArray[j - 1].GetHours() < inputArray[j].GetHours())
                            {
                                Employee temp = inputArray[j - 1];
                                inputArray[j - 1] = inputArray[j];
                                inputArray[j] = temp;
                            }
                        }
                    }
                    break;
                // The switch case for the gross descending sort
                case 5:
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        for (int j = i + 1; j > 0; j--)
                        {
                            if (inputArray[j - 1].GetGross() < inputArray[j].GetGross())
                            {
                                Employee temp = inputArray[j - 1];
                                inputArray[j - 1] = inputArray[j];
                                inputArray[j] = temp;
                            }
                        }
                    }
                    break;
            }
            return inputArray;
        }

        



        /// <summary>
        /// The method that runs the main block of
        /// program execution.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int userInput = 0;
            int counter = 0;
            bool running = true;

            while (running)
            {
                // create a new array from the returned read method array
                Employee[] employeeArray = Read();


                // Initializer
                if (counter == 0)
                {
                    Console.WriteLine("{0, -20}  {1, 6}  {2, 6}  {3, 5}  {4, 9}          {5, 15}", "Employee", "Number", "Rate", "Hours", "Gross Pay", "Bret's Company");
                    Console.WriteLine("{0, -20}  {1, 6}  {2, 6}  {3, 5}  {4, 9}          {5, 15}", "====================", "======", "======", "=====", "=========", "--------------");

                    for (int i = 0; i < employeeArray.Length; i++)
                    {
                        Console.WriteLine("{0, -20}  {1, 6}  {2, 6:C}  {3, 5:N2}  {4, 9:C}", $"{employeeArray[i].GetName()}", $"{employeeArray[i].GetNumber()}", $"{employeeArray[i].GetRate():C}", $"{employeeArray[i].GetHours():N}", $"{employeeArray[i].GetGross():C}");

                    }
                    Console.WriteLine("\n1. Sort by Employee Name");
                    Console.WriteLine("2. Sort by Employee Number");
                    Console.WriteLine("3. Sort by Employee Pay Rate");
                    Console.WriteLine("4. Sort by Employee Hours");
                    Console.WriteLine("5. Sort by Employee Gross Pay\n");
                    Console.WriteLine("6. Exit\n");
                    Console.Write("Enter choice: ");
                }

                // Loop the user input until a number is entered
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.Clear();
                    Console.WriteLine("{0, -20}  {1, 6}  {2, 6}  {3, 5}  {4, 9}          {5, 15}", "Employee", "Number", "Rate", "Hours", "Gross Pay", "Bret's Company");
                    Console.WriteLine("{0, -20}  {1, 6}  {2, 6}  {3, 5}  {4, 9}          {5, 15}", "====================", "======", "======", "=====", "=========", "--------------");

                    for (int i = 0; i < employeeArray.Length; i++)
                    {
                        Console.WriteLine("{0, -20}  {1, 6}  {2, 6:C}  {3, 5:N2}  {4, 9:C}", $"{employeeArray[i].GetName()}", $"{employeeArray[i].GetNumber()}", $"{employeeArray[i].GetRate():C}", $"{employeeArray[i].GetHours():N}", $"{employeeArray[i].GetGross():C}");

                    }

                    Console.WriteLine("\n1. Sort by Employee Name");
                    Console.WriteLine("2. Sort by Employee Number");
                    Console.WriteLine("3. Sort by Employee Pay Rate");
                    Console.WriteLine("4. Sort by Employee Hours");
                    Console.WriteLine("5. Sort by Employee Gross Pay\n");
                    Console.WriteLine("6. Exit\n");
                    Console.Write("Please Enter a number from 1 - 6: ");
                }
                if (userInput == 6) // end main loop if user inputs 6
                {
                    running = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0, -20}  {1, 6}  {2, 6}  {3, 5}  {4, 9}          {5, 15}", "Employee", "Number", "Rate", "Hours", "Gross Pay", "Bret's Company");
                    Console.WriteLine("{0, -20}  {1, 6}  {2, 6}  {3, 5}  {4, 9}          {5, 15}", "====================", "======", "======", "=====", "=========", "--------------");

                    // call the sort method and save new sorted array into employee array
                    employeeArray = Sort(employeeArray, userInput);

                    for (int i = 0; i < employeeArray.Length; i++)
                    {
                        Console.WriteLine("{0, -20}  {1, 6}  {2, 6:C}  {3, 5:N2}  {4, 9:C}", $"{employeeArray[i].GetName()}", $"{employeeArray[i].GetNumber()}", $"{employeeArray[i].GetRate():C}", $"{employeeArray[i].GetHours():N}", $"{employeeArray[i].GetGross():C}");

                    }

                    Console.WriteLine("\n1. Sort by Employee Name");
                    Console.WriteLine("2. Sort by Employee Number");
                    Console.WriteLine("3. Sort by Employee Pay Rate");
                    Console.WriteLine("4. Sort by Employee Hours");
                    Console.WriteLine("5. Sort by Employee Gross Pay\n");
                    Console.WriteLine("6. Exit\n");

                    // change output to remind user 1 - 6 are only valid numbers
                    if (userInput != 1 && userInput != 2 && userInput != 3 && userInput != 4 && userInput != 5)
                    {
                        Console.Write("Please Enter a number from 1 - 6: ");
                    }
                    else
                    {
                        Console.Write("Enter choice:");
                    }


                    counter++;
                }
             

            }

            Environment.Exit(0);

        }

    }
}
