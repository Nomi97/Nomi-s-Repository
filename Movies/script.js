var movies = [

    'Holy grail', 'Braveheart', 'Indiana jones', 'Lord of the rings', 'Star wars', 'raan', 'vilda flykten',
    'hero', 'drunken boxer', 'police stories', 'howls moving castle', 'spirited away', 'grave of the fireflies',
    'your name', 'The seven samurai', 'Once upon a time in America', 'Barry lyndon', 'ben-hur', 'gladiator',
    '300', 'Patrioten', 'king arthur', 'Dansar med vargar', 'Doktor Zjivago', 'Den längsta dagen',
    'En man för alla tider', 'Slaget om Alger', 'The Last King of Scotland', 'Den siste kejsaren',
    'Borta med vinden', 'Så tuktas ett lejon', 'Ärans män', 'Crouching Tiger, Hidden Dragon',
    'Den gyllene blommans förbannelse'
];

$('#antal').html("Antal filmer: " + movies.length);

function randomMovie() {
    var randomMovie = Math.floor(Math.random() * movies.length);
    var movie = movies[randomMovie];
    $("#movies").text("watch this movie: " + movie);
}

function checkMovie() {
    var film = $(".search").val()
    var result = movies.indexOf(film);
    if (result !== -1) {
        $(".search-result").text("movie exist");
    } else {
        $(".search-result").text("movie does not exist");

    }

}


function addMovie() {
    var film = $(".add").val()
    var result = movies.indexOf(film);
    if (result !== -1) {
        $(".add-result").text("movie already exist");
    } else {
        movies.push(film);
        $(".add-result").text("movie has been added");

    }
}