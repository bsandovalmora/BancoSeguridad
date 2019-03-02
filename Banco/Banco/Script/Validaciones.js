function validateForm() {
    var u = document.forms["inicio"]["usuario"].value;
    var p = document.forms["inicio"]["pass"].value;
    var tam_u = u.length;
    var tam_p = p.length;

    if (tam_u >= 6) {

    } else {
        alert("Inicio de sesión fallida");
        return false;
    }

    
}

function cuenta() {
    var u = document.forms["inicio"]["c"].value;

    if (u === "bloqueada") {
        alert("Cuenta bloqueada: verificación fallida, como modo de seguridad se bloqueó la cuenta de usuario");
    }

    if (u === "no existe") {
        alert("La cuenta del usuario no existe");
    }

    if (u === "desbloqueada") {
        alert("Se ha desbloqueado su cuenta de usuario puede usarla con normalidad");
    }

    if (u === "no coincide") {
        alert("Los datos ingresados no coinciden con el perfil de la cuenta de usuario. Vuélvalo a intentar");
    }
}