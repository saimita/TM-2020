var arrayNumbers=[];
function adicionarNumero(){
    var numero = document.getElementById("numero").value;
    arrayNumbers.push(parseInt(numero));
    if(!numero.length) alert("input vazio");
    document.getElementById("text").innerText = arrayNumbers;
}
function calcularNumero() {
    var maiorNumero =Math.max.apply(Math, arrayNumbers);
    document.getElementById("maior").innerText = maiorNumero;

}