namespace GestionEmpleados.services
{
using System;
using System.Text.RegularExpressions;

namespace GestionEmpleados.Servicios
{
    public static class ValidacionCompartidaService
    {
        public static string ValidarNombre(string prompt)
        {
            string valor;
            do
            {
                Console.Write(prompt);
                valor = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(valor))
                {
                    MostrarError("❌ El nombre no puede estar vacío.");
                    continue;
                }

                if (valor.Length < 2)
                {
                    MostrarError("❌ El nombre debe tener al menos 2 caracteres.");
                    continue;
                }

                if (!Regex.IsMatch(valor, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                {
                    MostrarError("❌ El nombre solo puede contener letras y espacios.");
                    continue;
                }

                break;
            } while (true);

            return CapitalizarPalabras(valor);
        }

        public static DateOnly ValidarFechaNacimiento(string prompt, int edadMinima, int edadMaxima)
        {
            DateOnly fecha;
            
            do
            {
                Console.Write(prompt);
                string entrada = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    MostrarError("❌ La fecha no puede estar vacía.");
                    continue;
                }

                if (!DateOnly.TryParseExact(entrada, "yyyy-MM-dd", null, System.Globalization.DateStyles.None, out fecha))
                {
                    MostrarError("❌ Formato de fecha inválido. Use: yyyy-MM-dd (Ejemplo: 1990-05-15)");
                    continue;
                }

                if (fecha > DateOnly.FromDateTime(DateTime.Today))
                {
                    MostrarError("❌ La fecha de nacimiento no puede ser futura.");
                    continue;
                }

                int edad = DateTime.Today.Year - fecha.Year;
                if (fecha.ToDateTime(TimeOnly.MinValue) > DateTime.Today.AddYears(-edad))
                {
                    edad--;
                }

                if (edad < edadMinima)
                {
                    MostrarError($"❌ La edad debe ser al menos {edadMinima} años.");
                    continue;
                }

                if (edad > edadMaxima)
                {
                    MostrarError($"❌ La edad no puede ser mayor a {edadMaxima} años.");
                    continue;
                }

                break;
            } while (true);

            return fecha;
        }

        private static void MostrarError(string mensaje)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = colorOriginal;
        }

        public static void MostrarExito(string mensaje)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✓ {mensaje}");
            Console.ForegroundColor = colorOriginal;
        }

        private static string CapitalizarPalabras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            var palabras = texto.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", palabras);
        }
    }
}
}