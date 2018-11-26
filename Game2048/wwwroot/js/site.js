// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Swipe() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            cellsVal = this.responseText;
            cells = document.getElementsByClassName('cell');
            for (var i = 0; i < 4; i++) {
                cells[i].innerHTML = cellsVal[i];
            }
        }
    };
    xhttp.open("GET", "GameBoardViewModel.cs", true);
    xhttp.send();
}
/*
window.onload = function () {
    alert("Hello! I am an alert box!");
}*/
    //window.addEventListener("keypress", myEventHandler, false);