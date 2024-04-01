//DO WHILE:
/*Casi simepre sirve para simplificar codigo. */

using System;
namespace doWhile
{
    class bucles
    {
        static void Main(string[] args)
        {
            int z = 10;

            
            do{                 //Al principio, va el DO.
                Console.WriteLine($"Impresion " + z);
                z++;
            } while (z < 10) ; // La condicion del WHILE se evalua al final del bucle, por lo que se ejecuta al menos una vez.
        }
    }
}