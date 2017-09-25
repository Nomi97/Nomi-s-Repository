<div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="<?php echo get_template_directory_uri(); ?>/images/banner_1.jpg" alt="Chania">
                </div>

                <div class="item">
                    <img src="<?php echo get_template_directory_uri(); ?>/images/banner_2.jpg" alt="Chania">
                </div>

                <div class="item">
                    <img src="<?php echo get_template_directory_uri(); ?>/images/banner_3.jpg" alt="Flower">
                </div>

                <div class="item">
                    <img src="<?php echo get_template_directory_uri(); ?>/images/banner_4.jpg" alt="Flower">
                </div>

            </div>
    
            <!-- Controls -->
            <a class="carousel-control left" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
            </a>
            <a class="carousel-control right" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
            </a>
        </div>