using System;

namespace laboratorio95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aleatorios aleatorios = new Aleatorios();

            int min = 1;
            int max = 20;
            int cantidad = 10;

            int[] arregloNoRepetidos = GenerarArregloNoRepetidos(aleatorios, cantidad, min, max);

            Console.WriteLine("Arreglo de números no repetidos:");
            foreach (int num in arregloNoRepetidos)
            {
                Console.Write(num + " ");
            }
        }

        static int[] GenerarArregloNoRepetidos(Aleatorios aleatorios, int cantidad, int min, int max)
        {
            if (cantidad > (max - min + 1))
                throw new ArgumentException("La cantidad es mayor al rango disponible de números únicos.");

            int[] arreglo = new int[cantidad];
            int index = 0;

            while (index < cantidad)
            {
                int num = aleatorios.GenerarNumero(min, max);

                bool repetido = false;
                for (int i = 0; i < index; i++)
                {
                    if (arreglo[i] == num)
                    {
                        repetido = true;
                        break;
                    }
                }

                if (!repetido)
                {
                    arreglo[index] = num;
                    index++;
                }
            }

            return arreglo;
        }
    }
}
