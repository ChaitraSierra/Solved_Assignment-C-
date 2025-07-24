// Assignment 2: Inheritance – Employee Hierarchy
csharpCopyEditusing System;
class Employee{
    public int EmpID { get; set; }
    public string Name { get; set; }
    public double BasicSalary { get; set; }
    public Employee(int empID, string name, double basicSalary)
    {
        EmpID = empID;
        Name = name;
        BasicSalary = basicSalary;
    }
    public virtual void Display()
    {
        Console.WriteLine($"ID: {EmpID}, Name: {Name}, Salary: {BasicSalary}");
    }
}
class Manager : Employee{
    public double Bonus { get; set; }
    public Manager(int empID, string name, double basicSalary, double bonus)
        : base(empID, name, basicSalary)
    {
        Bonus = bonus;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Bonus: {Bonus}");
    }
}
class Developer : Employee{
    public string ProjectName { get; set; }
    public Developer(int empID, string name, double basicSalary, string projectName)
        : base(empID, name, basicSalary)
    {
        ProjectName = projectName;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Project: {ProjectName}");
    }
}
csharpCopyEdit// Main method class Program{
    static void Main(string[] args)
    {
        Manager m = new Manager(1, "Diana", 80000, 10000);
        Developer d = new Developer(2, "Ethan", 60000, "AI Module");
        m.Display();
        d.Display();
    }
}
