﻿using POO;

WorkGroup workGroupA = new WorkGroup();

FullTimeEmploye employe1 = new FullTimeEmploye("Pepe", "Clown", 800);
PartTimeEmploye employe2 = new PartTimeEmploye("Jhon", "Pork", 5, 88);

workGroupA.AddEmploye(employe1);
workGroupA.AddEmploye(employe2);

workGroupA.ListEmployees();