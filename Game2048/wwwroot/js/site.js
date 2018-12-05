/* this would refresh the whole page
$('#swipeLeft').click(function () { document.location = '@Url.Action("SwipeLeft","GameBoardController")'; });
$('#swipeRight').click(function () { document.location = '@Url.Action("SwipeRight","GameBoardController")'; });
$('#swipeUp').click(function () { document.location = '@Url.Action("SwipeUp","GameBoardController")'; });
$('#swipeDown').click(function () { document.location = '@Url.Action("SwipeDown","GameBoardController")'; });
$('#newGame').click(function () { document.location = '@Url.Action("NewGame","GameBoardController")'; });
*/


//$(".swipe").click(function () { document.location = '@Url.Action("Index","HomeController")'; });




$(".swipe").click(function () {
    $.ajax({
        type: "POST",
        url: "/Home/Swipe",
        data: '{name: "' + $("#input").val() + '" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("success");
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert("error");
        }
    });
})

//$(".swipe").click(function () {
    
//    $.ajax({
//        url: "HomeController",
//        type: "POST",
//        // i'm trying to pass the value of the button "up", "down"...
//        data: { direction: this.val() }, 
//        success: function (response) {
//            alert(" alert ");
//        }
//    });
//})


//$(".swipe").click(function () {
//    var txt = $("input").val();
//    $.post("HomeController/Index",
//        { direction: txt });
//}






/*
$(".swipe").click(function () {
    $(".swipe").load('@(Url.Action("Index","HomeController");
    //,null, Request.Url.Scheme))?categoryId=' + categoryId
})*/





$("#newgame").click(function () {
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
})


    //$(document).ready(function () {
    //    $("#ddlCategory").change(function () {
    //        var categoryId = $("#ddlCategory").val();
    //        $("#dvCategoryResults").load('@(Url.Action("GetCategoryProducts","Home",null, Request.Url.Scheme))?categoryId=' + categoryId);
    //    });
    //});


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