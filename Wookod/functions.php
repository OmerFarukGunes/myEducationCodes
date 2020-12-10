<?php

// tema setup : İsmail Enes KIRLI
function wooshop_setup(){
add_theme_support('automatic-feed-links');
add_theme_support('html5',array('search-form','comment-form','comment-list','gallery','caption'));

//Menüleri buradan ekliyoruz.
register_nav_menu('primary',__('Ana Menü','wooshop') );
register_nav_menu('anasayfa',__('Anasayfa','wooshop') );
register_nav_menu('footermenu1',__('Footer Menü 1', 'wooshop'));
register_nav_menu('mobilmenu',__('Mobil Menü','wooshop'));


add_theme_support('post-thumbnails');
set_post_thumbnail_size(604,270,true);

add_filter('use_defualt_gallery_style','    __return_false');

add_theme_support('woocommerce');
add_theme_support('wc-product-gallery-zoom');
add_theme_support('wc-product-gallery-lightbox');
add_theme_support('wc-product-gallery-slider');
}
//tema script ve stiller Ömer Faruk Güneş
function ashion_scriptler_stiller()
{
wp_enqueue_style('bootstrap.min-css', get_template_directory_uri().'/inc/css/bootstrap.min.css', array() );
wp_enqueue_style('font-awesome', get_template_directory_uri().'/inc/css/font-awesome.min.css', array() );
wp_enqueue_style('elegant-icons', get_template_directory_uri().'/inc/css/elegant-icons.css', array() );
wp_enqueue_style('jquery-ui', get_template_directory_uri() .'/inc/css/jquery-ui.min.css', array() );
wp_enqueue_style('magnific-popup-css', get_template_directory_uri().'/inc/css/magnific-popup.css', array() );
wp_enqueue_style('owl.carousel.min', get_template_directory_uri().'/inc/css/owl.carousel.min.css', array() );
wp_enqueue_style('slicknav.min', get_template_directory_uri().'/inc/css/slicknav.min.css', array() );
wp_enqueue_style('ashion-style', get_template_directory_uri() .'/style.css', array() );

wp_enqueue_script('Popper', get_template_directory_uri().'/inc/js/jquery-3.3.1.min.js', array('jquery') );
wp_enqueue_script('bootstrap-js', get_template_directory_uri().'/inc/js/bootstrap.min.js', array('jquery'), '2016-19-08', true);
wp_enqueue_script('popup', get_template_directory_uri().'/inc/js/jquery.magnific-popup.min.js', array('jquery'), '2016-19-08', true );
wp_enqueue_script('jquery-ui', get_template_directory_uri().'/inc/js/jquery-ui.min.js', array('jquery'), '2016-19-08', true );
wp_enqueue_script('mixitup', get_template_directory_uri().'/inc/js/mixitup.min.js', array('jquery'), '2016-19-08', true );
wp_enqueue_script('countdown-js', get_template_directory_uri().'/inc/js/jquery.countdown.min.js', array('jquery'), '2016-19-08', true);
wp_enqueue_script('slicknav', get_template_directory_uri().'/inc/js/jquery.slicknav.js', array('jquery'), '2016-19-08', true );
wp_enqueue_script('owl.carousel', get_template_directory_uri().'/inc/js/owl.carousel.min.js', array('jquery'), '2016-19-08', true );
wp_enqueue_script('jquery.nicescroll', get_template_directory_uri().'/inc/js/jquery.nicescroll.min.js', array('jquery'), '2016-19-08', true );
wp_enqueue_script('main', get_template_directory_uri().'/inc/js/main.js', array('jquery'), '2016-19-08', true );
}
add_action('wp_enqueue_scripts', 'ashion_scriptler_stiller');

/*ACF Bileseni Ömer Faruk Güneş */
add_filter('acf/settings/path', 'my_acf_settings_path');
function my_acf_settings_path( $path ) {
    $path = get_stylesheet_directory() . '/inc/acf/';
    return $path;
}
add_filter('acf/settings/dir', 'my_acf_settings_dir');
function my_acf_settings_dir( $dir ) {
 
    $dir = get_stylesheet_directory_uri() . '/inc/acf/';
    return $dir;
}

//add_filter('acf/settings/show_admin', '__return_false');
include_once( get_stylesheet_directory() . '/inc/acf/acf.php' );
if( function_exists('acf_add_options_page') ) {
	acf_add_options_page(array(
		'page_title' 	=> 'Site Ayarları',
		'menu_title'	=> 'Site Ayarları',
		'menu_slug' 	=> 'site-ayarlari',
		'capability'	=> 'manage_options',
		'redirect'		=> false,
		'update_button'		=> __('Güncelle', 'acf'),
		'updated_message'	=> __("Ayarlar Güncellendi", 'acf'),
	));
}
/*Klasik Editore Geri Donus Ömer Faruk Güneş  */

