using System;
using System.Data.SqlClient;

namespace AltaAlumnos
{
    class Programa
    {
        public static void Main(string[] args)
        {
            //Conexión a SQL
            conexiondb conexion = new conexiondb();
            conexion.Open();

            //Información general
            Console.WriteLine("Aquí podras dar de alta y buscar la información de los alumnos \n");
            Console.WriteLine("¿Qué deseas hacer?\n");
            Console.WriteLine("Agregar (1) o buscar información (2) o Puede ver todos (3)");
           
            
                int accion = (Convert.ToInt32(Console.ReadLine()));

            
                switch (accion)
                {
                    case (1):
                        Console.WriteLine("Selecciono agregar alumno");
                        Console.WriteLine("Coloque el nombre del alumno: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Coloque los apellidos: ");
                        string apellidos = Console.ReadLine();
                        Console.WriteLine("Colocar grado: ");
                        string grado = Console.ReadLine();
                        Console.WriteLine("Coloque el grupo: ");
                        string grupo = Console.ReadLine();
                    try
                    {
                        string insertar = "insert into Alumnos (Apellidos, Nombres, Grado, Grupo) values (" + "'"+ apellidos + "', " + "'" + nombre + "', " + "'" + grado + "', " + "'" + grupo + "'" + ")";
                        SqlCommand insert = new SqlCommand(insertar, conexion.Conectardb);
                        insert.ExecuteNonQuery();
                        Console.WriteLine("Todo salió correctamente, ¡Alumno añadido!");

                       
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Algo no salió como debia, intentalo de nuevo");
                        Console.ReadLine();
                    }
                    break;
                       

                    case (2):
                        Console.WriteLine("Seleccionó buscar información");
                        Console.WriteLine("Coloque los Apellidos del alumno que desea buscar");
                        string buscador = Console.ReadLine();
                        string buscar = "Select * from Alumnos where Apellidos like" + "'%" + buscador + "%'";
                    try{
                            SqlCommand search = new SqlCommand(buscar, conexion.Conectardb);
                        search.ExecuteNonQuery();
                        SqlDataReader srcReader = search.ExecuteReader();
                    while (srcReader.Read())
                    {
                        Console.WriteLine(srcReader.GetValue(0).ToString() + " " + srcReader.GetValue(1).ToString() + " " + srcReader.GetValue(2).ToString() + " " + srcReader.GetValue(3).ToString() + " " + srcReader.GetValue(4).ToString());
                    }
                        }catch(Exception ex)
                        {
                            Console.WriteLine("Hubo un error al hacer la busqueda, intente de nuevo");
                        }
                        

                        break;

                    case (3):
                        Console.WriteLine("Seleccionaste ver todos");
                    string todos = "select * from Alumnos";
                    try
                    {
                        SqlCommand select = new SqlCommand(todos, conexion.Conectardb);
                        SqlDataReader lector = select.ExecuteReader();
                        while(lector.Read())
                        {
                            Console.WriteLine(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " + lector.GetValue(4).ToString());

                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Hubo un error al hacer la consulta, intenta de nuevo!");
                    }
                         break;

                    

                }

            
            //Cerrando la conexión
            conexiondb conexcionc = new conexiondb();
            conexcionc.Close();
            
            
                

                
           
        }
    }
}