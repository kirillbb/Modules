window.onload = currentTime();
function currentTime() {
  window.setInterval(function () {
    var now = new Date();
    var clock = document.getElementById("clock");
    clock.innerHTML = now.toLocaleDateString() + "___" + now.toLocaleTimeString();
  }, 1000);
}
