using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class User
    {
        //Blank Constructor
        public User() { }


        public string FirstName { get; set; }
       /* public string LastName { get; set; }*/
        public int ID { get; set; }
        public DateTime BirthDate { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        //Full Constructor
        public User(string firstName, string lastName, int idNum, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = idNum;
            BirthDate = birthDate;
        }
             
       //Bonus:  Create a method that returns the full name of the user.
        public string FullName()
        {
            return $"({FirstName} {LastName}";
        }

        //Double Bonus: Create a method that returns the age of the user in years.

        public int Age()
        {
            TimeSpan ageSpan = DateTime.Now - BirthDate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }  

}
