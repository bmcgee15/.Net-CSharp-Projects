using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// This is the Employee class (single employee)
    /// </summary>
    class Employee
    {
        private string name;
        private int number;
        private Decimal rate;
        private Double hours;
        private Decimal gross;

        /// <summary>
        /// This is the Employee overloaded constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="rate"></param>
        /// <param name="hours"></param>
        public Employee(string name, int number, Decimal rate, Double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }

        /// <summary>
        /// This is the gross getter method that calculates
        /// gross, and calculates overtime at 1.5 the rate.
        /// </summary>
        /// <returns>gross income</returns>
        public Decimal GetGross()
        {
            if (hours > 40)
            {
                gross = (40 * rate) + (((decimal)hours - 40) * (rate * (decimal)1.5));
            }
            else
            {
                gross = (decimal)hours * rate;
            }
                return gross;
        }

        /// <summary>
        /// This is the hours getter method
        /// </summary>
        /// <returns>hours worked</returns>
        public Double GetHours()
        {
            return hours;
        }

        /// <summary>
        /// This is the name getter method
        /// </summary>
        /// <returns>name of employee</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// This is the number getter method
        /// </summary>
        /// <returns>employee number</returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// This is the rate getter method
        /// </summary>
        /// <returns>pay rate</returns>
        public Decimal GetRate()
        {
            return rate;
        }

        /// <summary>
        /// This is the overidded to string method
        /// </summary>
        /// <returns>employee info</returns>
        public override string ToString()
        {
            return $"{name}, {number}, {rate}, {hours}, {gross}";
        }

        /// <summary>
        /// This is the hours setter method
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(Double hours)
        {
            this.hours = hours;
        }

        /// <summary>
        /// This is the name setter method
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// This is the number setter method
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(int number)
        {
            this.number = number;
        }

        /// <summary>
        /// This is the rate setter method
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(Decimal rate)
        {
            this.rate = rate;
        }
    }
}
