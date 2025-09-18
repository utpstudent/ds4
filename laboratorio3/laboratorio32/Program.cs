using System;
using lab3;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Programa que calcula el area de un circulo");

        Console.Write("Ingresa un numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        double resultado = CalculosMatematicos.CalculoArea(num1);

        Console.WriteLine($"El area del cicuclo con radio {num1} es: {resultado}");


    } 
}