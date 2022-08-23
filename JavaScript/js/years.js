window.onload = years();

function years(){
  var date = new Date(2014, 1, 1);
  //var years = document.getElementById("years");
  //var yearsString;
  for (let index = date.getFullYear; index < 2051; index++){
    date.setFullYear(index);
    if (date.getDay() == 7) {
      //yearsString += date.getFullYear().toString() + "\n";
      console.log(date.getFullYear() + "\n");
    }
    else{
      //yearsString += date.getFullYear().toString() + "no" + "\n";
      console.log(date.getFullYear() + "no" + "\n")
    }
  }
  //years.innerText = yearsString;
}