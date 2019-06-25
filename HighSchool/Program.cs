using System;
using System.Collections.Generic;


namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                { new Student() { FirstName = "Tristan", LastName = "Young", Grade = 5, GPA = 4 } },
                { new Student() { FirstName = "Chancellor", LastName = "DeLassus", Grade = 10, GPA = 3 }},
                { new Student() { FirstName = "Mary", LastName = "Stueck", Grade = 12, GPA = 4 }},
                { new Student() { FirstName = "Jessica", LastName = "Owens", Grade = 11, GPA = 3 }},
                { new Student() { FirstName = "Dustin", LastName = "Gabert", Grade = 9, GPA = 2 }},
                { new Student() { FirstName = "Susan", LastName = "Dudley", Grade = 10, GPA = 3 }},
                { new Student() { FirstName = "Sam", LastName = "Summers", Grade = 11, GPA = 4 }},
                { new Student() { FirstName = "Richard", LastName = "Forguson", Grade = 9, GPA = 3 }},
                { new Student() { FirstName = "Maribel", LastName = "Perez", Grade = 3, GPA = 1 }},
                { new Student() { FirstName = "Rebel", LastName = "Rouser", Grade = 10, GPA = 4 }}
            };

            List<Student> selectedStudents = Student.StarStudents(students);

            foreach (Student stud in selectedStudents)
            {
                Console.WriteLine(stud.FirstName, stud.LastName, stud.Grade, stud.GPA );
            }
            
            Console.ReadLine();
        }
    }
}
