namespace GestionEmpleados;
public abstract class Persona
    {
        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected DateOnly FechaNacimiento { get; set; }

        protected int Edad => DateTime.Today.Year - FechaNacimiento.Year;

        public Persona(string nombre, string apellido, DateOnly fechaNacimiento)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public abstract void MostrarInformacion();
    }
