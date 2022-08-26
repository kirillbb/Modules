function Test(){
 var arr = ["Ivanov", "Ivan", "Ivanovich"];
 var arrSeparator = "***";
 var arrStr = combine(arr, arrSeparator);
 document.getElementById("convertedArr").innerHTML = arrStr;
}
function combine(Arr, ArrSeparator){
  return Arr.join(ArrSeparator);
}