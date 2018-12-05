
//https://www.aspsnippets.com/Articles/ASPNet-MVC-Call-Controller-Method-from-View-using-jQuery-AJAX.aspx

$(".swipe").click(function () {
    var direction = $(this).text();;
    //alert("your direction is : " + direction);
    $.ajax({
        type: "post",
        url: "/home/swipe",
        data: '{name: "' + direction + '" }',
        success: function (response) {
            alert("response: " + direction);
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert("error");
        }
    });
})






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