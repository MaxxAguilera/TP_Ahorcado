const palabraOculta = document.getElementById("palabraOculta").value;
const palabraEscrita = document.getElementById("palabraEscrita");
const mensajeFinal = document.getElementById("mensajeFinal");
const vidasRestantes = document.getElementById("vidasRestantes");
const inputLetra = document.getElementById("inputLetra");
let vidas = 10;
vidasRestantes.innerHTML = vidas;

function ArriesgarLetra(){
    const letraUsuario = inputLetra.value.toUpperCase();
    inputLetra.value = "";
    inputLetra.style.border = "1px solid grey";
    mensajeFinal.innerHTML = "";

    if (!ValidarLetraUsuario(letraUsuario)){
        inputLetra.style.border = "1px solid red";
        mensajeFinal.style.color = "red";
        mensajeFinal.innerHTML = "Tiene que ingresar mínimo una letra.";
        return;
    }
    let palabraGuiones = "";

    for (let i = 0; i < palabraOculta.length; i++){
        if (palabraEscrita.innerHTML[i] === '_'){

            if(CompararLetras(letraUsuario, palabraOculta[i])){
                palabraGuiones += palabraOculta[i];
            }
            else{
                palabraGuiones += '_';
                 
            }
        }
        else{
            palabraGuiones += palabraEscrita.innerHTML[i];
        }
    }

    if (palabraGuiones === palabraOculta){
        mensajeFinal.style.color = "green";
        mensajeFinal.innerHTML = "¡Ganaste!";
        DesactivarBoton();
    } else {
        if (palabraGuiones === palabraEscrita.innerHTML){
            vidas--;
            vidasRestantes.innerHTML = vidas;
            if (vidas === 0){
                mensajeFinal.style.color = "red";
                mensajeFinal.innerHTML = "¡Perdiste! La palabra era: " + palabraOculta;
                DesactivarBoton();
            }
        }
    }
    palabraEscrita.innerHTML = palabraGuiones;
}

function CompararLetras(letraUsuario, letraPalabra){
    if (letraUsuario === letraPalabra){
        return true;
    }
    if (letraPalabra === "Á" && letraUsuario === "A" ||
        letraPalabra === "É" && letraUsuario === "E" || 
        letraPalabra === "Í" && letraUsuario === "I" || 
        letraPalabra === "Ó" && letraUsuario === "O" || 
        letraPalabra === "Ú" && letraUsuario === "U"){
        return true;
    }
    return false;
}

function DesactivarBoton(){
    document.getElementById("botonArriesgar").disabled = true;
}

function ValidarLetraUsuario(letraUsuario){
    if (letraUsuario.length === 0){
        return false;
    }
    return true;
}