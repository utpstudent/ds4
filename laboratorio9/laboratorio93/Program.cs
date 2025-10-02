using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        double lado1, lado2, lado3;

        
        Console.WriteLine("Por favor, ingrese la longitud del primer lado:");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la longitud del segundo lado:");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Por favor, ingrese la longitud del tercer lado:");
        lado3 = Convert.ToDouble(Console.ReadLine());

       
       
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo equilátero.");
            }
            
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo isósceles.");
            }
           
            else
            {
                Console.WriteLine("Es un triángulo escaleno.");
            }
        }
        else
        {
           
            Console.WriteLine("Las longitudes ingresadas no pueden formar un triángulo.");
        }
    }
}