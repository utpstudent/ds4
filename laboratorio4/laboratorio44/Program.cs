class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa la nota del estudiante: ");
        float score = float.Parse(Console.ReadLine());

        if (score >= 70)
        {
            Console.WriteLine();
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Reprobado");
        }

    }
}