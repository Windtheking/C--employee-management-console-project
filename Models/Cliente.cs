using System;
using GestionEmpleados.services;

namespace GestionEmpleados
{
    public class Cliente : Persona
    {
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string apellido, DateOnly fechaNacimiento, string email, string telefono)
            : base(nombre, apellido, fechaNacimiento)
        {
            Email = email;
            Telefono = telefono;
        }

        // Constructor con validaciones integradas
        public static Cliente CrearConValidaciones()
        {
            Console.WriteLine("\n╔══════════════════════════════════════════════════╗");
            Console.WriteLine("║          CREAR NUEVO CLIENTE                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════════╝\n");

            string nombre = ValidacionCompartidaService.ValidarNombre("Nombre: ");
            string apellido = ValidacionCompartidaService.ValidarNombre("Apellido: ");
            DateOnly fecha = ValidacionCompartidaService.ValidarFechaNacimiento(
                "Fecha de nacimiento (yyyy-MM-dd): ", 
                edadMinima: 18, 
                edadMaxima: 120
            );
            string email = ValidacionClienteService.ValidarEmail("Email: ");
            string telefono = ValidacionClienteService.ValidarTelefono("Teléfono: ");

            ValidacionCompartidaService.MostrarExito("Cliente creado exitosamente!");
            
            return new Cliente(nombre, apellido, fecha, email, telefono);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Cliente: {Nombre} {Apellido}, Edad: {Edad}, Email: {Email}, Teléfono: {Telefono}");
        }
    }
}