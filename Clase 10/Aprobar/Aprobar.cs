/*SE APRUEBA SOLO EN EL CASO DE TENER LOS 3 PARCIALES APROBADOS. En dicno caso, se hace un promedio entre las notas
 Si alguno de los parciales es menor que 4, entonces, debes recuperar ese parcial.
Si dos o mas parciales estan desaprobados, se recursa
  */

using System;
using System.Threading.Channels;
namespace parciales
{
    class condicionales
    {
        static void Main(string[] args)
        {
            //INICIALIZACION DE VARIABLES:
            int cant_parciales_desaprobados = 0;

            //Preguntar cual fue las notas de los estudiantes:
            Console.WriteLine("Cual fue la nota de tu parcial numero 1 ?");
            float nota_parcial_1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Cual fue la nota de tu parcial numero 2 ?");
            float nota_parcial_2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Cual fue la nota de tu parcial numero 3 ?");
            float nota_parcial_3 = Int32.Parse(Console.ReadLine());

            //Contador de parciales desaprobados:
            if (nota_parcial_1 < 4)
            {
                cant_parciales_desaprobados = cant_parciales_desaprobados + 1;
            }

            if (nota_parcial_2 < 4)
            {
                cant_parciales_desaprobados = cant_parciales_desaprobados + 1;
            }

            if (nota_parcial_3 < 4)
            {
                cant_parciales_desaprobados = cant_parciales_desaprobados + 1;
            }

            Console.WriteLine("Tenes " + cant_parciales_desaprobados + " parciales desaprobados.");

            
            //Determinar si aprobo o no:
            if (cant_parciales_desaprobados == 1)
            {
                Console.WriteLine("Vas a tener que recuperar un parcial!");
            }

            if (nota_parcial_3 >= 4 || nota_parcial_2 >= 4 || nota_parcial_1 >= 4)
            {
                float nota_promedio = ((nota_parcial_1 + nota_parcial_2 + nota_parcial_3) / 3);
                Console.WriteLine("Felicidades aprobaste la materia con una nota promedio de: " + nota_promedio);
            }

            else
            {
                Console.WriteLine("Lo siento soldado, deberas recursar la materia...");
            }
        }
    }
}