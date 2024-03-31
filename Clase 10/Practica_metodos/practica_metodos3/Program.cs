//PAMETROS OPCIONALES  
using System;
namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 2.21;
            double valor3 = 3.4;

            Console.WriteLine(valor1 + valor2 + valor3);
        }

        // a num=3, como parametro opcional, le tengo que pasar un valor por defecto.
        static double Suma(int num1, double num2, double num3 = 0) 
        {
            return num1 * num2 + num3;
        }

    }
}