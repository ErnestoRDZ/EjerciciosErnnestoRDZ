using System;

namespace centígrados
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Convierte tus centígrados a Kelvin y Fahrenheit");
            Console.WriteLine("¿Cuántos grados celsius?");
            string c = Console.ReadLine();

            double C = Convert.ToDouble(c);

            //kelvin
            double k = C + 273;
            Console.WriteLine("Kelvin: " +k);

            //Fahrenheit
            double f = C * 18 / 10 + 32;
            Console.WriteLine("Fahrenheit: " +f);
            Console.ReadLine();

        }
    }
}