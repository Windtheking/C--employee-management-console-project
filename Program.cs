using System;

namespace GestionEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa { Nombre = "Mi Empresa" };

            Console.WriteLine("Crear empleado:");
            var empleado = Administracion.CrearEmpleado();
            empresa.AgregarEmpleado(empleado);

            Console.WriteLine("\nCrear cliente:");
            var cliente = Administracion.CrearCliente();
            empresa.AgregarCliente(cliente);

            Console.WriteLine("\n--- Lista de Empleados ---");
            empresa.MostrarTodosLosEmpleados();

            Console.WriteLine("\n--- Lista de Clientes ---");
            empresa.MostrarTodosLosClientes();
        }
    }
}
