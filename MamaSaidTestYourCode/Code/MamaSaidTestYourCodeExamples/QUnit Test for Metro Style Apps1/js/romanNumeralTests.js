// JavaScript source code
test("Numeric To Roman Conversion", function() {
    equal(romanNumeral.convertToRoman(1), "I", "1 -> I");
    equal(romanNumeral.convertToRoman(2), "II", "2 -> II");
    equal(romanNumeral.convertToRoman(3), "III", "3 -> III");
});