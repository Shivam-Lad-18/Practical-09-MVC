 document.getElementById("printText").addEventListener("click", function () {
    document.getElementById("text").innerText = "Hello World";
});
document.getElementById("bold").addEventListener("click", function () {
    document.getElementById("text").style.fontWeight = "bold";
});
document.getElementById("italic").addEventListener("click", function () {
    document.getElementById("text").style.fontStyle = "italic";
});
document.getElementById("underline").addEventListener("click", function () {
    document.getElementById("text").style.textDecoration = "underline";
});
document.getElementById("reset").addEventListener("click", function () {
    document.getElementById("text").style= "none";
});