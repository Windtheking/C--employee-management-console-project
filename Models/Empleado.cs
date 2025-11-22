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

        private decimal CalcularBonificacion() => Salario * 0.10m;

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre} {Apellido}, Edad: {Edad}, Posición: {Posicion}, Salario Total: {Salario + CalcularBonificacion():C}");
        }
    }
}