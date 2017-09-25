<?php function enqueue(){
wp_enqueue_style( 'style', get_template_directory_uri() . '/css/style.css');
wp_enqueue_script( 'script', get_template_directory_uri() . '/js/script.js');
}
add_action( tag, function_to_add, priority, accepted_args )