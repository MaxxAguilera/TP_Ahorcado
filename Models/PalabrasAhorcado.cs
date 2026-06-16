namespace tpAhorcado.Models;

public class PalabrasAhorcado
{
    public List<string> palabras = new List<string>();
    public BD baseDeDatos;

    public PalabrasAhorcado(){
        this.baseDeDatos = new BD();
        this.palabras = baseDeDatos.TraerPalabras();

    }
    public string ObtenerPalabra(){

        Random rnd = new Random();
        string palabraFinal = palabras[rd.Next(0, palabras.Count)];
        return palabraFinal;
    }
}
