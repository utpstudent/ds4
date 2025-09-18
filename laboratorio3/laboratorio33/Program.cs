internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Programa que calcula el perimetro de un rectangulo");

        Console.Write("Ingrese el largo del rectangulo: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el ancho del rectangulo: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int P = 2 * (a + b);

        Console.Write($"El perimetro de rectangulo con largo de {a} y anchura de {b} es: {P}");

    }
}