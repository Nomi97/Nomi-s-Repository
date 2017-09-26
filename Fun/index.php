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
/*


$post_31 = get_post( 31 ); 
$title = $post_31->post_title;
$content = $post_31->post_content;
?>
    <section>
        <div class="well">    
            <h2><?php echo $title;  ?></h2>
        </div>
        <div>
            <?php echo $content; ?>
        </div>
    </section>

<?php      
$post_33 = get_post( 33 ); 
$title = $post_33->post_title;
$content = $post_33->post_content;
?>
    <section>
        <div class="well well-sm">    
            <h2><?php echo $title;  ?></h2>
        </div>
        <div class="entry">
            <?php echo $content; ?>
        </div>
    </section>
*/
?>
</main>
<?php get_footer()() ?>