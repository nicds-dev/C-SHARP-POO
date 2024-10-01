using System;

namespace POO;

public class PartTimeEmploye : Employe
{
    public int WorkedHours { get; private set; }

    public PartTimeEmploye(string name, string lastName, decimal baseSalary, int workedHours)
        : base(name, lastName, baseSalary)
        {
            WorkedHours = workedHours;
        }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Worked Hours: {WorkedHours}");
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary * WorkedHours;
    }
}
