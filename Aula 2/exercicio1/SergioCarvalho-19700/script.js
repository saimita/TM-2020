function lerInput() {
    var texto = document.getElementById("numero").value;
    if(!texto.length) alert("input vazio");
    document.getElementById("text").innerText=texto;
}