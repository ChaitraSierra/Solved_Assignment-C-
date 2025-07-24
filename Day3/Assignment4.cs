// Assignment 4: Employee-Department Join and Aggregation
csharpCopyEditusing System;using System.Collections.Generic;using System.Linq;
class Employee{
    public int ID { get; set; }
    public string Name { get; set; }
    public int DepartmentID { get; set; }
    public double Salary { get; set; }
}
class Department{
    public int ID { get; set; }
    public string DeptName { get; set; }
}
class Program{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Alice", DepartmentID = 1, Salary = 75000 },
            new Employee { ID = 2, Name = "Bob", DepartmentID = 2, Salary = 65000 },
            new Employee { ID = 3, Name = "Charlie", DepartmentID = 1, Salary = 85000 },
            new Employee { ID = 4, Name = "Diana", DepartmentID = 3, Salary = 72000 },
            new Employee { ID = 5, Name = "Ethan", DepartmentID = 2, Salary = 60000 },
        };
        var departments = new List<Department>
        {
            new Department { ID = 1, DeptName = "IT" },
            new Department { ID = 2, DeptName = "HR" },
            new Department { ID = 3, DeptName = "Finance" }
        };
        // a) Join employees with department namesvar empDept = from e in employees
                      join d in departments on e.DepartmentID equals d.ID
                      select new { e.Name, d.DeptName };
        Console.WriteLine("Employee - Department:");
        foreach (var ed in empDept)
            Console.WriteLine($"{ed.Name} - {ed.DeptName}");
        // b) Group employees by departmentvar avgByDept = employees
            .GroupBy(e => e.DepartmentID)
            .Select(g => new            {
                DeptID = g.Key,
                Avg = g.Average(e => e.Salary),
                Count = g.Count()
            });
        Console.WriteLine("\nAvg Salary and Count by Department:");
        foreach (var g in avgByDept)
        {
            string deptName = departments.First(d => d.ID == g.DeptID).DeptName;
            Console.WriteLine($"{deptName}: Avg = {g.Avg:F2}, Count = {g.Count}");
        }
        // c) Departments with highest average salaryvar maxAvg = avgByDept.Max(x => x.Avg);
        var topDepts = avgByDept.Where(x => x.Avg == maxAvg);
        Console.WriteLine("\nDepartment(s) with Highest Avg Salary:");
        foreach (var dept in topDepts)
        {
            string deptName = departments.First(d => d.ID == dept.DeptID).DeptName;
            Console.WriteLine($"{deptName} - Avg Salary: {dept.Avg}");
        }
    }
}
