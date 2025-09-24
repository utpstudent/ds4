using System;
class fruta
{
    string[] frutas = { "manzana", "platano", "naranja" };
    private static void Main(string[] args)
    {
       foreach (string fruta in new fruta().frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}