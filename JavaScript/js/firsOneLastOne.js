function Test(){
  var str = document.getElementById("txtInput").value;
  var sep = document.getElementById("separatorInput").value;
  var arr = str.split(sep);
  var result = firsOneLastOne(arr);
  document.getElementById("result").innerHTML = '[' + arr + ']' + " - " + result;
}
function firsOneLastOne(array){
  if (array[0] == 1 || array[array.length-1] == 1) {
    return true;
  }
  else{
    return false;
  }
}