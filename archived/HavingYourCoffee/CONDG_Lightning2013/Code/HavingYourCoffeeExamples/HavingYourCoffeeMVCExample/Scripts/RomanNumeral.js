(function() {
  var convertToArabic, convertToRoman;



  convertToArabic = function() {
    var result, romanNumeral, romanResult, romanlist, value, _i, _len;
    romanNumeral = $('#romanToString').val();
    romanResult = $('#rToStringResult');
    romanlist = romanNumeral.slice(0);
    result = 0;
    for (_i = 0, _len = romanlist.length; _i < _len; _i++) {
      value = romanlist[_i];
      result = result + 1;
    }
    return romanResult.html(result);
  };

  convertToRoman = function() {
    var arabicNumeral, url;
    arabicNumeral = $('#stringToRoman').val();
    url = "RomanNumeral/ConvertToRoman/" + arabicNumeral;
    return $.ajax(url, {
      type: 'POST',
      dataType: 'html',
      error: function(data) {
        return alert(data);
      },
      success: function(data) {
        var romanResult;
        romanResult = $('#sToRomanResult');
        return romanResult.html(data);
      }
    });
  };

  this.convertToRoman = convertToRoman;

  this.convertToArabic = convertToArabic;

}).call(this);
