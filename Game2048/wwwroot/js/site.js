
//https://www.aspsnippets.com/Articles/ASPNet-MVC-Call-Controller-Method-from-View-using-jQuery-AJAX.aspx

$(".swipe").click(function () {
    var direction = $(this).text();;
    alert("your direction is : " + direction);
    $.ajax({
        type: "post",
        url: "/home/swipe",
        data: '{name: "' + direction + '" }',
        success: function (response) {
            ("$gameBoard").html(response);
        },
        failure: function (response) {
            alert("fail");
        },
        error: function (response) {
            alert("error");
        }
    });
})


$("#new-game").click(function () {
    $.ajax({
        type: "post",
        url: "/home/newgame",
        success: function (response) {
            //$("#message-box").text("New Game");
            alert("New Game!");
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