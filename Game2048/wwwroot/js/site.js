// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/**************swipes event listener */
function SwipeLeft() {
    var xhttp = new XMLHttpRequest();
    
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            alert("Hello! I am an alert box!");
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


/* event listener for arrow press
 document.onkeydown = checkKey;

function checkKey(e) {

    e = e || window.event;

    if (e.keyCode == '38') {
        // up arrow
    }
    else if (e.keyCode == '40') {
        // down arrow
    }
    else if (e.keyCode == '37') {
       // left arrow
    }
    else if (e.keyCode == '39') {
       // right arrow
    }

}
 */