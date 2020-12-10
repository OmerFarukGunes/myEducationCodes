<!-- Ömer Faruk Güneş -->
<?php /*Template Name: Ilteisim*/ get_header();?>
 <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="./index.html"><i class="fa fa-home"></i> Ana Sayfa</a>
                        <span>İletişim</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <section class="contact spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6">
                    <div class="contact__content">
                        <div class="contact__address">
                            <h5>İletişim Bilgileri</h5>
                            <ul>
                                <li>
                                    <h6><i class="fa fa-map-marker"></i> Adres</h6>
                                    <p><?php the_field('firma_adres','option') ?></p>
                                </li>
                                <li>
                                    <h6><i class="fa fa-phone"></i> Telefon</h6>
                                    <p><span><?php the_field('firma_telefon','option') ?></span></p>
                                </li>
                                <li>
                                    <h6><i class="fa fa-headphones"></i> E-Posta</h6>
                                    <p><?php the_field('firma_e-posta','option') ?></p>
                                </li>
                            </ul>
                        </div>
                        <div class="contact__form">
                            <h5>MESAJ GÖNDER</h5>
                            <form action="#">
                              <?php echo  do_shortcode('[contact-form-7 id="111" title="İletişim formu 1"]');  ?>
                            </form>
                        </div>
                    </div>
                </div>
                 <div class="col-lg-6 col-md-6">
                    <div class="contact__map">
                        <iframe
                        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48158.305462977965!2d-74.13283844036356!3d41.02757295168286!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c2e440473470d7%3A0xcaf503ca2ee57958!2sSaddle%20River%2C%20NJ%2007458%2C%20USA!5e0!3m2!1sen!2sbd!4v1575917275626!5m2!1sen!2sbd"
                        height="780" style="border:0" allowfullscreen="">
                    </iframe>
                </div>
            </div>
        </div>
    </div>
</section>
    <!-- Breadcrumb End -->
<?php get_footer(); ?>