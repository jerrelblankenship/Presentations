# CoffeeScript

convertToArabic = () ->
    romanNumeral = $('#romanToString').val()
    romanResult = $('#rToStringResult')
    romanlist = romanNumeral[0..]
    result = 0
    
    result = result + 1 for value in romanlist

    romanResult.html(result)
    
convertToRoman = () ->
    arabicNumeral = $('#stringToRoman').val();
    url = "RomanNumeral/ConvertToRoman/" + arabicNumeral

    $.ajax url,
        type: 'POST'
        dataType: 'html'
        error: (data) ->
            alert(data)
        success: (data) ->
            romanResult = $('#sToRomanResult')
            romanResult.html(data)

this.convertToRoman = convertToRoman
this.convertToArabic = convertToArabic