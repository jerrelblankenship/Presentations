# CoffeeScript
## <reference path="../helloWorld.coffee" />

test "Testing add method", ->
  ok true, "you can add"
  value = mathLib.add(2,3)
  equal 5, value, "We expect value to be 5"