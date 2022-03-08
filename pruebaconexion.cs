using System;
using System.Data.SqlClient;

namespace ConexionPrueba
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba");
            conexiondb conexion = new conexiondb();
            conexion.Open();


            //Consulta a SQL
            string query = "Select * from Categories";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion.Conectardb);
                SqlDataReader lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    Console.WriteLine(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString() + " ");
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta");
            }
        }
    }
}