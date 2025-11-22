namespace GestionEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa { Nombre = "Gestion de software" };

            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    SISTEMA DE GESTIÓN                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");

            try
            {
                // Crear empleado usando el método estático con validaciones
                Console.WriteLine("\n→ Crear empleado:");
                var empleado = Empleado.CrearConValidaciones();
                empresa.AgregarEmpleado(empleado);

                // Crear cliente usando el método estático con validaciones
                Console.WriteLine("\n→ Crear cliente:");
                var cliente = Cliente.CrearConValidaciones();
                empresa.AgregarCliente(cliente);

                // Mostrar resultados
                Console.WriteLine("\n\n╔══════════════════════════════════════════════════╗");
                Console.WriteLine("║            LISTA DE EMPLEADOS                    ║");
                Console.WriteLine("╚══════════════════════════════════════════════════╝");
                empresa.MostrarTodosLosEmpleados();

                Console.WriteLine("\n╔══════════════════════════════════════════════════╗");
                Console.WriteLine("║            LISTA DE CLIENTES                     ║");
                Console.WriteLine("╚══════════════════════════════════════════════════╝");
                empresa.MostrarTodosLosClientes();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n❌ Error inesperado: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
