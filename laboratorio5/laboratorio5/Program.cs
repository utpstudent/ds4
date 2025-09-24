using System;
class PruebaVector1
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[6];
        for (int f = 0; f <= 5; f++)
        {
            Console.WriteLine("Ingrese el sueldo del operario " +f+": ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f]= int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios: \n");
        for (int f = 0; f <= 5; f++)
        {
            Console.WriteLine("["+sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

    //main principal

    private static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}