function Test(){
  var str = document.getElementById("txtInput").value;
  var sep = document.getElementById("separatorInput").value;
  var arr = str.split(sep);
  var arrSeparator = "***";
  var arrStr = combine(arr, arrSeparator);
  document.getElementById("convertedArr").innerHTML = arrStr;
}
function combine(Arr, ArrSeparator){
  return Arr.join(ArrSeparator);
}