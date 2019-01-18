///
/// Program: Employee Sort
/// 
/// Author: Bret McGee
/// Date:   November 18th 2018
/// 
/// Purpose:  This program reads the employee.txt data file and stores the information in an array of
///           Employee objects.  The user is then presented with a menu that allows them to select which
///           of five fields to sort the resultant table by: Employee name, ID, rate, hours, or gross pay.
///           
///           The program ends when the user selects the exit option from the menu.
///
/// I, Bret McGee, 000207475 certify that this material is my original work.
/// No other person's work has been used without due acknowledgement.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// This class describes the employee
/// </summary>
public class Employee
{
    public string Name { get; set; }                          // The employee name
    public int Number { get; set; }                           // The employee ID
    public decimal Rate { get; set; }                         // The hourly rate
    public double Hours { get; set; }                         // The weekly hours
    public decimal Gross { get; set; }                        // The gross pay

    /// <summary>
    /// Default constructor for Employee - used for creating Employee list
    /// </summary>
    public Employee()
    {
    }

    /// <summary>
    /// Four-argument constructor for Employee
    /// </summary>
    /// <param name="name">Employee name</param>
    /// <param name="number">Employee number</param>
    /// <param name="rate">Hourly rate of pay</param>
    /// <param name="hours">Hours worked in a week</param>
    public Employee(string name, int number, decimal rate, double hours)
    {
        Name = name;
        Number = number;
        Rate = rate;
        Hours = hours;
        Gross = GetGross();
    }

    /// <summary>
    /// Gross pay get method
    /// </summary>
    /// <returns>Gross pay for the week</returns>
    public decimal GetGross() => (Hours < 40) ? (decimal)Hours * Rate : (40.0m * Rate) + (((decimal)Hours - 40.0m) * Rate * 1.5m);

    /// <summary>
    /// Employee display method overriding ToString() method
    /// </summary>
    public override String ToString() => $"{Name,-20}  {Number:D5}  {Rate,6:C}  {Hours:#0.00}  {Gross,9:C}";


}

