function Valores(){
    var elemento = document.getElementById( "link");
    var info = document.getElementById( "info");

    info.innerHTML = "ID: "+elemento.id+"<br>"+ "href: "+elemento.href+"<br>"+"target: "+ elemento.target+"<br>"+"type: "+elemento.type+"<br>";
}
function Vermelho(){
    var titulos = document.getElementsByClassName( "titulo");
    for(let element of titulos){
        element.style.color = "red";
    }
}
function CellClick(id) {
    num = prompt("Novo Valor?");
    document.getElementById( id).innerHTML=num;
    document.getElementById( id).style.backgroundColor = "green";
}