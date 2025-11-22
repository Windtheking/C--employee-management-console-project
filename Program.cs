using System;
using SoftwareEmployeeManagement.models;

internal class Program
    {
        static void Main(string[] args)
        {
            /* *
            * Instance of the company with the seeders data, 
            * mainly used to set the information needed
            * to keep the "database" (lists) seeded with initial data
            *
            * To connect the seeders file with the program file we need to
            * create a variable to contain the seeders method that states the
            * values needed 
            */
            var company = Seeders.SeedCompany();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("============= MENÚ PRINCIPAL ==================");
                Console.WriteLine($"Welcome to the employee managament system of {company.Name} located in {company.Address}");
                Console.WriteLine("Please choose your option");
                Console.WriteLine("1. Mostrar todos los usuarios");
                Console.WriteLine("2. Agregar usuario");
                Console.WriteLine("3. Eliminar usuario");
                Console.WriteLine("4. Actualizar usuario");
                Console.WriteLine("5. Buscar usuario por ID");
                Console.WriteLine("6. Mostrar clientes");
                Console.WriteLine("7. Añadir cliente");
                Console.WriteLine("8. Borrar cliente");
                Console.WriteLine("9. Cerrar programa");
                Console.Write("Seleccione una opción: ");

                //Data try convertion 
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        // Mostrar todos los usuarios (employees + clients)
                        Console.WriteLine("--- Employees ---");
                        foreach (var e in company.EmployeesList)
                        {
                            e.ShowInformation();
                            Console.WriteLine();
                        }
                        Console.WriteLine("--- Clients ---");
                        foreach (var c in company.ClientsList)
                        {
                            c.ShowInformation();
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        // Agregar usuario
                        break;
                    case 3:
                        Console.Clear();
                        // Eliminar usuario
                        break;
                    case 4:
                        Console.Clear();
                        // Actualizar usuario
                        break;
                    case 5:
                        Console.Clear();
                        // Buscar usuario por ID
                        break;
                    case 6:
                        Console.Clear();
                        // Mostrar clientes
                        Console.WriteLine("--- Clients ---");
                        foreach (var client in company.ClientsList)
                        {
                            client.ShowInformation();
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        // Añadir cliente
                        break;
                    case 8:
                        Console.Clear();
                        // Borrar cliente
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Closing program...🧐");
                        break;
                    default:
                        Console.WriteLine("Not a valid option. Press anything to continue...");
                        Console.ReadKey();
                        break;
                }

                // Si no se ha elegido cerrar, espera antes de mostrar el menú de nuevo
                if (opcion != 9)
                {
                    Console.WriteLine("Press anything to continue...");
                    Console.ReadKey();
                }
            } while (opcion != 9);
            
        }
    }