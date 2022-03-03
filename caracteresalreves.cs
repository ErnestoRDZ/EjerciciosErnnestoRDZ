using System;

namespace Caracteres
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe 3 carácteres:");
            Console.WriteLine("Caracter 1: ");
            string Car1 = Console.ReadLine();

            Console.WriteLine("Caracter 2: ");
            string Car2 = Console.ReadLine();

            Console.WriteLine("Caracter 3: ");
            string Car3 = Console.ReadLine();

            Console.WriteLine(Car3 +Car2 +Car1);
            Console.ReadLine();

            /*Solución de la página
            char a = Convert.ToChar(Console.ReadLine());
        char b = Convert.ToChar(Console.ReadLine());
        char c = Convert.ToChar(Console.ReadLine());
 
        Console.WriteLine("{0} {1} {2}", c, b, a);
        */
        }
    }
}