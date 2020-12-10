<!doctype html>
<html <?php language_attributes(); ?>>
<!-- Header  Simla Beken -->
<head>
    <meta charset="<?php bloginfo('charset'); ?>">
    <meta name="viewport" content="width=device-width">
    <meta name="description" content="Ashion Template">
    <meta name="keywords" content="Ashion, unica, creative, html">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title><?php wp_title('|', true, 'right'); ?></title> 
    <link rel="profile" href="http://gmpg.org/xfn/11">
    <link rel="pingback" href="<?php bloginfo('pingback_url'); ?>">

  

    <!-- Google Font -->
    <link href="https://fonts.googleapis.com/css2?family=Cookie&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;500;600;700;800;900&display=swap"
    rel="stylesheet">
  <?php wp_head(); ?>
</head>

<body <?php body_class(''); ?>>

    <!-- Header Section Begin -->
    <header class="header">
        <div class="container-fluid">
            <div class="row">
                <div class="col-xl-3 col-lg-2">
                    <!-- Header bölümü logosu çekildi -->
                    <div class="header__logo">
                        <?php $site_logosu = get_field('site_logosu', 'option'); ?>
                        <a href="<?php echo bloginfo('url'); ?>"><img src="<?php echo $site_logosu['url']; ?>" alt=""></a>
                    </div>
                </div>
                <!-- Header bölümü menüler çekildi -->
                <div class="col-xl-6 col-lg-7">
                    <nav class="header__menu">
                        <?php wp_nav_menu(array('theme_location' => 'primary', 'menu_class' => 'header__menu', 'menu_id' => 'header__menu')); ?>
                    </nav>
                </div>
                <div class="col-lg-3">
                    <div class="header__right">
                        <div class="header__right__auth">
                            <a href="https://wookod.org/grup1/wp-login.php">Login</a>
                            <a href="https://wookod.org/grup1/wp-login.php">Register</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="canvas__open">
                <i class="fa fa-bars"></i>
            </div>
        </div>
    </header>
    <!-- Header Section End -->
    </body>