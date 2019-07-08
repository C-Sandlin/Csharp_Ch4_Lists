using System;
using System.Collections.Generic;

namespace NSSOrientation
{
    public class Program
    {
        public static void Main()
        {
            List<string> students = new List<string>() {
                "Megan", "Damon", "Chase", "Tekisha",
                "Castle", "Mark", "Keith", "Adam",
                "Patrick", "Hannah", "Mike"
            };

            Console.WriteLine("Initial list of students");
            students.ForEach(student => Console.WriteLine(student));


            // Can't do this easily with a base array
            students.Add("Melanie");
            Console.WriteLine("List of students after adding Melanie:");
            students.ForEach(stu => Console.WriteLine(stu));

            students.Insert(3, "Simon");
            Console.WriteLine("List of students after inserting Simon:");
            students.ForEach(stu => Console.WriteLine(stu));


            List<string> newStudents = new List<string>() {
                "JR",
                "DanceStorm",
                "Colin"
            };

            students.AddRange(newStudents);
            Console.WriteLine("List of students after adding range");
            students.ForEach(stu => Console.WriteLine(stu));

            List<string> newStudents2 = new List<string>() {
                "Frank",
                "Bob"
            };
            students.InsertRange(2, newStudents2);
            Console.WriteLine("List of students after inserting range");
            students.ForEach(stu => Console.WriteLine(stu));

            students.RemoveAt(5);
            Console.WriteLine("List of students after removing Simon");
            students.ForEach(stu => Console.WriteLine(stu));



            if (students.Contains("Chase"))
            {
                Console.WriteLine("Must be cohort 13");
            }

            string foundItem = students.Find(student => student == "DanceStorm");
            Console.WriteLine($"Found item: {foundItem}");

            string foundItem2 = students.Find(student => student.Length == 4);
            Console.WriteLine($"Found item2: {foundItem2}");

            List<string> foundItem3 = students.FindAll(student => student.Length == 4);
            Console.WriteLine($"Found item3: ");
            foundItem3.ForEach(item => Console.WriteLine(item));


        }
    }
}