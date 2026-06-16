namespace tpAhorcado.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public class BD
{
    private string miConexionABD = @"Server=localhost; DataBase=Palabras;Integrated Security=True;TrustServerCertificate=True;";
    public string TraerPalabras()
    {
        List<string> palabras = new List<string>();
        using(Sqlconnection conn = new Sqlconnection(miConexionABD))
        {
            string query = "SELECT palabra from Palabras";
            palabras = conn.Query<string>(query).ToList();
        }
        return palabras;
    }
}
