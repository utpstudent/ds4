using System;

namespace laboratorio95
{
    internal class Aleatorios
    {
        private Random random;

        // Constructor
        public Aleatorios()
        {
            random = new Random();
        }

        // Generar un número aleatorio entre 2 números
        public int GenerarNumero(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        // Generar un arreglo de números aleatorios entre 2 números
        public int[] GenerarArreglo(int cantidad, int min, int max)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }
}
