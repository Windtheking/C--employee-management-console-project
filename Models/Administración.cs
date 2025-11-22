using System;

namespace GestionEmpleados
{
    public static class Administracion
    {
        public static Empleado CrearEmpleado()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: "); 
            string apellido = Console.ReadLine();
            Console.Write("Fecha nacimiento (yyyy-MM-dd): "); 
            DateOnly fecha = DateOnly.Parse(Console.ReadLine());
            Console.Write("Número ID: "); 
            string numeroId = Console.ReadLine();
            Console.Write("Posición: ");
            string posicion = Console.ReadLine();
            Console.Write("Salario: "); 
            decimal salario = decimal.Parse(Console.ReadLine());
            return new Empleado(nombre, apellido, fecha, numeroId, posicion, salario);
        }

        public static Cliente CrearCliente()
        {
            Console.Write("Nombre: "); 
            string nombre = Console.ReadLine();
            Console.Write("Apellido: "); 
            string apellido = Console.ReadLine();
            Console.Write("Fecha nacimiento (yyyy-MM-dd): "); 
            DateOnly fecha = DateOnly.Parse(Console.ReadLine());
            Console.Write("Email: "); 
            string email = Console.ReadLine();
            Console.Write("Teléfono: "); 
            string telefono = Console.ReadLine();
            return new Cliente(nombre, apellido, fecha, email, telefono);
        }
    }
}