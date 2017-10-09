var movies = [
'Holy grail', 'Braveheart', 'Indiana jones', 'Lord of the rings', 'Star wars','raan','vilda flykten',
'hero','drunken boxer','police stories','howls moving castle','spirited away','grave of the fireflies',
'your name', 'The seven samurai','Once upon a time in America','Barry lyndon', 'ben-hur', 'gladiator',
'300', 'Patrioten','king arthur','Dansar med vargar','Doktor Zjivago', 'Den längsta dagen',
'En man för alla tider', 'Slaget om Alger','The Last King of Scotland','Den siste kejsaren',
'Borta med vinden','Så tuktas ett lejon','Ärans män','Crouching Tiger, Hidden Dragon',
'Den gyllene blommans förbannelse'
];

var btn = document.getElementById('btn');
var display = document.getElementById('movies');
var img = document.getElementById('img');
var antal = document.getElementById('antal').innerHTML += ": " + movies.length;

var a = movies.indexOf("Braveheart");
console.log(a);

function random(){
    var randomMovie = Math.floor(Math.random() * movies.length);
    var movie = movies[randomMovie];
    var filmNumber = document.getElementById('number').innerHTML = "Film number: " + randomMovie;
    
    display.innerHTML = "watch this movie: " + movie.bold();
}