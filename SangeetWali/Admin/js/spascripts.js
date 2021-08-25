// JScript File, SBT

$(document).ready(function(){

    $('#treatments').change(function() {
        dropdown = $('#treatments').val();

        $('#massagetreatment').fadeOut();
        $('#eyetreats').fadeOut();

        if (dropdown == '1')
        {
           $('#massagetreatment').fadeIn();
        }
        if (dropdown == '2')
        {
           $('#eyetreats').fadeIn();
        }
    });

      // Mouse Over Effect on Photo
      $(".gallery a").append("<span></span>");
      $(".gallery a").hover(function(){
        $(this).children("span").fadeIn(600);
        },function(){
        $(this).children("span").fadeOut(200);
      });
});   
