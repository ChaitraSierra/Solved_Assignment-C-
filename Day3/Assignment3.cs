csharpCopyEditusing System;using System.Collections.Generic;using System.Linq;
class Student{
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public Dictionary<string, int> Marks { get; set; }
}
class Program{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", RollNumber = 1, Marks = new Dictionary<string, int> { { "Math", 90 }, { "Science", 88 }, { "English", 91 } } },
            new Student { Name = "Bob", RollNumber = 2, Marks = new Dictionary<string, int> { { "Math", 70 }, { "Science", 68 }, { "English", 75 } } },
            new Student { Name = "Charlie", RollNumber = 3, Marks = new Dictionary<string, int> { { "Math", 95 }, { "Science", 97 }, { "English", 93 } } },
            new Student { Name = "Diana", RollNumber = 4, Marks = new Dictionary<string, int> { { "Math", 85 }, { "Science", 89 }, { "English", 84 } } },
            new Student { Name = "Ethan", RollNumber = 5, Marks = new Dictionary<string, int> { { "Math", 88 }, { "Science", 86 }, { "English", 89 } } },
        };

        // a) Students scoring above 85 in all subjectsvar topAllSubjects = students
            .Where(s => s.Marks.All(m => m.Value > 85))
            .Select(s => s.Name);

        Console.WriteLine("Students with >85 in all subjects: " + string.Join(", ", topAllSubjects));

        // b) Average marks per subjectvar subjectAverages = students
            .SelectMany(s => s.Marks)
            .GroupBy(m => m.Key)
            .Select(g => new { Subject = g.Key, Avg = g.Average(x => x.Value) });

        Console.WriteLine("\nAverage Marks Per Subject:");
        foreach (var avg in subjectAverages)
            Console.WriteLine($"{avg.Subject}: {avg.Avg:F2}");

        // c) Top scorer per subjectvar topScorers = students
            .SelectMany(s => s.Marks.Select(m => new { Student = s.Name, Subject = m.Key, Score = m.Value }))
            .GroupBy(x => x.Subject)
            .Select(g => g.OrderByDescending(x => x.Score).First());

        Console.WriteLine("\nTop Scorers Per Subject:");
        foreach (var top in topScorers)
            Console.WriteLine($"{top.Subject}: {top.Student} ({top.Score})");
    }
}
