using System;

namespace POO;

public abstract class Employe
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public decimal BaseSalary { get; private set; }

    protected Employe(string name, string lastName, decimal baseSalary)
    {
        Name = name;
        LastName = lastName;
        BaseSalary = baseSalary;
    }

    // Método virtual: mostrar información del empleado.
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name} {LastName}, Base Salary: {BaseSalary} USD");
    }

    // Método abstracto: implementar en clases derivadas.
    public abstract decimal CalculateSalary();
}
