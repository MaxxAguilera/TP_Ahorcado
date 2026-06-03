let palabraGuionesValor = document.getElementById("palabraGuiones").value;
const palabra = document.getElementById("palabra").value;
const contenedorPalabra = document.getElementById("palabraEscrita");

function ComprobarLetra(){
    const letraUsuario = document.getElementById("inputLetra").value;
    
    for (let i = 0; i < palabra.Length; i++){
        if(letraUsuario == palabra[i]){
            palabraGuionesValor[i] = letraUsuario;
        }
        else{
            console.log("nop")
        }
    }
    console.log(palabraGuionesValor);
    contenedorPalabra.innerHTML = palabraGuionesValor;
}