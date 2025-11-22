namespace GestionEmpleados
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();
        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

        public void AgregarEmpleado(Empleado empleado) => ListaEmpleados.Add(empleado);
        public void AgregarCliente(Cliente cliente) => ListaClientes.Add(cliente);

        public void MostrarTodosLosEmpleados()
        {
            foreach (var e in ListaEmpleados) e.MostrarInformacion();
        }

        public void MostrarTodosLosClientes()
        {
            foreach (var c in ListaClientes) c.MostrarInformacion();
        }
    }
}