// Assignment 1: Student Grades – Arrays, Lists & LINQ
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradesApp
{
    // 1️⃣ Student class with Name, RollNumber, and Marks
    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public int[] Marks { get; set; }  // Array of 5 subject marks
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2️⃣ Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", RollNumber = 101, Marks = new int[] { 85, 90, 78, 88, 92 } },
                new Student { Name = "Bob", RollNumber = 102, Marks = new int[] { 70, 65, 72, 60, 68 } },
                new Student { Name = "Charlie", RollNumber = 103, Marks = new int[] { 90, 95, 93, 89, 97 } },
                new Student { Name = "David", RollNumber = 104, Marks = new int[] { 55, 60, 58, 62, 57 } },
                new Student { Name = "Eva", RollNumber = 105, Marks = new int[] { 80, 82, 85, 84, 79 } }
            };

            Console.WriteLine("🎓 Student Report:");
            Console.WriteLine("---------------------------");

            // 3️⃣ Calculate total and average for each student
            foreach (var student in students)
            {
                int total = student.Marks.Sum();
                double average = student.Marks.Average();

                Console.WriteLine($"Name: {student.Name}, Roll No: {student.RollNumber}");
                Console.WriteLine($"Total Marks: {total}, Average: {average:F2}\n");
            }

            // 4️⃣ Highest and lowest scoring students (by total marks)
            var highestScoring = students.OrderByDescending(s => s.Marks.Sum()).First();
            var lowestScoring = students.OrderBy(s => s.Marks.Sum()).First();

            Console.WriteLine("🏆 Highest Scoring Student:");
            Console.WriteLine($"Name: {highestScoring.Name}, Roll No: {highestScoring.RollNumber}, Total: {highestScoring.Marks.Sum()}\n");

            Console.WriteLine("⚠️ Lowest Scoring Student:");
            Console.WriteLine($"Name: {lowestScoring.Name}, Roll No: {lowestScoring.RollNumber}, Total: {lowestScoring.Marks.Sum()}");
        }
    }
}
