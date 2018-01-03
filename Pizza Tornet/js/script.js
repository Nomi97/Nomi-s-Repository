    var price = $('#real_price').val();
    var counter = $('#Quantity').val();
    var result;
    var basePrice = 60;



    $(".vars").change(function() {
        newPrice = basePrice;

        $('.vars option:selected').each(function() {
            newPrice = $(this).data('price'); //get price of each selected option and add them to the newPrice
            $('.item_price').html(newPrice);
            $('#real_price').val(newPrice);
            $('#Quantity').val(1);
        });

        $('#price').html("Pris : " + newPrice + "kr"); //display new price
    });

    $('#Plus').click(function() {
        counter++;
        $('#Quantity').val(counter);
        price = $('#real_price').val();
        result = $('#price').html("Pris : " + counter * price + "kr");
        console.log(price);

    });
    $('#Minus').click(function() {
        counter = $('#Quantity').val();
        if (counter > 1) {
            counter--;
            $('#Quantity').val(counter);
            price = $('#real_price').val();
            result = $('#price').html("Pris : " + counter * price + "kr");

        }
    });


    $('#Sandwich').on('click', function() {
        $('#menu-item-1').hide();
        $('#menu-item-2').show();
        $('#menu-item-3').hide();
        $('#menu-item-4').hide();
        $('#menu-item-5').hide();
        $('#menu-item-6').hide();

    });

    $('#Pizza').on('click', function() {
        $('#menu-item-2').hide();
        $('#menu-item-1').show();
        $('#menu-item-3').hide();
        $('#menu-item-4').hide();
        $('#menu-item-5').hide();
        $('#menu-item-6').hide();

    });

    $('#Kebab').on('click', function() {
        $('#menu-item-2').hide();
        $('#menu-item-1').hide();
        $('#menu-item-3').show();
        $('#menu-item-4').hide();
        $('#menu-item-5').hide();
        $('#menu-item-6').hide();

    });
    $('#Sallad').on('click', function() {
        $('#menu-item-2').hide();
        $('#menu-item-1').hide();
        $('#menu-item-3').hide();
        $('#menu-item-4').show();
        $('#menu-item-5').hide();
        $('#menu-item-6').hide();

    });
    $('#Drycker').on('click', function() {
        $('#menu-item-2').hide();
        $('#menu-item-1').hide();
        $('#menu-item-3').hide();
        $('#menu-item-4').hide();
        $('#menu-item-5').show();
        $('#menu-item-6').hide();

    });
    $('#Bakad').on('click', function() {
        $('#menu-item-2').hide();
        $('#menu-item-1').hide();
        $('#menu-item-3').hide();
        $('#menu-item-4').hide();
        $('#menu-item-5').hide();
        $('#menu-item-6').show();

    });
    $(function() {
        $("a").on('click', function(event) {

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
                }, 400, function() {

                    // Add hash (#) to URL when done scrolling (default click behavior)
                    window.location.hash = hash;
                });
            } // End if
        }); // navigation scroll effect
    });