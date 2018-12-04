// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* this would refresh the whole page
$('#swipeLeft').click(function () { document.location = '@Url.Action("SwipeLeft","GameBoardController")'; });
$('#swipeRight').click(function () { document.location = '@Url.Action("SwipeRight","GameBoardController")'; });
$('#swipeUp').click(function () { document.location = '@Url.Action("SwipeUp","GameBoardController")'; });
$('#swipeDown').click(function () { document.location = '@Url.Action("SwipeDown","GameBoardController")'; });
$('#newGame').click(function () { document.location = '@Url.Action("NewGame","GameBoardController")'; });
*/


function Swipe() {

    alert(" should pass the hidden inputs to the controller + an input with the kind of swipe to the controller and refresh a partial view of the matrix; the controller should set the new values to the inputs");
$.ajax({
    type: "POST",
    url: "/GameBoardController/SwipeLeft", // the URL of the controller action method
    data: null, // optional data
    success: function (result) {
        // do something with result
    },
    error: function (req, status, error) {
        // do something with error   
    }
});
}
function NewGame() {

    alert(" should invoke NewGame method from the controller which will reset te inputs and the game; should refresh a partial view of the matrix");
$.ajax({
    type: "POST",
    url: "/GameBoardController/SwipeLeft", // the URL of the controller action method
    data: null, // optional data
    success: function (result) {
        // do something with result
    },
    error: function (req, status, error) {
        // do something with error   
    }
});
}








/* that is working
window.onload = function () {
    alert("Hello! I am an alert box!");
}
*/

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