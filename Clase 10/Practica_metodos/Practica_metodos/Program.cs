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
            mensajeEnPantalla(); /*Llamo al metodo mensajeEnPantalla.*/

            Console.WriteLine("Luego de ejecutar todas las lineas del metodo mensajeEnPantalla, se ejcutara esta, del metodo Main.");
            sumaNumeros(7, 9);

            //Llamo al metodo RETURN.
            Console.WriteLine(restaNumeros(7, 9));

            //Llamo al metodo que muestra una varibale de clase:
            metodoUno();

        }
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje en screen.");

        }
        static void sumaNumeros(int num1, int num2) //El metodo Void, no devuelve ningun dato, seguramente SOLO lo escriba por consola.
        {
            float suma = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
        }

        static int restaNumeros(int num1, int num2)
        {
            return num1 - num2; //A este punto, solo devuelve el valor. Tenemos que decirle que hacer con esto. 

            //con el return, se termina el metodo. Luego del return, aunque haya lineas de codigo, no se va a ejecutar nunca.
            //Console.WriteLine("You will never see this part of the code.");
        }

        void metodoUno()
        {
            Console.WriteLine("Se imprime una variable de ámbito de clase: " + numero1);
        }

        void metodoDos()
        {
            Console.WriteLine("Se imprime una variable de ámbito de clase: " + numero2);
        }
    }
}