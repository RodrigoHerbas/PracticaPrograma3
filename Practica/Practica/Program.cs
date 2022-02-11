using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de nombres desea registrar");
            int cant = int.Parse(Console.ReadLine());
            string[] vectorNombre = new string[cant];
            int[] vectorEdad = new int[cant];
            for (int i = 0; i < vectorNombre.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                int edad = int.Parse(Console.ReadLine());
                vectorNombre[i] = nombre;
                vectorEdad[i] = edad;
                
            }
            Console.WriteLine("   " + "Nombre" + "   " + "Edad");
            for (int i = 0; i < vectorNombre.Length; i++)
            {
                Console.WriteLine(i + "   " + vectorNombre[i] + "   " + vectorEdad[i]);
            }

            //Menor
            int max = vectorEdad[0], min = vectorEdad[0];
            for (int i = 0; i < vectorEdad.Length; i++)
            {
                if (vectorEdad[i] != min)
                {
                    if (vectorEdad[i] < min)
                    {
                        Console.WriteLine("Nombre de menor edad: " + vectorNombre[i] + " edad " + vectorEdad[i]);
                    }
                }
            }

            //Ordenamiento
            for (int f = 0; f < vectorNombre.Length; f++)
            {
                for (int g = f + 1; g < vectorNombre.Length; g++)
                {
                    int aux;
                    string auxNombre;
                    if (vectorEdad[f] > vectorEdad[g])
                    {
                        aux = vectorEdad[f];
                        vectorEdad[f] = vectorEdad[g];
                        vectorEdad[g] = aux;

                        auxNombre = vectorNombre[f];
                        vectorNombre[f] = vectorNombre[g];
                        vectorNombre[g] = auxNombre;
                    }
                }
            }
            Console.WriteLine("Ordenado a menor edad");
            Console.WriteLine("    " + "Nombre" + "    " + "Edad");
            for (int i = 0; i < vectorNombre.Length; i++)
            {
                Console.WriteLine(i + "    " + vectorNombre[i] + "    " + vectorEdad[i]);
            }

            for (int k = 0; k < vectorNombre.Length; k++)
            {
                for (int f = k + 1; f < vectorNombre.Length; f++)
                {
                    if (vectorNombre[f].CompareTo(vectorNombre[k]) < 0)
                    {
                        string aux;
                        aux = vectorNombre[f];
                        vectorNombre[f] = vectorNombre[k];
                        vectorNombre[k] = aux;

                        int auxEdad;
                        auxEdad = vectorEdad[f];
                        vectorEdad[f] = vectorEdad[k];
                        vectorEdad[k] = auxEdad;
                    }
                }
            }

            Console.WriteLine("Ordenado por nombre");
            Console.WriteLine("    " + "Nombre" + "    " + "Edad");
            for (int i = 0; i < vectorNombre.Length; i++)
            {
                Console.WriteLine(i + "    " + vectorNombre[i] + "    " + vectorEdad[i]);
            }
        }
    }
}
