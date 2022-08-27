$(document).ready(function(){
    $(".new-vacancy-btn").click(function(e){
        e.preventDefault();
      $(".advertisement").hide();
      $("#new-vacancy").show();
    });
});
