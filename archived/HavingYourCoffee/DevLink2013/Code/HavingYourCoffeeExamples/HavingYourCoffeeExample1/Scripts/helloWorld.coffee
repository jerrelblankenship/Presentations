# CoffeeScript

sayHelloWorld = () ->
    enteredText = $('#nameEntered').val()
    result = ""

    if enteredText.length > 0 
        result = "Hello " + enteredText + " from the wonderful world of CoffeeScript inside of .NET"

    $('#resultMessage').html(result)
    
this.sayHelloWorld = sayHelloWorld

mathLib = 
    add: (x,y) ->
        x + y

this.mathLib = mathLib