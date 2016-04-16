(function() {

  test("Testing add method", function() {
    var value;
    ok(true, "you can add");
    value = mathLib.add(2, 3);
    return equal(5, value, "We expect value to be 5");
  });

}).call(this);
