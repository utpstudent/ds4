using System;

public class Aleatorios
{
    private Random random; // atributo Random

    // Constructor
    public Aleatorios()
    {
        random = new Random();
    }

    // i. Generar un número entre 2 números (mínimo y máximo)
    public int GenerarNumero(int min, int max)
    {
        return random.Next(min, max + 1); // Next es excluyente en el max, por eso sumamos +1
    }

    // ii. Generar un arreglo de números aleatorios entre 2 números
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
