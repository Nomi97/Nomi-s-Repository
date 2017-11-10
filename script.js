$(function () {
    $(document).scroll(function () {
        var $nav = $(".navbar");
        $nav.toggleClass('scrolled', $(this).scrollTop() > $nav.height());
    }); // menu scroll effect

    

    $('#contactForm').submit(function () {
            $.ajax({
                url: '/Home/PostContactMessage',
                type: 'POST',
                data: $(this).serialize(),
                success: function (result) {
                    $(".Alert").prepend("<div class='alert alert-success'><strong> Success!</strong> We have recieved your message.</div >");
                },
                Error: function (result) {
                    $(".Alert").prepend("<div class='alert alert-danger'><strong> Warning!</strong> Something went wrong.</div >");
                }
            });
            return false;
        });
    $("a").on('click', function (event) {

        // Make sure this.hash has a value before overriding default behavior
        if (this.hash !== "") {
            // Prevent default anchor click behavior
            event.preventDefault();

            // Store hash
            var hash = this.hash;

            // Using jQuery's animate() method to add smooth page scroll
            // The optional number (800) specifies the number of milliseconds it takes to scroll to the specified area
            $('html, body').animate({
                scrollTop: $(hash).offset().top
            }, 400, function () {

                // Add hash (#) to URL when done scrolling (default click behavior)
                window.location.hash = hash;
            });
        } // End if
    }); // navigation scroll effect
});