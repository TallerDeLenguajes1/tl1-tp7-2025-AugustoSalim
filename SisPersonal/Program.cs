using System;
using EmpresaPersonal; // Importa la clase Empleado con su enum

class Program
{
    static void Main()
    {
        // Crear arreglo de empleados
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1985, 6, 10), 'C', new DateTime(2010, 3, 1), 650000, Empleado.Cargos.Ingeniero);
        empleados[1] = new Empleado("María", "Gómez", new DateTime(1990, 8, 20), 'S', new DateTime(2015, 4, 15), 500000, Empleado.Cargos.Administrativo);
        empleados[2] = new Empleado("Pedro", "López", new DateTime(1960, 12, 5), 'C', new DateTime(1995, 2, 20), 700000, Empleado.Cargos.Especialista);

        // Mostrar datos de cada empleado
        foreach (Empleado e in empleados)
        {
            e.MostrarDatos();
        }

        // Calcular monto total de salarios
        double total = 0;
        foreach (Empleado e in empleados)
        {
            total += e.CalcularSalario();
        }

        Console.WriteLine($"Monto total en sueldos: ${total:N2}");
        Console.WriteLine();

        // Mostrar empleado más próximo a jubilarse
        Empleado proximoJubilado = empleados[0];
        foreach (Empleado e in empleados)
        {
            if (e.AniosParaJubilarse() < proximoJubilado.AniosParaJubilarse())
            {
                proximoJubilado = e;
            }
        }

        Console.WriteLine("Empleado más próximo a jubilarse:");
        proximoJubilado.MostrarDatos();
    }
}
