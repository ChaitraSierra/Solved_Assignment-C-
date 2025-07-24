// Assignment 1: Classes & Objects – Student Management System
csharpCopyEditusing System;
class Student{
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
    public Student(string name, int rollNumber, string course, int marks)
    {
        Name = name;
        RollNumber = rollNumber;
        Course = course;
        Marks = marks;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNumber}, Course: {Course}, Marks: {Marks}/100");
    }
}
csharpCopyEdit
  // Main method class Program{
    static void Main(string[] args)
    {
        Student s1 = new Student("Alice", 101, "Math", 88);
        Student s2 = new Student("Bob", 102, "Science", 92);
        Student s3 = new Student("Charlie", 103, "History", 79);
        s1.DisplayDetails();
        s2.DisplayDetails();
        s3.DisplayDetails();
    }
}
