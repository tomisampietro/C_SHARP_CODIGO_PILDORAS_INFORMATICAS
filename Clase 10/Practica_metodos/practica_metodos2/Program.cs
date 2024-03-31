//SOBRECARGA DE METODOS.
using System;
namespace metodos
{
    class Program
    {
        //Definir variables de ambito de clase:
        int numero1 = 21;
        int numero2 = 10;
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(2,3,5));
        }

        static int Suma(int operador1, int operador2) 
        {
        return operador1 + operador2;
        }
        //Para poder hacer la sobrecarga, uno de los metodos, debe recibir por parametros valores de distinto tipo. O agregar parametros
        static int Suma(int operador1, int operador2, int operador3)
        {
            return operador1 + operador2 + operador3;
        }
    }
}