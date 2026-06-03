namespace tpAhorcado.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado(){
        palabras = new List<string>();
        palabras.Add("Rinoceronte");
        palabras.Add("Sardinas");
        palabras.Add("Ebullición");
        palabras.Add("Aglomerante");
        palabras.Add("Parafraseo");
    }

    public string ObtenerPalabra(){
        Random rnd = new Random();
        int palabra = rnd.Next(1, palabras.Count);
        return palabras[palabra];
    }
}
