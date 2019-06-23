

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
if (typeof jQuery !== 'undefined') {
    console.log('jQuery Loaded');
}
else {
    console.log('not loaded yet');
}

//  Ready es un método propio de jQuery, que revisa si el DOM está listo para usarse.Es más util que el window.onload, pues este debe esperar a que todos los elementos de la pagina esten cargados(como scripts e imagenes) paa ejecutar.El “ready”, en cambio, espera solo a la estructura"
$(document).ready(function () {

    alert("hola");
    alertify.alert('hola mundo');

    var availableTags = [
        "ActionScript",
        "AppleScript",
        "Asp",
        "BASIC",
        "C",
        "C++",
        "Clojure",
        "COBOL",
        "ColdFusion",
        "Erlang",
        "Fortran",
        "Groovy",
        "Haskell",
        "Java",
        "JavaScript",
        "Lisp",
        "Perl",
        "PHP",
        "Python",
        "Ruby",
        "Scala",
        "Scheme"
    ];
    $("#autocomplete").autocomplete({
        source: availableTags
    });

});