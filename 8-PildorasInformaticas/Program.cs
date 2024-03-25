//CONSTANTES. VIDEO 8
//https://www.youtube.com/watch?v=j8SYB_77fmE&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=8&ab_channel=pildorasinformaticas

using System;
namespace clase8
{
    class clase8
    {
        static void Main(string[] args)
        {
            const int VALOR = 5; //Por convencion el nombre de las contantes va en mayusculas.

            const int VALOR2 = 7;

            Console.WriteLine(VALOR + VALOR2);

            Console.WriteLine("El valor de la constante 1 es: {1}", VALOR, VALOR2); //Como segundo parametro de WriteLine, paso un valor. O corresponde al primer elemnto (del segundo parametro.

            //Armar un programa que calcule el area de un circulo.

            //Pedir al usuario que ingrese el radio del circulo.
            Console.WriteLine("Ingrese el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());
            const double pi = 3.1416; //Se usa una constante, porque PI no cambia nunca.

            Console.WriteLine("Si el circulo tiene un radio de: " + radio + " entonces, su area es de: " + pi * radio * radio);

            //Otra forma de hacerlo.
            double area = pi * radio * radio;
            Console.WriteLine($"El area del circulo es de {area}, porque su radio es de {radio}");
        }
    
     }
}