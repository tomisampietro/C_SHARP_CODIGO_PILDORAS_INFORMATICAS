
//Curso C#. Sintaxis básica V. Vídeo 7
using System;
namespace parte3
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int num1 = int.Parse(Console.ReadLine()); //Readline, se queda esperando a que el usuario escriba un algo por pantalla. - Devuelve str.
                                                      //Para convertir el string a int, se utiliza parse.

            Console.WriteLine("Ingrese otro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + (num1 + num2));
        }

    }
}