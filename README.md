## Sistema de gestión de empleados (C# y POO).

### Esto es un ejemplo básico en el que se utilizan algunos pilares la programación orientada a objetos (POO) como lo son el encapsulamiento, herencia, polimorfismo y más.
<br>

1- **Encapsulamiento**: se aplica en la clase principal `Employe` al dejar sus propiedades privadas y solamente poder acceder a ellas a través de métodos públicos (o el propio constructor).

2- **Herencia**: `FullTimeEmploye` y `PartTimeEmploye` heredan de la clase principal `Employe`.

3- **Polimorfismo**: `CalculateSalary()` y `ShowInfo()` son métodos en los que cada clase derivada de la principal, hace su propia implementación.

4- **Abstracción**: `CalculateSalary()` es un método abstracto que permite ser usado para diferente tipos de elmpleados (`FullTimeEmploye` y `PartTimeEmploye`) sin preocuparse por los detalles de implementación específicos de cada tipo (Jornada normal y Horas trabajadas).
