using System;

namespace POO;

public class FullTimeEmploye : Employe
{
    public FullTimeEmploye(string name, string lastName, decimal baseSalary)
        : base(name, lastName, baseSalary) { }

    public override decimal CalculateSalary()
    {
        return BaseSalary * 1.2m;
    }
}
