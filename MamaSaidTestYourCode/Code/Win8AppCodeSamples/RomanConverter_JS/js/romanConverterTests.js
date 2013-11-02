test("Numeric To Roman Conversion", function () {
    equal(romanConverter.convertToRoman(1), "I", "1 -> I");
    equal(romanConverter.convertToRoman(2), "II", "2 -> II");
    equal(romanConverter.convertToRoman(3), "III", "3 -> III");
});