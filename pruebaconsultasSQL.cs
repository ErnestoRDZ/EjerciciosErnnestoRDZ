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

             /*Agregando información a una tabla
            string insertar = " SET IDENTITY_INSERT Categories ON INSERT INTO Categories (CategoryID, CategoryName, Description) VALUES ('9', 'Chocolate', 'Soft');";

            SqlCommand insert = new SqlCommand(insertar, conexion.Conectardb);
            insert.ExecuteNonQuery();*/
            
            /*Eliminando una fila
            string borrar = "Delete Categories Where CategoryID=9";
            SqlCommand delete = new SqlCommand(borrar, conexion.Conectardb);
            delete.ExecuteNonQuery();*/
             
            //Consulta a SQL
            string query = "Select * from Customers where CustomerID like 'a%'";
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion.Conectardb);
                SqlDataReader lector = comando.ExecuteReader();
                while(lector.Read())
                {
                    Console.WriteLine(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString() + " \n");
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta");
            }

            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();

           
        }
    }
}