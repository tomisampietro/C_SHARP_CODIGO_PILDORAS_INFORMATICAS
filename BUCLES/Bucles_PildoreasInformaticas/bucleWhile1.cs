//BUCLE WHILE

using System;
namespace BucleWhile
{
    class bucleWhile1
    {
        static string nombreUsuario = "terricola";
        static void Main(string[] args)
        {
            Console.WriteLine($"Bienvenido {nombreUsuario}!\nCual es tu nombre?");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Deseas entrar en el bucle WHILE? ");
            string respuesta = Console.ReadLine();


            while (respuesta != "no")
            {
             Console.WriteLine($"Estas dentro del bucle WHILE, estimado {nombreUsuario}");
             Console.WriteLine($"{nombreUsuario}, quere seguir del bucle, loro?");
             respuesta = Console.ReadLine(); //En este caso desde dentro del bucle, puedo sobreescribir el valor de la varibale respuesta. 
             
            }
        }
    }
}