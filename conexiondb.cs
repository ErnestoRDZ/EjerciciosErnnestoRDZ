using System;
using System.Data.SqlClient;

class conexiondb
{
      
       string ConnectionString ="data source = LAPTOP-Q3B92K5D; initial catalog = Northwind; Integrated Security = SSPI";

     public SqlConnection Conectardb = new SqlConnection();

     
     public conexiondb()
     {
       Conectardb.ConnectionString = ConnectionString;
     }

     //abrir la conexion y checar si nos entrega un error
      public void Open()
     {
        try
         {
           Conectardb.Open();
           Console.WriteLine("La database fue abierta");
          } catch(Exception ex)
         {
         Console.WriteLine("error al abrir la Data Base \n " + ex.Message); 
          }
     }

     //cerrar la conexion
      public void Close()
     {
       Conectardb.Close();
       Console.WriteLine("La database fue cerrada");
      }
}