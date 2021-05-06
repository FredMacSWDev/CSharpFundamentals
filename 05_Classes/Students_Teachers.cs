using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum CourseType { CyberSecurity, SoftwareDevelopment, WebDevelopment }
    public enum BadgeType { GoldBadge, BlueBadge, RedBadge }
    public enum CourseTaught { Cyber, WebDev, SoftDev }
    public class Student
    {
        public Student() { }
        public Student(string firstName, string lastName, DateTime doB, CourseType classTaking, decimal balOwed, BadgeType typeofBadge, bool hasGrad)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = doB;
            ClassTaking = classTaking;
            BalanceOwed = balOwed;
            TypeofBadge = typeofBadge;
            HasGraduated = hasGrad;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType ClassTaking { get; set; }
        public decimal BalanceOwed { get; set; }
        public BadgeType TypeofBadge { get; set; }
        public bool HasGraduated { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Instructor
    {
        public Instructor(string firstName, string lastName, DateTime doB, int employeeNumber, CourseTaught courseTaught) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = doB;
            EmployeeNumber = employeeNumber;
            CourseTaught = courseTaught;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; }
        public int EmployeeNumber { get; set; }
        public CourseTaught CourseTaught { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
