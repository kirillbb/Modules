window.onload = years();
function years(){
  var date = new Date(2014, 0, 1);
  for (let index = date.getFullYear(); index < 2051; index++){
    date.setFullYear(index);
    if (date.getDay() == 0) {
      console.log(date.getFullYear());
    }
  }
}