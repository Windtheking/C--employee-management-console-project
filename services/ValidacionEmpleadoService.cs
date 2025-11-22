
using System;
using System.Text.RegularExpressions;

namespace GestionEmpleados.Servicios
{
    public static class ValidacionEmpleadoService
    {
        public static string ValidarNumeroIdentificacion(string prompt)
        {
            string? numeroId;
            do
            {
                Console.Write(prompt);
                numeroId = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(numeroId))
                {
                    MostrarError("El número de identificación no puede estar vacío.");
                    continue;
                }

                if (numeroId.Length < 5)
                {
                    MostrarError("El número de identificación debe tener al menos 5 caracteres.");
                    continue;
                }

                if (!Regex.IsMatch(numeroId, @"^[0-9]+$"))
                {
                    MostrarError("El número de identificación solo puede contener dígitos.");
                    continue;
                }

                break;
            } while (true);

            return numeroId;
        }

        public static string ValidarPosicion(string prompt)
        {
            string[] posicionesValidas = 
            { 
                "Gerente", 
                "Supervisor", 
                "Desarrollador", 
                "Analista", 
                "Contador",
                "Asistente",
                "Coordinador",
                "Director"
            };

            string? posicion;
            do
            {
                Console.WriteLine(prompt);
                Console.WriteLine("Posiciones válidas: " + string.Join(", ", posicionesValidas));
                Console.Write("Seleccione: ");
                posicion = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(posicion))
                {
                    MostrarError("La posición no puede estar vacía.");
                    continue;
                }

                bool encontrada = false;
                foreach (var pos in posicionesValidas)
                {
                    if (pos.Equals(posicion, StringComparison.OrdinalIgnoreCase))
                    {
                        posicion = pos;
                        encontrada = true;
                        break;
                    }
                }

                if (!encontrada)
                {
                    MostrarError("Posición no válida. Seleccione una de la lista.");
                    continue;
                }

                break;
            } while (true);

            return posicion;
        }

        public static decimal ValidarSalario(string prompt)
        {
            decimal salario;
            decimal minimo = 1000000;
            decimal maximo = 50000000;
            string? entrada;

            do
            {
                Console.Write(prompt);
                entrada = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    MostrarError("El salario no puede estar vacío.");
                    continue;
                }

                if (!decimal.TryParse(entrada, out salario))
                {
                    MostrarError("Debe ingresar un número válido.");
                    continue;
                }

                if (salario < minimo)
                {
                    MostrarError($"El salario no puede ser menor a {minimo:C}");
                    continue;
                }

                if (salario > maximo)
                {
                    MostrarError($"El salario no puede ser mayor a {maximo:C}");
                    continue;
                }

                break;
            } while (true);

            return salario;
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
