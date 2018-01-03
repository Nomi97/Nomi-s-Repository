// My global variables
var i;
var picked = [];
var first;
var second;
function compare() {
    "use strict";
    if (picked[0] !== picked[1]) { // checks if position 0 and 1 of the array are NOT the same
        first.className = "front"; // Changes the class of the first click
        second.className = "front"; // Changes the class of the second click
    }
    picked.length = 0; // resets the array
}
function pickImage() {
    "use strict";
    picked.push(this.previousElementSibling.firstChild.src); // pushes the source of the image that has been click into the array
    if (picked.length === 2) { // if the array contains 2 items it will wait 1 sec then run the function compare
        setTimeout(compare, 1000);
        second = this; // if the array already has a value it saves the second value of the second click in a variable
    } else {
        first = this; // If the array does not contain any value it saves the value of the first click
    }
}



function flip() {
    "use strict";
    this.className = "flipped-front"; // FLips the current front image that has been clicked
    this.previousElementSibling.className = "flipped-back"; // flips the back image that's connected to the front image
}
var front = document.querySelectorAll(".front"); // saves all the element with the class .front in a array called front
for (i = 0; i < front.length; i += 1) { // loops trough the array
    front[i].addEventListener('click', pickImage); // triggers the function pickImage when a image has been clicked
    front[i].addEventListener('click', flip);   // triggers the function flip when a image has been clicked
}