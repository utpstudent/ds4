using System;

namespace lab3;
public class CalculosMatematicos
{
    public static int Calcular(int a , int b)
    {
        return (a + b) * (a - b);
    }

    public static double CalculoArea(double r)
    {
        return (Math.PI * ( r * r ) );
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = CalculosMatematicos.Calcular(num1, num2);

        Console.WriteLine($"El resultado de la operación es: {resultado}");
    }
}