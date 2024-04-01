/* Consigna: Elaborar un programa que genere un nnúmero aleatorio entre 1 y 100 y le pida al usuario que lo adivine.
 Ante cada intento, el programa le dirá al usuario si el número a adivinar es mayor o menor que el ingresado.
 */

using System;
namespace BucleWhile
{
    class bucleWhile1
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            int minumero = 101;           //Se puede reemplazar por un DO WHILE.
            int intentos = 0;

            Console.WriteLine("Intorduce un numero entre 0 y 100");

            while (numeroAleatorio != minumero)
            {
                intentos++;
                minumero = int.Parse(Console.ReadLine());

                if (minumero > numeroAleatorio)
                {
                    Console.WriteLine("El numero es mas bajo");
                }
                else if (minumero < numeroAleatorio)
                {
                    Console.WriteLine("El numero es mas alto");
                }
            }
            Console.WriteLine($"Necesitastes {intentos} para resolver el desafio!");
        }
    }
}