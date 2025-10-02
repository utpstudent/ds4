using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;
        
        do {
            numero ++;
            

            if(numero % 2 == 0 && numero % 3 == 0){

                Console.WriteLine($"Numero: {numero}");

            }

        } while (numero < 100);

        
    }
}