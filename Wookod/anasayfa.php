  <!-- Omer Faruk Gunes-->
 <?php /*Template Name: AnaSayfa*/ get_header();?>
 <!-- header eklendi -->
 <!-- Kategori Bolumu -->
 <section class="categories">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-6 p-0">
                    <?php if( have_rows('big_Category','option')): ?>
                         <?php while(have_rows('big_Category','option')): the_row(); ?>
                        <?php $CatGorseli =get_sub_field('photo'); ?>
                    <div class="categories__item categories__large__item set-bg"
                    data-setbg="<?php echo $CatGorseli['url']; ?>">
                    <div class="categories__text">
                        <h1><?php the_sub_field('title');?></h1>
                        <p><?php the_sub_field('include');?></p>
                        <a href="#">Alışverişe Başla!</a>
                    </div>
                </div>
            
            <?php endwhile; ?>
            <?php endif; ?>
            </div>
            <div class="col-lg-6">
                <div class="row">
                      <?php if(have_rows('categories','option')): ?>
                         <?php while(have_rows('categories','option')): the_row(); ?>
                        <?php $CatGorseli =get_sub_field('photo'); ?>
                    <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                        <div class="categories__item set-bg" data-setbg="<?php echo $CatGorseli['url']; ?>">
                            <div class="categories__text">
                                <h4><?php the_sub_field('title');?></h4>
                                <p><?php the_sub_field('text');?></p>
                                <a href="#"><?php the_sub_field('shop_now');?></a>
                            </div>
                        </div>
                    </div>
                      <?php endwhile; ?>
            <?php endif; ?>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- yeni urunler -->
<section class="product spad">
    <div class="container">
        <div class="row">
            <div class="col-lg-4 col-md-4">
                <div class="section-title">
                    <h4>Yeni Ürünler</h4>
                </div>
            </div>
            <div class="col-lg-8 col-md-8">
                <ul class="filter__controls">
                    <li class="active" data-filter="*">Hepsi</li>
                    <li data-filter=".women"><?php the_field('new_product_baslik_1','option') ?></li>
                    <li data-filter=".men"><?php the_field('new_product_baslik_2','option') ?></li>
                    <li data-filter=".kid"><?php the_field('new_product_baslik_3','option') ?></li>
                </ul>
            </div>
        </div>
        <div class="row property__gallery">
            <?php $hot_trend = get_field('new_product_urun_1','option');
                     if ($hot_trend):
                       foreach ($hot_trend as $post):
                         setup_postdata($post);
                             ?>
            <div class="col-lg-3 col-md-4 col-sm-6 mix women">
                 <div class="product__item">
                    <div class="product__item__pic set-bg" data-setbg="<?php echo wp_get_attachment_url( $product->get_image_id() ); ?>">
                        <ul class="product__hover">
                            <li><a href="<?php echo wp_get_attachment_url( $product->get_image_id() ); ?>" class="image-popup"><span class="arrow_expand"></span></a></li>
                            <li><a href="<?php the_permalink() ?>"><span class="icon_bag_alt"></span></a></li>
                        </ul>
                    </div>
                    <div class="product__item__text">
                        <h6><a href="#"><?php the_title(); ?></a></h6>
                        <div class="rating">
                      <?php echo $product->get_rating_html() ; ?>
                        </div>
                        <div class="product__price"><?php echo $product->get_price_html(); ?></div>
                    </div>
                </div>
            </div>
            <?php endforeach; 
                          endif; ?>  
                           <?php $hot_trend = get_field('new_product_urun_2','option');

                     if ($hot_trend):
                       foreach ($hot_trend as $post):
                         setup_postdata($post);
                             ?>

            <div class="col-lg-3 col-md-4 col-sm-6 mix men">
                <div class="product__item">
                    <div class="product__item__pic set-bg" data-setbg="<?php echo wp_get_attachment_url( $product->get_image_id() ); ?>">
                        <ul class="product__hover">
                            <li><a href="<?php echo wp_get_attachment_url( $product->get_image_id() ); ?>" class="image-popup"><span class="arrow_expand"></span></a></li>
                            <li><a href="<?php the_permalink() ?>"><span class="icon_bag_alt"></span></a></li>
                        </ul>
                    </div>
                    <div class="product__item__text">
                        <h6><a href="#"><?php the_title(); ?></a></h6>
                        <div class="rating">
                             <?php echo $product->get_rating_html() ; ?>
                        </div>
                        <div class="product__price"><?php echo $product->get_price_html(); ?></div>
                    </div>
                </div>
            </div>
              <?php endforeach; 
                          endif; ?>  
                    <?php $hot_trend = get_field('new_product_urun_3','option');
                     if ($hot_trend):
                       foreach ($hot_trend as $post):
                         setup_postdata($post);
                             ?>       
            <div class="col-lg-3 col-md-4 col-sm-6 mix kid">
                <div class="product__item">
                    <div class="product__item__pic set-bg" data-setbg="<?php echo wp_get_attachment_url( $product->get_image_id() ); ?>">
                        <ul class="product__hover">
                            <li><a href="<?php echo wp_get_attachment_url( $product->get_image_id() ); ?>" class="image-popup"><span class="arrow_expand"></span></a></li>
                            <li><a href="<?php the_permalink() ?>"><span class="icon_bag_alt"></span></a></li>
                        </ul>
                    </div>
                    <div class="product__item__text">
                        <h6><a href="#"><?php the_title(); ?></a></h6>
                        <div class="rating">  <?php echo $product->get_rating_html() ; ?>
                        </div>
                        <div class="product__price"><?php echo $product->get_price_html(); ?></div>
                    </div>
                </div>
            </div>
             <?php endforeach; 
                          endif; ?>  
        </div>
    </div>
