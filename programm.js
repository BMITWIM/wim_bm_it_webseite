
function myFunction() {
    document.getElementById("demo").innerHTML = "Hello Javascript!";
}

function displayGreeting() {
    var d = new Date();
    if (d.getHours < 12){
        document.getElementById("demo").innerHTML = "Good morning!"
    }
    if(d.getHours < 19){
        document.getElementById("demo").innerHTML = "Good afternoon!"
    } else{
    document.getElementById("demo").innerHTML = "Good evening!";
    }
}