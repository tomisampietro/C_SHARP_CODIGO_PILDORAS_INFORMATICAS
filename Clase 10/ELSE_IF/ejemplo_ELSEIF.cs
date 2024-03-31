

using System;
namespace elseif
{
    class ejemplo_ELSEIF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("No sos adulto");
            }

            else if (edad < 30)
            {
                Console.WriteLine("Sos joven");
            }
            else if (edad < 60)
            {
                Console.WriteLine("sos adulto");
            }
            else
            {
                Console.WriteLine("Tenes que cuidarte");
            }
        }
    }
}

//Si tengo que usar muchas veces el ELSE IF, se puede evitar usando el SWITCH.