</section>

<!-- Slider-->
        <?php $slider_background = get_field('slider_background','option') ?>
<section class="banner set-bg" data-setbg="<?php echo $slider_background['url'];?>">
    <div class="container">
        <div class="row">
            <div class="col-xl-7 col-lg-8 m-auto">
                <div class="banner__slider owl-carousel">
<?php if( have_rows('ashion_slider','option')): ?>
<?php while(have_rows('ashion_slider','option')): the_row(); ?>
         <?php $yazi =get_sub_field('yazi');
         $yazi_2 =get_sub_field('yazi_2');
         $yazi_3 =get_sub_field('yazi_3'); ?>
                    <div class="banner__item">
                        <div class="banner__text">
                            <span><?php echo $yazi; ?></span>
                            <h1><?php echo $yazi_2; ?></h1>
                            <a href="#"><?php echo $yazi_3; ?></a>
                        </div>
                    </div>
           <?php endwhile; ?>
               <?php endif; ?>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Onerilen Urunler -->
<section class="trend spad">
    <div class="container">
        <div class="row">
            <div class="col-lg-4 col-md-4 col-sm-6">
                <div class="trend__content">
                    <div class="section-title">
                        <h4><?php the_field('ana_sayfa_alan_baslik_1','option') ?></h4> 
                        <!-- Baslik eklendi -->
                    </div>
                    <?php $hot_trend = get_field('anasayfa_alan_urunler_1','option');
// trendlerde olan urunler cekildi
                     if ($hot_trend):
                       foreach ($hot_trend as $post):
                         setup_postdata($post);
                         // urunler post edildi
                             ?>
                   <div class="trend__item">
                        <div class="trend__item__pic">
                             <a href="<?php the_permalink(); ?>"> 
                           <?php the_post_thumbnail('thumbnail',array('class'=>'img-fluid')); ?></a>
                            <!-- her bir urunun resimleri eklendi -->
                        </div>
                        <div class="trend__item__text">
                            <h6><?php the_title(); ?></h6>
                            <!-- her bir urunun basliklari eklendi -->
                            <div class="rating">
                            <?php echo $product->get_rating_html() ; ?>
                            <!-- her bir urunun derecelendirmesi eklendi -->
                            </div>
                            <div class="product__price"> <?php echo $product->get_price_html(); ?></div>
                            <!-- her bir urunun fiyatlandirmasi eklendi -->
                        </div>
                     </div>
                      <?php endforeach; 
                          endif; ?>  
                </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-6">
                <div class="trend__content">
                    <div class="section-title">
                       <h4><?php the_field('anasayfa_alan_baslik_2','option') ?></h4>
                       <!-- baslik eklendi -->
                    </div>      <?php $best_seller = get_field('anasayfa_alan_urunler_2','option');
                     // en cok satan urunler eklendi
                     if ($best_seller):
                       foreach ($best_seller as $post):
                         setup_postdata($post);
                         // urunler post edildi
                             ?>
                   <div class="trend__item">
                        <div class="trend__item__pic">
                            <a href="<?php the_permalink(); ?>"> 
                           <?php the_post_thumbnail('thumbnail',array('class'=>'img-fluid')); ?></a>
                           <!-- urunun resmi eklendi -->
                        </div>
                        <div class="trend__item__text">
                            <h6><?php the_title(); ?></h6>
                              <div class="clearfix"></div>
                            <div class="rating">
                                 <?php echo $product->get_rating_html() ; ?>
                                 <!-- urunun puani eklendi -->
                            </div>
                            <div class="product__price">  <?php echo $product->get_price_html(); ?></div>
                            <!-- urunun ucreti eklendi -->
                        </div>
                         
                    </div>
                     <?php endforeach; 
                          endif; ?>  
                </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-6">
                <div class="trend__content">
                    <div class="section-title">
                      <h4><?php the_field('anasayfa_alan_baslik_3','option') ?></h4>
                      <!-- baslik cekildi -->
                    </div><?php $feature = get_field('anasayfa_alan_urunler_3','option');
                    /*urunler cekildi*/
                     if ($feature):
                       foreach ($feature as $post):
                         setup_postdata($post);
                         // post edildi
                             ?>
                    <div class="trend__item">
                       
                        <div class="trend__item__pic">
                            <a href="<?php the_permalink(); ?>"> 
                           <?php the_post_thumbnail('thumbnail',array('class'=>'img-fluid')); ?></a>
                           <!-- resim eklendi -->
                        </div>
                        <div class="trend__item__text">
                            <h6><?php the_title(); ?></h6>
                            <!-- baslik eklendi -->
                              <div class="clearfix"></div>
                            <div class="rating">
                               <?php echo $product->get_rating_html() ; ?>
