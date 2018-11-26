function loadDoc() {
    var xhttp = new XMLHttpRequest();
    //window.addEventListener("keypress", myEventHandler, false);
    
    xhttp.onreadystatechange = function () {
        
        if (this.readyState == 4 && this.status == 200) {
            cellsVal = this.responseText;
            cells = document.document.getElementsByClassName('cell');
            for (var i = 0; i < 4; i++) {
                cells[i].innerHTML = cellsVal[i];
            }
        }
    };
    xhttp.open("GET", "GameBoardViewModel.cs", true);
    xhttp.send();
}
function myFunction() {
    alert("Hello! I am an alert box!");
}

/*
$(window).keypress(function (e) {
    var keyCode = e.keyCode;

    if (keyCode == 87 || keyCode == 119) {
        console.log("You pressed W!");
        alert("You pressed W!");
    }
});
*/
/*
var rows = document.getElementsByClassName('row');
var cells = document.document.getElementsByClassName('cell');
for (var i = 0; i < 4; i++) {
    for (var j = 0; j < 4; j++) {
        var child = cells.children[i];
        child.innerHTML = "val";
    }
}

*/