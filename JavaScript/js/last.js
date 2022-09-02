function Test(){
  var str = document.getElementById("txtInput").value;
  var sep = document.getElementById("separatorInput").value;
  var count = document.getElementById("countInput").value;
  var arr = str.split(sep);
  var arrResult = last(arr, count);
  document.getElementById("result").innerHTML = '[' + arr + ']' + " - " + '[' + arrResult + ']';
}
function last(array, count){
  var result = [];
  var countResult = 0;
  if (count == 0 || count == 1){
    return array[array.length - 1];
  }
  else{
    for (let index = count; index >= 1; index--){
      if (index > array.length) {
        continue;
      }
      result[countResult] = array[array.length - index];
      countResult++;
    }
    return result;
  }
}