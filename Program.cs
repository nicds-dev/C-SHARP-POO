using POO;

WorkGroup workGroupA = new();

FullTimeEmploye employe1 = new("Pepe", "Clown", 800);
PartTimeEmploye employe2 = new("Jhon", "Pork", 5, 88);

workGroupA.AddEmploye(employe1);
workGroupA.AddEmploye(employe2);

workGroupA.ListEmployees();