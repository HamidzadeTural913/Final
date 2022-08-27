$(function () {
    $(window).scroll(function () {
      var scroll = $(window).scrollTop();
      if (scroll < 100) {
        $(".scrolltop").removeClass("activescrolltop");
      } else {
        $(".scrolltop").addClass("activescrolltop");
      }
    });
    var scrolltop = document.querySelector(".scrolltop");
    $(scrolltop).click(function () {
      $("html, body").animate(
        {
          scrollTop: 0,
        },
        800
      );
      return false;
    });
 })