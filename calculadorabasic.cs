using System;

namespace calculadorabasic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe el primer número:");
            string Num1 = Console.ReadLine();

            Console.WriteLine("Escribe el segundo número:");
            string Num2 = Console.ReadLine();

            int x = Convert.ToInt32(Num1);
            int y = Convert.ToInt32(Num2);

            //Sumas
            int Sum = x + y;
            Console.WriteLine("la suma es: " +Sum);

            //Resta
            int Rest = x - y;
            Console.WriteLine("La resta es: " +Rest);

            //Multiplicación
            int Mult = x * y;
            Console.WriteLine("La multiplicación es: " +Mult);

            //División
            int Div = x / y;
            Console.WriteLine("La división es: " +Div);
            int Mod = x % y;
            Console.WriteLine("El resto de la división es: " +Mod);

            Console.ReadLine();

            /*Solución de la página
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
            Console.WriteLine("{0} x {1} = {2}", x, y, x*y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x/y);
            Console.WriteLine("{0} mod {1} = {2}", x, y, x%y);
            */
        }
    }
}