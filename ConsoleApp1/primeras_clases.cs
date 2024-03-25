using System;
namespace pildoras
{
    class codigo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola");
            Console.WriteLine(7 * 9);

            int edad;
            edad = 23;
            Console.WriteLine("Tenes una edad de" + edad);
            Console.WriteLine($"Tenes una edad de {edad}");

            // Incremeto y decremento:
            edad++;
            Console.WriteLine($"Tenes una edad de {edad}");

            //Ejemplo de parse.

            //1. Pedirle al usuario que ingrese un numero.
            Console.WriteLine("Ingrese un numero");
            // ReadLine() es un metodo que lee lo que el usuario ingresa por consola.
            Console.ReadLine(); // El programa se queda a la espera de que el usuario escriba un valor numerico.
        }
    }
}