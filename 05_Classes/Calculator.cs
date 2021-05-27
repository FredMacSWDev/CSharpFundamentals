using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        // Write a method that takes in two numbers and returns the sum of those two numbers as a double
        //Access mod + type + + body
        public double GetSum(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            return sumSolution;
        }

        //subtraction
        //multiplication
        //division

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;

        }
    }
}
