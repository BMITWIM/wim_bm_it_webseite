
function displayGreeting() {
    var d = new Date();
    if (d.getHours() < 12 && d.getHours() >= 0){
        document.getElementById("greeting").innerHTML = "Good morning!"
    }
    if(d.getHours() < 19 && d.getHours() >= 12){
        document.getElementById("greeting").innerHTML = "Good afternoon!"
    } if (d.getHours() <= 23 && d.getHours() >= 19) {
    document.getElementById("greeting").innerHTML = "Good evening!";
    }
}

function btnHamburger() {
    var x = document.getElementById("hiddenLinks");   
    if (x.style.display === "block") {
      x.style.display = "none";
      
    } else {
      x.style.display = "block";
    }
 }

 /* function btnSettings(){
   var x = document.getElementById("hiddenButtons");
   if (x.style.display === "block") {
    x.style.display = "none";
    
  } else {
    x.style.display = "block";
  }
 } */

 /* function btnLinks() {
  var x = document.getElementById("hiddenContent-Links");   
  if (x.style.display === "block") {
    x.style.display = "none";
    
  } else {
    x.style.display = "block";
  }
 } */

