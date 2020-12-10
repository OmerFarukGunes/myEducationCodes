<?php get_header(); ?>
<?php while(have_posts()): the_post(); ?>

<body>
<?php the_content(); ?>
</body>
<?php endwhile; ?>
<?php get_footer(); ?>