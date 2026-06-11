namespace tpAhorcado.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public class BD
{
    private string miConexionABD = @"Server=localhost; ...";

    public List<string> TraerPalabras()
    {
        List<string> Palabras = new List<string>();
        using(Sqlconnection conn= new Sqlconnection(miConexionABD))
        {
            string query = "SELECT palabra from Palabras";
            Palabras = conn.Query<string>(query).ToList();
        }
        return Palabras;
    }
}
