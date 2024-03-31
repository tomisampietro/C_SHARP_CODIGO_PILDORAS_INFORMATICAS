//EJEMPLO DE CONDICIONAL IF: VER SI PODES MANEJAR O NO. 
//ALTERNATIVA

using System;
namespace condicionales
{
    class Puedes_conducir_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad <18)
            {
                Console.WriteLine("No podes manejar!");

            }
            else
            {
                Console.WriteLine("Tenes carnet de conducir?");
                string carnet = Console.ReadLine();

                int compara = String.Compare(carnet, "si", true); //Valor positivo --> 0
                //Console.WriteLine("si pongo que si, el valor que devuelve es:" + compara);
                if (compara == 1) 
                {
                    Console.WriteLine("No podes manejar!");
                }
                else {
                    Console.WriteLine("Podes manejar!");
                }
            }
        }
    }
}