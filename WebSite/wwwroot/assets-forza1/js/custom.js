
  /////////////////
  $( document ).ready(function() {
    if ($('header').hasClass('fixed-menu')) {
      $('header').removeClass('fixed-menu');
    }
      $(window).on('scroll', function () {
      if ($(window).scrollTop() > 130) {
          $('header').addClass('fixed-menu');
      }
      else {
          $('header').removeClass('fixed-menu');
      }
  });
  });
  $(document).ready(function() {
    $(".mobil-menu-open").click(function() {
        $(".mobile-menu").fadeToggle("slow", "linear");
        $("html").toggleClass("mobile-scroll");
        $("body").toggleClass("mobile-scroll");
    });
    $(".mobile-menu-close").click(function() {
        $(".mobile-menu").fadeToggle("slow", "linear");
        $("html").toggleClass("mobile-scroll");
        $("body").toggleClass("mobile-scroll");
    });
});