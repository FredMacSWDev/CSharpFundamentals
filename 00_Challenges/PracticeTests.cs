using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class PracticeTests
    {
        [TestMethod]
        public void FizzBuzz()
        {
            int myNum = 20;

            for (int i = 0; i <= myNum; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        [TestMethod]
        public void AgeCalc()
        {
            DateTime today = DateTime.Today;            
            DateTime birthday = new DateTime(1975, 12, 09);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }
    }
}














