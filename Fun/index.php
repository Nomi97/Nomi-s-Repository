<?php get_header() ?>
<main class="container">
<?php require_once 'slider.php';
while(have_posts() ){
the_post();
?>
  <section>
  <div class="well">    
<h2><?php the_title();   ?></h2>
      </div>
<div><?php the_content(); ?></div>
      </section>
<?php
} 


?>
</main>
<?php get_footer()() ?>