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

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Cliente: {Nombre} {Apellido}, Edad: {Edad}, Email: {Email}, Teléfono: {Telefono}");
        }
    }
}