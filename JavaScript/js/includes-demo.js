function test(){
  var text = document.getElementById("myInput").value;
  var newText = includesdemo(text);
  document.getElementById("text").innerHTML = newText;
}
function includesdemo(text){
  if (text.includes('Py') || text == "") {
    return text;
  }
  else{
    return 'Py' + text;
  }
}