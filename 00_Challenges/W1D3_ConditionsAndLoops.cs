using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class W1D3_ConditionsAndLoops
    {
        [TestMethod]
        public void W1D3LoopsAndConditionals()
        {
            //Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.
            //Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".

            string super = "Supercalifragilisticexpialidocious";
            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {

                    Console.WriteLine("Not an 'i'");
                }
            }
            Console.WriteLine(super.Length);
            int letterCount = 0;
            foreach (char letter in super)
            {
                ++letterCount;
                //letterCount += 1;
                //letterCount = letterCount + 1;
            }
            Console.WriteLine(letterCount);

            //Bonus: After that, print the number of letters in the word(do this with code, not by counting manually and hard-coding the number).

            //Another Bonus: In part 2, also determine if the letter is 'L'.If it is, print 'L'.



            //Declare and initialize variables that hold your first name, last name, and age

            string firstName = "Jacob";
            string lastName = "Brown";
            int age = 64;

            //Declare and initialize an array that holds a collection of at least four of your favorite book or movie titles
            string[] fav = { "Starship Troopers", "The Martian", "Spider-man", "RLM" };

            List<string> favorites = new List<string>();
            favorites.Add("Starship Troopers");
            favorites.Add("The Martian");
            favorites.Add("Spider-man");
            favorites.Add("Red Letter Media");
            //favorites.IndexOf("Spider-man");

            foreach (string item in favorites)
            {
                Console.WriteLine(item);
            }

            //Make a list to hold dates. Include on that list the current date and time.
            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Now);

            //Write out to the Console the values calculated by your age variable and the number 7.
            int add = age + 7;
            int sub = age - 7;
            int mul = age * 7;
            int quo = age / 7;
            Console.WriteLine($"{add},{sub},{mul},{quo}");

            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            //You can just initialize this variable for now, it does not have to be actually given by a user.

            //If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
            //If the hours is greater than  or equal 8 but less than 10, write to the console "You should be pretty rested"
            //If the hours is greater than 4 but less than 8, output "Bummer"
            //For any other condition output "Oh man, get some sleep!"

            int hoursSlept = 8;

            if (hoursSlept >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursSlept >= 8 && hoursSlept < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursSlept > 4 && hoursSlept < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            { Console.WriteLine("Oh man, get some sleep!"); }

            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            //Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.

            string happinesIndex = "Bad";
            switch (happinesIndex)
            {
                case "Great":
                    Console.WriteLine("Sweet");
                    break;
                case "Good":
                    Console.WriteLine("Okay");
                    break;
                case "Okay":
                    Console.WriteLine("Good");
                    break;
                case "Bad":
                    Console.WriteLine("Great");
                    break;
                Default:
                    Console.WriteLine("What");
                    break;
            }
        }
        [TestMethod]
        public void UserTests()
        {
            User john = new User("John", "Smith", 001, new DateTime(1990, 01, 23));
            Console.WriteLine($"{john.FullName()}");
            Console.WriteLine(john.Age());
        }
    }
}