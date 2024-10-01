using System;

namespace POO;

public class WorkGroup
{
    private List<Employe> employees;

    public WorkGroup()
    {
        employees = new List<Employe>();
    }

    public void AddEmploye(Employe employe)
    {
        employees.Add(employe);
        Console.WriteLine($"Employe {employe.GetType().Name} added to the group.");
    }

    public void ListEmployees()
    {
        Console.WriteLine();
        Console.WriteLine("Group Employees:");
        foreach (var employe in employees)
        {
            employe.ShowInfo();
            Console.WriteLine($"Calculated Salary: {employe.CalculateSalary()} USD");
            Console.WriteLine();
        }
    }
}
