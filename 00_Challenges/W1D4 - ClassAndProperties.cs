using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class W1D4_ClassAndProperties
    {
        [TestMethod]
        public void UserTests()
        {
            User bobby = new User("Bob", "Mackey", 001, new DateTime(1988, 02, 12));
            Console.WriteLine($"{bobby.FullName()}");

            Console.WriteLine(bobby.ID);
            Console.WriteLine(bobby.BirthDate);
            
        }
}
}
