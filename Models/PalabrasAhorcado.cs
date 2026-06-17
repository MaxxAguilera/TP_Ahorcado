namespace tpAhorcado.Models;

public class PalabrasAhorcado
{
    public List<string> palabras {get;set;}
    public BD baseDeDatos;

    public PalabrasAhorcado(){
        this.baseDeDatos = new BD();
        this.palabras = new List<string>();
        this.palabras = baseDeDatos.TraerPalabras();

    }
    public string ObtenerPalabra(){
        
        Random rd = new Random();
        string palabraFinal = this.palabras[rd.Next(0, palabras.Count)];
        return palabraFinal;
    }
}
