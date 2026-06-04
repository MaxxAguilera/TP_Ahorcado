let palabraGuionesMostrarpPantalla = document.getElementById("palabraGuiones").value;
const palabra = document.getElementById("palabra").value;
const contenedorPalabra = document.getElementById("palabraEscrita");

function ComprobarLetra(){
    const letraUsuario = document.getElementById("inputLetra").value;
    let palabraGuiones = null;
    console.log(letraUsuario)
    for (let i = 0; i < palabra.length; i++){
        if (palabraGuionesMostrarpPantalla[i] == '-'){
            if(letraUsuario == palabra[i]){
                palabraGuiones += letraUsuario;
            }
            else{
                palabraGuiones += '-'
            }
        }
        else{
            palabraGuiones += palabraGuionesMostrarpPantalla[i]
        }
    }
    contenedorPalabra.innerHTML = palabraGuionesMostrarpPantalla;
}