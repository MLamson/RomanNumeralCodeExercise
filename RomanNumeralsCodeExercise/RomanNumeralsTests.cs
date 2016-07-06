using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCodeExercise
{
    [TestFixture]
    class RomanNumeralsTests
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XIII", 13)]
        [TestCase("XVII", 17)]
        [TestCase("XXXI", 31)]
        [TestCase("L", 50)]
        [TestCase("LI", 51)]
        [TestCase("LXVIII", 68)]
        [TestCase("LXXXVIII", 88)]
        [TestCase("LXXX", 80)]
        [TestCase("LXXXIX", 89)]
        [TestCase("C", 100)]
        [TestCase("XC", 90)]
        [TestCase("CXCIX", 199)]
        [TestCase("CC", 200)]
        [TestCase("CCLXXXIX", 289)]
        [TestCase("CCXCVIII", 298)]
        [TestCase("CCXCIX", 299)]
        [TestCase("CCC", 300)]
        [TestCase("D", 500)]
        [TestCase("CCCXCIX", 399)]
        [TestCase("CD", 400)]
        [TestCase("CDXCIX", 499)]
        [TestCase("DC", 600)]
        [TestCase("DCXLIX", 649)]
        [TestCase("M", 1000)]
        [TestCase("MMM", 3000)]
        [TestCase("MMCMXCIX", 2999)]
        [TestCase("MMCDXLIV", 2444)]
        public void ArabicOne_To_Roman_Numeral(string roman, int arabic)
        {
            // Act
            string result = Program.ConvertArabicToRoman(arabic);

            // Assert
            Assert.AreEqual(roman, result);
        }
    }
}
