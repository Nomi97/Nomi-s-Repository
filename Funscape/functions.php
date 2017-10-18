<?php function add_theme_scripts(){
 wp_enqueue_style( 'customstyle', get_template_directory_uri() . '/css/fun.css');
 wp_enqueue_style( 'bootstrap', get_template_directory_uri() . '/css/bootstrap.min.css');
 wp_enqueue_style( 'fontawesome', get_template_directory_uri() . '/css/font-awesome.min.css');
 wp_enqueue_script( 'jquery', get_template_directory_uri() . '/js/jquery-1.12.0.min.js');
 wp_enqueue_script( 'bootstrap', get_template_directory_uri() . '/js/bootstrap.min.js');
 wp_enqueue_script( 'customjs', get_template_directory_uri() . '/js/funtastic.js'); 
    
}
add_action( 'wp_enqueue_scripts', 'add_theme_scripts' );

function register_my_menu() {
    register_nav_menu('header-menu',__( 'Header Menu' ));
  }
  add_action( 'init', 'register_my_menu' );