function test(){
  var text = document.getElementById("myInput").value;
  var count = vowelsletter(text);
  document.getElementById("text").innerHTML = count;
}
function vowelsletter(text){
  var m = text.match(/[aeiou]/gi);
  return m === null ? 0 : m.length;
}