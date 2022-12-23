// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    CheckWH();
});

$(window).resize(function () {
    CheckWH();
});

function CheckWH() {
    var width = $(window).width();
    var height = $(window).height() + 400;

    if (width < height) {
        console.log(`changing objects to 100% width. W:${width} H:${height}`);
        $(".comic_page").width('100%');
        $("#cover_spacer").hide();
        $(".spacers").hide();
    }
    else {
        console.log(`changing objects to 50% width. W:${width} H:${height}`);
        $(".comic_page").width('50%');
        $("#cover_spacer").show();
        $(".spacers").show();
    }
}