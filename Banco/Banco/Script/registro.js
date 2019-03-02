function validar_pass() {
    var u = document.forms["registro"]["pass"].value;
    var p = document.forms["registro"]["pass_1"].value;
    var tam_u = u.length;
    var tam_p = p.length;

    if (tam_u >= 6) {
        if (u.equals(p)) {
            var res = u.match(/[A-Z]/g);
            if (res.length > 1) {

            } else {
                alert("Contraseña invalida: Agregue mínimo 2 mayúsculas");
                return false;
            }
        }
        else {
            alert("Contraseña invalida: las contraseñas son distintas");
            return false;
        }
    } else {
        alert("Contraseña invalida: mínimo 6 caracteres");
        return false;
    }
}

function recuperar_pass() {
    var u = document.forms["recuperar"]["pass"].value;
    var p = document.forms["recuperar"]["pass_1"].value;
    var tam_u = u.length;
    var tam_p = p.length;

    if (tam_u >= 6) {
        if (u.equals(p)) {
            var res = u.match(/[A-Z]/g);
            if (res.length > 1) {

            } else {
                alert("Contraseña invalida: Agregue mínimo 2 mayúsculas");
                return false;
            }
        }
        else {
            alert("Contraseña invalida: las contraseñas son distintas");
            return false;
        }
    } else {
        alert("Contraseña invalida: mínimo 6 caracteres");
        return false;
    }
}