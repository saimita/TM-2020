var count = 0;
var x= 0;
function Adicionar(){
    var url = "https://placeimg.com/250/150/${x}";
    var newNode = document.createElement("IMG");
    newNode.setAttribute("src",url);
    document.getElementById("imgs").appendChild(newNode);
    count++;
    x++;
    document.getElementById("quant").innerHTML = ""+(count);
}
function Remover(){
    var remove = Math.floor(Math.random() * count);
    document.getElementById("imgs").children[remove].remove();
    count --;
    document.getElementById("quant").innerHTML = ""+(count);
}