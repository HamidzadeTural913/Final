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