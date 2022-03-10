using System;
using System.Data.SqlClient;

class conexiondb
{ 
    string ConnectionString = "data source = LAPTOP-Q3B92K5D; Initial Catalog = AlumnosDB;  Integrated Security = SSPI";

    public SqlConnection Conectardb = new SqlConnection();

    public conexiondb()
    {
        Conectardb.ConnectionString = ConnectionString;
    }

    //abrimos la db y checamos errores
    public void Open()
    {
        try
        {
            Conectardb.Open();
            Console.WriteLine("La DataBase fue abierta");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al abri la data base \n" + ex.Message);
        }
    }

    //cerrar database
    public void Close()
    {
        Conectardb.Close();
        Console.WriteLine("La database fue cerrada");
    }
}