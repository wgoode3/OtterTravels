// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('.modaller').click(function() {
    var idToModel = $(this).attr("data-target");
    console.log("yep!");
    console.log(idToModel, this);
    document.getElementById(idToModel).classList.add("show");
    document.getElementById(idToModel).style.display = "block";
});

document.querySelectorAll("[data-dismiss]").forEach(ele => {
    ele.addEventListener("click", function() {
        var modals = document.querySelectorAll(".modal");
        for(let e of modals){
            e.classList.remove("show");
            e.style.display = "none";
        }
    });
});