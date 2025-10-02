using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double precio = 0;

        do { 
            Console.WriteLine("Ingrese precio de producto (mayor a 0): ");
            precio = Convert.ToDouble(value: Console.ReadLine());
        } while (precio < 0);

        string metodoPagoText = "";

       

        Console.WriteLine("Ingrese metodo de pago: ");
        Console.WriteLine("1. Efectivo");
        Console.WriteLine("2. Tarjeta");
        int metodoPago = Convert.ToInt32(value: Console.ReadLine());

        if (metodoPago == 1)
        {
            metodoPagoText = "Efectivo";

        }

        else if (metodoPago == 2)
        {

            metodoPagoText = "Tarjeta";

            string numeroTarjeta = "";

            do
            {
                Console.WriteLine("Ingrese el numero de su tarjeta (16 digitos): ");
                numeroTarjeta = Console.ReadLine();
            } while (numeroTarjeta.Length != 16);
        }
        else
        {
            metodoPagoText = "Metodo de pago no valido";
        }


        Console.WriteLine($"El total es ${precio} y elegiste el metodo de pago: {metodoPagoText}");
        
    }
}