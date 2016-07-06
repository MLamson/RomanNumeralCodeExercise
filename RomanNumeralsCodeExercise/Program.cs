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
            var output = "";
            while (arabicNumber >= 1000)
            {
                output += "M";
                arabicNumber -= 1000;
            }
            if (arabicNumber >= 900)
            {
                output += "CM";
                arabicNumber -= 900;
            }
            if (arabicNumber >= 500)
            {
                output += "D";
                arabicNumber -= 500;
            }
            if (arabicNumber >= 400)
            {
                output += "CD";
                arabicNumber -= 400;
            }
            while (arabicNumber >= 100)
            {
                output += "C";
                arabicNumber -= 100;
            }
            if (arabicNumber >= 90)
            {
                output += "XC";
                arabicNumber -= 90;
            }
            if (arabicNumber >= 50)
            {
                output += "L";
                arabicNumber -= 50;
            }
            if (arabicNumber >= 40)
            {
                output += "XL";
                arabicNumber -= 40;
            }
            while (arabicNumber >= 10)
            {
                output += "X";
                arabicNumber -= 10;
            }
            if (arabicNumber == 9)
            {
                output += "IX";
                arabicNumber -= 9;
            }
            if (arabicNumber >= 5)
            {
                output += "V";
                arabicNumber -= 5;
            }
            if (arabicNumber == 4)
            {
                output += "IV";
                arabicNumber -= 4; 
            }
            while (arabicNumber >= 1)
            {
                output += "I";
                arabicNumber--;
            }
              
            return output;
        }
    }
}
