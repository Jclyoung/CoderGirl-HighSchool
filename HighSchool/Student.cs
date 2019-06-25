using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _grade;
        private double _gpa;

        public int Grade
        {
            get { return _grade; }

            set
            {
                if ((value < 1) || (value >= 13))
                {
                    _grade = 0;
                }
                else
                    _grade = value;
            }

        }
        public double GPA
        {
            get { return _gpa; }

            set
            {
                if ((value < 1) || (value > 4))
                {
                    _gpa = 0;
                }
                else
                    _gpa = value;
            }
        }
                     
        public static List<Student> StarStudents(List<Student> students)
        {

            List<Student> student = students;
            var sortedStudents =
                from stud in students
                where stud.GPA >= 3 && stud.Grade > 8 && stud.Grade < 13
                orderby stud.Grade descending, stud.GPA descending, stud.LastName ascending, stud.FirstName ascending
                           
                select stud;
            List<Student> selectedStudents = sortedStudents.ToList();

            return selectedStudents;


            // Then, use LINQ to print a list of students with a GPA of 3 or higher that are in the 9th - 12th grade. 
            // The list should output their first name, last name, grade and GPA. It should be sorted by highest grade, 
            // then highest GPA, then last name, then first name.

        }
    }
}
