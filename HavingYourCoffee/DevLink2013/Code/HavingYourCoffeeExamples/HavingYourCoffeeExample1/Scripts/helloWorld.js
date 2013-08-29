(function() {
  var mathLib, sayHelloWorld;

  sayHelloWorld = function() {
    var enteredText, result;
    enteredText = $('#nameEntered').val();
    result = "";
    if (enteredText.length > 0) {
      result = "Hello " + enteredText + " from the wonderful world of CoffeeScript inside of .NET";
    }
    return $('#resultMessage').html(result);
  };

  this.sayHelloWorld = sayHelloWorld;

  mathLib = {
    add: function(x, y) {
      return x + y;
    }
  };

  this.mathLib = mathLib;

}).call(this);
