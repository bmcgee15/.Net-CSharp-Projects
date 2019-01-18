/*  
  Author: Bret MJ McGee
  Date:   September 27th 2018

  Purpose: This is the main program sequence.
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
    /// This is the main Class that runs the program 
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the method that runs the main block of
        /// program execution.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             First we display the console information using the initializer method, then
             we use the dataSetter method to promt the user to make a decision. Then we
             create an empty Shape list, and create a boolean flag to run a loop that
             validates the users input and then takes an action depending on the user input
             to either create a new shape of choice, or display the Shape list info and exit.
             */
            String input;
            initializer();
            dataSetter();
            bool flag = true;
            var shapeList = new List<Shape>();
            while (flag)
            {

                if(input.ToUpper() == "A" || input.ToUpper() == "B" || input.ToUpper() == "C" || input.ToUpper() == "D" || input.ToUpper() == "E" || input.ToUpper() == "F" || input.ToUpper() == "G" || input.ToUpper() == "H" || input.ToUpper() == "I" || input.ToUpper() == "J" || input == "0")
                {
                    switch (input.ToUpper())
                    {
                        // Switch statement deciding which shape to make
                        case "A":
                            Rectangle a = new Rectangle();
                            a.SetData();
                            a.CalculateArea();
                            shapeList.Add(a);
                            Console.Clear();
                            break;
                        case "B":
                            Square b = new Square();
                            b.SetData();
                            b.CalculateArea();
                            shapeList.Add(b);
                            Console.Clear();
                            break;
                        case "C":
                            Box c = new Box();
                            c.SetData();
                            c.CalculateArea();
                            c.CalculateVolume();
                            shapeList.Add(c);
                            Console.Clear();
                            break;
                        case "D":
                            Cube d = new Cube();
                            d.SetData();
                            d.CalculateArea();
                            d.CalculateVolume();
                            shapeList.Add(d);
                            Console.Clear();
                            break;
                        case "E":
                            Ellipse e = new Ellipse();
                            e.SetData();
                            e.CalculateArea();
                            shapeList.Add(e);
                            Console.Clear();
                            break;
                        case "F":
                            Circle f = new Circle();
                            f.SetData();
                            f.CalculateArea();
                            shapeList.Add(f);
                            Console.Clear();
                            break;
                        case "G":
                            Cylinder g = new Cylinder();
                            g.SetData();
                            g.CalculateArea();
                            g.CalculateVolume();
                            shapeList.Add(g);
                            Console.Clear();
                            break;
                        case "H":
                            Sphere h = new Sphere();
                            h.SetData();
                            h.CalculateArea();
                            h.CalculateVolume();
                            shapeList.Add(h);
                            Console.Clear();
                            break;
                        case "I":
                            Triangle i = new Triangle();
                            i.SetData();
                            i.CalculateArea();
                            shapeList.Add(i);
                            Console.Clear();
                            break;
                        case "J":
                            Tetrahedron j = new Tetrahedron();
                            j.SetData();
                            j.CalculateArea();
                            j.CalculateVolume();
                            shapeList.Add(j);
                            Console.Clear();
                            break;
                        case "0":
                            Console.WriteLine();
                            outputTemplate();
                            foreach(Shape shapes in shapeList)
                            {
                                Console.WriteLine(shapes.ToString());
                            }
                            flag = false;
                            break;
                        default:
                            break;
                    }
                    if (flag)
                    {
                        initializer();
                        dataSetter();
                    }

                } else
                {
                    Console.Clear();
                    initializer();
                    Console.WriteLine("Not valid input");
                    dataSetter();
                }


            }

            /*
             * This line was used to prevent the console from closing instantly when user
             * chooses to display the shape list info. Allows user to hit any button to exit.
             */
            Console.ReadLine();


            /// <summary>
            /// This is the initializer method, used to easily refill the console with
            /// the main information when needed.
            /// </summary>
            void initializer()
            {
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Bret's Geometry Class:");
                Console.ResetColor();
                Console.WriteLine("{0, -20}  {1, -20}", "A - Rectangle", "F - Circle");
                Console.WriteLine("{0, -20}  {1, -20}", "B - Square", "G - Cylinder");
                Console.WriteLine("{0, -20}  {1, -20}", "C - Box", "H - Sphere");
                Console.WriteLine("{0, -20}  {1, -20}", "D - Cube", "I - Triangle");
                Console.WriteLine("{0, -20}  {1, -20}", "E - Ellipse", "J - Tetrahedron");
                Console.WriteLine("\n0 - List all shapes | THEN HIT ENTER TO EXIT\n");
                Console.WriteLine($"You have entered {Shape.GetCount()} shape(s) so far\n");
            }

            /// <summary>
            /// This is the dataSetter method, used to easily prompt the user
            /// to input information when needed.
            /// </summary>
            void dataSetter()
            {
                Console.Write("Enter your choice: ");
                input = Console.ReadLine();
            }

            /// <summary>
            /// This is the outputTemplate method, used to easily display the output Heading
            /// when the user prompt for the output of the Shape array.
            /// </summary>
            void outputTemplate()
            {
                Console.WriteLine("{0, -11} {1, -11} {2, -11} {3, -45}", "Shape", "Area", "Volume", "Details");
                Console.WriteLine("{0, -11} {1, -11} {2, -11} {3, -45}", "===========", "===========", "===========", "=============================================");
            }
        }
    }
}
