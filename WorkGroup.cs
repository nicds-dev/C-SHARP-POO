using System;

namespace POO;

public class WorkGroup
{
    private List<Employe> employes;

    public WorkGroup()
    {
        employes = new List<Employe>();
    }

    public void AddEmploye(Employe employe)
    {
        employes.Add(employe);
        Console.WriteLine($"Employe {employe.GetType().Name} added to the group.");
    }

    public void ListEmployes()
    {
        Console.WriteLine();
        Console.WriteLine("Group Employes:");
        foreach (var employe in employes)
        {
            employe.ShowInfo();
            Console.WriteLine($"Calculated Salary: {employe.CalculateSalary()} USD");
            Console.WriteLine();
        }
    }
}
