window.EstructuraHTML = function(e) {
    var Sinopsis = document.getElementById("Sinopsis").value;
    var ContadorCaracteres = Sinopsis.length;
    document.getElementById("ContadorCaracteres").innerHTML = "Carácteres: " + ContadorCaracteres + " /500";
}