add_filter('use_block_editor_for_post','__return_false',10);
add_filter('use_block_editor_for_post_type','__return_false',10);


/*odeme ekrani duzenlemeleri Ömer Faruk Güneş*/

add_filter('woocommerce_checkout_fields','odeme_alan_ozellestirmeleri');

function odeme_alan_ozellestirmeleri( $fields){
 
   unset($fields['billing']['billing_postcode']);
   unset($fields['billing']['order_comments']);
    unset($fields['billing']['billing_company']);
   return $fields;
}
/*ekstra siparis alanmi ekleme Ömer Faruk Güneş*/

add_action('woocommerce_after_checkout_billing_form','ekstra_alan');

 function ekstra_alan($checkout){

  woocommerce_form_field('tckimlikno', array(
  'type'=>'text',
  'class'=>array('my-field-class form-row-wide'),
  'label'=> __('Tc Kimlik Numaraniz'),
  'placeholder'=>__('Tc Kimlik Numaraniz'),
  'required' =>"true"
 ),
 $checkout->get_value('tckimlikno'));
}
 add_action('woocommerce_checkout_process','ozel_alan_uyari');

 function ozel_alan_uyari(){
  if(!$_POST['tckimlikno']) wc_add_notice(__('lutfen 11 Haneli Tc Kimlik Numaranizi Giriniz'),'error');
 }


 add_action('woocommerce_checkout_update_order_meta','ozel_alan_sipariste_guncelleme');

function ozel_alan_sipariste_guncelleme($order_id){
 if( $_POST['tckimlikno']) update_post_meta($order_id,'_tckimlikno',sanitize_text_field($_POST['tckimlikno']));
}

 add_action('woocommerce_admin_order_data_after_billing_adress','ozel_alan_sipariste_gosterme',10,1);
 function ozel_alan_sipariste_gosterme($order){
  echo '<p><strong>'.__('Musteri Tc Kimlik Numarasi').':</strong>' . get_post_meta($order->id, '_tckimlikno',true) . '</p>';
 }

 /*isleniyor siparis durumu degistirme Ömer Faruk Güneş*/
add_filter('wc_order_statuses','siparis_durumu_degistirme');
function  siparis_durumu_degistirme($order_statuses){
  foreach( $order_statuses as $key => $status) {
    if ('wc-completed' === $key) 
        $order_statuses['wc-processing'] = _x('Sipariş Hazırlanıyor','Order status','woocommerce');
   }
  return $order_statuses;
}

/*yeni siparis durumu ekleme Ömer Faruk Güneş*/
add_filter('woocommerce_register_shop_order_post_statuses','yeni_siparis_durumu');  
function yeni_siparis_durumu($order_statuses){

  $order_statuses['wc-siparis-kargolandi']= array(
          'label' => _x('siparis kargolandi','Order status', 'woocommerce'),
          'public' => false,
          'exclue_from_search' =>false,
          'show_in_admin_all_list'=> true,
          'show_in_admin_status_list' =>true,
          'label_count' => _n_noop('Siparis kargolandi <span class="count">(%s)</span>','siparis kargolandi <span class="count">(%s)</span>','woocommerce'),
  );
}
add_filter ('wc_order_statuses','yeni_siparis_durumu_1');
function yeni_siparis_durumu_1($order_statuses){
  $order_statuses['wc-siparis-kargolandi'] =_x('siparis kargolandi','Order status','woocommerce');
  return $order_statuses;
}

add_filter ('bulk_actions-edit-shop-order', 'yeni_siparis_durumu_2');
function yeni_siparis_durumu_2($bulk_actions){
 $bulk_actions['mark_custom-status']= 'siparisi kargolandi olarak degistir';
 return $bulk_actions;
}

/*Admin bar kaldirma Ömer Faruk Güneş*/

add_action('after_setup_theme','admin_bar_kaldir');
function admin_bar_kaldir(){
  show_admin_bar(false);
}
// woocommerce default templatelerin calismasi saglandi Omer Faruk Gunes
function mytheme_add_woocommerce_support() {
  add_theme_support( 'woocommerce' );
}
add_action( 'after_setup_theme', 'mytheme_add_woocommerce_support' );