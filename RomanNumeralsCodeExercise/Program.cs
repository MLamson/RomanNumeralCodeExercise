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

            int[] arabicValues =
            {
                1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1
            };
            string[] romanValues =
            {
                "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V",
                "IV", "I"
            };

            for (int i = 0; i < arabicValues.Length; i++)
            {
                while (currentValue >= arabicValues[i])
                {
                    output += romanValues[i];
                    currentValue -= arabicValues[i];
                }
            }
            
            return output;
        }
    }
}
