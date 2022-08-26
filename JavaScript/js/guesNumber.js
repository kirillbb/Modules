window.onload = getNumber();
var number;
function getNumber(){
 number = Math.floor(Math.random() * 21);
}
function guesNumber(){
  var num = document.getElementById("guessedNumber").value;
  var div = document.getElementById("guess");
  if (num == number) {
    div.innerHTML = "Congrats! U r Winner!";
  }
  else{
    if (num < number) {
    div.innerHTML = "Your number are Less!";
    }
    else{
    div.innerHTML = "Your number are Greater!";
    }
  }
}