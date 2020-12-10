<!-- Footer Eklendi Omer Faruk Gunes -->

<footer class="footer" style="background-color: #FFEBEE">
    <div class="container">
        <div class="row">
            <div class="col-lg-4 col-md-6 col-sm-7">
                <div class="footer__about">
                    <div class="footer__logo">
                    	 <?php $footer_logo = get_field('footer_logo','option') ?>
                        <a href="<?php echo bloginfo('url');?>"><img src="<?php echo $footer_logo['url'];?>" alt=""></a>
                    </div>
                    <p> <?php the_field('e-bulten_kodu','option') ?></p>
                    <div class="footer__payment">
                        <?php if( have_rows('odeme_logolari','option')): ?>
                         <?php while(have_rows('odeme_logolari','option')): the_row(); ?>
                    	   	<?php $footer_odeme_logo = get_sub_field('logo','option'); ?>
                        <a href="#"><img src="<?php echo $footer_odeme_logo['url']; ?>" alt=""></a>

            <?php endwhile; ?>
            <?php endif; ?>
                    </div>
                </div>
            </div>
            <div class="col-lg-2 col-md-3 col-sm-5">
                <div class="footer__widget">
                    <h6>Linkler</h6>
                    <ul>
                    	<?php $menu_lokasyonlari = get_nav_menu_locations();
            $menu_id_1 =$menu_lokasyonlari["footermenu1"];
            $footer_menu_1 = wp_get_nav_menu_object($menu_id_1); ?>
                        <li>  <?php wp_nav_menu(array('theme_location' => 'footermenu2','menu_class' => 'footer-menu', 'menu_id' => 'footer-menu2')); ?></li>
                    </ul>
                </div>
            </div>
            <div class="col-lg-2 col-md-3 col-sm-4">
                <div class="footer__widget">
                    <h6>İletişim</h6>
                    <ul>
                        <li><a href="#"><?php the_field('firma_adres','option') ?></a></li>
                        <li><a href="#"><?php the_field('firma_telefon','option') ?></a></li>
                        <li><a href="mailto:<?php the_field('firma_e-posta','option') ?>"><?php the_field('firma_e-posta','option') ?></a></li>
                    </ul>
                </div>
            </div>
            <div class="col-lg-4 col-md-8 col-sm-8">
                <div class="footer__newslatter">
                    <h6>Sosyal Medya</h6>
                   <div class="footer__social">

                        <a href="#"><i class="fa fa-facebook"></i></a>
                        <a href="#"><i class="fa fa-twitter"></i></a>
                        <a href="#"><i class="fa fa-youtube-play"></i></a>
                        <a href="#"><i class="fa fa-instagram"></i></a>
                        <a href="#"><i class="fa fa-pinterest"></i></a>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="footer__copyright__text">
                    <p>Copyright &copy; <script>document.write(new Date().getFullYear());</script> <?php the_field('footer_copyright','option'); ?> <a href="https://colorlib.com" target="_blank"></a></p>
                </div>
            </div>
        </div>
    </div>
</footer>


<?php wp_footer(); ?>

</body>
</html>