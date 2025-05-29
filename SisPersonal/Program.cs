// See https://aka.ms/new-console-template for more information
using System;
using EspacioEmpleados;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado()
{
    Nombre = "Nicolas",
    Apellido = "Moreno",
    FechaNacimiento1 = new DateTime(2002, 9, 29),
    estadoCivil = 'S',
    FechaIngreso = new DateTime(2020, 6, 14),
    SueldoBasico = 700000,
    cargo = Cargos.Especialista
};

empleados[1] = new Empleado()
{
    Nombre = "Oscar",
    Apellido = "Moreno",
    FechaNacimiento1 = new DateTime(1986, 2, 1),
    estadoCivil = 'C',
    FechaIngreso = new DateTime(2004, 5, 19),
    SueldoBasico = 1200000,
    cargo = Cargos.Ingeniero
};

empleados[2] = new Empleado()
{
    Nombre = "Maria",
    Apellido = "Barrionuevo",
    FechaNacimiento1 = new DateTime(1990, 1, 21),
    estadoCivil = 'S',
    FechaIngreso = new DateTime(2014, 9, 2),
    SueldoBasico = 800000,
    cargo = Cargos.Administrativo
};


Empleado proximojubilarse = empleados[0];
double totalSalario = 0;
foreach (var emp in empleados)
{
    double salarios = emp.salario();
    totalSalario += salarios;

    if (emp.jubilarse() < proximojubilarse.jubilarse())
    {
        proximojubilarse = emp;
    }

}

Console.WriteLine("Total pagado en salarios: " + totalSalario);

Console.WriteLine("Empleado más próximo a jubilarse:");
Console.WriteLine($"Nombre: {proximojubilarse.Nombre} {proximojubilarse.Apellido}");
Console.WriteLine($"Edad: {proximojubilarse.Edad()} años");
Console.WriteLine($"Antigüedad: {proximojubilarse.CalcularAntiguedad()} años");
Console.WriteLine($"Años hasta jubilarse: {proximojubilarse.jubilarse()}");
Console.WriteLine($"Salario: ${proximojubilarse.salario():N2}");