$(document).ready(function() {
  $(" .account").click(function() {
    $(".accaunt-setting").toggle();
});
});

$('.count').each(function () {
  $(this).prop('Counter',0).animate({
      Counter: $(this).text()
  }, {
      duration: 3000,
      easing: 'swing',
      step: function (now) {
          $(this).text(Math.ceil(now));
      }
  });
});
 
$( function() {
    $( "#slider-range" ).slider({
      range: true,
      min: 0,
      max: 10000,
      values: [ 0, 100 ],
      slide: function( event, ui ) {
        $( "#amount" ).val( "(" + ui.values[ 0 ] + " - " + ui.values[ 1 ] +"AZN)");
      }
    });
    $( "#amount" ).val( "(" + $( "#slider-range" ).slider( "values", 0 ) +
      "-" + $( "#slider-range" ).slider( "values", 1 )+" AZN)");
  
} );
 
// etrafli axtaris
$( ".etrafli-axtar" ).click(function() {
  $( ".filter-toogle" ).toggle();
  $( ".slider-div" ).toggle();
  $( ".catacory" ).toggle();
  $( ".search" ).toggle();
  $( ".first-input input" ).toggle();
})

   
var hamburger = document.querySelector(".hamburger")
var open = document.querySelector(".open")
var overlay = document.querySelector(".menu-overlay")
var menu = document.querySelector(".menu")
var menulia = document.querySelectorAll(".content .logo_menu .menu .items li a")
var light_dark = document.querySelector(".light-dark")
var dark_mod = document.querySelector(".dark_mod")
var light_mod = document.querySelector(".light-mode")
var register_content_dark = document.querySelector(" .register .register_content .light-dark")
var icon = document.querySelector(".register .register_content .light-dark .fa-moon")
var iconsm = document.querySelector(".content .logo_menu .menu .items .light-dark .fa-moon " )
var dark_sm = document.querySelector(" .content .logo_menu .menu .items  .light-dark")
var register_dark = document.querySelector(" .accaunt-setting .settings ul li a  .light-dark")
var register_icon = document.querySelector(" .accaunt-setting .settings ul li a  .light-dark .fa-moon")
var logo = document.querySelector(" .content .logo_menu a img")
var element = document.body;
var header = document.querySelector("header")

// SM hamburger dark tema
dark_sm.addEventListener("click", function(){
  if(iconsm.classList.contains("fa-moon")){
    document.body.classList.add("dark-mode");
    menulia.forEach(white => {
     white.classList.add("light-write");
    });
    iconsm.classList.replace("fa-moon", "fa-sun")
    logo.src ="../images/staffy-logo-white.a39483d6.svg"
    menu.classList.add("dark-mode-menu")
    header.classList.add("dark-mode")
 }
 else{
  iconsm.classList.replace("fa-sun", "fa-moon")
   logo.src ="../images/darkmodelogo.svg"
   document.body.classList.remove("dark-mode");
   menulia.forEach(white => {
     white.classList.remove("light-write");
    });
    menu.classList.remove("dark-mode-menu")
    header.classList.remove("dark-mode")
 }
})



// LG  dark tema
register_content_dark.addEventListener("click", function(){
  if(icon.classList.contains("fa-moon")){
     document.body.classList.add("dark-mode");
     menulia.forEach(white => {
      white.classList.add("light-write");
     });
     icon.classList.replace("fa-moon", "fa-sun")
     logo.src ="../images/staffy-logo-white.a39483d6.svg"
     header.classList.add("dark-mode")
    
  }
  else{
    icon.classList.replace("fa-sun", "fa-moon")
    logo.src ="../images/darkmodelogo.svg";
    document.body.classList.remove("dark-mode");
    menulia.forEach(white => {
      white.classList.remove("light-write");
     });
     header.classList.remove("dark-mode")
  }
})
// hamburger acilib baglanma
hamburger.addEventListener("click", toglenav)
overlay.addEventListener("click", toglenav);

function toglenav(){
   menu.classList.toggle("open")
   overlay.classList.toggle("active"); 
  }


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

$(document).ready(function(){
  $(".login-btn").click(function(event){
    event.preventDefault();
    $("#login").show();
    $(".body").show();
  });

  $("close-btn").click(function (event) {
    event.preventDefault();
    $("#login").hide();
    $('.body').hide();
    $('#register').hide();
    $('#recruiter').hide();
    })

    $(".register-btn").click(function (event) {
      event.preventDefault();
      $("#register").show();
      $("#login").hide();
    })

    $(".recruiter-btn").click(function (event) {
      event.preventDefault();
      $("#register").hide()
      $("#login").hide();
      $("#recruiter").show();
      })
    $("#job-seeker").click(function (event) {
      event.preventDefault();
      $("#register").show();
      $("#login").hide();
      $("#recruiter").hide();
      })

      $(".login-btn").click(function(event){
        event.preventDefault();
        $("#login").show();
        $("#register").hide();
        $("#recruiter").hide();
      })
});

