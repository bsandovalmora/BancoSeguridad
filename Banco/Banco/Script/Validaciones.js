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