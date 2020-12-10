 <?php /*Template Name: Blog*/ get_header();?>
 <body>
  <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="./index.html"><i class="fa fa-home"></i> Home</a>
                        <span>Blog</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

 <?php 
  $anasayfa_son_postlar_array=array(
  	'post_type'=>'post',
'posts_per_page'=> 4, );

$anasayfa_son_postlar = new WP_Query($anasayfa_son_postlar_array); ?>

<?php $anasayfa_son_postlar->the_post();?>
 <section class="blog spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-4 col-md-4 col-sm-6">
                    <div class="blog__item">
                        <div class="blog__item__pic large__item set-bg" data-setbg="img/blog/blog-7.jpg"><?php the_post_thumbnail('thumb-blog-kapak',array('class'=> 'img-fluid')); ?></div>
                           <div class="blog__item__text">
                        	<h6><a href="<?php the_permalink(); ?>" class="anasayfa-blog-kutu-baslik"><?php the_title(); ?></a></h6>
                        	<h6><a href="<?php the_permalink(); ?>"><?php echo ozel_ozet(); ?></a></h6>
                        	 <ul>
                                <li>Seb 17, 2019</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>
 <?php get_footer();?>