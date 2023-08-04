using System;
using System.Configuration;
using System.Data.SqlClient;

public sealed class DatabaseConnection
{
    private static readonly DatabaseConnection instance = new DatabaseConnection();
    private readonly SqlConnection connection;

    private string connectionString;

    private DatabaseConnection()
    {
        connectionString = ConfigurationManager.ConnectionStrings["MiConexionBD"].ConnectionString;
        connection = new SqlConnection(connectionString);
    }

    public static DatabaseConnection Instance
    {
        get { return instance; }
    }

    public SqlConnection OpenConnection()
    {
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
        return connection;
    }

    public void CloseConnection()
    {
        if (connection.State != System.Data.ConnectionState.Closed)
        {
            connection.Close();
        }
    }

    public bool TestConnection()
    {
        try
        {
            using (SqlConnection tempConnection = new SqlConnection(connectionString))
            {
                tempConnection.Open();


                string sqlQuery = "SELECT * From EMPLEADOS;";
                using (SqlCommand command = new SqlCommand(sqlQuery, tempConnection))
                {
                    object result = command.ExecuteScalar();
                    return result != null && result != DBNull.Value;
                }
            }
        }
        catch (Exception ex)
        {
            // Si ocurre algún error, puedes manejarlo aquí o simplemente devolver falso
            return false;
        }
    }
}
