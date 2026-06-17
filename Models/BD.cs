namespace tpAhorcado.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public class BD
{
    private string miConexionABD = @"Server=localhost; DataBase=Ahorcado;Integrated Security=True;TrustServerCertificate=True;";

    public List<string> TraerPalabras()
    {
        List<string> palabras = new List<string>();
        using(SqlConnection conn = new SqlConnection(miConexionABD))
        {
            string query = "SELECT palabra FROM Palabras";
            palabras = conn.Query<string>(query).ToList();
        }
        return palabras;
    }

    public void NuevaPalabra(string palabraUsuario)
    {
        string query = "INSERT INTO Palabras(palabra) VALUES (@palabraUsuario)";

        using(SqlConnection conn = new SqlConnection(miConexionABD))
        {
            conn.Execute(query, new {palabra = palabraUsuario});
        }
        
    }
}
