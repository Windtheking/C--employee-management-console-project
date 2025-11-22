using System;
using System.Globalization;
using GestionEmpleados.services;

namespace GestionEmpleados
{
    public class Empleado : Persona
    {
        public string NumeroDeIdentificacion { get; set; }
        public string Posicion { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string apellido, DateOnly fechaNacimiento, string numeroId, string posicion, decimal salario)
            : base(nombre, apellido, fechaNacimiento)
        {
            NumeroDeIdentificacion = numeroId;
            Posicion = posicion;
            Salario = salario;
        }

        // Constructor con validaciones integradas
        public static Empleado CrearConValidaciones()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║          CREAR NUEVO EMPLEADO                    ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝\n");

            string nombre = ValidacionCompartidaService.ValidarNombre("Nombre: ");
            string apellido = ValidacionCompartidaService.ValidarNombre("Apellido: ");
            DateOnly fecha = ValidacionCompartidaService.ValidarFechaNacimiento(
                "Fecha de nacimiento (yyyy-MM-dd): ", 
                edadMinima: 18, 
                edadMaxima: 70
            );
            string numeroId = ValidacionEmpleadoService.ValidarNumeroIdentificacion("Número de identificación: ");
            string posicion = ValidacionEmpleadoService.ValidarPosicion("Posición");
            decimal salario = ValidacionEmpleadoService.ValidarSalario("Salario: $");

            ValidacionCompartidaService.MostrarExito("Empleado creado exitosamente!");
            
            return new Empleado(nombre, apellido, fecha, numeroId, posicion, salario);
        }

        private decimal CalcularBonificacion() => Salario * 0.10m;

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre} {Apellido}, Edad: {Edad}, Posición: {Posicion}, Salario Total: {Salario + CalcularBonificacion():C}");
        }
    }
}