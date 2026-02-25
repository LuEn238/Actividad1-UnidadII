using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int cantidad = 0;

        // Solicitar cantidad de personas (validación)
        while (true)
        {
            Console.Write("Ingrese la cantidad de personas a registrar: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out cantidad) && cantidad >= 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("Valor inválido. Debe ingresar un número entero mayor o igual a 1.");
            }
        }

        // Listas para almacenar datos
        List<string> nombres = new List<string>();
        List<int> edades = new List<int>();

        // Captura de datos
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nPersona #{i + 1}");

            // Validar nombre (no vacío)
            string nombre;
            while (true)
            {
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            }

            // Validar edad
            int edad;
            while (true)
            {
                Console.Write("Ingrese la edad: ");
                string entradaEdad = Console.ReadLine();

                if (int.TryParse(entradaEdad, out edad) && edad >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Debe ingresar un número entero válido.");
                }
            }

            nombres.Add(nombre);
            edades.Add(edad);
        }

        Console.WriteLine("\n----------------------------------");

        // Caso especial: solo una persona
        if (cantidad == 1)
        {
            Console.WriteLine("Registro individual:");
            Console.WriteLine($"Nombre: {nombres[0]}");
            Console.WriteLine($"Edad: {edades[0]}");

            if (edades[0] >= 18)
                Console.WriteLine("Es MAYOR de edad.");
            else
                Console.WriteLine("Es MENOR de edad.");
        }
        else
        {
            // Lista general
            Console.WriteLine("\nLista general de personas:");
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine($"{nombres[i]} - {edades[i]} años");
            }

            // Clasificación
            List<string> mayores = new List<string>();
            List<int> edadesMayores = new List<int>();

            List<string> menores = new List<string>();
            List<int> edadesMenores = new List<int>();

            for (int i = 0; i < nombres.Count; i++)
            {
                if (edades[i] >= 18)
                {
                    mayores.Add(nombres[i]);
                    edadesMayores.Add(edades[i]);
                }
                else
                {
                    menores.Add(nombres[i]);
                    edadesMenores.Add(edades[i]);
                }
            }

            // Mostrar mayores
            if (mayores.Count > 0)
            {
                Console.WriteLine("\nPersonas MAYORES de edad:");
                for (int i = 0; i < mayores.Count; i++)
                {
                    Console.WriteLine($"{mayores[i]} - {edadesMayores[i]} años");
                }
            }

            // Mostrar menores
            if (menores.Count > 0)
            {
                Console.WriteLine("\nPersonas MENORES de edad:");
                for (int i = 0; i < menores.Count; i++)
                {
                    Console.WriteLine($"{menores[i]} - {edadesMenores[i]} años");
                }
            }
        }

        Console.WriteLine("\nPrograma finalizado.");
        Console.ReadKey();
    }
}


