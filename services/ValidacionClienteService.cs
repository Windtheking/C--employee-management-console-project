namespace GestionEmpleados.services
{
using System;
using System.Text.RegularExpressions;

namespace GestionEmpleados.Servicios
    {
        public static class ValidacionClienteService
        {
            public static string ValidarEmail(string prompt)
            {
                string email;
                string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                do
                {
                    Console.Write(prompt);
                    email = Console.ReadLine()?.Trim().ToLower();

                    if (string.IsNullOrWhiteSpace(email))
                    {
                        MostrarError("❌ El email no puede estar vacío.");
                        continue;
                    }

                    if (!Regex.IsMatch(email, patronEmail))
                    {
                        MostrarError("❌ Formato de email inválido. Ejemplo: usuario@dominio.com");
                        continue;
                    }

                    break;
                } while (true);

                return email;
            }

            public static string ValidarTelefono(string prompt)
            {
                string telefono;
                string patronTelefono = @"^[\+]?[(]?[0-9]{1,4}[)]?[-\s\.]?[(]?[0-9]{1,4}[)]?[-\s\.]?[0-9]{1,4}[-\s\.]?[0-9]{1,9}$";

                do
                {
                    Console.Write(prompt);
                    telefono = Console.ReadLine()?.Trim();

                    if (string.IsNullOrWhiteSpace(telefono))
                    {
                        MostrarError("❌ El teléfono no puede estar vacío.");
                        continue;
                    }

                    string telefonoLimpio = Regex.Replace(telefono, @"[\s\-\(\)\.]", "");
                    
                    if (telefonoLimpio.Length < 7)
                    {
                        MostrarError("❌ El teléfono debe tener al menos 7 dígitos.");
                        continue;
                    }

                    if (!Regex.IsMatch(telefono, patronTelefono))
                    {
                        MostrarError("❌ Formato de teléfono inválido. Ejemplos: +57 300 123 4567, 3001234567");
                        continue;
                    }

                    break;
                } while (true);

                return telefono;
            }

            private static void MostrarError(string mensaje)
            {
                ConsoleColor colorOriginal = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensaje);
                Console.ForegroundColor = colorOriginal;
            }
        }
    }
}