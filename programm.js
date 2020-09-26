
function myFunction() {
    var y = new Date();
    document.getElementById("demo").innerHTML = y.getHours();
}

function displayGreeting() {
    var d = new Date();
    if (d.getHours() < 12 && d.getHours() >= 0){
        document.getElementById("demo").innerHTML = "Good morning!"
    }
    if(d.getHours() < 19 && d.getHours() >= 12){
        document.getElementById("demo").innerHTML = "Good afternoon!"
    } if (d.getHours() <= 23 && d.getHours() >= 19) {
    document.getElementById("demo").innerHTML = "Good evening!";
    }
}