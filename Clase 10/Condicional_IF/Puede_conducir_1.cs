//EJEMPLO DE CONDICIONAL IF: VER SI PODES MANEJAR O NO. 

using System;
namespace condicionales
{
    class Puede_conducir_1
    {
        static void Main(string[] args)
        {
            bool haceFrio; // Declaración de variable booleana
            haceFrio = false; // Asignación de valor a la variable

            Console.WriteLine(haceFrio);
            //Invertir la expresion booleana
            Console.WriteLine(!haceFrio);

            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = Int32.Parse(Console.ReadLine()); //ReadLine, por defecto devuelve un str. Hay que CASTEARLO.

            //ESPACIO DE INICIALIZACION DE VARIBALES:
            string carnet = "no" ; //Inicializo la variable CARNET, y le ASIGNO un valor por defecto.
            int tomo_alcohol = 0;

            if (edad >= 18)
            {
                Console.WriteLine("Sos mayor de edad, veamos si podes manejar...");
                //Ver si tiene carnet de conducir
                Console.WriteLine("Tenes carnet de conducir, vigente?");
                Console.WriteLine("MENU DE OPCIONES:\n   - si\n   - no");
                carnet = Console.ReadLine();


                if (carnet == "si") //Si tiene, entonces preguntar si tomo alcohol.
                {
                    //Ver si tomo alcohol: 
                    Console.WriteLine("Ha tomado alcohol?");
                    Console.WriteLine("1 ------>Si\n0 -----> No");
                    tomo_alcohol = Int32.Parse(Console.ReadLine());
                } //Tengo que cerrar el bloque if con {}, para poder iniciar el bloque ELSE.
                else
                {
                    Console.WriteLine("No tenes carne de conducir, maestro! \nNo va a poder maneja");
                }
            }
            else
            {
                Console.WriteLine("Sos menor de edad");
            }

            if (tomo_alcohol == 0 && edad >= 18 && carnet == "si") //Si NO tomo alcohol y es mayor de edad, puede manejar.
            {
                Console.WriteLine("Podes manejar!");
            }
            else
            {
                Console.WriteLine("No te hagas el loco, no podes manejar!");
            }
        }
    }
}
