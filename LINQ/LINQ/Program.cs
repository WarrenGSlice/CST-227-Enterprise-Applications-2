using System;
using System.Collections;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make some test scores
            var scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 90, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            // Print the scores
            foreach (var individualScore in scores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            // Use a LINQ statement to filter the list
            var theBestStudents =
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            // Print only the Best Scores
            foreach (var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            // Use LINQ to sort the Results
            var sortedScores =
                from individualScore in scores
                orderby individualScore
                select individualScore;

            // Print the sorted List
            foreach(var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            // Print a list of only the B Students (80% to 89%) in ascending order
            var sortedBStudents =
                from individualScore in scores
                where individualScore <= 89 && individualScore >= 80
                orderby individualScore
                select individualScore;

            // Print the sorted List
            foreach (var individualScore in sortedBStudents)
            {
                Console.WriteLine("One of the B scores was {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            // Create am arrayList of students
            ArrayList studentList = new ArrayList();
            studentList.Add(new Student("Warren", 22, 90));
            studentList.Add(new Student("Jesse", 22, 87));
            studentList.Add(new Student("Georgia", 3, 83));
            studentList.Add(new Student("Benny", 36, 35));
            studentList.Add(new Student("Mary", 33, 85));
            studentList.Add(new Student("Olivia", 36, 66));

            var sortedStudentObjs =
                from Student student in studentList
                orderby student.grade
                select student;
            Console.Write("This is an Array List of New Students, Sorted by grade in Ascending Order\n");
            foreach (var student in sortedStudentObjs)
            {
                
                Console.WriteLine("One of the New Students {0}", student.ToString());
            }

            Console.ReadLine();
        }
    }
}