<!-- urunlerin puanlari eklendi -->
                            </div>
                            <div class="product__price">  <?php echo $product->get_price_html(); ?>
                                <!-- urunun ucreti eklendi -->
                            </div>
                        </div>
                         
                    </div>
                       <?php endforeach; 
                        endif; ?>  
                </div>
            </div>
        </div>
    </div>
</section>

<!-- discount -->
<section class="discount">
    <div class="container">
        <div class="row">
            <div class="col-lg-6 p-0">
                <div class="discount__pic">
                  <?php $discount_background = get_field('discount_background','option') ?>
                    <img src="<?php echo $discount_background['url'];?>" alt=""/>
                    <!-- arkaplan resmi eklendi -->
                </div>
            </div>
            <div class="col-lg-6 p-0">
                <div class="discount__text">
                    <div class="discount__text__title">
                      <span><?php the_field('discount_yazi','option'); ?></span>
                        <h2><?php the_field('discount_yazi_2','option'); ?></h2>
                        <h5><span><?php the_field('discount_yazi_3','option'); ?></span><?php the_field('discount_yazi_4','option'); ?></h5>
                        <!-- yazilmasi istenilen tum yerler eklendi -->
                    </div>
                    <div class="discount__countdown" id="countdown-time">
                      <?php $kalan_SURE=get_field('discount_sayac','option');
                      $tercumeler= ['Ocak' =>'Jun','Şubat' =>'Feb', 'Mart'=>'Mar','Nisan'=>'April','Mayis'=>'May','Haziran'=>'Jun','Temmuz'=>'Jul','Ağustos'=>'Aug','Eylül'=>'Sep','Ekim'=>'Oct','Kasım'=>'Nov','Aralık'=>'Dec',]; 
                         $tarih=strtr($kalan_SURE,$tercumeler);?>
                         <!-- tarihlerin turkceleri esitlendi sure hesabi icin gerekli veriler cekildi. -->
                        <div class="countdown__item"> 
                            <span id="gun"></span>
                              <p>Gün</p>
                        </div>
                        <div class="countdown__item">
                            <span id="saat"></span>
                            <p>Saat</p>
                        </div>
                        <div class="countdown__item">
                            <span id="dakika"></span>
                            <p>Dk</p>
                        </div>
                        <div class="countdown__item">
                            <span id="Saniye"></span>
                            <p>Sn</p>
                            <!-- kalan sureler yukariya eklenecek -->
                        </div>
                        <!-- sure sayaci scripti -->
                   <script>
;(function($){   
    
$(document).ready(function(){    
    
var deadline = new Date("<?php echo $tarih; ?>").getTime(); 
var x = setInterval(function() { 
var now = new Date().getTime(); 
var t = deadline - now; 
var gun = Math.floor(t / (1000 * 60 * 60 * 24)); 
var saat = Math.floor((t%(1000 * 60 * 60 * 24))/(1000 * 60 * 60)); 
var dakika = Math.floor((t % (1000 * 60 * 60)) / (1000 * 60)); 
var saniye = Math.floor((t % (1000 * 60)) / 1000); 
 
    if (t < 0) { 
       clearInterval(x); 
       $('.countdown__item').hide();
    } 
    else {
       document.getElementById("gun").innerHTML = gun;document.getElementById("saat").innerHTML =saat; document.getElementById("dakika").innerHTML = dakika; 
       document.getElementById("Saniye").innerHTML = saniye; 
    }
    
}, 0);
     
});
     
      
})(jQuery); 
     
</script>   
                    </div>
                    <!-- yazi eklendi -->
                    <a href="<?php the_sub_field('slide_link');?>"><?php the_field('discount_yazi_5','option'); ?></a>
                </div>
            </div>
        </div>
    </div>
</section>
<div class="clearfix"></div> 
  <!-- bolumler arasi birbirine girmesini engeller duzenler -->
<!-- servisler -->
<section class="services spad">
    <div class="container">
        <div class="row">
          <?php if( have_rows('servisler','option')): ?>
            <!-- tum kutular cekildi -->
          <?php while(have_rows('servisler','option')): the_row(); ?>
            <!-- tum kutularda dolasildi -->
            <div class="col-lg-3 col-md-4 col-sm-6">
                <div class="services__item">
                    <!-- iconlar eklendi -->
                    <?php the_sub_field('servis_icon'); ?>
                    <!-- basliklar eklendi -->
                    <h6><?php the_sub_field('servis_baslik'); ?></h6>
                    <!-- yazilar eklendi -->
                    <p><?php the_sub_field('servis_yazi');?> </p>
                </div>
            
           </div>
           <!-- donguler kapatildi -->
        <?php endwhile; ?>
     <?php endif; ?> 
        </div>
    </div>
</section>
  <!-- footer eklendi -->
<?php get_footer();?>

