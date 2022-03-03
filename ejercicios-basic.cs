using System;
 
namespace ejercicios
{
    class MainClass
    {
        public static void Main (string[] args)
        {
           /*  Ejercicio 1
            int x = 45;
            int y = 78;
            int z = 2;
 
            int suma = x + y + z;
 
            Console.WriteLine ("El resultado es "+suma);*/

           /* Ejercicio 2 
            Console.WriteLine("Escribe tu nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Escribe una ciudad");
            string city = Console.ReadLine();

            Console.WriteLine("Hola " + name);
            Console.WriteLine("Bienvenido a " + city);
            */

            /* Ejercicio 3
            Console.WriteLine("Coloca tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Coloca tu edad:");
            string text = Console.ReadLine();
            int edad = Convert.ToInt32(text);

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años "); 
            */

            /* Ejercicio 4
            Console.WriteLine("Coloca un número");
            string num = Console.ReadLine();

            Console.WriteLine("Coloca cualquier otro número");
            string num2 = Console.ReadLine();

            int x = Convert.ToInt32(num);
            int y = Convert.ToInt32(num2);

            if (x>y)
            {
                Console.WriteLine( x + " Es mayor que " + y);
            }
            else if (x<y)
            {
                Console.WriteLine( x + " Es menor que " + y);
            }
            else
            {
                Console.WriteLine("Amnbos son iguales");
                

            }
            */

            
            /* Ejercicio 5
            Console.WriteLine("Coloque el día;");                                                                   
                string Dia = Console.ReadLine();

                string Dom = "Domingo";
                string Sab = "Sábado";

                if (Dia == Sab)
                {
                    Console.WriteLine("Estas en el fin de semana");
                }
                else if (Dia == Dom)
                {
                    Console.WriteLine("Estas en el fin de semana");
                }
                else
                {
                    Console.WriteLine("No te encuentras en el fin de semana");
                }

                //lo de abajo era la respuesta de la página

                Console.WriteLine ("Escribe un dia de la semana");
            String dia = Console.ReadLine ();
 
            switch(dia.ToLower()){
 
            case "lunes":
            case "martes":
            case "miercoles":
            case "jueves":
            case "viernes":
                Console.WriteLine ("No es fin de semana");
                break;
            case "sabado":
            case "domingo":
                Console.WriteLine ("Es fin de semana");
                break;
 
            default:
                Console.WriteLine ("Ese dia no es correcto");
                break;
            }
            */

            /* Ejercicio 6
            Console.WriteLine("Por favor, coloque el precio del producto;");
            string Price = Console.ReadLine();

            Console.WriteLine("Su pago será a ¿tarjeta o en efectivo?");
            string Pay = Console.ReadLine();

            switch(Pay){
            
            case "efectivo":
                Console.WriteLine("Perfecto!");
                break;
            case "tarjeta":
                Console.WriteLine("Coloque el número de tarjeta");
                string NumTarjeta = Console.ReadLine();
                break;
            default:
                Console.WriteLine("este no es método de pago");
                break;
            }
            */

            /* Ejercicio 8
            for (int i = 0; i<= 100; i++)
            {
                Console.WriteLine(i);
            }
            */

            /* Ejercicio 9
            int i = 0;
            while(i <= 100)
            {
                Console.WriteLine(i);
                i+=2;
            }
            */

            for (int i = 0; i<= 100; i++)
            {
                if (i%2==0 || i%3==0)
                {
                Console.WriteLine(i);
                }
            }

        }
    }
}

