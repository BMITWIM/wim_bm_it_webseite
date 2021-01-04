$(document).ready(function(){

    // jQuery methods go here...
    $("i#hamburger").click(function(){
        $("li#hiddenLinks").toggle();
      });
    $("i#toolbar").click(function(){
        $("li#hiddenButtons").toggle();
    })  
  });