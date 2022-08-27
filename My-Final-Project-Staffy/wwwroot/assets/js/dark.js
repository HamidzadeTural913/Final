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
      logo.src = "../assets/images/LoqoNormalRejim.svg"
    menu.classList.add("dark-mode-menu")
    header.classList.add("dark-mode")
 }
 else{
  iconsm.classList.replace("fa-sun", "fa-moon")
      logo.src = "../assets/images/LoqoGeceRejim.svg"
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
      logo.src = "../assets/images/LoqoNormalRejim.svg"
     header.classList.add("dark-mode")
    
  }
  else{
    icon.classList.replace("fa-sun", "fa-moon")
      logo.src = "../assets/images/LoqoGeceRejim.svg"
    document.body.classList.remove("dark-mode");
    menulia.forEach(white => {
      white.classList.remove("light-write");
     });
     header.classList.remove("dark-mode")
  }
})