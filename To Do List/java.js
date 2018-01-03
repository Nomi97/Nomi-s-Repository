/*global $*/
$(document).ready(function() {
    "use strict";
    var xhr = new XMLHttpRequest();
    xhr.onload = function() {
        var responseObject = JSON.parse(xhr.responseText);
        var i;
        for (i = 0; i < responseObject.articles.length; i += 1) {
            $("article").append("<section class = '" + i + "'>" + "</section>");
            $(" ." + i + "").append("<img src='" + responseObject.articles[i].urlToImage + "'> </img>");
            $(" ." + i + "").append("<h2>" + responseObject.articles[i].author + "</h2>");
            $(" ." + i + "").append("<h4>" + responseObject.articles[i].title + "</h4>");
            $(" ." + i + "").append("<p>" + responseObject.articles[i].description + "</p>");
            $(" ." + i + "").append("<i>" + responseObject.articles[i].url + "</i>");
        }
        // console.log(responseObject.articles[0]);
    };
    xhr.open("GET", "https://newsapi.org/v1/articles?source=bbc-news&sortBy=top&apiKey=551a4f53484f4905af568ae01cea180c", true);
    xhr.send(null);

    var date = new Date();
    var click = date.toDateString();
    $("li").append("<span style='float:right'>" + click + "</span>"); // adds time to current li
    $("#add").on("click", function(e) {
        e.preventDefault(); // Stops button submit
        var newItem = $("#newItem").val(); // Saves the value of the input
        if (newItem) { // Checks if value is empty
            $("ol").append("<li>" + newItem + "<span style='float:right'>" + click + "</span></li>").hide().slideDown(2000); // appends the value of the input into the ol
            $("#newItem").val(""); // reset the input after sumbit
        }
    });
    $(document).on('dblclick', 'li', function() { // removes item from list on dblclick
        $(this).slideUp(1000);
    });
});