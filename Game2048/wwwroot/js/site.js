﻿
$(document).keydown(function (e) { // keypress does not work for arrow keys
    switch (e.which) {
        case 37: // left
            document.getElementById("swipe-left").click();
            break;

        case 38: // up
            document.getElementById("swipe-up").click();
            break;

        case 39: // right
            document.getElementById("swipe-right").click();
            break;s

        case 40: // down
            document.getElementById("swipe-down").click();
            break;

        default: return; // exit this handler for other keys
    }
    //e.preventDefault(); // prevent the default action (scroll / move caret)
});

//https://www.aspsnippets.com/Articles/ASPNet-MVC-Call-Controller-Method-from-View-using-jQuery-AJAX.aspx
$(".swipe").click(function () {
    var direction = $(this).val();
    //alert("your direction is : " + direction);
    $.ajax({
        type: "POST",
        url: "/Home/Swipe",
        data: { "direction": direction},
        dataType: "text",
        success: function (response) {
            $("#gameBoard").html(response);
            //alert(direction);
        },
        failure: function (response) {
            alert("fail, direction: " + direction);
        },
        error: function (response) {
            alert("error, direction: " + direction);
        }
    });
})


$("#new-game").click(function () {
    $.ajax({
        type: "POST",
        url: "/Home/NewGame",
        success: function (response) {
            $("#gameBoard").html(response);
            //alert("New Game!");
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert("error");
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