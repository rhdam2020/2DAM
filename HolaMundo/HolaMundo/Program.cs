using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCual es tu nombre? ");
            var nombre = Console.ReadLine();
            var fecha = DateTime.Now;
            Console.WriteLine($"\nHola, {nombre}, a {fecha:d} at {fecha:t}!");
            Console.Write("\nPresiona cualquier tecla para salir...");
            Console.ReadKey(true);
        }
    }
}
