window.EstructuraHTML = function(e) {
    var Sinopsis = document.getElementById("Sinopsis").value;
    var ContadorCaracteres = Sinopsis.length;
    document.getElementById("ContadorCaracteres").innerHTML = "Carácteres: " + ContadorCaracteres + " /500";
}

window.EstructuraHTMLBiografia = function(e) {
    var Biografia = document.getElementById("Biografia").value;
    var ContadorCaracteresBiografia = Biografia.length;
    document.getElementById("ContadorCaracteresBiografia").innerHTML = "Carácteres: " + ContadorCaracteresBiografia + " /5000";
}
