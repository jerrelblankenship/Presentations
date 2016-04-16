# CoffeeScript

sayHelloWorld = () ->
    enteredText = $('#nameEntered').val()
    result = ""

    if enteredText.length > 0 
        result = "Hello hit save " + enteredText + " from the wonderful world of CoffeeScript inside of .NET"

    $('#resultMessage').html(result)
    
this.sayHelloWorld = sayHelloWorld