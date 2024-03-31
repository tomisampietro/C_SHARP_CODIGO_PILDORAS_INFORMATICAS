//SWITCH --> Solo permite comparar int, str, char
/*
 Programa de ejemplo:
Elegir un medio de transporte para un viaje.
 */

using System;
namespace ejemplo_switch
{
    class ejemploSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige un medio de transporte (auto, tren, avion)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte) //quiero comparar lo que dentro de la variable medioTransporte, con las opciones CASE del SWITCH para ver cual debe ejecutar. 
            {
                case "auto":
                    Console.WriteLine("Velocidad media: 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media: 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media: 800 km/h");
                    break;

                default: //No es obligatorio poner el DEFAULT, pero es una buena practica para que el programa no se quede trabado dentro del SWITCH.
                    Console.WriteLine("Bueno.. anda caminando!!!");
                    break;
            }
         }
    }
 }