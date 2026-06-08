namespace tpAhorcado.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado(){
        palabras = new List<string>()
        {
            "RINOCERONTE",
            "SARDINAS",
            "EBULLICIÓN",
            "AGLOMERANTE",
            "PARAFRASEO",
            "COMPUTADORA",
            "PROGRAMACIÓN",
            "TELEFONÍA",
            "ESTUDIANTE",
            "VENTILADOR",
        };
    }

    public string ObtenerPalabra(){
        Random rnd = new Random();
        int palabra = rnd.Next(0, palabras.Count);
        return palabras[palabra];
    }
}
