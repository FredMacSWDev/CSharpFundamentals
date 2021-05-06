using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Frederick";
            string lastName = "McClung";

            //Concatenation
            string concatenatedFullName = firstName + ' ' + lastName;
            Console.WriteLine(concatenatedFullName);

            //Compositing
            string compositeFullName = string.Format("{0} {1} will be a great coder {2}", firstName, lastName, "!");
            Console.WriteLine(compositeFullName);

            //Interpolation
            string interpolatedFullName = $"{firstName} \"Humble Servant\" {lastName} is blessed to be here!";
            Console.WriteLine(interpolatedFullName);

        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { stringExample, ". . .", "Why", "is it", "always", stringExample, "?" };

            string interpolatedStrings = $"{stringArray[2]} {stringArray[5]}";
            Console.WriteLine(interpolatedStrings);

            string firstString = stringArray[0];

            //Lists
            List<string> listofStrings = new List<String>();
            List<int> listofIntegers = new List<int>();

            listofStrings.Add("Hello");
            listofIntegers.Add(23);
            listofStrings.Add("World");

            Console.WriteLine(listofIntegers[0]);
            Console.WriteLine(listofStrings[1]);
            listofStrings.Remove(listofStrings[0]);
            Console.WriteLine(listofStrings[0]);

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm last");

            string whosFirst = firstInFirstOut.Peek();
            Console.WriteLine(whosFirst);
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string whosFirstNow = firstInFirstOut.Peek();
            Console.WriteLine(whosFirstNow);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(001, "EFA office");

            string badgeDoor = keyAndValue[001];
            Console.WriteLine(badgeDoor);
        }


    }
}
