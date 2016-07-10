using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        internal static string ConvertArabicToRoman(int arabicNumber)
        {
            int currentValue = arabicNumber;
            var output = "";

            Dictionary<int, string> arabicRomanEquivalance = new Dictionary<int, string>
            {
                {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
                {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
                {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I" }
            };

            for (int i = 0; i < arabicRomanEquivalance.Count; i++)
            {
                while (currentValue >= arabicRomanEquivalance.ElementAt(i).Key)
                {
                    output += arabicRomanEquivalance.ElementAt(i).Value;
                    currentValue -= arabicRomanEquivalance.ElementAt(i).Key;
                }
            }
            
            return output;
        }
    }
}
